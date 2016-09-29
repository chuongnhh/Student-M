using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using HC_Bluetooth.Resources;
using BluetoothConnectionManager;
using Windows.Networking.Proximity;
using Windows.Storage.Streams;
using System.Text;

namespace HC_Bluetooth
{
    public partial class MainPage : PhoneApplicationPage
    {
        String device_Name = "HC-06";
        // Constructor
        private ConnectionManager connectionManager;

        public MainPage()
        {
            connectionManager = new ConnectionManager();
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            connectionManager.Initialize();
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            connectionManager.Terminate();
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            connectToDevice();
        }
        private void connectToDevice()
        {
            try
            {
                AppToDevice(device_Name);
                txbStatus.Text = "Thiết bị đã sẵn sàng gửi và nhận dữ liệu.";
            }
            catch (Exception)
            {
                txbStatus.Text = "Không có kết nối. Vui lòng kiểm tra thiết bị.";
                MessageBox.Show("Đã xảy ra một số lỗi! Vui lòng thử lại.");
            }
        }
        private async void AppToDevice(string device_Name)
        {
            //connect.Content = "Đang kết nối...";
            PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
            var pairedDevices = await PeerFinder.FindAllPeersAsync();

            if (pairedDevices.Count == 0)
            {
                MessageBox.Show("Không có thiết bị đã ghép nào được tìm thấy.");
            }
            else
            {
                foreach (var pairedDevice in pairedDevices)
                {
                    if (pairedDevice.DisplayName == device_Name)
                    {
                        connectionManager.Connect(pairedDevice.HostName);
                        continue;
                    }
                }
            }
        }
        private async void btnOn_Click(object sender, RoutedEventArgs e)
        {
            string command = "1";
            await connectionManager.SendCommand(command);
            MessageBox.Show("Thiết bị đã được mở thành công.", "Thông báo", MessageBoxButton.OK);
        }
        private async void btnOff_Click(object sender, RoutedEventArgs e)
        {
            string command = "0";
            await connectionManager.SendCommand(command);
            MessageBox.Show("Thiết bị đã được tắt thành công.", "Thông báo", MessageBoxButton.OK);
        }
    }
}