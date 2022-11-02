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

namespace Payment
{
    /// <summary>
    /// Логика взаимодействия для Pays.xaml
    /// </summary>
    public partial class Pays : Window
    {
        public Pays()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Class_pays> result = new List<Class_pays>(6);
           
            grid_categ.ItemsSource = result;
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            Data_form data = new Data_form();
            data.Show();
            this.Close();


        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }
    }
}
