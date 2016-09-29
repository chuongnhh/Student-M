using BusinessLogicLayr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfMasteringItContest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Khai Bao
        private dbHeThi dbhethi = new dbHeThi();
        private DataTable dthethi = new DataTable();
        private dbDoiThi dbdoithi = new dbDoiThi();
        private DataTable dtdoithi = new DataTable();
        private dbTroChoi dbtrochoi = new dbTroChoi();
        private DataTable dttrochoi = new DataTable();
        private dbDiemSo dbdiemso = new dbDiemSo();
        private dbCauHoi dbcauhoi = new dbCauHoi();
        private DataTable dtcauhoi = new DataTable();
        private SoundPlayer sound = new SoundPlayer();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            }
            else this.WindowState = WindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            try
            {
                dthethi = dbhethi.getHeThi();
                cmbHeThi.ItemsSource = dthethi.DefaultView;
                cmbHeThi.DisplayMemberPath = "tenHeThi";
                cmbHeThi.SelectedValuePath = "maHeThi";
                cmbHeThi.SelectedIndex = 0;
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        #region cmb_SelectionChanged
        private void cmbHeThi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());
                dtdoithi = dbdoithi.getDoiThiTheoMaHeThi(maHeThi);
                frmSelectTeam.heThi = maHeThi;

                // Tro CHoi
                dttrochoi = dbtrochoi.getTroChoiTheoHeThi(maHeThi);
                if (dttrochoi.Rows.Count > 0)
                {
                    cmbTroChoi.ItemsSource = dttrochoi.DefaultView;
                    cmbTroChoi.DisplayMemberPath = "tenTroChoi";
                    cmbTroChoi.SelectedValuePath = "maTroChoi";
                    cmbTroChoi.SelectedIndex = 0;
                }

                // cap nhap ten doi len form
                try
                {
                    lblDoiSo1.Content = dtdoithi.Rows[0]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo1.IsEnabled = true;
                    //btnMinusScoreDoiSo1.IsEnabled = true;
                    //txtScoreDoiSo1.IsEnabled = true;

                    lblDoiSo1.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo1.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo1.Visibility = Visibility.Visible;
                    txtScoreDoiSo1.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo1.Content = "";
                    //btnPlusScoreDoiSo1.IsEnabled = false;
                    //btnMinusScoreDoiSo1.IsEnabled = false;
                    //txtScoreDoiSo1.IsEnabled = false;

                    lblDoiSo1.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo1.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo1.Visibility = Visibility.Hidden;
                    txtScoreDoiSo1.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo2.Content = dtdoithi.Rows[1]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo2.IsEnabled = true;
                    //btnMinusScoreDoiSo2.IsEnabled = true;
                    //txtScoreDoiSo2.IsEnabled = true;


                    lblDoiSo2.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo2.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo2.Visibility = Visibility.Visible;
                    txtScoreDoiSo2.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo2.Content = "";
                    //btnPlusScoreDoiSo2.IsEnabled = false;
                    //btnMinusScoreDoiSo2.IsEnabled = false;
                    //txtScoreDoiSo2.IsEnabled = false;

                    lblDoiSo2.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo2.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo2.Visibility = Visibility.Hidden;
                    txtScoreDoiSo2.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo3.Content = dtdoithi.Rows[2]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo3.IsEnabled = true;
                    //btnMinusScoreDoiSo3.IsEnabled = true;
                    //txtScoreDoiSo3.IsEnabled = true;

                    lblDoiSo3.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo3.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo3.Visibility = Visibility.Visible;
                    txtScoreDoiSo3.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo3.Content = "";
                    //btnPlusScoreDoiSo3.IsEnabled = false;
                    //btnMinusScoreDoiSo3.IsEnabled = false;
                    //txtScoreDoiSo3.IsEnabled = false;

                    lblDoiSo3.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo3.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo3.Visibility = Visibility.Hidden;
                    txtScoreDoiSo3.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo4.Content = dtdoithi.Rows[3]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo4.IsEnabled = true;
                    //btnMinusScoreDoiSo4.IsEnabled = true;
                    //txtScoreDoiSo4.IsEnabled = true;

                    lblDoiSo4.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo4.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo4.Visibility = Visibility.Visible;
                    txtScoreDoiSo4.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo4.Content = "";
                    //btnPlusScoreDoiSo4.IsEnabled = false;
                    //btnMinusScoreDoiSo4.IsEnabled = false;
                    //txtScoreDoiSo4.IsEnabled = false;

                    lblDoiSo4.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo4.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo4.Visibility = Visibility.Hidden;
                    txtScoreDoiSo4.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo5.Content = dtdoithi.Rows[4]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo5.IsEnabled = true;
                    //btnMinusScoreDoiSo5.IsEnabled = true;
                    //txtScoreDoiSo5.IsEnabled = true;

                    lblDoiSo5.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo5.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo5.Visibility = Visibility.Visible;
                    txtScoreDoiSo5.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo5.Content = "";
                    //btnPlusScoreDoiSo5.IsEnabled = false;
                    //btnMinusScoreDoiSo5.IsEnabled = false;
                    //txtScoreDoiSo5.IsEnabled = false;

                    lblDoiSo5.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo5.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo5.Visibility = Visibility.Hidden;
                    txtScoreDoiSo5.Visibility = Visibility.Hidden;
                }

            }
            catch (Exception)
            {
                // neu khong co du lieu
            }
        }

        private void cmbTroChoi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {

                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());
                ResetQuestionContent(maTroChoi);


                // laays thoi gian
                try
                {
                    DataTable dtTroChoi = dbtrochoi.getTroChoiTheoMaTroChoi(maTroChoi);
                    timeCount = int.Parse(dtTroChoi.Rows[0]["thoiGian"].ToString());
                    timeMax = timeCount;
                }
                catch (Exception)
                {
                    timeCount = 0;
                    timeMax = 0;
                    // khong có tro choi
                }

                int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());


                //Loai2DoiChoi();


                // cap nhat diem cho cac doi len form
                try
                {
                    int maDoi1 = int.Parse(dtdoithi.Rows[0]["maDoiThi"].ToString());
                    DataTable dtDoi1 = dbdiemso.getDiemSoTheoDoiThiVaTroChoi(maDoi1, maHeThi, maTroChoi);
                    txtScoreDoiSo1.Text = dtDoi1.Rows[0]["diemSo"].ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo1.Text = "0";
                }

                try
                {
                    int maDoi2 = int.Parse(dtdoithi.Rows[1]["maDoiThi"].ToString());
                    DataTable dtDoi2 = dbdiemso.getDiemSoTheoDoiThiVaTroChoi(maDoi2, maHeThi, maTroChoi);
                    txtScoreDoiSo2.Text = dtDoi2.Rows[0]["diemSo"].ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo2.Text = "0";
                }

                try
                {
                    int maDoi3 = int.Parse(dtdoithi.Rows[2]["maDoiThi"].ToString());
                    DataTable dtDoi3 = dbdiemso.getDiemSoTheoDoiThiVaTroChoi(maDoi3, maHeThi, maTroChoi);
                    txtScoreDoiSo3.Text = dtDoi3.Rows[0]["diemSo"].ToString();
                }
                catch (Exception)
                {
                    txtScoreDoiSo3.Text = "0";
                }

                try
                {
                    int maDoi4 = int.Parse(dtdoithi.Rows[3]["maDoiThi"].ToString());
                    DataTable dtDoi4 = dbdiemso.getDiemSoTheoDoiThiVaTroChoi(maDoi4, maHeThi, maTroChoi);
                    txtScoreDoiSo4.Text = dtDoi4.Rows[0]["diemSo"].ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo4.Text = "0";
                }

                try
                {
                    int maDoi5 = int.Parse(dtdoithi.Rows[4]["maDoiThi"].ToString());
                    DataTable dtDoi5 = dbdiemso.getDiemSoTheoDoiThiVaTroChoi(maDoi5, maHeThi, maTroChoi);
                    txtScoreDoiSo5.Text = dtDoi5.Rows[0]["diemSo"].ToString();
                }
                catch (Exception)
                {

                    txtScoreDoiSo5.Text = "0";
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
        }
        #endregion

        #region PlusScore MinusScore
        private string PlusScore(TextBox value, int increase)
        {
            int valueCurrent;
            if (int.TryParse(value.Text.ToString().Trim(), out valueCurrent) == false)
                return value.Text.ToString().Trim(); ;// không chuyển được thành số
            valueCurrent += increase;

            return valueCurrent.ToString();
        }

        private string MinusScore(TextBox value, int decrease)
        {
            int valueCurrent;
            if (int.TryParse(value.Text.ToString().Trim(), out valueCurrent) == false)
                return value.Text.ToString().Trim(); ;// không chuyển được thành số
            valueCurrent -= decrease;

            return valueCurrent.ToString();
        }

        private void UpdateScore(int maDoiThi, float diemSo)
        {
            try
            {
                string err = "";
                int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());
                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());

                DataTable dtdiemso = new DataTable();
                dtdiemso = dbdiemso.getDiemSoTheoDoiThiVaTroChoi(maDoiThi, maHeThi, maTroChoi);

                // kiểm tra xem da cos diem chua
                if (dtdiemso.Rows.Count > 0)// cap nhat
                    dbdiemso.updateDiemSo(ref err, maDoiThi, maTroChoi, maHeThi, diemSo);
                else// insert 
                    dbdiemso.insertDiemSo(ref err, maDoiThi, maTroChoi, maHeThi, diemSo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnPlusScoreDoiSo_Click

        private void btnPlusScoreDoiSo1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo1.Text = PlusScore(txtScoreDoiSo1, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[0]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo1.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinusScoreDoiSo1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo1.Text = MinusScore(txtScoreDoiSo1, 5);

                int maDoiThi = int.Parse(dtdoithi.Rows[0]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo1.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlusScoreDoiSo2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo2.Text = PlusScore(txtScoreDoiSo2, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[1]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo2.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinusScoreDoiSo2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo2.Text = MinusScore(txtScoreDoiSo2, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[1]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo2.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlusScoreDoiSo3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo3.Text = PlusScore(txtScoreDoiSo3, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[2]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo3.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinusScoreDoiSo3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo3.Text = MinusScore(txtScoreDoiSo3, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[2]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo3.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinusScoreDoiSo4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo4.Text = MinusScore(txtScoreDoiSo4, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[3]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo4.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlusScoreDoiSo4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo4.Text = PlusScore(txtScoreDoiSo4, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[3]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo4.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinusScoreDoiSo5_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                txtScoreDoiSo5.Text = MinusScore(txtScoreDoiSo5, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[4]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo5.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlusScoreDoiSo5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtScoreDoiSo5.Text = PlusScore(txtScoreDoiSo5, 5);
                int maDoiThi = int.Parse(dtdoithi.Rows[4]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo5.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region dispatcherTimer
        // Time
        DispatcherTimer dispatcherTimer;
        int timeCount = 0;// thoi gian dem
        int timeMax = 0;// thoi gian cua tro choi

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
            {
                btnStartTime.IsEnabled = true;
                dispatcherTimer.Stop();
                txbTime.Text = "Hết Giờ";
                sound.Stop();
                played = false;
                // bat cac button len sau khi het time
                IsEnableControl(true);
            }
            else
            {
                // Updating the Label which displays the current second
                // if (pause == false)
                {
                    timeCount = ++timeCount;
                    //txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                txbTime.Text = (TimeSpan.FromSeconds(timeMax - timeCount)).ToString("mm':'ss");
                prgTime.Value = timeCount;
                int percent = Convert.ToInt32(0.7 * timeMax);
                if (timeCount <= percent)
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                else
                    prgTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF6335"));
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        // Game
        int indexquestion = -1;

        private void IsEnableControl(bool value)
        {
            btnAnswer.IsEnabled = value;
            btnStartTime.IsEnabled = value;
            btnNextQuestion.IsEnabled = value;
            btnPreviewQuestion.IsEnabled = value;

            //
            //btnPlusScoreDoiSo1.IsEnabled = value;
            //btnPlusScoreDoiSo2.IsEnabled = value;
            //btnPlusScoreDoiSo3.IsEnabled = value;
            //btnPlusScoreDoiSo4.IsEnabled = value;
            //btnPlusScoreDoiSo5.IsEnabled = value;


            //btnMinusScoreDoiSo1.IsEnabled = value;
            //btnMinusScoreDoiSo2.IsEnabled = value;
            //btnMinusScoreDoiSo3.IsEnabled = value;
            //btnMinusScoreDoiSo4.IsEnabled = value;
            //btnMinusScoreDoiSo5.IsEnabled = value;

            //txtScoreDoiSo1.IsEnabled = value;
            //txtScoreDoiSo2.IsEnabled = value;
            //txtScoreDoiSo3.IsEnabled = value;
            //txtScoreDoiSo4.IsEnabled = value;
            //txtScoreDoiSo5.IsEnabled = value;

            //
            cmbHeThi.IsEnabled = value;
            cmbTroChoi.IsEnabled = value;
            btnSummary.IsEnabled = value;
        }

       
        private void indexQuestion(int index)
        {
            try
            {
              
                if ((int)dtcauhoi.Rows[index]["maCauHoi"]!= 23)
                {
                    image.Visibility = Visibility.Hidden;
                }
                else image.Visibility = Visibility.Visible;

                txbTenCauHoi.Text = dtcauhoi.Rows[index]["tenCauHoi"].ToString();

                txbNoiDungCauHoi.Text = dtcauhoi.Rows[index]["noiDung"].ToString();

                // new modify
                //if ((int)dtcauhoi.Rows[index]["maCauHoi"] == 43)
                //{
                //    temp= dtcauhoi.Rows[index]["noiDung"].ToString();
                //    txbNoiDungCauHoi.Text = "";
                //}


                if (txbNoiDungCauHoi.Text.Count() <= 300)
                    txbNoiDungCauHoi.FontSize = 48;
               else if (txbNoiDungCauHoi.Text.Count() <= 500)
                    txbNoiDungCauHoi.FontSize = 26;
                else if (txbNoiDungCauHoi.Text.Count() >= 500)
                    txbNoiDungCauHoi.FontSize = 22;

                //int count = txbNoiDungCauHoi.Text.Count();
                txbLuaChonA.Text = dtcauhoi.Rows[index]["luaChonA"].ToString();
                txbLuaChonB.Text = dtcauhoi.Rows[index]["luaChonB"].ToString();
                txbLuaChonC.Text = dtcauhoi.Rows[index]["luaChonC"].ToString();
                txbLuaChonD.Text = dtcauhoi.Rows[index]["luaChonD"].ToString();

                txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                txbLuaChonB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                txbLuaChonC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                txbLuaChonD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                txbD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show(ex.Message);
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
            }
        }

        private void ResetQuestionContent(int maTroChoi)
        {
            try
            {
                // lay du lieu Cau Hoi
                dtcauhoi = dbcauhoi.getCauHoiTheoTroChoi(maTroChoi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // neu khong cos du lieu
            }
            finally
            {
                txbTenCauHoi.Text = "";
                txbNoiDungCauHoi.Text = "";
                txbLuaChonA.Text = "";
                txbLuaChonB.Text = "";
                txbLuaChonC.Text = "";
                txbLuaChonD.Text = "";
                txbA.Text = "";
                txbB.Text = "";
                txbC.Text = "";
                txbD.Text = "";
                indexquestion = -1;
                btnAnswer.IsEnabled = false;
                btnStartTime.IsEnabled = false;
                btnShowQuestion.IsEnabled = false;
            }
        }

        private void btnNextQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                // so cau hoi
                int maxquestion = dtcauhoi.Rows.Count;

                if (indexquestion < maxquestion)
                {
                    indexQuestion(++indexquestion);

                    prgTime.Maximum = timeMax;
                    prgTime.Value = timeCount = 0;
                    txbTime.Text = (TimeSpan.FromSeconds(timeMax)).ToString("mm':'ss");

                    btnAnswer.IsEnabled = false;

                    if (btnStartTime.IsEnabled == false)
                        btnStartTime.IsEnabled = true;
                    if (btnShowQuestion.IsEnabled == false)
                        btnShowQuestion.IsEnabled = true;
                    try
                    {
                        SoundPlay("../../../Music/Next.wav");
                        sound.Play();
                        played = false;
                    }
                    catch (Exception)
                    {
                    }
                    seen = false;
                }
            }
            catch (Exception)
            {
                txbTenCauHoi.Text = "";
                txbNoiDungCauHoi.Text = "";
                txbLuaChonA.Text = "";
                txbLuaChonB.Text = "";
                txbLuaChonC.Text = "";
                txbLuaChonD.Text = "";
                txbA.Text = "";
                txbB.Text = "";
                txbC.Text = "";
                txbD.Text = "";
                txbTime.Text = "</>";
                btnShowQuestion.IsEnabled = false;
                btnStartTime.IsEnabled = false;

                image.Visibility = Visibility.Hidden;

                //if ((int)dtcauhoi.Rows[0]["maCauHoi"] == 15)
                //    txbNoiDungCauHoi.Text = dtcauhoi.Rows[indexquestion]["maCauHoi"].ToString();

            }
        }

        private void btnPreviewQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                int maxquestion = dtcauhoi.Rows.Count;

                if (indexquestion > 0)
                {
                    indexQuestion(--indexquestion);
                    prgTime.Maximum = timeMax;
                    prgTime.Value = timeCount = 0;
                    txbTime.Text = (TimeSpan.FromSeconds(timeMax)).ToString("mm':'ss");
                    btnAnswer.IsEnabled = false;


                    if (btnStartTime.IsEnabled == false)
                        btnStartTime.IsEnabled = true;
                    if (btnShowQuestion.IsEnabled == false)
                        btnShowQuestion.IsEnabled = true;

                    SoundPlay("../../../Music/Next.wav");
                    sound.Play();
                    played = false;
                    seen = false;
                }
            }
            catch (Exception)
            {

            }
        }

        public bool seen { get; set; }
        public bool seenAnswer { get; set; }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (controlKeyPress == true || seen == true)
            {
                try
                {
                    string answer = dtcauhoi.Rows[indexquestion]["dapAnDung"].ToString();
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
                        txbLuaChonA.Text = dtcauhoi.Rows[indexquestion]["dapAnDung"].ToString();
                    }

                    if (played == false)
                    {
                        SoundPlay("../../../Music/Answer.wav");
                        sound.Play();
                        played = false;
                    }

                    seen = true;
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                    // khong có cau hoi thì đâu có dáp án
                }
            }
        }

        private void btnSummaryScore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmSummaryScore frmsummaryscore = new frmSummaryScore();
                frmsummaryscore.getMaHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());
                if (played == false)
                {
                    SoundPlay("../../../Music/Winer.wav");
                    sound.Play();
                    played = false;
                }

                frmsummaryscore.ShowDialog();
                sound.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool played = false;
        private void SoundPlay(string soundLocation)
        {
            try
            {
                sound.SoundLocation = soundLocation;
                played = true;
            }
            catch (Exception)
            {
            }
        }

        private void btnStartTime_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int maCauHoi = int.Parse(dtcauhoi.Rows[indexquestion]["maCauHoi"].ToString());
                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());
                try
                {
                    if (played == false && timeCount < timeMax)
                    {
                        SoundPlay("../../../Music/BackGroundSound.wav");
                        sound.PlayLooping();
                    }
                }
                catch { }

                DispatcherTimer();

                // tat cac control
                IsEnableControl(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int maCauHoi = int.Parse(dtcauhoi.Rows[indexquestion]["maCauHoi"].ToString());

                int maTroChoi = int.Parse(cmbTroChoi.SelectedValue.ToString());
                if(maCauHoi==23)
                {
                    image.Visibility = Visibility.Visible;
                }
                try
                {
                    dispatcherTimer.Stop();
                }
                catch (Exception)
                {

                }


                btnStartTime_Click(null, null);

                frmShowQuestion frmshowquestion = new frmShowQuestion();
                frmshowquestion.getMaCauHoi = maCauHoi;
                frmshowquestion.getMaTroChoi = maTroChoi;
                frmshowquestion.getTimeCount = timeCount;
                frmshowquestion.seen = seen;
                frmshowquestion.ShowDialog();

                if (frmshowquestion.seen == true)
                {
                    seen = true;
                    btnAnswer_Click(null, null);
                    //seen = false;
                    //frmshowquestion.seen = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region txtScoreDoiSo_TextChanged
        private void txtScoreDoiSo1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int maDoiThi = int.Parse(dtdoithi.Rows[0]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo1.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
            }
            catch { }
        }

        private void txtScoreDoiSo2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int maDoiThi = int.Parse(dtdoithi.Rows[1]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo2.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
            }
            catch (Exception)
            {

            }
        }

        private void txtScoreDoiSo3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int maDoiThi = int.Parse(dtdoithi.Rows[2]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo3.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
            }
            catch (Exception)
            {

            }
        }

        private void txtScoreDoiSo4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int maDoiThi = int.Parse(dtdoithi.Rows[3]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo3.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
            }
            catch (Exception)
            {
            }
        }

        private void txtScoreDoiSo5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int maDoiThi = int.Parse(dtdoithi.Rows[4]["maDoiThi"].ToString());
                float diemSo = float.Parse(txtScoreDoiSo5.Text);
                UpdateScore(maDoiThi, diemSo);
                txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF0000"));
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region txtScoreDoiSo_KeyDown
        private void txtScoreDoiSo1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
                e.Handled = false;

            if (e.Key == Key.Enter)
            {
                try
                {
                    int maDoiThi = int.Parse(dtdoithi.Rows[0]["maDoiThi"].ToString());
                    float diemSo = float.Parse(txtScoreDoiSo1.Text);
                    UpdateScore(maDoiThi, diemSo);

                    txtScoreDoiSo1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception)
                {

                }
            }
        }

        private void txtScoreDoiSo2_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
                e.Handled = false;

            if (e.Key == Key.Enter)
            {
                try
                {
                    int maDoiThi = int.Parse(dtdoithi.Rows[1]["maDoiThi"].ToString());
                    float diemSo = float.Parse(txtScoreDoiSo2.Text);
                    UpdateScore(maDoiThi, diemSo);

                    txtScoreDoiSo2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception)
                {

                }
            }
        }

        private void txtScoreDoiSo3_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
                e.Handled = false;

            if (e.Key == Key.Enter)
            {
                try
                {
                    int maDoiThi = int.Parse(dtdoithi.Rows[2]["maDoiThi"].ToString());
                    float diemSo = float.Parse(txtScoreDoiSo3.Text);
                    UpdateScore(maDoiThi, diemSo);

                    txtScoreDoiSo3.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception)
                {

                }
            }
        }

        private void txtScoreDoiSo4_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
                e.Handled = false;

            if (e.Key == Key.Enter)
            {
                try
                {
                    int maDoiThi = int.Parse(dtdoithi.Rows[3]["maDoiThi"].ToString());
                    float diemSo = float.Parse(txtScoreDoiSo4.Text);
                    UpdateScore(maDoiThi, diemSo);

                    txtScoreDoiSo4.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception)
                {

                }
            }
        }

        private void txtScoreDoiSo5_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
                e.Handled = false;

            if (e.Key == Key.Enter)
            {
                try
                {
                    int maDoiThi = int.Parse(dtdoithi.Rows[4]["maDoiThi"].ToString());
                    float diemSo = float.Parse(txtScoreDoiSo5.Text);
                    UpdateScore(maDoiThi, diemSo);

                    txtScoreDoiSo5.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        private bool pause = false;

        private void txbTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (timeCount != 0)
            {
                if (pause == false)
                {
                    try
                    {
                        dispatcherTimer.Stop();
                        txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FFFF6335"));

                        IsEnableControl(true);
                    }
                    catch (Exception)
                    {

                    }
                    pause = true;
                    sound.Stop();
                    played = false;
                }
                else
                {
                    try
                    {
                        dispatcherTimer.Start();

                        txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                    }
                    catch (Exception)
                    {

                    }
                    pause = false;
                    try
                    {
                        if (played == false && timeCount < timeMax)
                        {
                            SoundPlay("../../../Music/BackGroundSound.wav");
                            sound.PlayLooping();
                        }
                    }
                    catch { }
                }
            }
        }

        private void btnAnswer_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private bool loai;
        private void Loai2DoiChoi()
        {
            int maHeThi = int.Parse(cmbHeThi.SelectedValue.ToString());

            string mht = cmbTroChoi.SelectedValue.ToString();
            if ((mht == "2" || mht == "3" || mht == "4" /*|| mht == "7" || mht == "8" || mht == "9"*/))
            {
                if (loai || MessageBox.Show("Hệ thống sẽ loại bỏ 2 đội chơi có điểm thấp nhất ở vòng thi này.", "Thông báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    dtdoithi = dbdoithi.get3DoiThiTheoMaHeThi(maHeThi);
                    loai = true;
                }
            }
            else
            {
                dtdoithi = dbdoithi.getDoiThiTheoMaHeThi(maHeThi);
                loai = false;
            }


            try
            {
                // cap nhap ten doi len form
                try
                {
                    lblDoiSo1.Content = dtdoithi.Rows[0]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo1.IsEnabled = true;
                    //btnMinusScoreDoiSo1.IsEnabled = true;
                    //txtScoreDoiSo1.IsEnabled = true;

                    lblDoiSo1.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo1.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo1.Visibility = Visibility.Visible;
                    txtScoreDoiSo1.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo1.Content = "";
                    //btnPlusScoreDoiSo1.IsEnabled = false;
                    //btnMinusScoreDoiSo1.IsEnabled = false;
                    //txtScoreDoiSo1.IsEnabled = false;

                    lblDoiSo1.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo1.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo1.Visibility = Visibility.Hidden;
                    txtScoreDoiSo1.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo2.Content = dtdoithi.Rows[1]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo2.IsEnabled = true;
                    //btnMinusScoreDoiSo2.IsEnabled = true;
                    //txtScoreDoiSo2.IsEnabled = true;


                    lblDoiSo2.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo2.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo2.Visibility = Visibility.Visible;
                    txtScoreDoiSo2.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo2.Content = "";
                    //btnPlusScoreDoiSo2.IsEnabled = false;
                    //btnMinusScoreDoiSo2.IsEnabled = false;
                    //txtScoreDoiSo2.IsEnabled = false;

                    lblDoiSo2.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo2.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo2.Visibility = Visibility.Hidden;
                    txtScoreDoiSo2.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo3.Content = dtdoithi.Rows[2]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo3.IsEnabled = true;
                    //btnMinusScoreDoiSo3.IsEnabled = true;
                    //txtScoreDoiSo3.IsEnabled = true;

                    lblDoiSo3.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo3.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo3.Visibility = Visibility.Visible;
                    txtScoreDoiSo3.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo3.Content = "";
                    //btnPlusScoreDoiSo3.IsEnabled = false;
                    //btnMinusScoreDoiSo3.IsEnabled = false;
                    //txtScoreDoiSo3.IsEnabled = false;

                    lblDoiSo3.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo3.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo3.Visibility = Visibility.Hidden;
                    txtScoreDoiSo3.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo4.Content = dtdoithi.Rows[3]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo4.IsEnabled = true;
                    //btnMinusScoreDoiSo4.IsEnabled = true;
                    //txtScoreDoiSo4.IsEnabled = true;

                    lblDoiSo4.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo4.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo4.Visibility = Visibility.Visible;
                    txtScoreDoiSo4.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo4.Content = "";
                    //btnPlusScoreDoiSo4.IsEnabled = false;
                    //btnMinusScoreDoiSo4.IsEnabled = false;
                    //txtScoreDoiSo4.IsEnabled = false;

                    lblDoiSo4.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo4.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo4.Visibility = Visibility.Hidden;
                    txtScoreDoiSo4.Visibility = Visibility.Hidden;
                }
                ///////////////////////////
                try
                {
                    lblDoiSo5.Content = dtdoithi.Rows[4]["tenDoiThi"].ToString();

                    //btnPlusScoreDoiSo5.IsEnabled = true;
                    //btnMinusScoreDoiSo5.IsEnabled = true;
                    //txtScoreDoiSo5.IsEnabled = true;

                    lblDoiSo5.Visibility = Visibility.Visible;
                    btnPlusScoreDoiSo5.Visibility = Visibility.Visible;
                    btnMinusScoreDoiSo5.Visibility = Visibility.Visible;
                    txtScoreDoiSo5.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    lblDoiSo5.Content = "";
                    //btnPlusScoreDoiSo5.IsEnabled = false;
                    //btnMinusScoreDoiSo5.IsEnabled = false;
                    //txtScoreDoiSo5.IsEnabled = false;

                    lblDoiSo5.Visibility = Visibility.Hidden;
                    btnPlusScoreDoiSo5.Visibility = Visibility.Hidden;
                    btnMinusScoreDoiSo5.Visibility = Visibility.Hidden;
                    txtScoreDoiSo5.Visibility = Visibility.Hidden;
                }

            }
            catch (Exception)
            {
                // neu khong co du lieu
            }
        }

        private bool controlKeyPress;
       // bool=
        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
                controlKeyPress = true;

            if (controlKeyPress == true && e.Key == Key.S)
            {
                #region Chon doi thi
                (new frmSelectTeam()).ShowDialog();

                if (frmSelectTeam.heThi == 1)
                {
                    if (frmSelectTeam.chk1 == false)
                    {
                        lblDoiSo1.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo1.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo1.Visibility = Visibility.Hidden;
                        txtScoreDoiSo1.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo1.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo1.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo1.Visibility = Visibility.Visible;
                        txtScoreDoiSo1.Visibility = Visibility.Visible;
                    }
                    if (frmSelectTeam.chk2 == false)
                    {
                        lblDoiSo2.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo2.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo2.Visibility = Visibility.Hidden;
                        txtScoreDoiSo2.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo2.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo2.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo2.Visibility = Visibility.Visible;
                        txtScoreDoiSo2.Visibility = Visibility.Visible;
                    }
                    if (frmSelectTeam.chk3 == false)
                    {
                        lblDoiSo3.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo3.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo3.Visibility = Visibility.Hidden;
                        txtScoreDoiSo3.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo3.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo3.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo3.Visibility = Visibility.Visible;
                        txtScoreDoiSo3.Visibility = Visibility.Visible;
                    }
                    if (frmSelectTeam.chk4 == false)
                    {
                        lblDoiSo4.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo4.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo4.Visibility = Visibility.Hidden;
                        txtScoreDoiSo4.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo4.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo4.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo4.Visibility = Visibility.Visible;
                        txtScoreDoiSo4.Visibility = Visibility.Visible;
                    }

                    if (frmSelectTeam.chk5 == false)
                    {
                        lblDoiSo5.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo5.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo5.Visibility = Visibility.Hidden;
                        txtScoreDoiSo5.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo5.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo5.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo5.Visibility = Visibility.Visible;
                        txtScoreDoiSo5.Visibility = Visibility.Visible;
                    }
                }
                else if (frmSelectTeam.heThi == 2)
                {
                    if (frmSelectTeam.chk6 == false)
                    {
                        lblDoiSo1.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo1.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo1.Visibility = Visibility.Hidden;
                        txtScoreDoiSo1.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo1.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo1.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo1.Visibility = Visibility.Visible;
                        txtScoreDoiSo1.Visibility = Visibility.Visible;
                    }
                    if (frmSelectTeam.chk7 == false)
                    {
                        lblDoiSo2.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo2.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo2.Visibility = Visibility.Hidden;
                        txtScoreDoiSo2.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo2.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo2.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo2.Visibility = Visibility.Visible;
                        txtScoreDoiSo2.Visibility = Visibility.Visible;
                    }
                    if (frmSelectTeam.chk8 == false)
                    {
                        lblDoiSo3.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo3.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo3.Visibility = Visibility.Hidden;
                        txtScoreDoiSo3.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo3.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo3.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo3.Visibility = Visibility.Visible;
                        txtScoreDoiSo3.Visibility = Visibility.Visible;
                    }
                    if (frmSelectTeam.chk9 == false)
                    {
                        lblDoiSo4.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo4.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo4.Visibility = Visibility.Hidden;
                        txtScoreDoiSo4.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo4.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo4.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo4.Visibility = Visibility.Visible;
                        txtScoreDoiSo4.Visibility = Visibility.Visible;
                    }

                    if (frmSelectTeam.chk10 == false)
                    {
                        lblDoiSo5.Visibility = Visibility.Hidden;
                        btnPlusScoreDoiSo5.Visibility = Visibility.Hidden;
                        btnMinusScoreDoiSo5.Visibility = Visibility.Hidden;
                        txtScoreDoiSo5.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        lblDoiSo5.Visibility = Visibility.Visible;
                        btnPlusScoreDoiSo5.Visibility = Visibility.Visible;
                        btnMinusScoreDoiSo5.Visibility = Visibility.Visible;
                        txtScoreDoiSo5.Visibility = Visibility.Visible;
                    }
                }
                #endregion
            }

            if (e.Key == Key.A)
                btnPreviewQuestion_Click(null, null);
            else if (e.Key == Key.D)
                btnNextQuestion_Click(null, null);


            if (e.Key == Key.H && controlKeyPress == true)
            {
                txbNoiDungCauHoi.Text = temp;
                txbNoiDungCauHoi.FontSize = 26;
            }
        }
        string temp = @"Nội dung: Đây là HÀM tính tổng các số nguyên tố có trong mảng các số nguyên a gồm n phần tử.

1	}
2	Else
3	if (a[i] % j == 0) nt = 0;
4	int tongnt(inta[], intn) {						
5	for (int i = 0; i <n; i++){ 
6	if (nt) tong += a[i];
7	}
8	int tong = 0;
9	return tong;
10	if (a[i] < 2) nt = 0;
11	for (int j = 2; j <a[i]; j++)
12	int nt = 1";
        private void window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
                controlKeyPress = false;
        }

        private void btnChayLai_Click(object sender, RoutedEventArgs e)
        {
            if (controlKeyPress == true && indexquestion >= 0)
            {
                try
                {
                    try
                    {
                        txbTime.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF000000"));
                        prgTime.Maximum = timeMax;
                        prgTime.Value = timeCount = 0;
                        txbTime.Text = (TimeSpan.FromSeconds(timeMax)).ToString("mm':'ss");

                        txbLuaChonA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                        txbA.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                        txbLuaChonB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                        txbB.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                        txbLuaChonC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                        txbC.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                        txbLuaChonD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");
                        txbD.Foreground = (Brush)(new BrushConverter()).ConvertFrom("#FF000000");

                        if (played == false && timeCount < timeMax)
                        {
                            SoundPlay("../../../Music/BackGroundSound.wav");
                            sound.PlayLooping();
                        }
                    }
                    catch { }
                    try
                    {
                        dispatcherTimer.Stop();
                    }
                    catch (Exception)
                    {

                    }
                    DispatcherTimer();

                    // tat cac control
                    IsEnableControl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            image.Visibility = Visibility.Hidden;
        }
    }
}
