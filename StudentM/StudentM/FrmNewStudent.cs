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
    public partial class FrmNewStudent : Form
    {
        private BLLStudent bllStudent;

        public FrmNewStudent()
        {
            InitializeComponent();
            bllStudent = new BLLStudent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private bool Insert()
        {
            string StudentID = txtStudentID.Text;
            string StudentName = txtStudentName.Text;
            string Gender = cmbGender.SelectedItem.ToString();
            DateTime BirthDay = dtpBirthDay.Value;
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;
            string Staying = txtStaying.Text;
            string Education = cmbEducation.Text;
            string University = cmbUniversity.Text;

            if(string.IsNullOrEmpty(StudentID)|| 
                string.IsNullOrEmpty(StudentName))
            {
                MessageBox.Show("Mã học viên hoặc Tên học viên không được để rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string Message = "";

            if (!bllStudent.Insert(ref Message, StudentID, StudentName, Gender, BirthDay, PhoneNumber,
                Email, Staying, Address, Education, University))
            {
                MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            Program.StudentID = StudentID;
            return true;
        }
        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            if (Insert() == true) this.Close();
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            cmbEducation.SelectedIndex = 0;
            cmbUniversity.SelectedIndex = 0;
        }
    }
}
