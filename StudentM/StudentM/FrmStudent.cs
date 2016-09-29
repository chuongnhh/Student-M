using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLayer;

namespace StudentM
{
    public partial class FrmStudent : Form
    {
        private BLLStudent bllStudent;
        private BindingSource bdStudent;
        private DataTable dtStudent;
        private BLLTranscript bllTranscript;
        private BLLRegister bllRegister;
        private BLLReceipt bllReceipt;
        private BLLLevel bllLevel;
        private BLLCourse bllCourse;
        public FrmStudent()
        {
            InitializeComponent();

            bllStudent = new BLLStudent();
            bllTranscript = new BLLTranscript();
            bllRegister = new BLLRegister();
            bdStudent = new BindingSource();
            dtStudent = new DataTable();
            bllLevel = new BLLLevel();
            bllCourse = new BLLCourse();
            bllReceipt = new BLLReceipt();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            //isActiveToolStripComboBox.SelectedIndex = 0;
            // Select Index of Commbox 
            //cmbFilter.SelectedIndex = 0;
            //searchToolStripComboBox.SelectedIndex = 0;

            ////Fill data on Level Combobox
            //cmbLevel.DataSource = bllLevel.GetAll();
            //cmbLevel.DisplayMember = "LevelName";
            //cmbLevel.ValueMember = "LevelID";

            //// Binding Source
            ////bdStudent.DataSource = bllStudent.GetAll();
            //dgvStudent.DataSource = bdStudent;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = cmbFilter.SelectedIndex;
            ////All
            //if (index == 0)
            //{
            //    dtpFromDate.Enabled = false;
            //    dtpToDate.Enabled = false;
            //    cmbLevel.Enabled = false;
            //    cmbCourse.Enabled = false;

            //    //  Get All Student
            //    bdStudent.DataSource = bllStudent.GetAll();
            //}
            //// Time & Course
            //else if (index == 1)
            //{
            //    dtpFromDate.Enabled = true;
            //    dtpToDate.Enabled = true;
            //    cmbLevel.Enabled = true;
            //    cmbCourse.Enabled = true;
            //}
            //// Time
            //else if (index == 2)
            //{
            //    dtpFromDate.Enabled = false;
            //    dtpToDate.Enabled = false;
            //    cmbLevel.Enabled = true;
            //    cmbCourse.Enabled = true;
            //}
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            //int indexSearch = searchToolStripComboBox.SelectedIndex;
            //int indexFillter = cmbFilter.SelectedIndex;
            //string searchText = searchToolStripTextBox.Text;
            //// ALL
            //if (indexFillter == 0)
            //{
            //    if (indexSearch == 0)// StudentID
            //    {
            //        bdStudent.DataSource = bllStudent.SearchStudentID(searchText);
            //    }
            //    else if (indexSearch == 1)// StudentID
            //    {
            //        bdStudent.DataSource = bllStudent.SearchStudentName(searchText);
            //    }
            //    else if (indexSearch == 2)// StudentID
            //    {
            //        bdStudent.DataSource = bllStudent.SearchStudentPhoneNumber(searchText);
            //    }
            //}
            //// Time and Course
            //else if (indexFillter == 1)
            //{
            //    string CoursID = cmbCourse.SelectedValue.ToString();

            //    if (indexSearch == 0)// StudentID
            //    {
            //        bdStudent.DataSource = bllStudent.SearchStudentIDByCourse(searchText, CoursID);
            //    }
            //    else if (indexSearch == 1)// StudentID
            //    {
            //        bdStudent.DataSource = bllStudent.SearchStudentNameByCourse(searchText, CoursID);
            //    }
            //    else if (indexSearch == 2)// StudentID
            //    {
            //        bdStudent.DataSource = bllStudent.SearchStudentPhoneNumberByCourse(searchText, CoursID);
            //    }
            //}
        }

        private void cmbLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            //// Filter
            //int IndexFilter = cmbFilter.SelectedIndex;

            //// Get Info data
            //string LevelID = "";
            //try
            //{

            //    LevelID = cmbLevel.SelectedValue.ToString();
            //}
            //catch { }

            //DateTime FromDate = dtpFromDate.Value;
            //DateTime ToDate = dtpToDate.Value;

            //// All if IndexFilter = 0
            //// Time & course
            //if (IndexFilter == 1)
            //{
            //    cmbCourse.DataSource = bllCourse.GetByOpeningAndLevel(LevelID, FromDate, ToDate);
            //    cmbCourse.ValueMember = "CourseID";
            //    cmbCourse.DisplayMember = "CourseName";
            //}
            //// Course
            //else if (IndexFilter == 2)
            //{
            //    cmbCourse.DataSource = bllCourse.GetByLevel(LevelID);
            //    cmbCourse.ValueMember = "CourseID";
            //    cmbCourse.DisplayMember = "CourseName";
            //}
        }

        //private void newToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    (new FrmNewStudent()).ShowDialog();
        //    Program.StudentID = string.Empty;
        //    reloadToolStripMenuItem_Click(null, null);
        //}

        //private void editToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int index = dgvStudent.CurrentCell.RowIndex;
        //    string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();
        //    Program.StudentID = StudentID;

        //    (new FrmEditStudent()).ShowDialog();
        //    reloadToolStripMenuItem_Click(null, null);
        //}

        //private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DialogResult Result = new DialogResult();
        //    Result = MessageBox.Show("Tất cả dữ liệu liên quan sẽ bị hủy khi xóa học viên.\nBạn muốn xóa học viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (Result == DialogResult.Yes)
        //    {
        //        // Get StudentID
        //        int index = dgvStudent.CurrentCell.RowIndex;
        //        string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();

        //        string Message = "";

        //        // delete all receipt
        //        bllReceipt.DeleteByStudent(ref Message, StudentID);

        //        //delete all transcript
        //        bllTranscript.DeleteByStudent(ref Message, StudentID);

        //        // delete all Register
        //        bllRegister.DeleteByStudent(ref Message, StudentID);


        //        if (!bllStudent.Delete(ref Message, StudentID))
        //        {
        //            MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //            reloadToolStripMenuItem_Click(null, null);
        //    }
        //}

        //private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //int IndexFilter = cmbFilter.SelectedIndex;
        //    //// All
        //    //if (IndexFilter == 0)
        //    //    bdStudent.DataSource = bllStudent.GetAll();
        //    //else
        //    //{
        //    //    try
        //    //    {
        //    //        string CourseID = cmbCourse.SelectedValue.ToString();
        //    //        bdStudent.DataSource = bllStudent.GetByStudentByCourse(CourseID);
        //    //    }
        //    //    catch { }
        //    //}
        //}

        //private void cmbCourse_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    string CourseID = cmbCourse.SelectedValue.ToString();
        //    //    bdStudent.DataSource = bllStudent.GetByStudentByCourse(CourseID);
        //    //}
        //    //catch { }
        //}
    }
}
