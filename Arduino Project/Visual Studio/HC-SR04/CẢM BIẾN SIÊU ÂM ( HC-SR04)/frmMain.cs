using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CẢM_BIẾN_SIÊU_ÂM___HC_SR04_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnec1_Click(object sender, EventArgs e)
        {
            (new Setting.frmConnection(serialPort1)).ShowDialog();
        }

        public void setConnectStatus(string message)
        {
            lblConnection.Text = message;
        }

        protected override void OnClosing(CancelEventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                if (MessageBox.Show("Vui lòng ngắt kết nối trước khi đóng ứng dụng.\r\n Bạn có muốn đóng ngay không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    serialPort1.Close();
                else e.Cancel = true;
            }

            base.OnClosing(e);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tab);
            }
            addFormOnTabPage((new Chart.frmLineGraph(serialPort1)), tabControl1, tabPageLineGraph);
        }

        // thêm form vào tabpage trong tabcontrol
        private void addFormOnTabPage(Form frm, TabControl tabControl, TabPage tabPage)
        {
            if (tabControl1.TabPages.Contains(tabPage))
            {
                tabControl.SelectedTab = tabPage;
                return;
            }

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = tabPage;
            tabPage.Text = frm.Text;
            frm.Show();
            tabControl.Controls.Add(tabPage);
            tabControl.SelectedTab = tabPage;
        }

        #region ////////////////////Vẽ tabPage trên tabControl

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                var closeRect = this.tabControl1.GetTabRect(i);
                closeRect.Size = new Size(205, 18);
                closeRect.Inflate(-98, -1);

                var imageRect = new Rectangle(closeRect.Right - closeRect.Width,
                                    closeRect.Top + (closeRect.Height - closeRect.Height) / 2,
                                    closeRect.Width, closeRect.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.tabControl1.TabPages[i].Controls.RemoveAt(0);
                    this.tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        // Draw Item Event
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabRect = this.tabControl1.GetTabRect(e.Index);
                tabRect.Inflate(-7, -1);

                var sf = new StringFormat(StringFormat.GenericDefault);

                Font font = new Font("Segoe UI", 8, FontStyle.Bold);

                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text,
                                     font, Brushes.Black, tabRect, sf);

                var closeRect = this.tabControl1.GetTabRect(e.Index);
                closeRect.Size = new Size(205, 18);
                closeRect.Inflate(-98, -1);
                e.Graphics.DrawString("×", this.Font, Brushes.DimGray, closeRect);//×
            }
            catch (Exception) { }
        }
        #endregion

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            btnConnec1_Click(null, null);
        }

        private void btnAbout1_Click(object sender, EventArgs e)
        {
            (new Help.frmAbout()).ShowDialog();
        }

        private void btnAbout2_Click(object sender, EventArgs e)
        {
            btnAbout1_Click(null, null);
        }

        private void btnSaveGraph2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnCurveGraph1_Click(object sender, EventArgs e)
        {
            addFormOnTabPage((new Chart.frmCurveGraph()), tabControl1, tabPageCurveGraph);
        }

        private void btnLineGraph1_Click(object sender, EventArgs e)
        {
            addFormOnTabPage((new Chart.frmLineGraph(serialPort1)), tabControl1, tabPageLineGraph);
        }

        private void btnCurveGraph2_Click(object sender, EventArgs e)
        {
            btnCurveGraph1_Click(null, null);
        }

        private void btnLineGraph2_Click(object sender, EventArgs e)
        {
            btnLineGraph1_Click(null, null);
        }

        public void setNumberOfMeasurements(string value)
        {
            lblNumberOfMeasurements.Text =value;
        }

        public void setAr(string value)
        {
            lblAr.Text = value;
        }

        public void setDAr(string value)
        {
            lblDAr.Text = value;
        }

        public void setA(string value)
        {
            lblA.Text = value;
        }
        private void btnMeasure_Click(object sender, EventArgs e)
        {
            Chart.frmLineGraph frmLineGraph = (Chart.frmLineGraph)Application.OpenForms["frmLineGraph"];
            if (frmLineGraph != null)
                frmLineGraph.startMeasure();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Chart.frmLineGraph frmLineGraph = (Chart.frmLineGraph)Application.OpenForms["frmLineGraph"];
            if (frmLineGraph != null)
                frmLineGraph.reloadData();
        }
    }
}
