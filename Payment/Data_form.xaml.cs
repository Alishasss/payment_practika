using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Payment
{
    /// <summary>
    /// Логика взаимодействия для Data_form.xaml
    /// </summary>
    public partial class Data_form : Window
    {
        public Data_form()
        {
            InitializeComponent();
        }

        

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            Pays pay = new Pays();
            pay.Show();
            this.Close();
        }
    }
}
