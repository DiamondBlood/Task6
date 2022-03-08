using System;
using System.Collections.Generic;
using System.Data;
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

namespace Task6_7_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");

            SqlConnection sqlConnection = new SqlConnection("server=DIAMONDPC;Trusted_Connection=Yes;DataBase=CustPostOrd;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;

        }

        public DataTable data;
        public MainWindow()
        {
            InitializeComponent();
            data = Select("SELECT * FROM [dbo].[Customer]");
            DataCust.ItemsSource = data.DefaultView;

            data = Select("SELECT * FROM [dbo].[Providers]");
            DataProv.ItemsSource = data.DefaultView;

            data = Select("SELECT * FROM [dbo].[Orders]");
            DataOrd.ItemsSource = data.DefaultView;
        }


        private void BtCustUpdate_Click(object sender, RoutedEventArgs e)
        {
            CustomerUpd customerUpd = new CustomerUpd();
            
            customerUpd.Show();
            this.Close();
        }

        private void BtCustDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
            this.Close();
        }

        private void BtCustAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Close();
        }

        private void BtProvUpdate_Click(object sender, RoutedEventArgs e)
        {
            ProviderUpd providerUpd = new ProviderUpd();
            providerUpd.Show();
            this.Close();
        }

        private void BtProvDelete_Click(object sender, RoutedEventArgs e)
        {
            ProviderDelete providerDelete = new ProviderDelete();
            providerDelete.Show();
            this.Close();
        }

        private void BtProvAdd_Click(object sender, RoutedEventArgs e)
        {
            ProviderAdd providerAdd = new ProviderAdd();
            providerAdd.Show();
            this.Close();
        }

        private void BtOrdUpdate_Click(object sender, RoutedEventArgs e)
        {
            OrdUpdate ordUpdate = new OrdUpdate();
            ordUpdate.Show();
            this.Close();
        }

        private void BtOrdAdd_Click(object sender, RoutedEventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd();
            orderAdd.Show();
            this.Close();
        }

        private void BtOrdDelete_Click(object sender, RoutedEventArgs e)
        {
            OrdDelete ordDelete = new OrdDelete();
            ordDelete.Show();
            this.Close();
        }
    }
}
