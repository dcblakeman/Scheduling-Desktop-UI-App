using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Customer_mainNavigationPages;
using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using Scheduling_Desktop_UI_App.Classes;
using Scheduling_Desktop_UI_App.User_Navigation_Pages;

namespace Scheduling_Desktop_UI_App
{
    public partial class CustomerNavigationPage : Form
    {
        private User _user = new User();
        private Customer _customer = new Customer();

        //Create connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

        public CustomerNavigationPage()
        {
            InitializeComponent();
            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
            CustomerDataGridView.Rows[0].Selected = false;
        }

        public CustomerNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
            CustomerDataGridView.Rows[0].Selected = false;
        }

        public CustomerNavigationPage(User user, Customer customer)
        {
            //Refresh page
            InitializeComponent();
            _user = user;
            _customer = customer;
            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
            CustomerDataGridView.Rows[0].Selected = false;
        }

        private void NavigationFormButton_Click(object sender, EventArgs e)
        {
            MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
            mainNavigationPage.Show();
            this.Hide();
        }
        private void CustomerNavigationPage_Load(object sender, EventArgs e)
        {
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
            if (_customer.CustomerId == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }
            //Pass customer object to updatecustomerpage
            CustomerUpdatePage updateCustomerPage = new CustomerUpdatePage(_customer, _user);
            updateCustomerPage.Show();
            this.Hide();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            _customer.DeleteCustomer(_customer);

        }

        private void MainNavigationPageButton_Click(object sender, EventArgs e)
        {
            //If a customer has been selected, pass the customer to the main navagation page object too
            if (_customer.CustomerId != 0)
            {
                MainNavigationPage mainNavigationPage = new MainNavigationPage(_user, _customer);
                mainNavigationPage.Show();
                this.Hide();
                return;
            } else
            {
                //Return to main page
                MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
                mainNavigationPage.Show();
                this.Hide();
            }

        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow clickedRow = CustomerDataGridView.Rows[e.RowIndex];
                // Safely convert and assign values to a Customer instance
                _customer.CustomerId = Convert.ToInt32(clickedRow.Cells[0].Value);
                _customer.CustomerName = Convert.ToString(clickedRow.Cells[1].Value);
                _customer.AddressId = Convert.ToInt32(clickedRow.Cells[2].Value);
                _customer.Active = Convert.ToInt32(clickedRow.Cells[3].Value);
                _customer.LastUpdate = Convert.ToDateTime(clickedRow.Cells[4].Value);
                _customer.LastUpdateBy = Convert.ToString(clickedRow.Cells[5].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerProfileButton_Click(object sender, EventArgs e)
        {
            
         
        }
        private void AppointmentNavigationPageButton_Click(object sender, EventArgs e)
        {
            if(_customer.CustomerId == 0)
            {
                MessageBox.Show("Please select a customer to schedule an appointment.");
                return;
            }
            //Go to AppointmentNavigationPage
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user, _customer);
            appointmentNavigationPage.Show();
            this.Hide();
        }
    }
}
