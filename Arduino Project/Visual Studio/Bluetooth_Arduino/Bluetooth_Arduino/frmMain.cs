using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth_Arduino
{
    public partial class frmMain : Form
    {
        private delegate void callBackDataReceived(string data);

        public frmMain()
        {
            InitializeComponent();

            string[] comPorts = SerialPort.GetPortNames();
            cboComPort.Items.AddRange(comPorts);
            cboComPort.SelectedIndex = cboComPort.Items.Count - 1;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = cboComPort.Text.Trim();
                    serialPort1.Open();
                    cboComPort.Enabled = false;
                    lblStatus.Text = "Connected.";
                    btnConnect.Text = "Disconnect";
                }
                else
                {
                    serialPort1.Close();
                    cboComPort.Enabled = true;
                    lblStatus.Text = "Disconnected.";
                    btnConnect.Text = "Connect";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connect not success.",
                    "Error connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            try
            {
                //Thread.Sleep(100);
                string dataRow = serialPort1.ReadLine();
                if (string.IsNullOrEmpty(dataRow) == false)
                    callBackProcessData(dataRow);
            }
            catch { }
            finally
            {
                serialPort1.DiscardOutBuffer();
                serialPort1.DiscardInBuffer();
            }
        }

        private void callBackProcessData(string dataRow)
        {
            if (this.InvokeRequired)
            {
                callBackDataReceived c = new callBackDataReceived(callBackProcessData);
                this.Invoke(c, new object[] { dataRow });
            }
            else
            {
                rtbReceive.AppendText(dataRow);
                rtbReceive.ScrollToCaret();
            }
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTransmit.Text) == false)
                serialPort1.Write(txtTransmit.Text.Trim());
        }

        private void txtTransmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSent_Click(null, null);
        }

        private void chkLEDControls_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            string value = chk.Tag.ToString();
            if (chk.Checked == true)
                serialPort1.Write("Turn on LED" + value);
            else
                serialPort1.Write("Turn off LED" + value);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (serialPort1.IsOpen == false)
                serialPort1.Close();
            base.OnClosing(e);
        }
    }
}
