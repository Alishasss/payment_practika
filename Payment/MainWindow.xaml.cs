using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Payment
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      SqlConnection connect;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
           
        }

        //private void Authorization()
        //{
        //    bool success = false;
        //    try
        //    {
        //        const string command = "Select 100 From Users Where login = @login and password=@password";
        //        SqlCommand check = new SqlCommand(command, connect);
        //        check.Parameters.AddWithValue("@login", txt_name.Text);
        //        check.Parameters.AddWithValue("@password", txt_password.Text);
        //        connect.Open();
        //        using(var dataReader = check.ExecuteReader())
        //        {
        //            success = dataReader.Read();
        //        }
        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }
        //    if(success){
        //        Pays pay = new Pays();
        //        pay.ShowDialog();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Неверный логин или пароль");
        //    }
        //}
    }
}
