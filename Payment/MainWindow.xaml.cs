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
using System.Security.Cryptography;
using System.Data;

namespace Payment
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow mainWindow;
        SqlConnection connect;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void SHA()
        {
           

            User user;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passBytes = Encoding.UTF8.GetBytes(password.Text);
                byte[] hashBytes = sha256.ComputeHash(passBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                user = Instances.db.Users.Where(u => u.password == hash).ToList()[0];
            }


        }


        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
            //if (txt_name.Text.Length > 0)
            //{
            //    if(password.Password.Length>0)
            //    {
            //        DataTable dt_user = MainWindow.Select("Select * From [dbo].[Users] Where [login] = '" + txt_name.Text + "'AND [password] = '" + password.Password + "'");
            //    }
            //}
            Pays pays = new Pays();
            pays.Show();
            this.Close();
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
