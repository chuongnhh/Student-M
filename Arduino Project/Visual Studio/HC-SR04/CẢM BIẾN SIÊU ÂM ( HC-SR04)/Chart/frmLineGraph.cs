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

namespace CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Chart
{
    public partial class frmLineGraph : Form
    {

        public delegate void graphCallback(string data);

        private Graphics g1;
        private Graphics g2;

        private List<float> lstdata = new List<float>();
        private SerialPort serialPort1;

        public frmLineGraph(SerialPort serialPort1)
        {
            InitializeComponent();
            this.serialPort1 = serialPort1;
        }

        private void frmLineGraph_Load(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            base.OnClosing(e);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadLine();
            if (string.IsNullOrEmpty(data) == false)
                graphLine(data);
        }

        private void graphLine(string data)
        {
            if (this.InvokeRequired)
            {
                graphCallback stcb = new graphCallback(graphLine);
                this.Invoke(stcb, new object[] { data });
            }
            else
            {
                // code do something
                if (lstdata.Count() >= 20)
                    this.lstdata.RemoveAt(0);
                this.lstdata.Add(float.Parse(data));

                g1.Clear(Color.Gray);
                panel1_Paint(null, null);

                g2.Clear(Color.Black);
                panel2_Paint(null, null);


                frmCurveGraph frm = (frmCurveGraph)Application.OpenForms["frmCurveGraph"];
                if (frm != null)
                    frm.setText(data);

                setValueFrmMain();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g1 = panel1.CreateGraphics();

            Graph.LineGraph lineGrap =
                new Graph.LineGraph(panel2.Height, panel2.Width);

            lineGrap.DrawValueV(g1, panel2.Left, panel2.Top, panel2.Top + panel2.Height, 10, 400, "000");
            //lineGrap.DrawValueH(g1, panel2.Top + panel2.Height, panel2.Left, panel2.Left + panel2.Width, lstdata.Count(), 150, "00");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            g2 = panel2.CreateGraphics();
            Graph.LineGraph lineGraph = new Graph.LineGraph(panel2.Height, panel2.Width);
            lstdata.Add(20);
            lstdata.Add(30);
            lstdata.Add(20);
            lstdata.Add(30);
            lstdata.Add(20);
            lineGraph.DrawLineGraph(g2, 400, getPointF(lstdata));
        }

        private PointF[] getPointF(List<float> data)
        {
            int size = data.Count(); ;
            PointF[] pointfs = new PointF[size];

            for (int i = 0; i < size; i++)
            {
                float x = i;
                float y = data[i];
                pointfs[i] = new PointF(i, y);
            }
            return pointfs;
        }

        public void reloadData()
        {
            frmMain frmMain = (frmMain)Application.OpenForms["frmMain"];
            frmMain.setAr("A* = 00.00 cm");
            frmMain.setDAr("ΔA* = 00.00 cm");
            frmMain.setA("A = 00.00 ± 00.00 cm");
            frmMain.setNumberOfMeasurements("N = 00");
            lstdata.Clear();
            g1.Clear(Color.Gray);
            panel1_Paint(null, null);

            g2.Clear(Color.Black);
            panel2_Paint(null, null);
        }

        public void startMeasure()
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Write("1");
        }

        private float mathAr()
        {
            int count = lstdata.Count();
            if (count == 0) return 0;
            return lstdata.Sum() / count;
        }

        private float mathDeltaAr()
        {
            int count = lstdata.Count();
            if (count == 0) return 0;

            float Ar = mathAr();
            float deltaA = 0;
            foreach (float d in lstdata)
            {
                deltaA += Math.Abs(d - Ar);
            }
            return deltaA / count;
        }

        private void setValueFrmMain()
        {
            frmMain frmMain = (frmMain)Application.OpenForms["frmMain"];

            string ar = mathAr().ToString("00.00");
            string dar = mathDeltaAr().ToString("00.00");
            frmMain.setAr("A* = " + ar + " cm");
            frmMain.setDAr("ΔA* = " + dar + " cm");
            frmMain.setA("A = " + ar + " ± " + dar + " cm");
            frmMain.setNumberOfMeasurements("N = "+lstdata.Count().ToString("00"));
        }
    }
}
