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
    public partial class FrmNewLevel : Form
    {
        private BLLLevel bllLevel;
        public FrmNewLevel()
        {
            InitializeComponent();
            bllLevel = new BLLLevel();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private bool Save()
        {
            string LevelID = txtLevelID.Text;
            string LevelName = txtLevelName.Text;

            string Message = "";
            if(!bllLevel.Insert(ref Message,LevelID,LevelName))
            {
                MessageBox.Show(Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                MessageBox.Show("Thêm cấp độ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            if (Save() == true) this.Close();
        }
    }
}
