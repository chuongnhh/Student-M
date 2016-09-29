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
    public partial class FrmEditStudent : Form
    {
        private BLLStudent bllStudent;
        private DataTable dtStudent;
        public FrmEditStudent()
        {
            InitializeComponent();
            bllStudent = new BLLStudent();
            dtStudent = new DataTable();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            string StudentID = Program.StudentID;
            Program.StudentID = string.Empty;
            dtStudent = bllStudent.GetByStudentID(StudentID);

            string StudentName = dtStudent.Rows[0]["StudentName"].ToString();
            string Gender = dtStudent.Rows[0]["Gender"].ToString();
            DateTime BirthDay = (DateTime)dtStudent.Rows[0]["BirthDay"];
            string PhoneNumber = dtStudent.Rows[0]["PhoneNumber"].ToString();
            string Email = dtStudent.Rows[0]["Email"].ToString();
            string Address = dtStudent.Rows[0]["Address"].ToString();
            string Staying = dtStudent.Rows[0]["Staying"].ToString();
            string Education = dtStudent.Rows[0]["Education"].ToString();
            string University = dtStudent.Rows[0]["University"].ToString();

            txtStudentID.Text = StudentID;
            txtStudentName.Text = StudentName;
            cmbGender.SelectedItem = Gender;
            dtpBirthDay.Value = BirthDay;
            txtPhoneNumber.Text = PhoneNumber;
            txtEmail.Text = Email;
            txtAddress.Text = Address;
            txtStaying.Text = Staying;
            cmbEducation.Text = Education;
            cmbUniversity.Text = University;
        }

        private bool Save()
        {
            string StudentID = txtStudentID.Text;
            string StudentName = txtStudentName.Text;
            string Gender = "Nam";
            try
            {
                Gender = cmbGender.SelectedItem.ToString();
            }
            catch (Exception)
            {
                Gender = cmbGender.Text;
            }

            DateTime BirthDay = dtpBirthDay.Value;
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;
            string Staying = txtStaying.Text;
            string Education = cmbEducation.Text;
            string University = cmbUniversity.Text;
            string Message = "";

            if (!bllStudent.Update(ref Message, StudentID, StudentName, Gender, BirthDay, PhoneNumber,
                Email, Staying, Address, Education, University))
            {
                MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            if (Save() == true) this.Close();
        }
    }
}
