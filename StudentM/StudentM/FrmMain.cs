using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tab);
            }
            //FrmStudent frmStudent = new FrmStudent();
            //FrmCourse frmCourse = new FrmCourse();
            //FrmRegistration frmRegistration = new FrmRegistration();
            //FrmTranscript frmTranscript = new FrmTranscript();

            //frmStudent.TopLevel = false;
            //frmStudent.Dock = DockStyle.Fill;
            //frmStudent.FormBorderStyle = FormBorderStyle.None;
            //frmStudent.Parent = tabPage1;
            //tabPage1.Text = frmStudent.Text;
            //frmStudent.Show();

            //frmCourse.TopLevel = false;
            //frmCourse.Dock = DockStyle.Fill;
            //frmCourse.FormBorderStyle = FormBorderStyle.None;
            //frmCourse.Parent = tabPage2;
            //tabPage2.Text = frmCourse.Text;
            //frmCourse.Show();

            //frmRegistration.TopLevel = false;
            //frmRegistration.Dock = DockStyle.Fill;
            //frmRegistration.FormBorderStyle = FormBorderStyle.None;
            //frmRegistration.Parent = tabPage3;
            //tabPage3.Text = frmRegistration.Text;
            //frmRegistration.Show();

            //frmTranscript.TopLevel = false;
            //frmTranscript.Dock = DockStyle.Fill;
            //frmTranscript.FormBorderStyle = FormBorderStyle.None;
            //frmTranscript.Parent = tabPage4;
            //tabPage4.Text = frmTranscript.Text;
            //frmTranscript.Show();
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Remove(this.tabControl1.SelectedTab);
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                if (tab == tabPage1)
                {

                    this.tabControl1.SelectedTab = tabPage1;
                    return;
                }
            }
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.TopLevel = false;
            frmStudent.Dock = DockStyle.Fill;
            frmStudent.FormBorderStyle = FormBorderStyle.None;
            frmStudent.Parent = tabPage1;
            tabPage1.Text = frmStudent.Text;
            frmStudent.Show();
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.SelectedTab = tabPage1;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                if (tab == tabPage3)
                {

                    this.tabControl1.SelectedTab = tabPage3;
                    return;
                }
            }
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.TopLevel = false;
            frmRegistration.Dock = DockStyle.Fill;
            frmRegistration.FormBorderStyle = FormBorderStyle.None;
            frmRegistration.Parent = tabPage3;
            tabPage3.Text = frmRegistration.Text;
            frmRegistration.Show();
            this.tabControl1.Controls.Add(tabPage3);
            this.tabControl1.SelectedTab = tabPage3;
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                if (tab == tabPage2)
                {

                    this.tabControl1.SelectedTab = tabPage2;
                    return;
                }
            }
            FrmCourse frmCourse = new FrmCourse();
            frmCourse.TopLevel = false;
            frmCourse.Dock = DockStyle.Fill;
            frmCourse.FormBorderStyle = FormBorderStyle.None;
            frmCourse.Parent = tabPage2;
            tabPage2.Text = frmCourse.Text;
            frmCourse.Show();
            this.tabControl1.Controls.Add(tabPage2);
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void transcriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                if (tab == tabPage4)
                {

                    this.tabControl1.SelectedTab = tabPage4;
                    return;
                }
            }
            FrmTranscript frmTranscript = new FrmTranscript();
            frmTranscript.TopLevel = false;
            frmTranscript.Dock = DockStyle.Fill;
            frmTranscript.FormBorderStyle = FormBorderStyle.None;
            frmTranscript.Parent = tabPage4;
            tabPage4.Text = frmTranscript.Text;
            frmTranscript.Show();
            this.tabControl1.Controls.Add(tabPage4);
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void attenDanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                if (tab == tabPage5)
                {

                    this.tabControl1.SelectedTab = tabPage5;
                    return;
                }
            }
            FrmAttendance frmAttenDance = new FrmAttendance();
            frmAttenDance.TopLevel = false;
            frmAttenDance.Dock = DockStyle.Fill;
            frmAttenDance.FormBorderStyle = FormBorderStyle.None;
            frmAttenDance.Parent = tabPage5;
            tabPage5.Text = frmAttenDance.Text;
            frmAttenDance.Show();
            this.tabControl1.Controls.Add(tabPage5);
            this.tabControl1.SelectedTab = tabPage5;
        }
    }
}
