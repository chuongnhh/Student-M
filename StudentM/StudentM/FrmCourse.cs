using BLLayer;
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
    public partial class FrmCourse : Form
    {
        private BLLCourse bllCourse;
        private BindingSource bdCourse;
        private BLLLevel bllLevel;
        private BLLReceipt bllReceipt;
        private BLLRegister bllRegister;
        private BLLTranscript bllTranscript;
        public FrmCourse()
        {
            InitializeComponent();
            bllCourse = new BLLCourse();
            bdCourse = new BindingSource();
            bllLevel = new BLLLevel();
            bllReceipt = new BLLReceipt();
            bllTranscript = new BLLTranscript();
            bllRegister = new BLLRegister();
        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            //searchToolStripComboBox.SelectedIndex = 0;
            //cmbFilter.SelectedIndex = 0;
            //cmbLevel.DataSource = bllLevel.GetAll();
            //cmbLevel.DisplayMember = "LevelName";
            //cmbLevel.ValueMember = "LevelID";

            //// For DgvCourse = BdCourse
            //dgvCourse.DataSource = bdCourse;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    int index = cmbFilter.SelectedIndex;

            //    // All
            //    if (index == 0)
            //    {
            //        cmbLevel.Enabled = false;
            //        dtpFromDate.Enabled = false;
            //        dtpToDate.Enabled = false;

            //        bdCourse.DataSource = bllCourse.GetAll();
            //    }
            //    // Time
            //    else if (index == 1)
            //    {
            //        cmbLevel.Enabled = false;
            //        dtpFromDate.Enabled = true;
            //        dtpToDate.Enabled = true;
            //    }
            //    // Level
            //    else if (index == 2)
            //    {
            //        cmbLevel.Enabled = true;
            //        dtpFromDate.Enabled = false;
            //        dtpToDate.Enabled = false;
            //    }
            //    else if (index == 3)
            //    {
            //        cmbLevel.Enabled = true;
            //        dtpFromDate.Enabled = true;
            //        dtpToDate.Enabled = true;
            //    }
        }

        private void cmbLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayDataCourse();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayDataCourse();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayDataCourse();
        }

        private void DisplayDataCourse()
        {
            //try
            //{
            //    string LevelID = cmbLevel.SelectedValue.ToString();
            //    DateTime FromDate = dtpFromDate.Value;
            //    DateTime ToDate = dtpToDate.Value;

            //    int index = cmbFilter.SelectedIndex;

            //    cmbLevelID.DataSource = bllLevel.GetAll();
            //    cmbLevelID.DisplayMember = "LevelName";
            //    cmbLevelID.ValueMember = "LevelID";

            //    // All 
            //    if (index == 0)
            //    {
            //        bdCourse.DataSource = bllCourse.GetAll();
            //    }
            //    // time
            //    else if (index == 1)
            //    {
            //        bdCourse.DataSource = bllCourse.GetByOpening(FromDate, ToDate);
            //    }
            //    // level
            //    else if (index == 2)
            //    {
            //        bdCourse.DataSource = bllCourse.GetByLevel(LevelID);
            //    }
            //    // time & level
            //    else if (index == 3)
            //    {
            //        bdCourse.DataSource = bllCourse.GetByOpeningAndLevel(LevelID, FromDate, ToDate);
            //    }
            //}
            //catch { }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvCourse.CurrentCell.RowIndex;
            string CourseID = dgvCourse.Rows[index].Cells["CourseID"].Value.ToString();

            string Message = "";

            if (MessageBox.Show("Tất cả dữ liệu liên quan sẽ xóa khỏi hệ thống.\nBạn có muốn xóa khóa học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bllReceipt.DeleteByCourse(ref Message, CourseID);
                bllTranscript.DeleteByCourse(ref Message, CourseID);
                bllRegister.DeleteByCourse(ref Message, CourseID);

                if (!bllCourse.Delete(ref Message, CourseID))
                {
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdCourse.DataSource = bllCourse.GetAll();
        }

        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmNewCourse()).ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvCourse.CurrentCell.RowIndex;
                Program.CourseID = dgvCourse.Rows[index].Cells["CourseID"].Value.ToString();
                (new FrmEditCourse()).ShowDialog();
            }
            catch { }
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            //int IndexFilter = cmbFilter.SelectedIndex;

            //string CourseID = searchToolStripTextBox.Text;
            //int IndexSearch = searchToolStripComboBox.SelectedIndex;
            //DateTime FromDate = dtpFromDate.Value;
            //DateTime ToDate = dtpToDate.Value;
            //string LevelID = cmbLevel.SelectedValue.ToString();

            //// Course ID
            //if (IndexSearch == 0)
            //{
            //    // All
            //    if (IndexFilter == 0)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseID(CourseID);
            //    }
            //    // Time
            //    else if (IndexFilter == 1)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseIDByOpening(CourseID, FromDate, ToDate);
            //    }
            //    // Level
            //    else if (IndexFilter == 2)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseIDByLevel(CourseID, LevelID);
            //    }
            //    // Level & time
            //    else if (IndexFilter == 3)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseIDByOpeningAndLevel(CourseID, LevelID, FromDate, ToDate);
            //    }
            //}
            //// CourseName
            //else if (IndexSearch == 1)
            //{
            //    // All
            //    if (IndexFilter == 0)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseName(CourseID);
            //    }
            //    // Time
            //    else if (IndexFilter == 1)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseNameByOpening(CourseID, FromDate, ToDate);
            //    }
            //    // Level
            //    else if (IndexFilter == 2)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseNameByLevel(CourseID, LevelID);
            //    }
            //    // Level & time
            //    else if (IndexFilter == 3)
            //    {
            //        bdCourse.DataSource = bllCourse.SearchCourseNameByOpeningAndLevel(CourseID, LevelID, FromDate, ToDate);
            //    }
            //}
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbPractice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbSecondDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}