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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

                this.txt_tdn.Focus();
        }

        private void btn_dangnhap_Click(object sender, RoutedEventArgs e)
        {
            string dangnhap = this.txt_tdn.Text;
            string matkhau = this.psw_matkhau.Password;

            if (dangnhap == "admin" && matkhau == "123")
            {
                Loginwindow.Close();
                TurnOn();
                
            }
               
            else
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại!!");

        }
        private void TurnOn()
        {
            LichChieu phim = new LichChieu();
            phim.ShowDialog();
        }

        private void btn_thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainform = new MainWindow();
            mainform.ShowDialog();
        }



    }
}
