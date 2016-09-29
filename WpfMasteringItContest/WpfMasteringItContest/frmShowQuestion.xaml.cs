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
using System.Windows.Threading;

namespace WpfMasteringItContest
{
    /// <summary>
    /// Interaction logic for frmShowQuestion.xaml
    /// </summary>
    public partial class frmShowQuestion : Window
    {
        private dbCauHoi dbcauhoi = new dbCauHoi();
        private DataTable dtcauhoi = new DataTable();

        private dbTroChoi dbtrochoi = new dbTroChoi();
        private DataTable dttrochoi = new DataTable();

        public frmShowQuestion()
        {
            InitializeComponent();
        }

        public int getMaCauHoi { get; set; }
        public int getMaTroChoi { get; set; }
        public int getTimeCount { get; set; }
        private int timeMax;
        public bool seen { get; set; }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            try
            {
                dtcauhoi = dbcauhoi.getCauHoiTheoMaCauHoi(getMaCauHoi);

                txbNoiDungCauHoi.Text = dtcauhoi.Rows[0]["noiDung"].ToString();
                if (txbNoiDungCauHoi.Text.Count() >= 1000)
                    txbNoiDungCauHoi.FontSize = 28;
                else txbNoiDungCauHoi.FontSize = 48;

                txbLuaChonA.Text = dtcauhoi.Rows[0]["luaChonA"].ToString();
                txbLuaChonB.Text = dtcauhoi.Rows[0]["luaChonB"].ToString();
                txbLuaChonC.Text = dtcauhoi.Rows[0]["luaChonC"].ToString();
                txbLuaChonD.Text = dtcauhoi.Rows[0]["luaChonD"].ToString();

                if (seen == true)
                {
                    SeenAnswer();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (txbLuaChonA.Text == "") txbA.Text = "";
                else txbA.Text = "A. ";
                if (txbLuaChonB.Text == "") txbB.Text = "";
                else txbB.Text = "B. ";
                if (txbLuaChonC.Text == "") txbC.Text = "";
                else txbC.Text = "C. ";
                if (txbLuaChonD.Text == "") txbD.Text = "";
                else txbD.Text = "D. ";

                if (dtcauhoi.Rows[0]["dapAnDung"].ToString().Count() > 1)
                    txbA.Text = "";
            }


            timeCount = getTimeCount;
            prgTime.Value = getTimeCount;
            txbTime.Text = "</>";


            int maTroCHoi = getMaTroChoi;
            try
            {
                DataTable dtTroChoi = dbtrochoi.getTroChoiTheoMaTroChoi(maTroCHoi);
                timeMax = int.Parse(dtTroChoi.Rows[0]["thoiGian"].ToString());
            }
            catch (Exception)
            {

            }

            prgTime.Maximum = timeMax;
            DispatcherTimer();
        }

        // Time
        DispatcherTimer dispatcherTimer;
        int timeCount = 0;

        private void DispatcherTimer()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            if (timeCount >= timeMax)
                dispatcherTimer.Stop();
            else
            {
                // Updating the Label which displays the current second
                timeCount = ++timeCount;
                txbTime.Text = (TimeSpan.FromSeconds(timeMax - timeCount)).ToString("mm':'ss");
                prgTime.Value = timeCount;
                int percent = Convert.ToInt32(0.7 * timeMax);
                if (timeCount <= percent)
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                else
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFEA2222"));
            }
            CommandManager.InvalidateRequerySuggested();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (controlKeyPress == true)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.Close();

                else if (timeCount >= timeMax)
                {
                    try
                    {
                        // xem đáp án
                        SeenAnswer();
                        seen = true;
                    }
                    catch (Exception)
                    {
                        // khong có cau hoi thì đâu có dáp án
                    }
                }
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SeenAnswer()
        {
            string answer = dtcauhoi.Rows[0]["dapAnDung"].ToString();
            if (answer == "A")
            {
                txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
            }
            else if (answer == "B")
            {
                txbLuaChonB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                txbB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
            }
            else if (answer == "C")
            {
                txbLuaChonC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                txbC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
            }
            else if (answer == "D")
            {
                txbLuaChonD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                txbD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
            }
            else
            {
                txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FFFF0000");
                txbA.Text = "";
                txbLuaChonA.Text = dtcauhoi.Rows[0]["dapAnDung"].ToString();
            }
        }

        private bool controlKeyPress;
        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
                controlKeyPress = true;
        }

        private void window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
                controlKeyPress = false;
        }
    }
}
