using System;
using System.Collections.Generic;
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


namespace CinemaWPF
{
    /// <summary>
    /// Interaction logic for LichChieu.xaml
    /// </summary>
    public partial class LichChieu : Window
    {
        
        public LichChieu()
        {
            InitializeComponent();
            
            
        }
        int sovedangchon = 0;
        int tongsove;
        int soveNL;
        int soveTE;
        int soveTV;
        private void _Dangxuat_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Nếu đăng xuất bạn sẽ kết thúc phiên làm việc. Bạn có chắc chắn đăng xuất hay không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
                MainWindow mainform = new MainWindow();
                mainform.ShowDialog();
            }

            
        }

        private void btn_dtv_Click(object sender, RoutedEventArgs e)
        {
            formTV formtv = new formTV();
            formtv.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Credit Credit = new Credit();
            Credit.ShowDialog();
        }

        private void btn_sc1_Click(object sender, RoutedEventArgs e)
        {
            
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap1.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian1.Text;
        }

        private void btn_sc2_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap2.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian2.Text;
        }

        private void btn_sc3_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap3.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian3.Text;
        }

        private void btn_sc4_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap4.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian4.Text;
        }

        private void btn_sc5_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap5.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian5.Text;
        }

        private void btn_sc7_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap7.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian7.Text;
        }

        private void btn_sc6_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim1.Text;
            this.lbl_hienthirap.Content = this.tbl_rap6.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian6.Text;
        }

        private void btn_sc8_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim2.Text;
            this.lbl_hienthirap.Content = this.tbl_rap8.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian8.Text;
        }

        private void btn_sc9_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim2.Text;
            this.lbl_hienthirap.Content = this.tbl_rap9.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian9.Text;
        }

        private void btn_sc10_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim2.Text;
            this.lbl_hienthirap.Content = this.tbl_rap10.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian10.Text;
        }

        private void btn_sc11_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim2.Text;
            this.lbl_hienthirap.Content = this.tbl_rap11.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian11.Text;
        }

        private void btn_sc12_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim2.Text;
            this.lbl_hienthirap.Content = this.tbl_rap12.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian12.Text;
        }

        private void btn_sc13_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim2.Text;
            this.lbl_hienthirap.Content = this.tbl_rap13.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian13.Text;
        }

        private void btn_sc14_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim3.Text;
            this.lbl_hienthirap.Content = this.tbl_rap14.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian14.Text;
        }

        private void btn_sc15_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim3.Text;
            this.lbl_hienthirap.Content = this.tbl_rap15.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian15.Text;
        }

        private void btn_sc16_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim3.Text;
            this.lbl_hienthirap.Content = this.tbl_rap16.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian16.Text;
        }

        private void btn_sc17_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim3.Text;
            this.lbl_hienthirap.Content = this.tbl_rap17.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian17.Text;
        }

        private void btn_sc18_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim4.Text;
            this.lbl_hienthirap.Content = this.tbl_rap18.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian18.Text;
        }

        private void btn_sc19_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex + 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;
            lbl_hienthiphim.Content = tbl_tenphim4.Text;
            this.lbl_hienthirap.Content = this.tbl_rap19.Text;
            lbl_ngaychieu.Content = dpk_ngaychieu.Text;
            lbl_thoigian.Content = tbl_tgian19.Text;
        }


        private void btn_tieptheobanve_Click(object sender, RoutedEventArgs e)
        {
 
            if(sovedangchon==tongsove)
            {
               
                int newIndex = tab_banhang.SelectedIndex + 1;
                if (newIndex >= tab_banhang.Items.Count)
                    newIndex = 0;
                tab_banhang.SelectedIndex = newIndex;
            }
            else if(sovedangchon<tongsove)
            {
                MessageBox.Show("Bạn chưa chọn đủ số ghế! Vui lòng kiểm tra lại");
            }
        }

        private void btn_quaylaisuatchieu_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_phim.SelectedIndex - 1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex;

            GheA1 = "cosan"; GheA2 = "cosan"; GheA3 = "cosan"; GheA4 = "cosan"; GheA5 = "cosan"; GheA6 = "cosan";
            GheA7 = "cosan"; GheA8 = "cosan"; GheA9 = "cosan"; GheA10 = "cosan"; GheA11 = "cosan"; GheA12 = "cosan"; GheB1 = "cosan"; GheB2 = "cosan"; GheB3 = "cosan"; GheB4 = "cosan"; GheB5 = "cosan";
            GheB6 = "cosan"; GheB7 = "cosan"; GheB8 = "cosan"; GheB9 = "cosan"; GheB10 = "cosan"; GheB11 = "cosan"; GheB12 = "cosan"; GheC1 = "cosan"; GheC2 = "cosan"; GheC3 = "cosan"; GheC4 = "cosan"; GheC5 = "cosan"; GheC6 = "cosan";
            GheC7 = "cosan"; GheC8 = "cosan"; GheC9 = "cosan"; GheC10 = "cosan"; GheC11 = "cosan"; GheC12 = "cosan"; GheD1 = "cosan"; GheD2 = "cosan"; GheD3 = "cosan";
            GheD4 = "cosan"; GheD5 = "cosan"; GheD6 = "cosan"; GheD7 = "cosan"; GheD8 = "cosan"; GheD9 = "cosan"; GheD10 = "cosan";
            GheD11 = "cosan"; GheD12 = "cosan"; GheE1 = "cosan"; GheE2 = "cosan"; GheE3 = "cosan"; GheE4 = "cosan"; GheE5 = "cosan"; GheE6 = "cosan"; GheE7 = "cosan";
            GheE8 = "cosan"; GheE9 = "cosan"; GheE10 = "cosan"; GheE11 = "cosan"; GheE12 = "cosan"; GheF1 = "cosan"; GheF2 = "cosan"; GheF3 = "cosan"; GheF4 = "cosan"; GheF5 = "cosan";
            GheF6 = "cosan"; GheF7 = "cosan"; GheF8 = "cosan"; GheF9 = "cosan"; GheF10 = "cosan"; GheF11 = "cosan"; GheF12 = "cosan";
                A1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                A12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                B12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                C12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                D12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                E12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                F12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));

                tongsove = 0; soveNL = 0; soveTE = 0; soveTV = 0; Tongghe.Content = "0";
                lbl_NL.Content = "0"; lbl_TE.Content = "0"; lbl_TV.Content = "0"; sovedangchon = 0;

            }
        

        private void btn_tieptheobapnuoc_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_banhang.SelectedIndex + 1;
            if (newIndex >= tab_banhang.Items.Count)
                newIndex = 0;
            tab_banhang.SelectedIndex = newIndex;
        }

        private void btn_quaylaichonghe_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_banhang.SelectedIndex - 1;
            if (newIndex >= tab_banhang.Items.Count)
                newIndex = 0;
            tab_banhang.SelectedIndex = newIndex;
        }

        private void btn_Huytientrinh1_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_banhang.SelectedIndex - 1;
            if (newIndex >= tab_banhang.Items.Count)
                newIndex = 0;
            tab_banhang.SelectedIndex = newIndex;

            int newIndex1 = tab_phim.SelectedIndex -1;
            if (newIndex >= tab_phim.Items.Count)
                newIndex = 0;
            tab_phim.SelectedIndex = newIndex1;


            GheA1 = "cosan"; GheA2 = "cosan"; GheA3 = "cosan"; GheA4 = "cosan"; GheA5 = "cosan"; GheA6 = "cosan";
            GheA7 = "cosan"; GheA8 = "cosan"; GheA9 = "cosan"; GheA10 = "cosan"; GheA11 = "cosan"; GheA12 = "cosan"; GheB1 = "cosan"; GheB2 = "cosan"; GheB3 = "cosan"; GheB4 = "cosan"; GheB5 = "cosan";
            GheB6 = "cosan"; GheB7 = "cosan"; GheB8 = "cosan"; GheB9 = "cosan"; GheB10 = "cosan"; GheB11 = "cosan"; GheB12 = "cosan"; GheC1 = "cosan"; GheC2 = "cosan"; GheC3 = "cosan"; GheC4 = "cosan"; GheC5 = "cosan"; GheC6 = "cosan";
            GheC7 = "cosan"; GheC8 = "cosan"; GheC9 = "cosan"; GheC10 = "cosan"; GheC11 = "cosan"; GheC12 = "cosan"; GheD1 = "cosan"; GheD2 = "cosan"; GheD3 = "cosan";
            GheD4 = "cosan"; GheD5 = "cosan"; GheD6 = "cosan"; GheD7 = "cosan"; GheD8 = "cosan"; GheD9 = "cosan"; GheD10 = "cosan";
            GheD11 = "cosan"; GheD12 = "cosan"; GheE1 = "cosan"; GheE2 = "cosan"; GheE3 = "cosan"; GheE4 = "cosan"; GheE5 = "cosan"; GheE6 = "cosan"; GheE7 = "cosan";
            GheE8 = "cosan"; GheE9 = "cosan"; GheE10 = "cosan"; GheE11 = "cosan"; GheE12 = "cosan"; GheF1 = "cosan"; GheF2 = "cosan"; GheF3 = "cosan"; GheF4 = "cosan"; GheF5 = "cosan";
            GheF6 = "cosan"; GheF7 = "cosan"; GheF8 = "cosan"; GheF9 = "cosan"; GheF10 = "cosan"; GheF11 = "cosan"; GheF12 = "cosan";
            A1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            A12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            B12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            C12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            D12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            E12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
            F12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));

            tongsove = 0; soveNL = 0; soveTE = 0; soveTV = 0; Tongghe.Content = "0";
            lbl_NL.Content = "0"; lbl_TE.Content = "0"; lbl_TV.Content = "0"; sovedangchon = 0;
        }

        private void btn_huysuatchieu2_Click(object sender, RoutedEventArgs e)
        {
          int newIndex = tab_banhang.SelectedIndex - 2;
        if (newIndex >= tab_banhang.Items.Count)
         newIndex = 0;
           tab_banhang.SelectedIndex = newIndex;

           int newIndex1 = tab_phim.SelectedIndex - 1;
           if (newIndex >= tab_phim.Items.Count)
               newIndex = 0;
           tab_phim.SelectedIndex = newIndex1;

           GheA1 = "cosan"; GheA2 = "cosan"; GheA3 = "cosan"; GheA4 = "cosan"; GheA5 = "cosan"; GheA6 = "cosan";
           GheA7 = "cosan"; GheA8 = "cosan"; GheA9 = "cosan"; GheA10 = "cosan"; GheA11 = "cosan"; GheA12 = "cosan"; GheB1 = "cosan"; GheB2 = "cosan"; GheB3 = "cosan"; GheB4 = "cosan"; GheB5 = "cosan";
           GheB6 = "cosan"; GheB7 = "cosan"; GheB8 = "cosan"; GheB9 = "cosan"; GheB10 = "cosan"; GheB11 = "cosan"; GheB12 = "cosan"; GheC1 = "cosan"; GheC2 = "cosan"; GheC3 = "cosan"; GheC4 = "cosan"; GheC5 = "cosan"; GheC6 = "cosan";
           GheC7 = "cosan"; GheC8 = "cosan"; GheC9 = "cosan"; GheC10 = "cosan"; GheC11 = "cosan"; GheC12 = "cosan"; GheD1 = "cosan"; GheD2 = "cosan"; GheD3 = "cosan";
           GheD4 = "cosan"; GheD5 = "cosan"; GheD6 = "cosan"; GheD7 = "cosan"; GheD8 = "cosan"; GheD9 = "cosan"; GheD10 = "cosan";
           GheD11 = "cosan"; GheD12 = "cosan"; GheE1 = "cosan"; GheE2 = "cosan"; GheE3 = "cosan"; GheE4 = "cosan"; GheE5 = "cosan"; GheE6 = "cosan"; GheE7 = "cosan";
           GheE8 = "cosan"; GheE9 = "cosan"; GheE10 = "cosan"; GheE11 = "cosan"; GheE12 = "cosan"; GheF1 = "cosan"; GheF2 = "cosan"; GheF3 = "cosan"; GheF4 = "cosan"; GheF5 = "cosan";
           GheF6 = "cosan"; GheF7 = "cosan"; GheF8 = "cosan"; GheF9 = "cosan"; GheF10 = "cosan"; GheF11 = "cosan"; GheF12 = "cosan";
           A1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           A12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           B12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           C12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           D12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           E12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
           F12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));

           tongsove = 0; soveNL = 0; soveTE = 0; soveTV = 0; Tongghe.Content = "0";
           lbl_NL.Content = "0"; lbl_TE.Content = "0"; lbl_TV.Content = "0"; sovedangchon = 0;
        }

        private void btn_quaylaiFB_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tab_banhang.SelectedIndex - 1;
            if (newIndex >= tab_banhang.Items.Count)
                newIndex = 0;
            tab_banhang.SelectedIndex = newIndex;
        }
        //CHọn ghế--------------------------------------------------------------------------
        string GheA1 = "cosan"; string GheA2 = "cosan"; string GheA3 = "cosan"; string GheA4 = "cosan"; string GheA5 = "cosan"; string GheA6 = "cosan";
        string GheA7 = "cosan"; string GheA8 = "cosan"; string GheA9 = "cosan"; string GheA10 = "cosan"; string GheA11 = "cosan"; string GheA12 = "cosan"; string GheB1 = "cosan"; string GheB2 = "cosan"; string GheB3 = "cosan"; string GheB4 = "cosan"; string GheB5 = "cosan";
        string GheB6 = "cosan"; string GheB7 = "cosan"; string GheB8 = "cosan"; string GheB9 = "cosan"; string GheB10 = "cosan"; string GheB11 = "cosan"; string GheB12 = "cosan"; string GheC1 = "cosan"; string GheC2 = "cosan"; string GheC3 = "cosan"; string GheC4 = "cosan"; string GheC5 = "cosan"; string GheC6 = "cosan";
        string GheC7 = "cosan"; string GheC8 = "cosan"; string GheC9 = "cosan"; string GheC10 = "cosan"; string GheC11 = "cosan"; string GheC12 = "cosan"; string GheD1 = "cosan"; string GheD2 = "cosan"; string GheD3 = "cosan";
        string GheD4 = "cosan"; string GheD5 = "cosan"; string GheD6 = "cosan"; string GheD7 = "cosan"; string GheD8 = "cosan"; string GheD9 = "cosan"; string GheD10 = "cosan";
        string GheD11 = "cosan"; string GheD12 = "cosan"; string GheE1 = "cosan"; string GheE2 = "cosan"; string GheE3 = "cosan"; string GheE4 = "cosan"; string GheE5 = "cosan"; string GheE6 = "cosan"; string GheE7 = "cosan";
        string GheE8 = "cosan"; string GheE9 = "cosan"; string GheE10 = "cosan"; string GheE11 = "cosan"; string GheE12 = "cosan"; string GheF1 = "cosan"; string GheF2 = "cosan"; string GheF3 = "cosan"; string GheF4 = "cosan"; string GheF5 = "cosan";
        string GheF6 = "cosan"; string GheF7 = "cosan"; string GheF8 = "cosan"; string GheF9 = "cosan"; string GheF10 = "cosan"; string GheF11 = "cosan"; string GheF12 = "cosan";


        private void btn_CongNL_Click(object sender, RoutedEventArgs e)
        {
            soveNL = int.Parse(lbl_NL.Content.ToString());
            lbl_NL.Content = soveNL + 1;
            lbl_NL.Content.ToString();
            soveNL += 1;
            tongsove = soveTV + soveTE + soveNL;
            Tongghe.Content = tongsove;
        }

        private void btn_TruNL_Click(object sender, RoutedEventArgs e)
        {
             soveNL = int.Parse(lbl_NL.Content.ToString());
             if (tongsove > 0 && sovedangchon < tongsove && soveNL>0)
            {
                lbl_NL.Content = soveNL - 1;
                lbl_NL.Content.ToString();
                soveNL -= 1;
                tongsove = soveTV + soveTE + soveNL;
                Tongghe.Content = tongsove;
            }
        }

        private void btn_CongTE_Click(object sender, RoutedEventArgs e)
        {
             soveTE = int.Parse(lbl_TE.Content.ToString());
            lbl_TE.Content = soveTE + 1;
            lbl_TE.Content.ToString();
            soveTE += 1;
            tongsove = soveTV + soveTE + soveNL;
            Tongghe.Content = tongsove;
        }

        private void btn_TruTE_Click(object sender, RoutedEventArgs e)
        {
            soveTE = int.Parse(lbl_TE.Content.ToString());
            if (tongsove > 0 && sovedangchon < tongsove && soveTE>0)
            {
                lbl_TE.Content = soveTE - 1;
                lbl_TE.Content.ToString();
                soveTE -= 1;
                tongsove = soveTV + soveTE + soveNL;
                Tongghe.Content = tongsove;
            }
        }

        private void btn_CongTV_Click(object sender, RoutedEventArgs e)
        {
            soveTV = int.Parse(lbl_TV.Content.ToString());
            lbl_TV.Content = soveTV + 1;
            lbl_TV.Content.ToString();
            soveTV += 1;
            tongsove = soveTV + soveTE + soveNL;
            Tongghe.Content = tongsove;
        }

        private void btn_TruTV_Click(object sender, RoutedEventArgs e)
        {
            soveTV = int.Parse(lbl_TV.Content.ToString());
            if (tongsove > 0 && sovedangchon < tongsove && soveTV  > 0)
            {
                lbl_TV.Content = soveTV - 1;
                lbl_TV.Content.ToString();
                soveTV -= 1;
                tongsove = soveTV + soveTE + soveNL;
                Tongghe.Content = tongsove;
            }
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            
	if (GheA1 == "cosan" && sovedangchon < tongsove )
            { A1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA1 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheA1 == "kocosan")
            {A1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA1 = "cosan";
                sovedangchon -= 1;
            }
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (GheA2 == "cosan" && sovedangchon < tongsove)
            {
                A2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA2 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA2 == "kocosan")
            {
                A2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA2 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (GheA3 == "cosan" && sovedangchon < tongsove)
            {
                A3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA3 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA3 == "kocosan")
            {
                A3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA3 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (GheA4 == "cosan" && sovedangchon < tongsove)
            {
                A4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA4 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA4 == "kocosan")
            {
                A4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA4 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A5_Click(object sender, RoutedEventArgs e)
        {
            if (GheA5 == "cosan" && sovedangchon < tongsove)
            {
                A5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA5 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA5 == "kocosan")
            {
                A5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA5 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A6_Click(object sender, RoutedEventArgs e)
        {
            if (GheA6 == "cosan" && sovedangchon < tongsove)
            {
                A6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA6 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA6 == "kocosan")
            {
                A7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA6 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A7_Click(object sender, RoutedEventArgs e)
        {
            if (GheA7 == "cosan" && sovedangchon < tongsove)
            {
                A7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA7 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA7 == "kocosan")
            {
                A7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA7 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A8_Click(object sender, RoutedEventArgs e)
        {
            if (GheA8 == "cosan" && sovedangchon < tongsove)
            {
                A8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA8 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA8 == "kocosan")
            {
                A8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA8 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A9_Click(object sender, RoutedEventArgs e)
        {
            if (GheA9 == "cosan" && sovedangchon < tongsove)
            {
                A9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA9 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA9 == "kocosan")
            {
                A9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA9 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A10_Click(object sender, RoutedEventArgs e)
        {
            if (GheA10 == "cosan" && sovedangchon < tongsove)
            {
                A10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA10 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA10 == "kocosan")
            {
                A10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA10 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A11_Click(object sender, RoutedEventArgs e)
        {
            if (GheA11 == "cosan" && sovedangchon < tongsove)
            {
                A11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA11 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA11 == "kocosan")
            {
                A11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA11 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void A12_Click(object sender, RoutedEventArgs e)
        {
            if (GheA12 == "cosan" && sovedangchon < tongsove)
            {
                A12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheA12 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheA12 == "kocosan")
            {
                A12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheA12 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (GheB1 == "cosan" && sovedangchon < tongsove)
            {
                B1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB1 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB1 == "kocosan")
            {
                B1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB1 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (GheB2 == "cosan" && sovedangchon < tongsove)
            {
                B2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB2 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB2 == "kocosan")
            {
                B2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB2 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (GheB3 == "cosan" && sovedangchon < tongsove)
            {
                B3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB3 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB3 == "kocosan")
            {
                B3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB3 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (GheB4 == "cosan" && sovedangchon < tongsove)
            {
                B4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB4 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB4 == "kocosan")
            {
                B4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB4 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (GheB5 == "cosan" && sovedangchon < tongsove)
            {
                B5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB5 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB5 == "kocosan")
            {
                B5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB5 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (GheB6 == "cosan" && sovedangchon < tongsove)
            {
                B6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB6 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB6 == "kocosan")
            {
                B6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB6 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (GheB7 == "cosan" && sovedangchon < tongsove)
            {
                B7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB7 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB7 == "kocosan")
            {
                B7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB7 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (GheB8 == "cosan" && sovedangchon < tongsove)
            {
                B8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB8 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB8 == "kocosan")
            {
                B8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB8 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (GheB9 == "cosan" && sovedangchon < tongsove)
            {
                B9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB9 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB9 == "kocosan")
            {
                B9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB9 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B10_Click(object sender, RoutedEventArgs e)
        {
            if (GheB10 == "cosan" && sovedangchon < tongsove)
            {
                B10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB10 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB10 == "kocosan")
            {
                B10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB10 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B11_Click(object sender, RoutedEventArgs e)
        {
            if (GheB11 == "cosan" && sovedangchon < tongsove)
            {
                B11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB11 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB11 == "kocosan")
            {
                B11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB11 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void B12_Click(object sender, RoutedEventArgs e)
        {
            if (GheB12 == "cosan" && sovedangchon < tongsove)
            {
                B12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheB12 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheB12 == "kocosan")
            {
                B12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheB12 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            if (GheC1 == "cosan" && sovedangchon < tongsove)
            {
                C1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC1 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheC1 == "kocosan")
            {
                C1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC1 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (GheC2 == "cosan" && sovedangchon < tongsove)
            {
                C2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC2 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheC2 == "kocosan")
            {
                C2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC2 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void C3_Click(object sender, RoutedEventArgs e)
        {
            if (GheC3 == "cosan" && sovedangchon < tongsove)
            {
                C3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC3 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheC3 == "kocosan")
            {
                C3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC3 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void C4_Click(object sender, RoutedEventArgs e)
        {
            if (GheC4 == "cosan" && sovedangchon < tongsove)
            {
                C4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC4 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheC4 == "kocosan")
            {
                C4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC4 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void C5_Click(object sender, RoutedEventArgs e)
        {
            if (GheC5 == "cosan" && sovedangchon < tongsove)
            {
                C5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC5 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheC5 == "kocosan")
            {
                C5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC5 = "cosan";
                sovedangchon -= 1;
            }
        }
        private void C6_Click(object sender, RoutedEventArgs e)
        {
            if (GheC6 == "cosan" && sovedangchon < tongsove)
            {
                C6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC6 = "kocosan";
                sovedangchon += 1;
            }
            else if (GheC6 == "kocosan")
            {
                C6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC6 = "cosan";
                sovedangchon -= 1;
            }
        }
         private  void D2_Click(object sender, RoutedEventArgs e)
        {
            if (GheD2 == "cosan" && sovedangchon < tongsove)
            {
                D2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD2 = "kocosansan";
                sovedangchon += 1;
            }
            else if (GheD2 == "kocosansan")
            {
                D2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD2 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D1_Click(object sender, RoutedEventArgs e)
{ if (GheD1 == "cosan" && sovedangchon < tongsove)
            { D1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD1 = "kocosansan";
                sovedangchon  += 1;
            }
         else if (GheD1 == "kocosansan")
            {D1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD1 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D3_Click(object sender, RoutedEventArgs e)
{ if (GheD3 == "cosan" && sovedangchon < tongsove)
            { D3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD3 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD3 == "kocosan")
            {D3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD3 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D4_Click(object sender, RoutedEventArgs e)
{ if (GheD4 == "cosan" && sovedangchon < tongsove)
            { D4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD4 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD4 == "kocosan")
            {D4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD4 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D5_Click(object sender, RoutedEventArgs e)
{ if (GheD5 == "cosan" && sovedangchon < tongsove)
            { D5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD5 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD5 == "kocosan")
            {D5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD5 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D6_Click(object sender, RoutedEventArgs e)
{ if (GheD6 == "cosan" && sovedangchon < tongsove)
            { D6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD6 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD6 == "kocosan")
            {D6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD6 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D7_Click(object sender, RoutedEventArgs e)
{ if (GheD7 == "cosan" && sovedangchon < tongsove)
            { D7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD7 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD7 == "kocosan")
            {D7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD7 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D8_Click(object sender, RoutedEventArgs e)
{ if (GheD8 == "cosan" && sovedangchon < tongsove)
            { D8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD8 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD8 == "kocosan")
            {D8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD8 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D9_Click(object sender, RoutedEventArgs e)
{ if (GheD9 == "cosan" && sovedangchon < tongsove)
            { D9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD9 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD9 == "kocosan")
            {D9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD9 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D10_Click(object sender, RoutedEventArgs e)
{ if (GheD10 == "cosan" && sovedangchon < tongsove)
            { D10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD10 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD10 == "kocosan")
            {D10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD10 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D11_Click(object sender, RoutedEventArgs e)
{ if (GheD11 == "cosan" && sovedangchon < tongsove)
            { D11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD11 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD11 == "kocosan")
            {D11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD11 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void D12_Click(object sender, RoutedEventArgs e)
{ if (GheD12 == "cosan" && sovedangchon < tongsove)
            { D12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheD12 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheD12 == "kocosan")
            {D12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheD12 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E1_Click(object sender, RoutedEventArgs e)
{ if (GheE1 == "cosan" && sovedangchon < tongsove)
            { E1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE1 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE1 == "kocosan")
            {E1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE1 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E2_Click(object sender, RoutedEventArgs e)
{ if (GheE2 == "cosan" && sovedangchon < tongsove)
            { E2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE2 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE2 == "kocosan")
            {E2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE2 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E3_Click(object sender, RoutedEventArgs e)
{ if (GheE3 == "cosan" && sovedangchon < tongsove)
            { E3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE3 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE3 == "kocosan")
            {E3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE3 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E4_Click(object sender, RoutedEventArgs e)
{ if (GheE4 == "cosan" && sovedangchon < tongsove)
            { E4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE4 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE4 == "kocosan")
            {E4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE4 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E5_Click(object sender, RoutedEventArgs e)
{ if (GheE5 == "cosan" && sovedangchon < tongsove)
            { E5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE5 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE5 == "kocosan")
            {E5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE5 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E6_Click(object sender, RoutedEventArgs e)
{ if (GheE6 == "cosan" && sovedangchon < tongsove)
            { E6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE6 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE6 == "kocosan")
            {E6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE6 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E7_Click(object sender, RoutedEventArgs e)
{ if (GheE7 == "cosan" && sovedangchon < tongsove)
            { E7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE7 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE7 == "kocosan")
            {E7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE7 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E8_Click(object sender, RoutedEventArgs e)
{ if (GheE8 == "cosan" && sovedangchon < tongsove)
            { E8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE8 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE8 == "kocosan")
            {E8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE8 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E9_Click(object sender, RoutedEventArgs e)
{ if (GheE9 == "cosan" && sovedangchon < tongsove)
            { E9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE9 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE9 == "kocosan")
            {E9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE9 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E10_Click(object sender, RoutedEventArgs e)
{ if (GheE10 == "cosan" && sovedangchon < tongsove)
            { E10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE10 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE10 == "kocosan")
            {E10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE10 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E11_Click(object sender, RoutedEventArgs e)
{ if (GheE11 == "cosan" && sovedangchon < tongsove)
            { E11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE11 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE11 == "kocosan")
            {E11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE11 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void E12_Click(object sender, RoutedEventArgs e)
{ if (GheE12 == "cosan" && sovedangchon < tongsove)
            { E12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheE12 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheE12 == "kocosan")
            {E12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheE12 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F1_Click(object sender, RoutedEventArgs e)
{ if (GheF1 == "cosan" && sovedangchon < tongsove)
            { F1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF1 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF1 == "kocosan")
            {F1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF1 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F2_Click(object sender, RoutedEventArgs e)
{ if (GheF2 == "cosan" && sovedangchon < tongsove)
            { F2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF2 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF2 == "kocosan")
            {F2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF2 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F3_Click(object sender, RoutedEventArgs e)
{ if (GheF3 == "cosan" && sovedangchon < tongsove)
            { F3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF3 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF3 == "kocosan")
            {F3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF3 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F4_Click(object sender, RoutedEventArgs e)
{ if (GheF4 == "cosan" && sovedangchon < tongsove)
            { F4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF4 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF4 == "kocosan")
            {F4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF4 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F5_Click(object sender, RoutedEventArgs e)
{ if (GheF5 == "cosan" && sovedangchon < tongsove)
            { F5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF5 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF5 == "kocosan")
            {F5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF5 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F6_Click(object sender, RoutedEventArgs e)
{ if (GheF6 == "cosan" && sovedangchon < tongsove)
            { F6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF6 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF6 == "kocosan")
            {F6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF6 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F7_Click(object sender, RoutedEventArgs e)
{ if (GheF7 == "cosan" && sovedangchon < tongsove)
            { F7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF7 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF7 == "kocosan")
            {F7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF7 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F8_Click(object sender, RoutedEventArgs e)
{ if (GheF8 == "cosan" && sovedangchon < tongsove)
            { F8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF8 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF8 == "kocosan")
            {F8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF8 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F9_Click(object sender, RoutedEventArgs e)
{ if (GheF9 == "cosan" && sovedangchon < tongsove)
            { F9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF9 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF9 == "kocosan")
            {F9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF9 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F10_Click(object sender, RoutedEventArgs e)
{ if (GheF10 == "cosan" && sovedangchon < tongsove)
            { F10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF10 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF10 == "kocosan")
            {F10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF10 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F11_Click(object sender, RoutedEventArgs e)
{ if (GheF11 == "cosan" && sovedangchon < tongsove)
            { F11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF11 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF11 == "kocosan")
            {F11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF11 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void F12_Click(object sender, RoutedEventArgs e)
{ if (GheF12 == "cosan" && sovedangchon < tongsove)
            { F12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheF12 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheF12 == "kocosan")
            {F12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheF12 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void C7_Click(object sender, RoutedEventArgs e)
{ if (GheC7 == "cosan" && sovedangchon < tongsove)
            { C7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC7 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheC7 == "kocosan")
            {C7.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC7 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void C8_Click(object sender, RoutedEventArgs e)
{ if (GheC8 == "cosan" && sovedangchon < tongsove)
            { C8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC8 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheC8 == "kocosan")
            {C8.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC8 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void C9_Click(object sender, RoutedEventArgs e)
{ if (GheC9 == "cosan" && sovedangchon < tongsove)
            { C9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC9 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheC9 == "kocosan")
            {C9.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC9 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void C10_Click(object sender, RoutedEventArgs e)
{ if (GheC10 == "cosan" && sovedangchon < tongsove)
            { C10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC10 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheC10 == "kocosan")
            {C10.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC10 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void C11_Click(object sender, RoutedEventArgs e)
{ if (GheC11 == "cosan" && sovedangchon < tongsove)
            { C11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC11 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheC11 == "kocosan")
            {C11.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC11 = "cosan";
                sovedangchon -= 1;
            }
}
 private  void C12_Click(object sender, RoutedEventArgs e)
{ if (GheC12 == "cosan" && sovedangchon < tongsove)
            { C12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(56, 232, 72));
                GheC12 = "kocosan";
                sovedangchon  += 1;
            }
         else if (GheC12 == "kocosan")
            {C12.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 64, 64));
                GheC12 = "cosan";
                sovedangchon -= 1;
            }
}


 








    }
}
