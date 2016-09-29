using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Proximity;
using Windows.Networking.Sockets;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace ArduinoBluetooth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
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
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PeerFinder.ConnectionRequested += PeerFinder_ConnectionRequested;
        }
        void PeerFinder_ConnectionRequested(object sender, ConnectionRequestedEventArgs args)
        {
            if (ShouldConnect())
            {
                // Go ahead and connect
                ConnectToPeer(args.PeerInformation);
            }

        }

        async void ConnectToPeer(PeerInformation peer)
        {
            StreamSocket socket = await PeerFinder.ConnectAsync(peer);
            //DoSomethingUseful(socket);

        }

        private bool ShouldConnect()
        {
            // Determine whether to accept this connection request and return
            return true;
        }

        private async void AppToDevice()
        {
            // Configure PeerFinder to search for all paired devices.
            PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
            var pairedDevices = await PeerFinder.FindAllPeersAsync();

            if (pairedDevices.Count == 0)
            {
                Debug.WriteLine("No paired devices were found.");
            }
            else
            {
                // Select a paired device. In this example, just pick the first one.
                PeerInformation selectedDevice = pairedDevices[0];
                // Attempt a connection
                StreamSocket socket = new StreamSocket();
                // Make sure ID_CAP_NETWORKING is enabled in your WMAppManifest.xml, or the next 
                // line will throw an Access Denied exception.
                // In this example, the second parameter of the call to ConnectAsync() is the RFCOMM port number, and can range 
                // in value from 1 to 30.
                await socket.ConnectAsync(selectedDevice.HostName, "1");
                //DoSomethingUseful(socket);
            }
        }

        async void AppToApp()
        {

            // PeerFinder.Start() is used to advertise our presence so that peers can find us. 
            // It must always be called before FindAllPeersAsync.
            PeerFinder.Start();

            var peers = await PeerFinder.FindAllPeersAsync();

            if (peers.Count == 0)
            {
                Debug.WriteLine("Peer not found.");
            }
            else
            {
                // Select a peer. In this example, let's just pick the first peer.
                PeerInformation selectedPeer = peers[0];

                // Attempt a connection
                var streamSocket = await PeerFinder.ConnectAsync(selectedPeer);

                //DoSomethingUseful(streamSocket);
            }


        }

        private async void FindPaired()
        {

            // Search for all paired devices
            PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";

            try
            {
                var peers = await PeerFinder.FindAllPeersAsync();

                // Handle the result of the FindAllPeersAsync call
            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x8007048F)
                {
                    //MessageBox.Show("Bluetooth is turned off");
                    Debug.WriteLine("Bluetooth is turned off");
                }
            }
        }
    }
}
