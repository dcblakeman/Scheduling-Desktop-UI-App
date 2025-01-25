using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Customer_mainNavigationPages;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class AppointmentAddPage : Form
    {
        //user.UserName variable
        private User _user;
        private Customer _customer = new Customer();
        private Appointment _appointment = new Appointment();
        private DateTime _appointmentStart = new DateTime();
        private DateTime _appointmentEnd = new DateTime();
        //Create Connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
        private Address _address;
        private City _city;
        private Country _country;
        private User user;
        private Customer customer;

        public AppointmentAddPage(User user, Customer customer, Address address, City city, Country country)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
            _address = address;
            _city = city;
            _country = country;

            //Show Today Method
            ShowToday();
        }

        public AppointmentAddPage(User user, Customer customer)
        {
            this.user = user;
            this.customer = customer;
        }

        private void AddAppointmentPage_Load(object sender, EventArgs e)
        {
            //Assign object attributes to read only fields
            AppointmentIdTextBox.Text = GetNextAppointmentId().ToString();
            CustomerIdTextBox.Text = _customer.CustomerId.ToString();
            UserIdTextBox.Text = _user.UserId.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
            appointmentNavigationPage.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Make sure all of the textboxes are filled out
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text) || string.IsNullOrWhiteSpace(LocationTextBox.Text) || string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(AppointmentTypeComboBox.Text) || string.IsNullOrWhiteSpace(StartTimeComboBox.Text) || string.IsNullOrWhiteSpace(EndTimeTextBox.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
        }

        private void UpcomingAppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpcomingAppointmentsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Show what date is clicked in the console
            Console.WriteLine(AppointmentCalendar.SelectionRange.Start);

            try
            {
                //Populate the UpcomingAppointmentsDataGridView with the appointments scheduled for the date clicked
                AppointmentsDataGridView.DataSource = null;
                //Convert that time to mysql format
                string selectedDate = AppointmentCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
                //Create query to select all appointments
                string selectQuery = $"SELECT * FROM appointment WHERE start = '{selectedDate}'";
                //Create command
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //Create a dataset
                DataSet ds = new DataSet();
                //Fill the dataset
                adapter.Fill(ds);
                //Set the data source of the data grid view to the dataset
                AppointmentsDataGridView.DataSource = ds.Tables[0];
                //Refresh datagridview
                AppointmentsDataGridView.Refresh();

            } catch(Exception ex)
            {
                //Write exception to console
                Console.WriteLine(ex.Message);
                //Allow user to proceed without error message
                AppointmentsDataGridView.DataSource = null;
            }
            
        }

        private void AppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combine the date from the monthlycalendar and the time from the combobox to create a datetime object
            _appointmentStart = Convert.ToDateTime(AppointmentCalendar.SelectionRange.Start.ToShortDateString() + " " + StartTimeComboBox.Text);

            //Set end appointment time to one hour after appointmentTime
            _appointmentEnd = _appointmentStart.AddHours(1);

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
                //AppointmentsDataGridView.DataSource = _appointment.GetDayAppointments(AppointmentCalendar.SelectionRange.Start);
            }
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerProfileButton_Click(object sender, EventArgs e)
        {
            //Go to Customer Profile
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, _customer, _address, _city, _country);
            customerProfilePage.Show();
            this.Hide();
        }

        //Method that starts with today's date selected on the appointment calendar and today's appointments showing in the appointment datagridview
        private void ShowToday()
        {
            //Set appointment calendar to today's date
            AppointmentCalendar.SetDate(DateTime.Now);
            //Populate the UpcomingAppointmentsDataGridView with the appointments scheduled for today
            AppointmentsDataGridView.DataSource = null;
            //Convert that time to mysql format
            string selectedDate = AppointmentCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            //Create query to select all appointments
            string selectQuery = $"SELECT * FROM appointment WHERE start = '{selectedDate}'";
            //Create command
            MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
            //Create data adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //Create a dataset
            DataSet ds = new DataSet();
            //Fill the dataset
            adapter.Fill(ds);
            //Set the data source of the data grid view to the dataset
            AppointmentsDataGridView.DataSource = ds.Tables[0];
            //Refresh datagridview
            AppointmentsDataGridView.Refresh();
        }

        //Method to get the next appointmentid that will be generated in the database
        private int GetNextAppointmentId()
        {
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
    }
}
