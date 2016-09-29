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
    public partial class FrmEditCourse : Form
    {
        private BLLCourse bllCourse;
        private BLLLevel bllLevel;
        DataTable dtCourse;
        public FrmEditCourse()
        {
            InitializeComponent();
            bllCourse = new BLLCourse();
            dtCourse = new DataTable();
            bllLevel = new BLLLevel();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditCourse_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLevel.DataSource = bllLevel.GetAll();
                cmbLevel.DisplayMember = "LevelName";
                cmbLevel.ValueMember = "LevelID";
                string CourseID = Program.CourseID;
                Program.CourseID = string.Empty;

                dtCourse = bllCourse.GetByCourseID(CourseID);

                string LevelID = dtCourse.Rows[0]["LevelID"].ToString();
                string CourseName = dtCourse.Rows[0]["CourseName"].ToString();
                DateTime CourseTime = DateTime.Parse(dtCourse.Rows[0]["CourseTime"].ToString());
                DateTime Opening = DateTime.Parse(dtCourse.Rows[0]["Opening"].ToString());
                DateTime Closing = DateTime.Parse(dtCourse.Rows[0]["Closing"].ToString());

                string FirstDay = dtCourse.Rows[0]["FirstDay"].ToString();
                string SecondDay = dtCourse.Rows[0]["SecondDay"].ToString();
                string Skill = dtCourse.Rows[0]["Skill"].ToString();
                string Practice = dtCourse.Rows[0]["Practice"].ToString();

                cmbLevel.SelectedValue = LevelID;
                txtCourseID.Text = CourseID;
                txtCourseName.Text = CourseName;
                dtpCourseTime.Value = CourseTime;
                dtpOpening.Value = Opening;
                dtpClosing.Value = Closing;

                cmbFirstDay.Text = FirstDay;
                cmbSecondDay.Text = SecondDay;
                cmbSkill.Text = Skill;
                cmbPractice.Text = Practice;
            }
            catch (Exception)
            {
            }
        }

        private void btnNewLevel_Click(object sender, EventArgs e)
        {
            (new FrmNewLevel()).ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {

        }
    }
}
