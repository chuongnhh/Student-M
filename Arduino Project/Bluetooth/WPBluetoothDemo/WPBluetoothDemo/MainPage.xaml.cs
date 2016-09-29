using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WPBluetoothDemo.Resources;
using Windows.Networking.Proximity;
using Windows.Foundation;
using Windows.Networking.Sockets;

namespace WPBluetoothDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        

        private async void buttonDiscoverDevices_Click(object sender, RoutedEventArgs e)
        {
            PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
            var peerList = await PeerFinder.FindAllPeersAsync();
            if (peerList.Count > 0)
            {
                textBoxPeer.Text = peerList[0].DisplayName;
            }
            else MessageBox.Show("No active peers");
        }

        private async void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
            
            var peerList = await PeerFinder.FindAllPeersAsync();
            if (peerList.Count > 0)
                textBoxPeer.Text = peerList[0].DisplayName;
            StreamSocket socket = new StreamSocket();
            await socket.ConnectAsync(peerList[0].HostName, "0");
            MessageBox.Show("Connected.");
        }
                

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            PeerFinder.ConnectionRequested += PeerFinder_ConnectionRequested;
        }

        void PeerFinder_ConnectionRequested(object sender, ConnectionRequestedEventArgs args)
        {
            Connect(args.PeerInformation);
        }
        async void Connect(PeerInformation peerToConnect)
        {
            StreamSocket socket = await PeerFinder.ConnectAsync(peerToConnect);
        }

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}