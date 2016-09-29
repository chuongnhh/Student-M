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
    public partial class frmInsertGame : Form
    {
        private dbTroChoi dbtrochoi = new dbTroChoi();
        private dbHeThi dbhethi = new dbHeThi();

        public frmInsertGame()
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
                string tenTroChoi = txtTenTroChoi.Text.Trim();
                int thoiGian = int.Parse(nrcThoiGian.Value.ToString());

                if (MessageBox.Show("Bạn có muốn thêm trò chơi '" + tenTroChoi + "' này không?", "Thêm Trò Chơi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!dbtrochoi.insertTroChoi(ref err, maHeThi, tenTroChoi, thoiGian))
                    {
                        MessageBox.Show(err);
                    }
                    else
                        MessageBox.Show("Thêm trò chơi '" + tenTroChoi + "' thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInsertGame_Load(object sender, EventArgs e)
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
