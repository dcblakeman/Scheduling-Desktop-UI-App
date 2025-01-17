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
        private User _user;
        Customer customer;
        //Create connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

        public CustomerNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public CustomerNavigationPage()
        {
        }

        private void NavigationFormButton_Click(object sender, EventArgs e)
        {
            MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
            mainNavigationPage.Show();
            this.Hide();

        }
        private void CustomerNavigationPage_Load(object sender, EventArgs e)
        {
            //Open connection
            conn.Open();
            //Create query to populate datagridview
            string query = "SELECT * FROM customer";
            //Create command
            MySqlCommand cmd = new MySqlCommand(query, conn);
            //Create data adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //Create dataset
            DataSet ds = new DataSet();
            //Fill dataset
            adapter.Fill(ds);
            //Set datagridview data source to dataset
            CustomerDataGridView.DataSource = ds.Tables[0];
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerAddPage addCustomerPage = new CustomerAddPage(_user);
            addCustomerPage.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
 
        }

        private void MainNavigationPageButton_Click(object sender, EventArgs e)
        {
            //Return to main page
            MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
            mainNavigationPage.Show();
            this.Hide();
        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select record in datagridview
            customer = new Customer();
            customer.CustomerId = Convert.ToInt32(CustomerDataGridView.SelectedRows[0].Cells[0].Value);
            customer.CustomerName = CustomerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            customer.AddressId = Convert.ToInt32(CustomerDataGridView.SelectedRows[0].Cells[2].Value);
            customer.Active = Convert.ToInt32(CustomerDataGridView.SelectedRows[0].Cells[3].Value);
            customer.LastUpdate = Convert.ToDateTime(CustomerDataGridView.SelectedRows[0].Cells[4].Value);
            customer.LastUpdateBy = CustomerDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
