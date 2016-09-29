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
    public partial class FrmFindStudent : Form
    {
        private BLLStudent bllStudent;
        private BindingSource bdStudent;
        private BLLReceipt bllReceipt;
        private BLLRegister bllRegister;
        private BLLTranscript bllTranscript;
        public FrmFindStudent()
        {
            InitializeComponent();
            bllStudent = new BLLStudent();
            bdStudent = new BindingSource();
            bllTranscript = new BLLTranscript();
            bllReceipt = new BLLReceipt();
            bllRegister = new BLLRegister();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFindStudent_Load(object sender, EventArgs e)
        {
            searchToolStripComboBox.SelectedIndex = 0;
            bdStudent.DataSource = bllStudent.GetAll();
            dgvStudent.DataSource = bdStudent;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvStudent.CurrentCell.RowIndex;

                string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();
                Program.StudentID = StudentID;
                this.Close();
            }
            catch { }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvStudent.CurrentCell.RowIndex;

                string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();
                Program.StudentID = StudentID;
                this.Close();
            }
            catch { }
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvStudent.CurrentCell.RowIndex;

                string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();
                Program.StudentID = StudentID;
                this.Close();
            }
            catch { }
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = searchToolStripComboBox.SelectedIndex;
            string SearchText = searchToolStripTextBox.Text;
            // StudentID
            if (index == 0)
            {
                bdStudent.DataSource = bllStudent.SearchStudentID(SearchText);
            }
            // StudentName
            else if (index == 1)
            {
                bdStudent.DataSource = bllStudent.SearchStudentName(SearchText);
            }
            // PhoneNumber
            else if (index == 2)
            {
                bdStudent.DataSource = bllStudent.SearchStudentPhoneNumber(SearchText);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = new DialogResult();
            Result = MessageBox.Show("Tất cả dữ liệu liên quan sẽ bị hủy khi xóa học viên.\nBạn muốn xóa học viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                // Get StudentID
                int index = dgvStudent.CurrentCell.RowIndex;
                string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();

                string Message = "";

                // delete all receipt
                bllReceipt.DeleteByStudent(ref Message, StudentID);

                //delete all transcript
                bllTranscript.DeleteByStudent(ref Message, StudentID);

                // delete all Register
                bllRegister.DeleteByStudent(ref Message, StudentID);


                if (!bllStudent.Delete(ref Message, StudentID))
                {
                    MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    reloadToolStripMenuItem_Click(null, null);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdStudent.DataSource = bllStudent.GetAll();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvStudent.CurrentCell.RowIndex;
            string StudentID = dgvStudent.Rows[index].Cells["StudentID"].Value.ToString();
            Program.StudentID = StudentID;

            (new FrmEditStudent()).ShowDialog();
            reloadToolStripMenuItem_Click(null, null);
        }
    }
}

