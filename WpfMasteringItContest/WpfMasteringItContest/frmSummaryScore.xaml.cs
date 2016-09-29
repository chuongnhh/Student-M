using BusinessLogicLayr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfMasteringItContest
{
    /// <summary>
    /// Interaction logic for frmSummaryScore.xaml
    /// </summary>
    public partial class frmSummaryScore : Window
    {
        private dbSummaryTeam dbsummary = new dbSummaryTeam();
        private DataTable dtsummary = new DataTable();

        public int getMaHeThi { get; set; }

        public frmSummaryScore()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            dtsummary = dbsummary.getSummaryTeamDesc(getMaHeThi);
            // if (dtsummary.Rows.Count <= 0) return;// khong co diem


            try
            {
                txbDoiSo1.Text = dtsummary.Rows[0]["tenDoiThi"].ToString();
                txbDoi1.Text = dtsummary.Rows[0]["tongDiem"].ToString();

            }
            catch { }

            try
            {
                txbDoiSo2.Text = dtsummary.Rows[1]["tenDoiThi"].ToString();
                txbDoi2.Text = dtsummary.Rows[1]["tongDiem"].ToString();

            }
            catch { }

            try
            {
                txbDoiSo3.Text = dtsummary.Rows[2]["tenDoiThi"].ToString();
                txbDoi3.Text = dtsummary.Rows[2]["tongDiem"].ToString();
            }
            catch { }

            try
            {
                txbDoiSo4.Text = dtsummary.Rows[3]["tenDoiThi"].ToString();
                txbDoi4.Text = dtsummary.Rows[3]["tongDiem"].ToString();
            }
            catch { }

            try
            {
                txbDoiSo5.Text = dtsummary.Rows[4]["tenDoiThi"].ToString();
                txbDoi5.Text = dtsummary.Rows[4]["tongDiem"].ToString();
            }
            catch { }
        }
    }
}
