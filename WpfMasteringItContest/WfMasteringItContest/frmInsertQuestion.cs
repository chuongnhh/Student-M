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
    public partial class frmInsertQuestion : Form
    {
        private dbCauHoi dbcauhoi = new dbCauHoi();
        private dbTroChoi dbtrochoi = new dbTroChoi();
        private dbHeThi dbhetthi = new dbHeThi();

        public frmInsertQuestion()
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
                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());
                string tenCauHoi = txtTenCauHoi.Text.Trim();
                string noiDung = txtNoiDung.Text.Trim();
                string luaChonA = txtLuaChonA.Text.Trim();
                string luaChonB = txtLuaChonB.Text.Trim();
                string luaChonC = txtLuaChonC.Text.Trim();
                string luaChonD = txtLuaChonD.Text.Trim();
                string dapAnDung = cmbDapAnDung.SelectedItem.ToString();

                bool tuLuan = ckbTuLuan.Checked;
                if (tuLuan == true)
                {
                    dapAnDung = txtDapAn.Text.Trim();
                }

                if (MessageBox.Show("Bạn có muốn thêm câu hỏi '" + tenCauHoi + "' này không?", "Thêm Câu Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!dbcauhoi.insertCauHoi(ref err, maTroChoi, tenCauHoi, noiDung, luaChonA, luaChonB, luaChonC, luaChonD, dapAnDung))
                    {
                        MessageBox.Show(err);
                    }
                    else
                        MessageBox.Show("Thêm câu hỏi '" + tenCauHoi + "' thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInsertQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                cmbDapAnDung.SelectedItem = "A";
                cmbHeThi.DataSource = dbhetthi.getHeThi();
                cmbHeThi.ValueMember = "tenHeThi";
                cmbHeThi.ValueMember = "maHeThi";
            }
            catch (Exception)
            {

            }
        }

        private void cmbHeThi_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());
                cmbTroChoi.DataSource = dbtrochoi.getTroChoiTheoHeThi(maHeThi);
                cmbTroChoi.ValueMember = "tenTroChoi";
                cmbTroChoi.ValueMember = "maTroChoi";
            }
            catch (Exception)
            {

            }
        }

        private void cmbTroChoi_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDapAnDung.SelectedItem = "A";
        }

        private void ckbTuLuan_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTuLuan.Checked == true)
            {
                //txtNoiDung.Enabled = false;
                txtLuaChonA.Enabled = false;
                txtLuaChonB.Enabled = false;
                txtLuaChonC.Enabled = false;
                txtLuaChonD.Enabled = false;
                cmbDapAnDung.Visible = false;
                txtDapAn.Visible = true;
            }
            else
            {
                //txtNoiDung.Enabled = true;
                txtLuaChonA.Enabled = true;
                txtLuaChonB.Enabled = true;
                txtLuaChonC.Enabled = true;
                txtLuaChonD.Enabled = true;
                cmbDapAnDung.Visible = true;
                txtDapAn.Visible = false;
            }
        }
    }
}
