using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Sockets;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Windows.Forms;
using System.Net.Sockets;

namespace HC_Bluetooth
{
    public partial class frmBTTerminal : Form
    {
        private BluetoothClient thisDevice;
        private BluetoothDeviceInfo[] bluetoothDevices;
        private BluetoothDeviceInfo device;
        public frmBTTerminal()
        {
            InitializeComponent();
            this.Size = new Size(300, 500);
        }
        protected override void OnLoad(EventArgs e)
        {

            rtbCommand.SelectionStart = rtbCommand.Text.Count();
        }

        private void discoverDevices()
        {
            try
            {
                thisDevice = new BluetoothClient();
                bluetoothDevices = thisDevice.DiscoverDevices();
                if (bluetoothDevices == null) return;

                foreach (var item in bluetoothDevices)
                {
                    rtbCommand.AppendText("\r\n   " + item.DeviceName);
                }
            }
            catch (Exception ex)
            {
                rtbCommand.AppendText("\r\n   " + ex.Message);
            }
        }
        private BluetoothDeviceInfo find()
        {
            SelectBluetoothDeviceDialog select = new SelectBluetoothDeviceDialog();
            select.ShowAuthenticated = true;
            select.ShowRemembered = true;
            select.ShowUnknown = true;
            if (select.ShowDialog() == DialogResult.OK)
            {

                rtbCommand.AppendText("\r\n   " + select.SelectedDevice.DeviceName);
                device = select.SelectedDevice;
                return select.SelectedDevice;
            }
            rtbCommand.AppendText("\r\n   No device selected.");
            return null;
        }
        private void pair()
        {
            //Create a new instance of the BluetoothClient class
            //BluetoothClient thisDevice = new BluetoothClient();
            //Scan for bluetooth devices in range
            //Display only discoverable devices(last argument)
            //Dont display already discovered devices (second argument)
            //Display remembered and unknown devices (third and fourth arguments)
            //BluetoothDeviceInfo[] devices = thisDevice.DiscoverDevices(8, false, true, true, true);

            //Send a pairing request to each device
            // foreach (BluetoothDeviceInfo device in devices)
            {
                bool paired = BluetoothSecurity.PairRequest(device.DeviceAddress, null);
                if (paired) rtbCommand.AppendText("\r\n   Paired success!");
                else
                    rtbCommand.AppendText("\r\n   There was a problem pairing.");
            }
        }
        private void remove()
        {
            bool remove = BluetoothSecurity.RemoveDevice(device.DeviceAddress);
            if (remove) rtbCommand.AppendText("\r\n   Removed success!");
            else
                rtbCommand.AppendText("\r\n   There was a problem removing.");
        }
        private void write()
        {
            try
            {
                BluetoothEndPoint endPoint = new BluetoothEndPoint(device.DeviceAddress, BluetoothService.SerialPort, 1);
                thisDevice.Connect(endPoint);

                NetworkStream stream = thisDevice.GetStream();

                if (stream.CanWrite)
                {
                    //byte[] data_conf = System.Text.Encoding.ASCII.GetBytes(config);
                    stream.Write(new byte[] { 1 }, 0, 1);
                    stream.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearScreen()
        {
            rtbCommand.Clear();
            rtbCommand.AppendText(@"HC Bluetooth Terminal [2016.11.8]");
            rtbCommand.AppendText("\r\n© 2016 Nguyen Hoang Chuong. All right reserved.");
        }
        private void commandText()
        {
            // rtbCommand.WordWrap = false;
            int cursorPosition = rtbCommand.SelectionStart;
            int lineIndex = rtbCommand.GetLineFromCharIndex(cursorPosition);
            string lineText = rtbCommand.Lines[lineIndex];
            //rtbCommand.WordWrap = true;

            string command = lineText.Remove(0, 2);
            if (command == "discover")
                discoverDevices();
            if (command == "clear")
                clearScreen();
            if (command == "about")
                (new frmAbout()).ShowDialog();
            if (command == "find")
                find();
            if (command == "pair")
                pair();
            if (command == "remove")
                remove();
            if (command == "exit")
                this.Close();
            if (command == "sent")
                write();
            rtbCommand.AppendText("\r\n> ");
        }

        private void rtbCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                commandText();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Delete)
                e.Handled = true;

            if (e.KeyCode == Keys.Back)
            {
                string lineText = rtbCommand.Lines[rtbCommand.Lines.LongLength - 1];
                if (lineText.Length <= 2) e.Handled = true;
            }
        }
        private void rtbCommand_KeyUp(object sender, KeyEventArgs e)
        {
            if (rtbCommand.SelectedText != "")
                rtbCommand.Select(rtbCommand.Text.Length, 0);
        }
        private void rtbCommand_MouseUp(object sender, MouseEventArgs e)
        {
            rtbCommand.Select(rtbCommand.Text.Length, 0);
        }
    }
}
