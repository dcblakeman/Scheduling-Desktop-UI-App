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

        public CustomerNavigationPage()
        {
            InitializeComponent();
            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
        }

        public CustomerNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
        }

        public CustomerNavigationPage(User user, Customer customer)
        {
            //Initialize page
            InitializeComponent();
            _user = user;
            _customer = customer;

            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
        }

        private void NavigationFormButton_Click(object sender, EventArgs e)
        {
            MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
            mainNavigationPage.Show();
            this.Hide();
        }
        private void CustomerNavigationPage_Load(object sender, EventArgs e)
        {
            /////////////////////////////Load CustomerDataGridView//////////////////////////////////
            MySqlDataAdapter custAdapter = new MySqlDataAdapter();
            DataTable custDt = new DataTable();

            //Console.WriteLine("Customer: " + _customer.CustomerId);
            //Call Populate Data Grid View Method
            custAdapter = GetAllCustomers();

            //Fill DataTable with customerAdapter information
            custAdapter.Fill(custDt);

            //Assign data table to the data grid view
            CustomerDataGridView.DataSource = custDt;

            //Allow Active column to be editable
            CustomerDataGridView.Columns["active"].ReadOnly = false;

            //Refresh CustomerDataGridView
            CustomerDataGridView.Refresh();            
            
            // Disable editing on all other columns
            foreach (DataGridViewColumn column in CustomerDataGridView.Columns)

            {

                if (column.Name != "active")

                {

                    column.ReadOnly = true;

                }

            }
            //////////////////////////////End CustomerDataGridView/////////////////////////////////
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
            int value;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Make sure a row is selected from CustomerDataGridView
                if (CustomerDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete");
                    return;
                }
                else
                {
                    //Check to see if the customer has any appointments that need to be deleted first.
                    //Delete customer
                    _customer.CustomerId = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value);
                    try
                    {
                        //Check to see if the customer has any appointments
                        if (_customer.HasAppointments(_customer.CustomerId))
                        {
                            MessageBox.Show("This customer has appointments and cannot be deleted.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                        value = _customer.DeleteCustomer(_customer.CustomerId);
                    //Refresh data grid view
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    adapter = _customer.GetAllCustomers();
                    adapter.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                    if (value == 1)
                    {
                        MessageBox.Show("Customer deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Customer not deleted");
                    }

                }
            }//End Delete Customer Method

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
            //Make sure that a row has been selected
            if (_customer.CustomerId == 0)
            {
                MessageBox.Show("Please select a customer to view their profile.");
                return;
            }
            //Sending the customer object to the customer profile page
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, _customer.CustomerId);
            customerProfilePage.Show();
            this.Hide();
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
        public MySqlDataAdapter GetAllCustomers()
        {
            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
            //Create data adapter object
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Create query string
            string getAllCustomersQuery = "SELECT * FROM customer";
            //Create command
            MySqlCommand cmd = new MySqlCommand(getAllCustomersQuery, conn);
            //Open connection
            conn.Open();
            cmd.CommandText = getAllCustomersQuery;
            conn.Close();
            //Assign command to adapter
            adapter.SelectCommand = cmd;
            return adapter;
        }

        private void SelectCustomerButton_Click(object sender, EventArgs e)
        {
            //Make sure a row is selected from CustomerDataGridView
            if (CustomerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }

            /////////////Assign CustomerId value from data grid view to customer object////////////
            _customer.CustomerId = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value);
        }
    }
}
