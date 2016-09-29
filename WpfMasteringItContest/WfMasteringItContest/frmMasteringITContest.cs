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
    public partial class frmMasteringITContest : Form
    {
        private dbDoiThi dbdoithi = new dbDoiThi();
        private dbCauHoi dbcauhoi = new dbCauHoi();
        private dbDiemSo dbdiemso = new dbDiemSo();
        private dbHeThi dbhethi = new dbHeThi();
        private dbTroChoi dbtrochoi = new dbTroChoi();
        private DataTable dtSource = new DataTable();

        int indexCurrentCell = -1;

        public frmMasteringITContest()
        {
            InitializeComponent();
        }

        private void cauHoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmInsertQuestion()).ShowDialog();
            dataGridView.DataSource = dbcauhoi.getCauHoi();
            cmbSearch.SelectedItem = "Câu Hỏi";
        }

        private void diemSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmInsertScore()).ShowDialog();
            dataGridView.DataSource = dbdiemso.getDiemSo();
            cmbSearch.SelectedItem = "Điểm Số";
        }

        private void doiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmInsertTeam()).ShowDialog();
            dataGridView.DataSource = dbdoithi.getDoiThi();
            cmbSearch.SelectedItem = "Đội Thi";
        }

        private void khoiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmInsertExamSystem()).ShowDialog();
            dataGridView.DataSource = dbhethi.getHeThi();
            cmbSearch.SelectedItem = "Khối Thi";
        }

        private void troChoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmInsertGame()).ShowDialog();
            dataGridView.DataSource = dbtrochoi.getTroChoi();
            cmbSearch.SelectedItem = "Trò Chơi";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMasteringITContest_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedItem = "Đội Thi";
        }


        private void UpdateData()
        {
            try
            {
                if (cmbSearch.SelectedItem.ToString() == "Đội Thi")
                    dtSource = dbdoithi.getDoiThi();
                else if (cmbSearch.SelectedItem.ToString() == "Câu Hỏi")
                    dtSource = dbcauhoi.getCauHoi();
                else if (cmbSearch.SelectedItem.ToString() == "Điểm Số")
                    dtSource = dbdiemso.getDiemSo();
                else if (cmbSearch.SelectedItem.ToString() == "Khối Thi")
                    dtSource = dbhethi.getHeThi();
                else if (cmbSearch.SelectedItem.ToString() == "Trò Chơi")
                    dtSource = dbtrochoi.getTroChoi();
                dataGridView.DataSource = dtSource;
            }
            catch (Exception)
            {

            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexCurrentCell = dataGridView.CurrentCell.RowIndex;
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem.ToString() == "Đội Thi")
            {
                try
                {
                    int maDoiThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maDoiThi"].Value.ToString());
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());
                    string err = "";

                    if (MessageBox.Show("Bạn có muốn xóa đội thi '" + maDoiThi + "' này không?", "Xóa Đội Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbdoithi.deleteDoiThi(ref err, maDoiThi, maHeThi))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Xóa đội thi '" + maDoiThi + "' thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbdoithi.getDoiThi();
            }
            else
                       if (cmbSearch.SelectedItem.ToString() == "Câu Hỏi")
            {
                try
                {
                    int maCauHoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maCauHoi"].Value.ToString());

                    string err = "";

                    if (MessageBox.Show("Bạn có muốn xóa câu hỏi '" + maCauHoi + "' này không?", "Xóa Câu hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbcauhoi.deleteCauHoi(ref err, maCauHoi))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Xóa câu hỏi '" + maCauHoi + "' thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbcauhoi.getCauHoi();
            }
            else
                       if (cmbSearch.SelectedItem.ToString() == "Điểm Số")
            {
                try
                {
                    int maTroChoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maTroChoi"].Value.ToString());
                    int maDoiThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maDoiThi"].Value.ToString());
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());

                    string err = "";

                    if (MessageBox.Show("Bạn có muốn xóa điểm số cho đội thi '" + maDoiThi + "' này không?", "Xóa Điểm Số", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbdiemso.deleteDiemSo(ref err, maDoiThi, maTroChoi, maHeThi))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Xóa điểm số cho đội thi '" + maDoiThi + "' thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView.DataSource = dbdiemso.getDiemSo();
            }
            else
                       if (cmbSearch.SelectedItem.ToString() == "Hệ Thi")
            {
                try
                {
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());

                    string err = "";

                    if (MessageBox.Show("Bạn có muốn xóa hệ thi '" + maHeThi + "' này không?", "Xóa Hệ Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbhethi.deleteHeThi(ref err, maHeThi))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Xóa hệ thi '" + maHeThi + "' thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView.DataSource = dbhethi.getHeThi();
            }
            else
                       if (cmbSearch.SelectedItem.ToString() == "Trò Chơi")
            {
                try
                {
                    int maTroChoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maTroChoi"].Value.ToString());

                    string err = "";

                    if (MessageBox.Show("Bạn có muốn xóa trò chơi '" + maTroChoi + "' này không?", "Xóa Trò Chơi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbtrochoi.deleteTroChoi(ref err, maTroChoi))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Xóa trò chơi '" + maTroChoi + "' thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView.DataSource = dbtrochoi.getTroChoi();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem.ToString() == "Đội Thi")
            {
                dataGridView.DataSource = dbdoithi.getDoiThi();
            }
            else
          if (cmbSearch.SelectedItem.ToString() == "Câu Hỏi")
            {
                dataGridView.DataSource = dbcauhoi.getCauHoi();
            }
            else
          if (cmbSearch.SelectedItem.ToString() == "Điểm Số")
            {
                dataGridView.DataSource = dbdiemso.getDiemSo();
            }
            else
          if (cmbSearch.SelectedItem.ToString() == "Hệ Thi")
            {
                dataGridView.DataSource = dbhethi.getHeThi();
            }
            else
          if (cmbSearch.SelectedItem.ToString() == "Trò Chơi")
            {
                dataGridView.DataSource = dbtrochoi.getTroChoi();
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem.ToString() == "Đội Thi")
            {
                try
                {
                    string err = "";
                    int maDoiThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maDoiThi"].Value.ToString());
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());
                    string tenDoiThi = dataGridView.Rows[indexCurrentCell].Cells["tenDoiThi"].Value.ToString();
                    string thanhVien1 = dataGridView.Rows[indexCurrentCell].Cells["thanhVien1"].Value.ToString();
                    string thanhVien2 = dataGridView.Rows[indexCurrentCell].Cells["thanhVien2"].Value.ToString();
                    string thanhVien3 = dataGridView.Rows[indexCurrentCell].Cells["thanhVien3"].Value.ToString();
                    string thanhVien4 = dataGridView.Rows[indexCurrentCell].Cells["thanhVien4"].Value.ToString();
                    string thanhVien5 = dataGridView.Rows[indexCurrentCell].Cells["thanhVien5"].Value.ToString();

                    if (MessageBox.Show("Bạn có muốn cập nhật đội thi '" + tenDoiThi + "' này không?", "Cập Nhật Đội Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbdoithi.updateDoiThi(ref err, maDoiThi, maHeThi, tenDoiThi, thanhVien1, thanhVien2, thanhVien3, thanhVien4, thanhVien5))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Cập nhật đội thi '" + tenDoiThi + "' thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbdoithi.getDoiThi();
            }
            else
        if (cmbSearch.SelectedItem.ToString() == "Câu Hỏi")
            {
                try
                {
                    string err = "";
                    int maTroChoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maTroChoi"].Value.ToString());
                    int maCauHoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maCauHoi"].Value.ToString());
                    string tenCauHoi = dataGridView.Rows[indexCurrentCell].Cells["tenCauHoi"].Value.ToString();
                    string noiDung = dataGridView.Rows[indexCurrentCell].Cells["noiDung"].Value.ToString();
                    string luaChonA = dataGridView.Rows[indexCurrentCell].Cells["luaChonA"].Value.ToString();
                    string luaChonB = dataGridView.Rows[indexCurrentCell].Cells["luaChonB"].Value.ToString();
                    string luaChonC = dataGridView.Rows[indexCurrentCell].Cells["luaChonC"].Value.ToString();
                    string luaChonD = dataGridView.Rows[indexCurrentCell].Cells["luaChonD"].Value.ToString();
                    string dapAnDung = dataGridView.Rows[indexCurrentCell].Cells["dapAnDung"].Value.ToString();

                    if (MessageBox.Show("Bạn có muốn cập nhật câu hỏi '" + tenCauHoi + "' này không?", "Cập Nhật Câu Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbcauhoi.updateCauHoi(ref err, maCauHoi, maTroChoi, tenCauHoi, noiDung, luaChonA, luaChonB, luaChonC, luaChonD, dapAnDung))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Cập nhật câu hỏi '" + tenCauHoi + "' thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbcauhoi.getCauHoi();
            }
            else
        if (cmbSearch.SelectedItem.ToString() == "Điểm Số")
            {
                try
                {
                    string err = "";
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());
                    int maTroChoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maTroChoi"].Value.ToString());
                    int maDoiThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maDoiThi"].Value.ToString());
                    int diemSo = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["diemSo"].Value.ToString());

                    if (MessageBox.Show("Bạn có muốn cập nhật điểm này cho đội '" + maDoiThi + "' này không?", "Cập Nhật Điểm Số", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbdiemso.updateDiemSo(ref err, maDoiThi, maTroChoi, maHeThi, diemSo))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Cập nhật điểm này cho đội '" + maDoiThi + "' thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbdiemso.getDiemSo();
            }
            else
        if (cmbSearch.SelectedItem.ToString() == "Hệ Thi")
            {
                try
                {
                    string err = "";
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());
                    string tenHeThi = dataGridView.Rows[indexCurrentCell].Cells["tenHeThi"].Value.ToString();

                    if (MessageBox.Show("Bạn có muốn cập nhật hệ thi '" + tenHeThi + "' này không?", "Cập Nhật Hệ Thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbhethi.updateHeThi(ref err, maHeThi, tenHeThi))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Cập nhật hệ thi '" + tenHeThi + "' thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbhethi.getHeThi();
            }
            else
        if (cmbSearch.SelectedItem.ToString() == "Trò Chơi")
            {
                try
                {
                    string err = "";
                    int maTroChoi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maTroChoi"].Value.ToString());
                    int maHeThi = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["maHeThi"].Value.ToString());
                    string tenTroChoi = dataGridView.Rows[indexCurrentCell].Cells["tenTroChoi"].Value.ToString();
                    int thoiGian = int.Parse(dataGridView.Rows[indexCurrentCell].Cells["thoiGian"].Value.ToString());

                    if (MessageBox.Show("Bạn có muốn cập nhật trò chơi '" + tenTroChoi + "' này không?", "Cập Nhật Trò Chơi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!dbtrochoi.updateTroChoi(ref err, maTroChoi, maHeThi, tenTroChoi, thoiGian))
                        {
                            MessageBox.Show(err);
                        }
                        else
                            MessageBox.Show("Cập nhật trò chơi '" + tenTroChoi + "' thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView.DataSource = dbtrochoi.getTroChoi();
            }
        }

        private void luatThiStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmInsertCompetitionRules()).ShowDialog();
        }
    }
}
