using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Customer_mainNavigationPages;
using System.Collections.Generic;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class AppointmentAddPage : Form
    {
        //user.UserName variable
        private User _user = new User();
        Customer _customer = new Customer();
        private Appointment _appointment = new Appointment();
        private DateTime _appointmentStart = new DateTime();
        private DateTime _appointmentEnd = new DateTime();
        private DateTime _daySelected = DateTime.Today;

        public AppointmentAddPage(User user, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
            
            try
            {
                //Assign object attributes to read only fields
                AppointmentIdTextBox.Text = GetNextAppointmentId().ToString();
                CustomerIdTextBox.Text = _customer.CustomerId.ToString();
                UserIdTextBox.Text = _user.UserId.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Load CustomerDataGridView
            CustomerDataGridView.DataSource = _customer.GetAllCustomers();
            CustomerDataGridView.ClearSelection();
        }

        private void AddAppointmentPage_Load(object sender, EventArgs e)
        {
            //Assign object attributes to read only fields
            AppointmentIdTextBox.Text = GetNextAppointmentId().ToString();
            UserIdTextBox.Text = _user.UserId.ToString();

            /////////////////////////////////Populate AppointmentDataGridView////////////////////////
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
            /////////////////////////////////End AppointmentDataGridView/////////////////////////////

            /////////////////////////////Load CustomerDataGridView//////////////////////////////////
            MySqlDataAdapter custAdapter = new MySqlDataAdapter();
            DataTable custDt = new DataTable();

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

                //////////////////////////////End CustomerDataGridView/////////////////////////////////

            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
            appointmentNavigationPage.Show();
            this.Hide();
        }

        private void AppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assign appointment type to _appointment
            _appointment.Type = AppointmentTypeComboBox.Text;
        }

        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Start Time combo box changed" + _daySelected);
            //Set start time  to create a datetime object And account for timezone and dst
            _appointmentStart = Convert.ToDateTime(StartTimeComboBox.Text);
            StartTimeComboBox.Text = _appointmentStart.ToString("hh:mm:ss tt");

            //Set end appointment time to one hour after appointmentTime accounting for timezone and dst
            _appointmentEnd = _appointmentStart.AddHours(1);
            EndTimeComboBox.Text = _appointmentEnd.ToString("hh:mm:ss tt");
            //Console.WriteLine("Appointment End: " + _appointmentEnd);

            string startTime = _daySelected.ToString("yyyy-MM-dd") + " " + _appointmentStart.ToString("hh:mm:ss tt");
            string endTime = _daySelected.ToString("yyyy-MM-dd") + " " + _appointmentEnd.ToString("hh:mm:ss tt");
            
            Console.WriteLine("Start time: " + startTime);
            Console.WriteLine("End time: " + endTime);
        }

        private void EndTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Make sure the user can only pick from Monday through Friday
            if (AppointmentCalendar.SelectionRange.Start.DayOfWeek == DayOfWeek.Saturday || AppointmentCalendar.SelectionRange.Start.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Please select a Monday through Friday.");
            }
            else
            {
                //Assign _daySelected to the selected date
                _daySelected = AppointmentCalendar.SelectionRange.Start;
                Console.WriteLine(_daySelected);
            }
            AppointmentsDataGridView.DataSource = _appointment.GetAppointmentsByDate(_daySelected);
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerProfileButton_Click(object sender, EventArgs e)
        {
            //Make sure that a row has been selected
            if (CustomerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to view their profile.");
                return;
            }

            int customerId;
            //Otherwise, assign customerId cell to _customer.customerId
            customerId = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value);
            

            //Go to Customer Profile
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, customerId);
            customerProfilePage.Show();
            this.Hide();
        }

        //Method to get the next appointmentid that will be generated in the database
        private int GetNextAppointmentId()
        {
            //Create Connection Object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
            int appointmentId = 0;
            //Create query to select all appointments
            string selectQuery = $"SELECT appointmentId FROM appointment ORDER BY appointmentId DESC LIMIT 1";
            //Create command
            MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
            try
            {
                conn.Open();
                //Set the appointmentId to the first column of the first row of the result set
                appointmentId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Return the next appointmentid
            return appointmentId + 1;
        }

        private void CustomerSelectButton_Click(object sender, EventArgs e)
        {
            CustomerIdTextBox.Text = CustomerDataGridView.CurrentRow.Cells[0].Value.ToString();
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

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            //If no cell is selected, have pop up box stating to select row
            if (AppointmentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }
            //Otherwise, delete the selected appointment
            else
            {
                //Get the appointmentId from the selected row
                int appointmentId = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value);
                //Delete the appointment from the database
                _appointment.DeleteAppointment(appointmentId);
                //Refresh the AppointmentDataGridView
                AppointmentsDataGridView.DataSource = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);
                AppointmentsDataGridView.Refresh();
            }
        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// ///////////////////////////Submit Button Click Event///////////////////////////
        /// </summary>
        /// ///////////////////////////////////////////////////////////////////////////////
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Make sure all of the textboxes are filled out
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text) || string.IsNullOrWhiteSpace(LocationTextBox.Text) || string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(AppointmentTypeComboBox.Text) || string.IsNullOrWhiteSpace(StartTimeComboBox.Text) || string.IsNullOrWhiteSpace(EndTimeComboBox.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            //Assign textboxes to _appointment attributes
            _appointment.AppointmentId = Convert.ToInt32(AppointmentIdTextBox.Text);
            _appointment.UserId = Convert.ToInt32(UserIdTextBox.Text);
            _appointment.CustomerId = Convert.ToInt32(CustomerIdTextBox.Text);
            _appointment.Title = TitleTextBox.Text;
            _appointment.Description = DescriptionTextBox.Text;
            _appointment.Location = LocationTextBox.Text;
            _appointment.Contact = ContactTextBox.Text;
            _appointment.Type = AppointmentTypeComboBox.Text;

            ///////Appointment Start and End Times/////////////
            //Calculate based on timezone and dst
            _appointmentStart = Convert.ToDateTime(StartTimeComboBox.Text);
            _appointmentStart = TimeZoneInfo.ConvertTimeToUtc(_appointmentStart, TimeZoneInfo.Local);
            //Convert to my timezone

            _appointmentEnd = Convert.ToDateTime(EndTimeComboBox.Text);
            _appointmentEnd = TimeZoneInfo.ConvertTimeToUtc(_appointmentEnd, TimeZoneInfo.Local);

            Console.WriteLine("TimeZoneInfo Appointment Start: " + _appointmentStart);
            Console.WriteLine("TimeZoneInfo Appointment End: " + _appointmentEnd);

            string startTime = _daySelected.ToString("yyyy-MM-dd") + " " + _appointmentStart.ToString("hh:mm:ss tt");
            string endTime = _daySelected.ToString("yyyy-MM-dd") + " " + _appointmentEnd.ToString("hh:mm:ss tt");
            Console.WriteLine("Starttime: " + startTime);
            Console.WriteLine("Endtime: " + endTime);
            _appointment.Start = Convert.ToDateTime(startTime);
            _appointment.End = Convert.ToDateTime(endTime);
            Console.WriteLine(_appointment.Start);
            Console.WriteLine(_appointment.End);
            ///////End Appointment Start and End Times///////
            _appointment.CreateDate = DateTime.Now;
            _appointment.CreatedBy = _user.UserName;
            _appointment.LastUpdate = DateTime.Now;
            _appointment.LastUpdateBy = _user.UserName;

            //Otherwise, call insert address method
            _appointment.AppointmentId = _appointment.InsertAppointment(_appointment);
            if (_appointment.AppointmentId == 0)
            {
                MessageBox.Show("Appointment was not added.");
            }
            else
            {
                //Return to Appointment Navigation Page
                MessageBox.Show("Appointment was added.");
                AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
                appointmentNavigationPage.Show();
                this.Hide();
            }

        }
    }
}
