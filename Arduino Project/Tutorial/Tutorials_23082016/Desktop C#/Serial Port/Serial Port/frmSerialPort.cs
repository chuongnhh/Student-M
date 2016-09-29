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

namespace Serial_Port
{
    public partial class frmSerialPort : Form
    {
        private delegate void callBackDataReceived(string data);

        public frmSerialPort()
        {
            InitializeComponent();
            this.Size = new Size(300, 500);

            string[] comPorts = SerialPort.GetPortNames();
            cboSerialPort.Items.AddRange(comPorts);
            cboSerialPort.SelectedIndex = cboSerialPort.Items.Count - 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
            this.Close();
        }

        private void btnSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = cboSerialPort.Text;
                    serialPort1.Open();
                    btnSerialPort.Text = "Disconnect";
                }
                else
                {
                    serialPort1.Close();
                    btnSerialPort.Text = "Connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(10);
                string dataRaw = serialPort1.ReadExisting();

                //rtbRecieved.AppendText(dataRaw);
                //rtbRecieved.ScrollToCaret();

                callBackRecieved(dataRaw);
            }
            catch { }
            finally
            {
                //serialPort1.DiscardOutBuffer();
                //serialPort1.DiscardInBuffer();
            }
        }

        private void callBackRecieved(string dataRaw)
        {
            if (this.InvokeRequired)
            {
                callBackDataReceived c = new callBackDataReceived(callBackRecieved);
                this.Invoke(c, new object[] { dataRaw });
            }
            else
            {
                rtbRecieved.AppendText(dataRaw);
                rtbRecieved.ScrollToCaret();
            }
        }

        private void btnTransmit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;

            string command = txtTransmit.Text.Trim();
            serialPort1.Write(command);
            txtTransmit.Clear();
        }

        private void txtTransmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTransmit_Click(null, null);
        }
    }
}
