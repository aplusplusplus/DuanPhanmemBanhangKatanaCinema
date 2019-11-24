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
    /// Interaction logic for formTV.xaml
    /// </summary>
    public partial class formTV : Window
    {
        public formTV()
        {
            InitializeComponent();
        }

        private void btn_Huytv_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
