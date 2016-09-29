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
    public partial class frmInsertCompetitionRules : Form
    {
        private dbCauHoi dbcauhoi = new dbCauHoi();
        private dbTroChoi dbtrochoi = new dbTroChoi();
        private dbHeThi dbhetthi = new dbHeThi();

        public frmInsertCompetitionRules()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertCompetitionRules_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());
                DataTable dtluatthi = dbtrochoi.getTroChoiTheoMaTroChoi(maTroChoi);
                string tenTroChoi = dtluatthi.Rows[0]["tenTroChoi"].ToString();
                string tenCauHoi = "Luật Thi Vòng " + tenTroChoi;
                string noiDung = txtLuatThi.Text.Trim();
                string luaChonA = "";
                string luaChonB = "";
                string luaChonC = "";
                string luaChonD = "";
                string dapAnDung = "";

                if (MessageBox.Show("Bạn có muốn thêm luật thi '" + tenTroChoi + "' này không?", "Thêm Luật Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!dbcauhoi.insertCauHoi(ref err, maTroChoi, tenCauHoi, noiDung, luaChonA, luaChonB, luaChonC, luaChonD, dapAnDung))
                    {
                        MessageBox.Show(err);
                    }
                    else
                        MessageBox.Show("Thêm luật thi '" + tenTroChoi + "' thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
