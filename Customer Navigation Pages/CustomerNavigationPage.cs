using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Customer_mainNavigationPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Scheduling_Desktop_UI_App.Classes;

namespace Scheduling_Desktop_UI_App
{
    public partial class CustomerNavigationPage : Form
    {
        string userName;
        public CustomerNavigationPage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        public CustomerNavigationPage()
        {
        }

        private void NavigationFormButton_Click(object sender, EventArgs e)
        {
            MainNavigationPage mainNavigationPage = new MainNavigationPage(userName);
            mainNavigationPage.Show();
            this.Hide();

        }
        private void CustomerNavigationPage_Load(object sender, EventArgs e)
        {
            // Retrieve the connection string from the App.config file
            string connectionString = ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString;

            //Create query to populate datagridview
            string query = "SELECT * FROM customer"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    customerDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerPage addCustomerPage = new AddCustomerPage(userName);
            addCustomerPage.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
