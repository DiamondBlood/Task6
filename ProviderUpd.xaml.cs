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
    /// Логика взаимодействия для ProviderUpd.xaml
    /// </summary>
    public partial class ProviderUpd : Window
    {
        public ProviderUpd()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string sql = $"UPDATE Providers SET Commodity = '{TextBoxStuff.Text}', Name = '{TextBoxName.Text}', Address = '{TextBoxAddress.Text}', Price = {Convert.ToInt32(TextBoxCost.Text)}, TelephonePr = '{TextBoxNumber.Text}' WHERE IdPs = {Convert.ToInt32(TextBoxId.Text)}";
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
    }
}
