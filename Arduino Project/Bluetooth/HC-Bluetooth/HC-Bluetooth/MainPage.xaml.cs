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
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
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
                        MessageBox.Show(pairedDevice.HostName);
                        connectionManager.Connect(pairedDevice.HostName);
                        continue;
                    }
                }
            }
        }
      
        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string command = txtMessage.Text.Trim();
            await connectionManager.SendCommand(command);
            //MessageBox.Show("Đã gửi thành công.");
        }
        private void txtMessage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                btnSend.Focus();
        }
    }
}