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
    public partial class frmInsertScore : Form
    {
        private dbDiemSo dbdiemso = new dbDiemSo();
        private dbHeThi dbhethi = new dbHeThi();
        private dbTroChoi dbtrochoi = new dbTroChoi();
        private dbDoiThi dbdoithi = new dbDoiThi();

        public frmInsertScore()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertScore_Load(object sender, EventArgs e)
        {
            cmbHeThi.DataSource = dbhethi.getHeThi();
            cmbHeThi.DisplayMember = "tenHeThi";
            cmbHeThi.ValueMember = "maHeThi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());
                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());
                int maDoiThi = int.Parse(cmbDoiThi.SelectedValue.ToString());
                int diemSo = int.Parse(nrcDiemSo.Value.ToString());

                if (MessageBox.Show("Bạn có muốn thêm điểm này cho đội '" + maDoiThi + "' này không?", "Thêm Điểm Số", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!dbdiemso.insertDiemSo(ref err, maDoiThi, maTroChoi, maHeThi, diemSo))
                    {
                        MessageBox.Show(err);
                    }
                    else
                        MessageBox.Show("Thêm điểm này cho đội '" + maDoiThi + "' thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbHeThi_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTroChoi.DataSource = dbtrochoi.getTroChoiTheoHeThi(int.Parse(cmbHeThi.SelectedValue.ToString()));
                cmbTroChoi.DisplayMember = "tenTroChoi";
                cmbTroChoi.ValueMember = "maTroChoi";

                cmbDoiThi.DataSource = dbdoithi.getDoiThiTheoMaHeThi(int.Parse(cmbHeThi.SelectedValue.ToString()));
                cmbDoiThi.DisplayMember = "tenDoiThi";
                cmbDoiThi.ValueMember = "maDoiThi";
            }
            catch (Exception)
            {

            }
        }
    }
}
