using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Setting
{
    public partial class frmConnection : Form
    {
        private SerialPort serialPort1;

        public frmConnection(SerialPort serialPort1)
        {
            this.serialPort1 = serialPort1;
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            // Cài đặt các thông số cho COM
            // Mảng string port để chứ tất cả các cổng COM đang có trên máy tính
            string[] comPorts = SerialPort.GetPortNames();

            // Thêm toàn bộ các COM đã tìm được vào combox cbCom
            cboComPort.Items.AddRange(comPorts); // Sử dụng AddRange thay vì dùng foreach
            serialPort1.ReadTimeout = 1000;

            // Cài đặt cho BaudRate
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cboBaudRate.Items.AddRange(BaudRate);

            // Cài đặt cho DataBits
            string[] Databits = { "6", "7", "8" };
            cboDataBit.Items.AddRange(Databits);

            //Cho Parity
            string[] Parity = { "None", "Odd", "Even" };
            cboParity.Items.AddRange(Parity);

            //Cho Stop bit
            string[] stopbit = { "1", "1.5", "2" };
            cboStopBit.Items.AddRange(stopbit);

            if (cboComPort.Items.Count > 0)
                cboComPort.SelectedIndex = 0;
            cboBaudRate.SelectedIndex = 3;
            cboDataBit.SelectedIndex = 2;
            cboParity.SelectedIndex = 0;
            cboStopBit.SelectedIndex = 0;

            if (serialPort1.IsOpen == true)
            {
                cboComPort.SelectedItem = serialPort1.PortName;
                cboBaudRate.Text = serialPort1.BaudRate.ToString();
                cboDataBit.Text = serialPort1.DataBits.ToString();
                cboParity.Text = serialPort1.Parity.ToString();
                cboStopBit.Text = serialPort1.StopBits.ToString();

                btnConnect.Text = "Disconnect";
                enableControl(false);
            }
            else
            {
                btnConnect.Text = "Connect";
                enableControl(true);
            }
        }

        private void enableControl(bool value)
        {
            cboComPort.Enabled = value;
            cboBaudRate.Enabled = value;
            cboDataBit.Enabled = value;
            cboParity.Enabled = value;
            cboStopBit.Enabled = value;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string conn_ms = "Not connected.";
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = cboComPort.Text.Trim();
                    serialPort1.BaudRate = int.Parse(cboBaudRate.Text);
                    serialPort1.DataBits = int.Parse(cboDataBit.Text);

                    switch (cboParity.Text)
                    {
                        case "None":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "Even":
                            serialPort1.Parity = Parity.None;
                            break;
                        default:
                            break;
                    }

                    switch (cboStopBit.Text)
                    {
                        case "1":
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            break;
                    }
                    serialPort1.Open();
                    btnConnect.Text = "Disconnect";
                    conn_ms = "Connected - " + serialPort1.PortName+".";
                    enableControl(false);
                }
                else
                {
                    serialPort1.Close();
                    btnConnect.Text = "Connect";
                    enableControl(true);

                    //Chart.frmLineGraph frmLineGraph = 
                    //    (Chart.frmLineGraph)Application.OpenForms["frmLineGraph"];
                    //frmLineGraph.closeConnect();
                }
                frmMain frmMain = (frmMain)Application.OpenForms["frmMain"];
                frmMain.setConnectStatus(conn_ms);
            }
            catch (Exception)
            {
            }
        }
    }
}
