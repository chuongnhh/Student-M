using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Chart
{
    public partial class frmCurveGraph : Form
    {
        public frmCurveGraph()
        {
            InitializeComponent();
        }

        private void frmCurveGraph_Load(object sender, EventArgs e)
        {

        }

        public void setText(string text)
        {
            richTextBox1.AppendText(text);
            richTextBox1.ScrollToCaret();
        }
    }
}
