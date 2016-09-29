using BusinessLogicLayr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfMasteringItContest
{
    public partial class frmInsertExamSystem : Form
    {
        private dbHeThi dbhethi = new dbHeThi();
        private DataTable dthethi = new DataTable();

        public frmInsertExamSystem()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertExamSystem_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                string tenHeThi = txtTenKhoiThi.Text.Trim();
                if (MessageBox.Show("Bạn có muốn thêm hệ thi '" + tenHeThi + "' này không?", "Thêm Hệ Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!dbhethi.insertHeThi(ref err, tenHeThi))
                    {
                        MessageBox.Show(err);
                    }
                    else
                        MessageBox.Show("Thêm hệ thi '" + tenHeThi + "' thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
