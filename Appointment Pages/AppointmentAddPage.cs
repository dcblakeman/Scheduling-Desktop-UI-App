using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Customer_mainNavigationPages;
using System.Collections.Generic;
using System.Device.Location;
using System.Globalization;
using System.Data.Common;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Collections.Specialized;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using NUglify.Helpers;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class AppointmentAddPage : Form
    {
        //user.UserName variable
        private User _user = new User();
        Customer _customer = new Customer();
        Address _address = new Address();
        City _city = new City();
        Country _country = new Country();
        private Appointment _appointment = new Appointment();
        private DateTime _appointmentStart = new DateTime();
        private DateTime _appointmentEnd = new DateTime();
        private DateTime _daySelected = DateTime.Today;
        List<String> _timesList = new List<String>();
        TimeZoneInfo _timeZone;
        DateTime _startEasternDateTime;
        DateTime _startLocalDateTime;
        DateTime _endEasternDateTime;
        DateTime _endLocalDateTime;

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

        private void AppointmentAddPage_Load(object sender, EventArgs e)
        {
            //Assign object attributes to read only fields
            AppointmentIdTextBox.Text = GetNextAppointmentId().ToString();
            UserIdTextBox.Text = _user.UserId.ToString();
            CustomerIdTextBox.Text = _customer.CustomerId.ToString();

            _timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            Console.WriteLine("TimeZone: " + _timeZone.StandardName);
            //Assign _daySelected to the selected date
            //_daySelected = AppointmentCalendar.SelectionRange.Start;
            _timesList = GetTimeZoneTimes(_timeZone);
            Console.WriteLine("Day Selected: " + _daySelected);

            /////////////////////////////////Populate AppointmentDataGridView////////////////////////
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter = _appointment.GetAppointmentsByDate(_daySelected);
            adapter.Fill(dt);
            AppointmentsDataGridView.DataSource = dt;

            //Then remove those times from the times list
            foreach (DataGridViewRow row in AppointmentsDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    _timesList.Remove(row.Cells[9].Value.ToString());
                }
            }

            //Assign the times list to the start field
            StartTimeComboBox.DataSource = new BindingSource(_timesList, null);


            /////////////////////////////////End AppointmentDataGridView/////////////////////////////

            /////////////////////////////Load CustomerDataGridView//////////////////////////////////
            MySqlDataAdapter custAdapter = new MySqlDataAdapter();
            DataTable custDt = new DataTable();
            custAdapter = GetAllCustomers();
            custAdapter.Fill(custDt);
            CustomerDataGridView.DataSource = custDt;
            CustomerDataGridView.Columns["active"].ReadOnly = false;
            CustomerDataGridView.Refresh();

            //Disable editing in customerdatagridview except for active column
            foreach (DataGridViewColumn column in CustomerDataGridView.Columns) 
            {
                if (column.Name != "active"){column.ReadOnly = true;}
            }
            //////////////////////////////End CustomerDataGridView/////////////////////////////////
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
        /// <summary>
        /// /////////////////////////////LocationComboBox//////////////////////////////
        //////////////////
        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Time Zone Abbreviation Conditional
            if (LocationComboBox.Text == "Phoenix")
            {
                if (_daySelected.IsDaylightSavingTime())
                {
                    _timeZone = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
                    Console.WriteLine("Daylight Time Zone: " + _timeZone.Id);
                }
                else
                {
                    _timeZone = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
                    Console.WriteLine("Standard Time Zone: " + _timeZone.Id);
                }

                Console.WriteLine("TimeZone: " + _timeZone.StandardName);
                Console.WriteLine("TimeZone: " + _timeZone.DisplayName);
                Console.WriteLine("TimeZone: " + _timeZone.ToString());
                Console.WriteLine("TimeZone: " + _timeZone.DisplayName);
                Console.WriteLine("TimeZone: " + _timeZone.DisplayName);
                Console.WriteLine("TimeZone: " + _timeZone.DisplayName);
                Console.WriteLine("TimeZone: " + _timeZone.DisplayName);

            }
            else if (LocationComboBox.Text == "London")
            {
                _timeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            }
            else
            {
                _timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            }

            //Called GetTimeZoneTimes to get appoiontment times
            _timesList = GetTimeZoneTimes(_timeZone);

            //Assigned the starttimecombobox to a source
            StartTimeComboBox.DataSource = _timesList;

            //Derive eastern and local endtime for endtimetext box
            String[] times = StartTimeComboBox.Text.Split('/');
            Console.WriteLine(StartTimeComboBox.Text);
            Console.WriteLine(times[0] + " " + times[1]);

            //Grab substring to parse to datetime object
            DateTime endEasternDateTime = DateTime.Parse(times[0].Substring(0, 11)).AddHours(1);
            DateTime endLocalDateTime = DateTime.Parse(times[1].Substring(1, 11).Trim()).AddHours(1);

            //Assign both times to the endtimecombobox
            //EndTimeComboBox.Text = endEasternDateTime.ToString("hh:mm:ss tt") + " EST / " + endLocalDateTime.ToString("hh:mm:ss tt") + " " + _timeZone.StandardName ;
        } // End LocationComboBox Event Handler
        private void AppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Assign _daySelected to the selected date
            _daySelected = AppointmentCalendar.SelectionRange.Start;
            _timesList = GetTimeZoneTimes(_timeZone);

            foreach (DataGridViewRow row in AppointmentsDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    _timesList.Remove(row.Cells[9].Value.ToString());
                }
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter = _appointment.GetAppointmentsByDate(_daySelected);
            adapter.Fill(dt);
            AppointmentsDataGridView.DataSource = dt;
            //Populate start time combo box with available times
            StartTimeComboBox.DataSource = new BindingSource(_timesList, null);
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
        public List<String> GetTimeZoneTimes(TimeZoneInfo timeZone)
        {
            Console.WriteLine("TimeZone: " +  timeZone);
            Console.WriteLine("DateSelected: " + _daySelected);
            
            ///////////////////////Format Times Block////////////////////////
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            dtfi.TimeSeparator = ":";

            /////////////////////String Time Objects//////////////////////////////
            String easternTimeString;
            String mountainTimeString;
            String greenwichTimeString;
  
            ///////////////////////Time Zone Times Lists///////////////////
            List<String> easternTimes = new List<String>();
            List<String> mountainTimes = new List<String>();
            List<String> greenwichTimes = new List<String>();

            ///////////////////////Formatted Combined Lists////////////////////
            List<String> easternAndEasternList = new List<String>();
            List<String> easternAndMountainList = new List<String>();
            List<String> easternAndGreenwichList = new List<String>();

            ///////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////For Loop to Assign Times to Lists////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////
            for (int hour = 9; hour < 17; hour++)
            {
                //Getting time zone datetime objects
                DateTime easternTime = new DateTime(_daySelected.Year, _daySelected.Month, _daySelected.Day, hour, 0, 0);
                Console.WriteLine("Eastern Time: " + easternTime);
                DateTime mountainTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(easternTime, "Eastern Standard Time", "US Mountain Standard Time");
                DateTime greenwichTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(easternTime, "Eastern Standard Time", "GMT Standard Time");
                //DateTime mountainTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(easternTime, "Eastern Standard Time", timeZoneString);
                //DateTime greenwichTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(easternTime, "Eastern Standard Time", timeZoneString);

                //Convert the datetime objects to string
                easternTimeString = easternTime.ToString("hh:mm:ss tt");
                mountainTimeString = mountainTime.ToString("hh:mm:ss tt");
                greenwichTimeString = greenwichTime.ToString("hh:mm:ss tt");

                //Add the time string to it's respective list 
                easternTimes.Add(easternTimeString);
                mountainTimes.Add(mountainTimeString);
                greenwichTimes.Add(greenwichTimeString);

                //Combine and add to respective lists
                easternAndMountainList.Add(easternTimeString + " EST / " + mountainTimeString + " MST");
                easternAndGreenwichList.Add(easternTimeString + " EST / " + greenwichTimeString + " GMT");
                easternAndEasternList.Add(easternTimeString + " EST / " + easternTimeString + " EST");
            }

            Console.WriteLine("Time Zone: " + _timeZone);
            //////////////////////Switch Block for location////////////////////////////
            if(_timeZone.ToString() == "(UTC-07:00) Arizona")
            {
                return easternAndMountainList;
            }
            else if (_timeZone.ToString() == "(UTC+00:00) Dublin, Edinburgh, Lisbon, London")
            {
                return easternAndGreenwichList;
            }
            else
            {
                return easternAndEasternList;
            }
        }
        private MySqlDataAdapter GetTakenAppointmentTimes(DateTime daySelected)
        {
            // When a date is clicked, populate the appointment times combobox with any appointments that have been made on that day by a specific user
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string getAppointmentTimesQuery = "SELECT * FROM appointment WHERE start = @start AND userId = @userId";
            MySqlCommand cmd = new MySqlCommand(getAppointmentTimesQuery, conn);
            cmd.Parameters.AddWithValue("@start", daySelected);
            cmd.Parameters.AddWithValue("@userId", _user.UserId);
            conn.Open();
            cmd.CommandText = getAppointmentTimesQuery;
            conn.Close();
            adapter.SelectCommand = cmd;
            return adapter;
            //Also, set the dropdown list to the remaining appointment times available.
        }
        //////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////Submit Button Click Event///////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Make sure all of the textboxes are filled out
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text) || string.IsNullOrWhiteSpace(LocationComboBox.Text) || string.IsNullOrWhiteSpace(ContactTextBox.Text) || string.IsNullOrWhiteSpace(AppointmentTypeComboBox.Text) || string.IsNullOrWhiteSpace(StartTimeComboBox.Text) || string.IsNullOrWhiteSpace(EndTimeComboBox.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (AppointmentCalendar.SelectionRange.Start.DayOfWeek == DayOfWeek.Saturday || AppointmentCalendar.SelectionRange.Start.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Please select a Monday through Friday.");
                return;
            }

            //TimeZoneInfo customerTimeZone = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");

            //Assign textboxes to _appointment attributes
            _appointment.AppointmentId = Convert.ToInt32(AppointmentIdTextBox.Text);
            _appointment.UserId = Convert.ToInt32(UserIdTextBox.Text);
            _appointment.CustomerId = Convert.ToInt32(CustomerIdTextBox.Text);
            _appointment.Title = TitleTextBox.Text;
            _appointment.Description = DescriptionTextBox.Text;
            _appointment.Location = LocationComboBox.Text;
            _appointment.Contact = ContactTextBox.Text;
            _appointment.Type = AppointmentTypeComboBox.Text;

            ///////Appointment Start and End Times/////////////
            //Split up the Start Time using substring
            Console.WriteLine(StartTimeComboBox.Text.Substring(0, 10));
            _appointmentStart = Convert.ToDateTime(_startEasternDateTime);
            _appointmentEnd = Convert.ToDateTime(_endEasternDateTime);

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
        }//End Submit Button Method

        private void StartTimeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            //Derive eastern and local endtime for endtimetext box
            String[] times = StartTimeComboBox.Text.Split('/');
            Console.WriteLine(StartTimeComboBox.Text);
            Console.WriteLine(times[0] + " " + times[1]);

            //Get the timezone abbreviation
            string easternTimeTimeZone = times[0].Trim().Substring(12, 3);
            string localTimeTimeZone = times[1].Trim().Substring(12, 3);


            //Assign StartTimeComboBox to the start time
            StartTimeComboBox.Text = _startEasternDateTime.ToString("hh:mm:ss tt") + " " + easternTimeTimeZone + " / " + _startLocalDateTime.ToString("hh:mm:ss tt") + " " + localTimeTimeZone;

            //Grab substring to parse to datetime object
            _startEasternDateTime = DateTime.Parse(times[0].Substring(0, 11));
            _startLocalDateTime = DateTime.Parse(times[1].Substring(1, 11));
            _endEasternDateTime = _startEasternDateTime.AddHours(1);
            _endLocalDateTime = _startLocalDateTime.AddHours(1);

            //Assign both times to the endtimecombobox
            EndTimeComboBox.Text = _endEasternDateTime.ToString("hh:mm:ss tt") + " " + easternTimeTimeZone + " / " + _endLocalDateTime.ToString("hh:mm:ss tt") + " " + localTimeTimeZone;
        }
    }//End of add appointment page form class
}//End of namespace
