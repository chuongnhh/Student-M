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
    public partial class FrmNewCourse : Form
    {
        private BLLCourse bllCourse;
        private BLLLevel bllLevel;
        public FrmNewCourse()
        {
            InitializeComponent();
            bllCourse = new BLLCourse();
            bllLevel = new BLLLevel();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private bool Save()
        {
            string LevelID = cmbLevel.SelectedValue.ToString();
            string CourseID = txtCourseID.Text;
            string CourseName = txtCourseName.Text;
            DateTime CourseTime = dtpCourseTime.Value;
            DateTime Opening = dtpOpening.Value;
            DateTime Closing = dtpClosing.Value;

            string FirstDay = cmbFirstDay.Text;
            string SecondDay = cmbSecondDay.Text;
            string Skill = cmbSkill.Text;
            string Practice = cmbPractice.Text;

            string Message = "";
            if (!bllCourse.Insert(ref Message, CourseID, CourseName, CourseTime, Opening, Closing, FirstDay,
                SecondDay, Skill, Practice, LevelID))
            {
                MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                MessageBox.Show("Thêm khóa học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            if (Save() == true) this.Close();
        }

        private void FrmNewCourse_Load(object sender, EventArgs e)
        {
            cmbLevel.DataSource = bllLevel.GetAll();
            cmbLevel.ValueMember = "LevelID";
            cmbLevel.DisplayMember = "LevelName";

            //
            cmbFirstDay.SelectedIndex = 0;
            cmbSecondDay.SelectedIndex = 0;
            cmbSkill.SelectedIndex = 0;
            cmbPractice.SelectedIndex = 0;
        }

        private void btnNewLevel_Click(object sender, EventArgs e)
        {
            (new FrmNewLevel()).ShowDialog();
        }
    }
}
