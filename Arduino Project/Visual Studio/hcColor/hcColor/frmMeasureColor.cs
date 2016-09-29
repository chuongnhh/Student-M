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

namespace hcColor
{
    public partial class frmMeasureColor : Form
    {
        private SerialPort serialPort1;
        private delegate void callBackDataReceived(string data);
        private bool startMeasure = false;

        public frmMeasureColor(SerialPort serialPort1)
        {
            this.serialPort1 = serialPort1;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (startMeasure == false &&
                serialPort1.IsOpen == false) return;
            try
            {
                Thread.Sleep(100);
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
                string []values = processDataRow(dataRow);

                frmMain frmMain = (frmMain)Application.OpenForms["frmMain"];
                if (frmMain != null)
                {
                    frmMain.setDataGridView(values[0], values[1], values[2]);
                }
            }
        }

        private string[] processDataRow(string dataRow)
        {
            string[] temp = dataRow.Split(' ');
            return temp;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            this.Close();
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            if (startMeasure == false)
            {
                startMeasure = true;
                label1.Text = "Processing the data read from the colorimeter...";
                btnMeasure.Text = "Stop";
            }
            else
            {
                startMeasure = false;
                label1.Text = "Please, press 'Measure' to measure...";
                btnMeasure.Text = "Measure";
            }
        }

        private void frmMeasureColor_Load(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                label1.Text = "Please, connect to the colorimeter.";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
