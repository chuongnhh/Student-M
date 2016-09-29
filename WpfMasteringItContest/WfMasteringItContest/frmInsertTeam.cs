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
    public partial class frmInsertTeam : Form
    {
        private dbDoiThi dbdoithi = new dbDoiThi();
        private dbHeThi dbhethi = new dbHeThi();

        public frmInsertTeam()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                string err = "";
                int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());
                string tenDoiThi = txtTenDoi.Text.Trim();
                string thanhVien1 = txtThanhVien1.Text.Trim();
                string thanhVien2 = txtThanhVien2.Text.Trim();
                string thanhVien3 = txtThanhVien3.Text.Trim();
                string thanhVien4 = txtThanhVien4.Text.Trim();
                string thanhVien5 = txtThanhVien5.Text.Trim();

                if (MessageBox.Show("Bạn có muốn thêm đội thi '" + tenDoiThi + "' này không?", "Thêm Đội Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!dbdoithi.insertDoiThi(ref err, maHeThi, tenDoiThi, thanhVien1, thanhVien2, thanhVien3, thanhVien4, thanhVien5))
                    {
                        MessageBox.Show(err);
                    }
                    else
                        MessageBox.Show("Thêm đội thi '" + tenDoiThi + "' thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInsertTeam_Load(object sender, EventArgs e)
        {
            try
            {
                cmbHeThi.DataSource = dbhethi.getHeThi();
                cmbHeThi.DisplayMember = "tenHeThi";
                cmbHeThi.ValueMember = "maHeThi";
            }
            catch (Exception)
            {

            }
        }
    }
}
