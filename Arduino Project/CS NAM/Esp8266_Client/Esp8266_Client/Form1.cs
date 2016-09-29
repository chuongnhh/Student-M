using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esp8266_Client
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            write("/led/" + richTextBox2.Text.Trim());
            //byte[] inStream = new byte[10025];
            //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            //string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            //msg(returndata);
            //richTextBox2.Text = "";
            //richTextBox2.Focus();
        }

        private void write(string command)
        {
            connect();
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(command);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            richTextBox2.Clear();
            close();
        }
        public void msg(string mesg)
        {
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + " >> " + mesg;
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clientSocket.Connect("192.168.1.87", 80);
            //label1.Text = "Client Socket Program - Server Connected ...";
        }

        private void connect()
        {
            try
            {
                clientSocket = new System.Net.Sockets.TcpClient();
                clientSocket.Connect("172.16.87.72", 80);
                label1.Text = "Client Socket Program - Server Connected ...";
            }
            catch (Exception)
            {
                //exception handle
            }
        }
        private void close()
        {
            try
            {
                clientSocket.Close();
            }
            catch (Exception)
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "1. OFF")
            {
                write("/led/11");
                button2.Text = "1. ON";
            }
            else
            {
                write("/led/21");
                button2.Text = "1. OFF";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "2. OFF")
            {
                write("/led/12");
                button2.Text = "2. ON";
            }
            else
            {
                write("/led/22");
                button2.Text = "2. OFF";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button2.Text == "3. OFF")
            {
                write("/led/13");
                button2.Text = "3. ON";
            }
            else
            {
                write("/led/23");
                button2.Text = "3. OFF";
            }
        }
    }
}
