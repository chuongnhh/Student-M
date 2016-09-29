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
    /// Interaction logic for frmSelectTeam.xaml
    /// </summary>
    public partial class frmSelectTeam : Window
    {
        private dbDoiThi dbdoithi = new dbDoiThi();
        private DataTable dtdoithi = new DataTable();

        private DataTable chuyen = new DataTable();
        private DataTable khongchuyen = new DataTable();

        public static bool chk1 { get; set; }
        public static bool chk2 { get; set; }
        public static bool chk3 { get; set; }
        public static bool chk4 { get; set; }
        public static bool chk5 { get; set; }
        public static bool chk6 { get; set; }
        public static bool chk7 { get; set; }
        public static bool chk8 { get; set; }
        public static bool chk9 { get; set; }
        public static bool chk10 { get; set; }
        public static int heThi { get; set; }


        public frmSelectTeam()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dtdoithi = dbdoithi.getDoiThi();
            chuyen = dbdoithi.getDoiThiTheoMaHeThi(1);
            khongchuyen = dbdoithi.getDoiThiTheoMaHeThi(2);
            try
            {

                //checkBox1.Content = dtdoithi.Rows[0]["tenDoiThi"].ToString();
                //checkBox2.Content = dtdoithi.Rows[1]["tenDoiThi"].ToString();
                //checkBox3.Content = dtdoithi.Rows[2]["tenDoiThi"].ToString();
                //checkBox4.Content = dtdoithi.Rows[3]["tenDoiThi"].ToString();
                //checkBox5.Content = dtdoithi.Rows[4]["tenDoiThi"].ToString();
                //checkBox6.Content = dtdoithi.Rows[5]["tenDoiThi"].ToString();
                //checkBox7.Content = dtdoithi.Rows[6]["tenDoiThi"].ToString();
                //checkBox8.Content = dtdoithi.Rows[7]["tenDoiThi"].ToString();
                //checkBox9.Content = dtdoithi.Rows[8]["tenDoiThi"].ToString();
                //checkBox10.Content = dtdoithi.Rows[9]["tenDoiThi"].ToString();

                checkBox1.Content = chuyen.Rows[0]["tenDoiThi"].ToString();
                checkBox2.Content = chuyen.Rows[1]["tenDoiThi"].ToString();
                checkBox3.Content = chuyen.Rows[2]["tenDoiThi"].ToString();
                checkBox4.Content = chuyen.Rows[3]["tenDoiThi"].ToString();
                checkBox5.Content = chuyen.Rows[4]["tenDoiThi"].ToString();
                checkBox6.Content = khongchuyen.Rows[0]["tenDoiThi"].ToString();
                checkBox7.Content = khongchuyen.Rows[1]["tenDoiThi"].ToString();
                checkBox8.Content = khongchuyen.Rows[2]["tenDoiThi"].ToString();
                checkBox9.Content = khongchuyen.Rows[3]["tenDoiThi"].ToString();
                checkBox10.Content = khongchuyen.Rows[4]["tenDoiThi"].ToString();
            }
            catch (Exception)
            {

            }

            checkBox1.IsChecked = chk1;
            checkBox2.IsChecked = chk2;
            checkBox3.IsChecked = chk3;
            checkBox4.IsChecked = chk4;
            checkBox5.IsChecked = chk5;
            checkBox6.IsChecked = chk6;
            checkBox7.IsChecked = chk7;
            checkBox8.IsChecked = chk8;
            checkBox9.IsChecked = chk9;
            checkBox10.IsChecked = chk10;
            if (heThi == 1)
            {
                StackPanel1.Visibility = Visibility.Visible;
                StackPanel2.Visibility = Visibility.Hidden;
            }
            if (heThi == 2)
            {
                StackPanel1.Visibility = Visibility.Hidden;
                StackPanel2.Visibility = Visibility.Visible;
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
                chk1 = true;
            else
                chk1 = false;

            if (checkBox2.IsChecked == true)
                chk2 = true;
            else chk2 = false;

            if (checkBox3.IsChecked == true)
                chk3 = true;
            else chk3 = false;
            if (checkBox4.IsChecked == true)
                chk4 = true;
            else chk4 = false;

            if (checkBox5.IsChecked == true)
                chk5 = true;
            else chk5 = false;
            //================
            if (checkBox6.IsChecked == true)
                chk6 = true;
            else chk6 = false;
            if (checkBox7.IsChecked == true)
                chk7 = true;
            else chk7 = false;
            if (checkBox8.IsChecked == true)
                chk8 = true;
            else chk8 = false;
            if (checkBox9.IsChecked == true)
                chk9 = true;
            else chk9 = false;
            if (checkBox10.IsChecked == true)
                chk10 = true;
            else chk10 = false;
            this.Close();
        }
    }
}
