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

namespace hcColor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnComPort_Click(object sender, EventArgs e)
        {
            (new frmSerialPort(serialPort1)).ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();

            base.OnClosing(e);
        }

        public void setStatus(string value)
        {
            lblStatus.Text = value;
        }

        private void btnMeasureColor_Click(object sender, EventArgs e)
        {
            (new frmMeasureColor(serialPort1)).ShowDialog();
        }

        private int getCountRow(DataGridView g)
        {
            return g.RowCount + 1;
        }

        public void setDataGridView(string RE, string GR, string BL)
        {
            int STT = getCountRow(dataGridView1);
            string[] calib = calibRGB(RE, GR, BL);

            dataGridView1.Rows.Add(STT, "", calib[0], calib[1], calib[2]);
            dataGridView1.Rows[STT - 1].Cells[1].Style.BackColor = getColorRGB(RE, GR, BL);
            // chọn dòng dử liệu mới
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Rows[STT - 1].Selected = true;
        }

        private string[] calibRGB(string RE, string GR, string BL)
        {
            string[] temp = new string[3];

            int re = int.Parse(RE);
            if (re > 255) re = 255;
            if (re < 0) re = 0;

            int gr = int.Parse(GR);
            if (gr > 255) gr = 255;
            if (gr < 0) gr = 0;

            int bl = int.Parse(BL);
            if (bl > 255) bl = 255;
            if (bl < 0) bl = 0;

            temp[0] = re.ToString();
            temp[1] = gr.ToString();
            temp[2] = bl.ToString();

            return temp;
        }

        private Color getColorRGB(string RE, string GR, string BL)
        {
            string[] calib = calibRGB(RE, GR, BL);

            int re = int.Parse(calib[0]);
            int gr = int.Parse(calib[1]);
            int bl = int.Parse(calib[2]);

            Color c = System.Drawing.Color.FromArgb(re, gr, bl);

            return c;
        }

    }
}
