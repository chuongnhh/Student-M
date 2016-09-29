using HC_Bluetooth.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace HC_Bluetooth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        private BluetoothManager bluetoothManager;

        private string bluetoothDevice = "HC-06";

        public MainPage()
        {
            this.InitializeComponent();

            bluetoothManager = new BluetoothManager();
            bluetoothManager.DiagnosticsChangedNotification += new BluetoothManager.DiagnosticsMessageDelegate(diagnosticsStringReceived);
            bluetoothManager.StatusChangedNotification += new BluetoothManager.StatusChangedDelegate(bluetoothStatusChanged);

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }


        private void setControlEnabled(bool state)
        {
            btnSend.IsEnabled = state;
            btnConnect.IsEnabled = !state;
        }

        private async void displayMessage(string message)
        {
            MessageDialog mess = new MessageDialog(message);
            await mess.ShowAsync();
        }

        private async void bluetoothStatusChanged(BluetoothManager.ManagerStatus status)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                switch (status)
                {
                    case BluetoothManager.ManagerStatus.Idle:
                        setControlEnabled(false);
                        break;
                    case BluetoothManager.ManagerStatus.GettingConnection:
                        //ConnectProgressRing.IsActive = true;
                        break;
                    case BluetoothManager.ManagerStatus.FailedToGetConnection:
                        displayMessage("Failed to get connection. Press Connect to retry.");
                        //ConnectProgressRing.IsActive = false;
                        setControlEnabled(false);
                        break;
                    case BluetoothManager.ManagerStatus.GotConnection:
                        //ConnectProgressRing.IsActive = false;
                        setControlEnabled(true);
                        break;
                    case BluetoothManager.ManagerStatus.LostConnection:
                        displayMessage("Lost connection. Press Connect to reconnect.");
                        setControlEnabled(false);
                        break;
                }
            });
        }

        private async void diagnosticsStringReceived(string message)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                txbConnectStatus.Text = message;
            });
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            bluetoothManager.ResetToIdle();
            startBluetooth();
        }

        private void startBluetooth()
        {
            if (bluetoothManager.Status == BluetoothManager.ManagerStatus.Idle)
            {
                bluetoothManager.Initialise(bluetoothDevice);
            }
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            startBluetooth();
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (bluetoothManager.Status == BluetoothManager.ManagerStatus.GotConnection)
            {
                byte[] buffer = new byte[messageTextBlock.Text.Length];
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = (byte)messageTextBlock.Text[i];
                }
                bluetoothManager.SendBytes(buffer);
            }
        }
    }
}
