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
    public partial class FrmRegistration : Form
    {
        private BLLRegister bllRegister;
        private BindingSource bdRegister;
        private BindingSource bdReceipt;
        private BLLLevel bllLevel;
        private BLLReceipt bllReceipt;
        private BLLCourse bllCourse;
        private BindingSource bdCourse;
        private BLLStudent bllStudent;
        private DataTable dtStudent;
        private DataTable dtRegister;
        private DataTable dtReceipt;
        private BLLTranscript bllTranscript;
        public FrmRegistration()
        {
            InitializeComponent();
            bllRegister = new BLLRegister();
            bllLevel = new BLLLevel();
            bllReceipt = new BLLReceipt();

            bllCourse = new BLLCourse();
            bdCourse = new BindingSource();

            bllStudent = new BLLStudent();
            dtStudent = new DataTable();

            bdReceipt = new BindingSource();
            bdRegister = new BindingSource();

            dtRegister = new DataTable();
            dtReceipt = new DataTable();

            bllTranscript = new BLLTranscript();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            (new FrmNewStudent()).ShowDialog();
            string StudentID = Program.StudentID;
            Program.StudentID = string.Empty;

            try
            {
                dtStudent = bllStudent.GetByStudentID(StudentID);
                string StudentName = dtStudent.Rows[0]["StudentName"].ToString();
                txtStudentID.Text = StudentID + " - " + StudentName;
                txtStudentID.Tag = StudentID;
            }
            catch { }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string StudentID = "";
                try
                {
                    StudentID = txtStudentID.Tag.ToString();
                }
                catch (Exception)
                {
                    StudentID = txtStudentID.Text;
                }
                string CourseID = "";
                try
                {
                    CourseID = txtCourseID.Tag.ToString();
                }
                catch (Exception)
                {
                    CourseID = txtCourseID.Text;
                }

                DateTime RegisterDate = DateTime.Now;
                decimal Tuition = decimal.Parse(nudTuition.Value.ToString());
                string Note = txtNote.Text;
                decimal Payment = 0;
                decimal Debt = Tuition;
                string Message = "";

                if (!bllRegister.Insert(ref Message, StudentID, CourseID, RegisterDate, Tuition, Payment, Debt, Note))
                {
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bdRegister.DataSource = bllRegister.GetByStudent(StudentID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            //searchCourseToolStripComboBox.SelectedIndex = 0;
            //cmbFilter.SelectedIndex = 0;
            //cmbLevel.DataSource = bllLevel.GetAll();
            //cmbLevel.DisplayMember = "LevelName";
            //cmbLevel.ValueMember = "LevelID";

            //// For DgvCourse = BdCourse
            //dgvCourse.DataSource = bdCourse;

            dgvReceipt.DataSource = bdReceipt;
            dgvRegister.DataSource = bdRegister;

            nudPayment.TextChanged += new EventHandler(nudPayment_TextChanged);
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

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = cmbFilter.SelectedIndex;

            //// All
            //if (index == 0)
            //{
            //    cmbLevel.Enabled = false;
            //    dtpFromDate.Enabled = false;
            //    dtpToDate.Enabled = false;

            //    bdCourse.DataSource = bllCourse.GetAll();
            //}
            //// Time
            //else if (index == 1)
            //{
            //    cmbLevel.Enabled = false;
            //    dtpFromDate.Enabled = true;
            //    dtpToDate.Enabled = true;
            //}
            //// Level
            //else if (index == 2)
            //{
            //    cmbLevel.Enabled = true;
            //    dtpFromDate.Enabled = false;
            //    dtpToDate.Enabled = false;
            //}
            //else if (index == 3)
            //{
            //    cmbLevel.Enabled = true;
            //    dtpFromDate.Enabled = true;
            //    dtpToDate.Enabled = true;
            //}
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dgvCourse.CurrentCell.RowIndex;

            //string CourseID = dgvCourse.Rows[index].Cells["CourseID"].Value.ToString();
            //string CourseName = dgvCourse.Rows[index].Cells["CourseName"].Value.ToString();
            //txtCourseID.Text = CourseID + " - " + CourseName;
            //txtCourseID.Tag = CourseID;
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            (new FrmFindStudent()).ShowDialog();

            try
            {
                string StudentID = Program.StudentID;
                Program.StudentID = string.Empty;
                dtStudent = bllStudent.GetByStudentID(StudentID);
                string StudentName = dtStudent.Rows[0]["StudentName"].ToString();
                txtStudentID.Tag = StudentID;
                txtStudentID.Text = StudentID + " - " + StudentName;
            }
            catch { }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            string StudentID = "";
            try
            {
                 StudentID = txtStudentID.Tag.ToString();
                
            }
            catch
            {
                StudentID = txtStudentID.Text;
            }

            CourseIDRgister.DataSource = bllCourse.GetAll();
            CourseIDRgister.DisplayMember = "CourseName";
            CourseIDRgister.ValueMember = "CourseID";
            bdRegister.DataSource = bllRegister.GetByStudent(StudentID);
        }

        private void dgvRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvRegister.CurrentCell.RowIndex;
                // Get info
                string CourseID = dgvRegister.Rows[index].Cells["CourseIDRgister"].Value.ToString();
                string StudentID = dgvRegister.Rows[index].Cells["StudentID"].Value.ToString();


                dtReceipt = bllReceipt.GetByRegister(StudentID, CourseID);
                bdReceipt.DataSource = dtReceipt;


                // solve 
                decimal Tuition = decimal.Parse(dgvRegister.Rows[index].Cells["Tuition"].Value.ToString());
                decimal Debt = decimal.Parse(dgvRegister.Rows[index].Cells["DebtRegister"].Value.ToString());

                nudDebt.Value = Debt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvRegister.CurrentCell.RowIndex;

                string ReceiptID = txtReceiptID.Text;
                string StudentID = dgvRegister.Rows[index].Cells["StudentID"].Value.ToString();
                string CourseID = dgvRegister.Rows[index].Cells["CourseIDRgister"].Value.ToString();
                decimal Payment = nudPayment.Value;
                decimal Debt = nudDebt.Value;
                DateTime Date = DateTime.Now;

                string Message = "";

                if (!bllReceipt.Insert(ref Message, ReceiptID, StudentID, CourseID, Payment, Date))
                {
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bdReceipt.DataSource = bllReceipt.GetByRegister(StudentID, CourseID);

                    //Update Register

                    int indexRegister = dgvRegister.CurrentCell.RowIndex;
                    // Get info
                    DateTime RegisterDate = (DateTime)dgvRegister.Rows[index].Cells["RegisterDay"].Value;
                    string Note = dgvRegister.Rows[index].Cells["Note"].Value.ToString();

                    decimal Tuition = decimal.Parse(dgvRegister.Rows[index].Cells["Tuition"].Value.ToString());
                    decimal PaymentReg = decimal.Parse(dgvRegister.Rows[index].Cells["PaymentRegister"].Value.ToString());
                    decimal DebtReg = decimal.Parse(dgvRegister.Rows[index].Cells["DebtRegister"].Value.ToString());

                    PaymentReg += Payment;
                    //DebtReg = nudDebt.Value;
                    DebtReg -= Payment;


                    bllRegister.Update(ref Message, StudentID, CourseID, RegisterDate, Tuition, PaymentReg, DebtReg, Note);
                    bdRegister.DataSource = bllRegister.GetByStudent(StudentID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nudPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvRegister.CurrentCell.RowIndex;
                decimal DebtReg = decimal.Parse(dgvRegister.Rows[index].Cells["DebtRegister"].Value.ToString());
                nudDebt.Value = DebtReg - nudPayment.Value;
            }
            catch (Exception)
            {

            }
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

        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmNewCourse()).ShowDialog();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int index = dgvCourse.CurrentCell.RowIndex;
            //string CourseID = dgvCourse.Rows[index].Cells["CourseID"].Value.ToString();

            //string Message = "";

            //if (MessageBox.Show("Tất cả dữ liệu liên quan sẽ xóa khỏi hệ thống.\nBạn có muốn xóa khóa học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    bllReceipt.DeleteByCourse(ref Message, CourseID);
            //    bllTranscript.DeleteByCourse(ref Message, CourseID);
            //    bllRegister.DeleteByCourse(ref Message, CourseID);

            //    if (!bllCourse.Delete(ref Message, CourseID))
            //    {
            //        MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        reloadCourseToolStripMenuItem_Click(null, null);
            //    }
            //}
        }

        private void reloadCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdCourse.DataSource = bllCourse.GetAll();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int index = dgvCourse.CurrentCell.RowIndex;
            //    Program.CourseID = dgvCourse.Rows[index].Cells["CourseID"].Value.ToString();
            //    (new FrmEditCourse()).ShowDialog();
            //}
            //catch { }
        }
    }
}
