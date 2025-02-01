using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Appointment_Navigation_Pages;
using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App
{
    public partial class AppointmentNavigationPage : Form
    {
        //Create connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

        //User object
        User _user;
        Customer _customer = new Customer();
        //Appointment date selected
        Appointment _appointment = new Appointment();
        DateTime _daySelected = DateTime.Today;
        CustomerDemographics customerAppointmentTable = new CustomerDemographics();
        AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();

        //Create object to hold selected appointmentdatagridview row
        //Appointment _appointment;

        public AppointmentNavigationPage()
        {
            InitializeComponent();
        }
        public AppointmentNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
        }
        public AppointmentNavigationPage(User user, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
            
        }
        public AppointmentNavigationPage(User user, Appointment appointment, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _appointment = appointment;
            _customer = customer;
        }


        private void AppointmentNavigationPage_Load(object sender, EventArgs e)
        {
            PopulateAppointmentDataGridView();

            PopulateCustomerDataGridView();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            if(_customer.CustomerId == 0)
             {
                //Have a pop up box say "please select customer in data grid and then click 'select customer'"
                MessageBox.Show("Please select a customer to schedule an appointment.");
                return;
            } else
            {
                    AppointmentAddPage appointmentAddPage = new AppointmentAddPage(_user, _customer);
                    appointmentAddPage.Show();
                    this.Hide();
            }
        }
        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            //Make sure an appointment has been selected
            if (AppointmentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to update");
                return;
            }
            //Assign text boxes to appointment object fields
            _appointment.AppointmentId = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value);
            _appointment.CustomerId = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[1].Value);
            _appointment.UserId = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[2].Value);
            _appointment.Title = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[3].Value);
            _appointment.Description = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[4].Value);
            _appointment.Location = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[5].Value);
            _appointment.Contact = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[6].Value);
            _appointment.Type = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[7].Value);
            _appointment.Url = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[8].Value);
            _appointment.Start = Convert.ToDateTime(AppointmentsDataGridView.CurrentRow.Cells[9].Value);
            _appointment.End = Convert.ToDateTime(AppointmentsDataGridView.CurrentRow.Cells[10].Value);
            _appointment.CreateDate = Convert.ToDateTime(AppointmentsDataGridView.CurrentRow.Cells[11].Value);
            _appointment.CreatedBy = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[12].Value);
            _appointment.LastUpdate = Convert.ToDateTime(AppointmentsDataGridView.CurrentRow.Cells[13].Value);
            _appointment.LastUpdateBy = Convert.ToString(AppointmentsDataGridView.CurrentRow.Cells[14].Value);
            //Go to Update Appointment Page
            AppointmentUpdatePage appointmentUpdatePage = new AppointmentUpdatePage(_user, _appointment, _customer);
            appointmentUpdatePage.Show();
            this.Hide();
        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            int value;
            try
            {
                //Make sure a row is selected from AppointmentsDtaGridView
                if (AppointmentsDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete");
                    return;
                }
                else
                {
                    value = _appointment.DeleteAppointment(Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value));
                    //Refresh data grid view
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    adapter = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);
                    adapter.Fill(dt);
                    AppointmentsDataGridView.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void MainNavigationPageButton_Click(object sender, EventArgs e)
        {
            //Go to main nagivation page
            MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
            mainNavigationPage.Show();
            this.Hide();
        }

        private void AppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Assign appointmentcalendarselection to _daySelected
            _daySelected = AppointmentCalendar.SelectionRange.Start;

            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.DataSource = null;

            ///////////Populate AppointmentDataGridView with appointments/////////////////
            //////////////////////scheduled for the selected date/////////////////////////
            
            //Create new adapter and data table objects
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            //Call Populate Data Grid View Method
            adapter = _appointment.GetAppointmentsByDate(_daySelected);

            //Fill Adapter with data table information.
            adapter.Fill(dt);

            //Assign data table information to the data grid view
            AppointmentsDataGridView.DataSource = dt;

            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.Refresh();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            //Go to customer navigation page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();

        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void PopulateCustomerDataGridView()
        {
            /////////////////////////////Load CustomerDataGridView//////////////////////////////////
            MySqlDataAdapter custAdapter = new MySqlDataAdapter();
            DataTable custDt = new DataTable();

            //Console.WriteLine("Customer: " + _customer.CustomerId);
            //Call Populate Data Grid View Method
            custAdapter = _customer.GetAllCustomers();

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

        private void PopulateAppointmentDataGridView()
        {
            //Populate AppointmentDataGridView with appointments scheduled for the selected date
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            //Call Populate Data Grid View Method
            adapter = _appointment.GetAppointmentsByDate(_daySelected);

            //Fill The Data table with adapter information
            adapter.Fill(dt);

            //Assign data table to the data grid view
            AppointmentsDataGridView.DataSource = dt;

            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.Refresh();
        }

        private void CustomerNavigationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SelectCustomerButton_Click(object sender, EventArgs e)
        {
            //Make sure a row is selected from CustomerDataGridView
            if (CustomerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }

            ////////Populate the AppointmentDataGridView with selected customer's appointments//////////
            _customer.CustomerId = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value);

            //Create new adapter and data table objects
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            AppointmentsDataGridView.DataSource = null;

            //Return customer appointments to adapter and fill data tables
            adapter = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);
            adapter.Fill(dt);

            //Assign data table information to the data grid view
            AppointmentsDataGridView.DataSource = dt;
        }

        private void CustomerProfile_Click(object sender, EventArgs e)
        {
            //Assign selected customerId to object
            _customer.CustomerId = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value);

            //Go to customer profile page
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, _customer.CustomerId);
            customerProfilePage.Show();
            this.Hide();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            int value;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                //Make sure a row is selected from CustomerDataGridView
                if (CustomerDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete");
                    return;
                }
                else
                {
                    //Delete customer
                    _customer.CustomerId = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value);
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
            }//End Delete Customer Block
        }//End Delete Customer Event
    }
}
