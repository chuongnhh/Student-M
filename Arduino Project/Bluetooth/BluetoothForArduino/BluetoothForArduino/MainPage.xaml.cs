using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Networking.Proximity;
using Windows.Networking.Sockets;
using Windows.UI.Popups;
using System.Diagnostics;
using Windows.Networking;
using Windows.Devices.Enumeration;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Rfcomm;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace HC_Bluetooth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string device_Name = "HC-06";
        private StreamSocket socket = new StreamSocket();

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //foreach (DeviceInformation di in await DeviceInformation.FindAllAsync(BluetoothLEDevice.GetDeviceSelector()))
            //{
            //    BluetoothLEDevice bleDevice = await BluetoothLEDevice.FromIdAsync(di.Id);
            //    if (bleDevice.Name == device_Name)
            //    {
            //        currentDevice = bleDevice;
            //        listView.Items.Add(currentDevice.Name);
            //        break;
            //    }
            //}
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void MainPage1_Loaded(object sender, RoutedEventArgs e)
        {
            PeerFinder.ConnectionRequested += PeerFinder_ConnectionRequested;
            discoverDevices(null, null);
            //btnConnect_Click(null, null);
            appToDevice();
        }

        private void PeerFinder_ConnectionRequested(object sender, ConnectionRequestedEventArgs args)
        {
            connectPeer(args.PeerInformation);
        }

        private async void connectPeer(PeerInformation peerToConnect)
        {
            StreamSocket socket = await PeerFinder.ConnectAsync(peerToConnect);
        }

        private async void discoverDevices(object sender, RoutedEventArgs e)
        {
            PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
            var peerList = await PeerFinder.FindAllPeersAsync();
            if (peerList.Count > 0)
            {
                foreach (var item in peerList)
                {
                    listView.Items.Add(item.DisplayName);

                }
                //Creating instance for the MessageDialog Class  
                //and passing the message in it's Constructor  
                //MessageDialog msgbox = new MessageDialog("Peers: " + peerList[0].DisplayName + ".");
                //Calling the Show method of MessageDialog class  
                //which will show the MessageBox  
                //await msgbox.ShowAsync();
                //textBoxPeer.Text = peerList[0].DisplayName;
            }
            else
            {
                //Creating instance for the MessageDialog Class  
                //and passing the message in it's Constructor  
                MessageDialog msgbox = new MessageDialog("No active peers.");
                //Calling the Show method of MessageDialog class  
                //which will show the MessageBox  
                await msgbox.ShowAsync();
            }
        }

        private async void appToDevice()
        {
            //connect.Content = "Đang kết nối...";
            PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
            var pairedDevices = await PeerFinder.FindAllPeersAsync();

            if (pairedDevices.Count == 0)
            {
                //MessageBox.Show("Không có thiết bị đã ghép nào được tìm thấy.");
            }
            else
            {
                //Creating instance for the MessageDialog Class  
                //and passing the message in it's Constructor  
                MessageDialog msgbox = new MessageDialog("Peers: " + pairedDevices[0].DisplayName + ".");
                //Calling the Show method of MessageDialog class  
                //which will show the MessageBox  
                await msgbox.ShowAsync();
                await socket.ConnectAsync(pairedDevices[0].HostName, "1");
            }
        }
    }
}
