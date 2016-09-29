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
using System.Threading;

namespace HC_Bluetooth
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string device_Name = "HC-06";

        private ConnectionManager connectionManager;

        public MainPage()
        {
            connectionManager = new ConnectionManager();
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                connectionManager.Initialize();
            }
            catch (Exception ex)
            {
                enalbeControls(false);
                MessageBox.Show(ex.Message);
            }
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            connectionManager.Terminate();
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                connectToDevice();
                enalbeControls(true);
            }
            catch (Exception ex)
            {
                enalbeControls(false);
                MessageBox.Show(ex.Message);
            }
        }
        private void connectToDevice()
        {
            try
            {
                AppToDevice(device_Name);
            }
            catch (Exception)
            {
                txbStatus.Text = "Không có kết nối. Vui lòng kiểm tra thiết bị.";
                MessageBox.Show("Đã xảy ra một số lỗi! Vui lòng thử lại.");
            }
        }
        private async void AppToDevice(string device_Name)
        {
            txbStatus.Text = "Đang kết nối đến thiết bị...";
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
                Thread.Sleep(3000);
            }
        }
        private void btnTurnOn_Click(object sender, RoutedEventArgs e)
        {
            sendCommand("1");
        }
        private void btnTurnOff_Click(object sender, RoutedEventArgs e)
        {
            sendCommand("0");
        }

        private async void sendCommand(string command)
        {
            try
            {
                await connectionManager.SendCommand(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Current.Terminate();
            }
            //MessageBox.Show("Thiết bị đã được tắt thành công.");
        }
        private void enalbeControls(bool state)
        {
            if (state == true)
                txbStatus.Text = "Thiết bị đã sẵn sàng gửi và nhận dữ liệu.";
            btnTurnOff.IsEnabled = state;
            btnunrnOn.IsEnabled = state;
        }

    }
}