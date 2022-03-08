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
using System.Windows.Shapes;

namespace Task6_7_
{
    /// <summary>
    /// Логика взаимодействия для AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sql = $"INSERT INTO Customer (Family, Address, Balance, TelephoneCs) " +
                $"VALUES ('{TextBoxFam.Text}', '{TextBoxAddress.Text}', {Convert.ToInt32(TextBoxBalance.Text)}, '{TextBoxNumber.Text}')";
            SqlConnection sqlConn = new SqlConnection(
            "server=DIAMONDPC;Trusted_Connection=Yes;DataBase=CustPostOrd;");
            sqlConn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
