using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class AppointmentUpdatePage : Form
    {
        private User _user;
        private Appointment _appointment = new Appointment();
        private Customer _customer = new Customer();
        private Address _address = new Address();
        private City _city = new City();
        private Country _country = new Country();

        private DateTime _easternAppointmentStart = new DateTime();
        private DateTime _easternAppointmentEnd = new DateTime();
        private DateTime _localAppointmentStart = new DateTime();
        private DateTime _localAppointmentEnd = new DateTime();

        private DateTime _daySelected = DateTime.Today;
        private TimeZoneInfo _timeZone;
        List<String> _timesList = new List<String>();

        DateTime _startEasternDateTime;
        DateTime _startLocalDateTime;
        DateTime _endEasternDateTime;
        DateTime _endLocalDateTime;

        string _easternTimeZoneAbbreviation = "EST";
        string _localTimeZoneAbbreviation;

        public AppointmentUpdatePage(User user, Appointment appointment, Customer customer)
        {
            Console.WriteLine("AppointmentUpdatePage Method Test");
            InitializeComponent();
            _user = user;
            _appointment = appointment;
            _customer = customer;

            //Get the date part of the string of _appointment.start
            string date = _appointment.Start.ToString("yyyy-MM-dd");

            //Assign the date to the appointment calendar
            AppointmentCalendar.SelectionStart = Convert.ToDateTime(date);

            //Assign appointmentcalendarselection to _daySelected
            _daySelected = AppointmentCalendar.SelectionRange.Start;

            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.DataSource = null;
        }
        private void AppointmentUpdatePage_Load(object sender, EventArgs e)
        {
            Console.WriteLine("AppointmentUpdatePage_Load Method Test");

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
            adapter = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);

            //Fill Adapter with data table information.
            adapter.Fill(dt);

            //Assign data table information to the data grid view
            AppointmentsDataGridView.DataSource = dt;

            //Populate the update appointment fields
            AppointmentIdTextBox.Text = _appointment.AppointmentId.ToString();
            UserIdTextBox.Text = _appointment.UserId.ToString();
            CustomerIdTextBox.Text = _appointment.CustomerId.ToString();
            TitleTextBox.Text = _appointment.Title;
            DescriptionTextBox.Text = _appointment.Description;
            
            LocationComboBox.Text = _appointment.Location;
            Console.WriteLine(LocationComboBox.Text);

            ContactTextBox.Text = _appointment.Contact;
            AppointmentTypeComboBox.Text = _appointment.Type;

            //StartTimeComboBox.SelectedText = _appointment.Start.ToString("hh:mm:ss tt");
            Console.WriteLine("Start Time ComboBox: " + _appointment.Start.ToString("hh:mm:ss tt"));
         
            CustomerIdTextBox.Text = _appointment.CustomerId.ToString();
            UserIdTextBox.Text = _appointment.UserId.ToString();

            //Time Zone Abbreviation Conditional
            if (LocationComboBox.Text == "Phoenix")
            {
                _timeZone = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
                Console.WriteLine("Standard Time Zone: " + _timeZone.Id);
                _localTimeZoneAbbreviation = "MST";
                _localAppointmentStart = TimeZoneInfo.ConvertTime(_appointment.Start, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"), _timeZone);
                if (_localAppointmentStart.IsDaylightSavingTime())
                {
                    _localAppointmentStart = _localAppointmentStart.AddHours(1);
                    Console.WriteLine("Local Appointment Start: " + _localAppointmentStart.ToString("hh:mm:ss tt"));
                }
                
            }
            else if (LocationComboBox.Text == "London")
            {
                _timeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                _localTimeZoneAbbreviation = "GMT";
                //Get Local time
                _localAppointmentStart = TimeZoneInfo.ConvertTime(_appointment.Start, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"), _timeZone);
            }
            else
            {
                _timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                _localTimeZoneAbbreviation = "EST";
                //Get Local time
                _localAppointmentStart = TimeZoneInfo.ConvertTime(_appointment.Start, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"), _timeZone);
            }

         
            
            //Set End Local Appointment time
            _localAppointmentEnd = _localAppointmentStart.AddHours(1);

            //Get Eastern time
            _startEasternDateTime = TimeZoneInfo.ConvertTime(_appointment.Start, _timeZone, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
            //Set End Eastern time
            _endEasternDateTime = TimeZoneInfo.ConvertTime(_appointment.End, _timeZone, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

            //Called GetTimeZoneTimes to get appoiontment times
            _timesList = GetTimeZoneTimes(_timeZone);

            /////////////////////////////////End AppointmentDataGridView/////////////////////////////
            //Assign current list time item to variable
            string currentAppointmentStartDateAndTime = _appointment.Start.ToString("hh:mm:ss tt") + " " + _easternTimeZoneAbbreviation + " / " + _localAppointmentStart.ToString("hh:mm:ss tt") + " " + _localTimeZoneAbbreviation;
        
            try
            {
                Console.WriteLine(currentAppointmentStartDateAndTime);
                Console.WriteLine("TimesList Count: " + _timesList.Count);
                for (int x = 0; x < _timesList.Count; x++)
                {
                    if (_timesList[x] == currentAppointmentStartDateAndTime)
                    {
                        StartTimeComboBox.DataSource = new BindingSource(_timesList, null);
                        StartTimeComboBox.SelectedItem = _timesList[x];
                        Console.WriteLine("Value found");
                        break;
                    }
                    Console.WriteLine(_timesList[x]);
                }

                
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            _endEasternDateTime = _startEasternDateTime.AddHours(1);
            _endLocalDateTime = _startLocalDateTime.AddHours(1);
            //Assign both times to the endtimecombobox
            EndTimeComboBox.Text = _appointment.End.ToString("hh:mm:ss tt") + " " + _easternTimeZoneAbbreviation + " / " + _localAppointmentEnd.ToString("hh:mm:ss tt") + " " + _localTimeZoneAbbreviation;
        }
        private void StartTimeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            //Derive eastern and local endtime for endtimetext box
            String[] times = StartTimeComboBox.Text.Split('/');
            Console.WriteLine(StartTimeComboBox.Text);
            Console.WriteLine(times[0] + " " + times[1]);

            //Get the timezone abbreviation
            _easternTimeZoneAbbreviation = times[0].Trim().Substring(12, 3);
            _localTimeZoneAbbreviation = times[1].Trim().Substring(12, 3);


            //Assign StartTimeComboBox to the start time
            //StartTimeComboBox.Text = _startEasternDateTime.ToString("hh:mm:ss tt") + " " + easternTimeTimeZone + " / " + _startLocalDateTime.ToString("hh:mm:ss tt") + " " + localTimeTimeZone;

            //Grab substring to parse to datetime object
            _startEasternDateTime = DateTime.Parse(times[0].Substring(0, 11));
            _startLocalDateTime = DateTime.Parse(times[1].Substring(1, 11));
            _endEasternDateTime = _startEasternDateTime.AddHours(1);
            _endLocalDateTime = _startLocalDateTime.AddHours(1);

            //Assign both times to the endtimecombobox
            EndTimeComboBox.Text = _endEasternDateTime.ToString("hh:mm:ss tt") + " " + _easternTimeZoneAbbreviation + " / " + _endLocalDateTime.ToString("hh:mm:ss tt") + " " + _localTimeZoneAbbreviation;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
            appointmentNavigationPage.Show();
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
            adapter = _appointment.PopulateAppointmentDataGridViewWithDateAndName(_daySelected);

            //Fill Adapter with data table information.
            adapter.Fill(dt);

            //Assign data table information to the data grid view
            AppointmentsDataGridView.DataSource = dt;

            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.Refresh();
        }

        private void UpdateAppointmentCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user, _appointment, _customer);
            appointmentNavigationPage.Show();
            this.Hide();
        }
        private void CustomerProfileButton_Click(object sender, EventArgs e)
        {
            //Go to customer profile page
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, _customer.CustomerId);
            customerProfilePage.Show();
            this.Hide();
        }
        public List<String> GetTimeZoneTimes(TimeZoneInfo timeZone)
        {
            Console.WriteLine("TimeZone: " + timeZone);
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
                DateTime mountainTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(easternTime, "Eastern Standard Time", "US Mountain Standard Time");
                DateTime greenwichTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(easternTime, "Eastern Standard Time", "GMT Standard Time");
                if(mountainTime.IsDaylightSavingTime())
                {
                    mountainTime = mountainTime.AddHours(1);
                }

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
            if (_timeZone.ToString() == "(UTC-07:00) Arizona")
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
            _easternAppointmentStart = Convert.ToDateTime(_startEasternDateTime);
            _easternAppointmentEnd = Convert.ToDateTime(_endEasternDateTime);

            string startTime = _daySelected.ToString("yyyy-MM-dd") + " " + _easternAppointmentStart.ToString("hh:mm:ss tt");
            string endTime = _daySelected.ToString("yyyy-MM-dd") + " " + _easternAppointmentEnd.ToString("hh:mm:ss tt");

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
            _appointment.AppointmentId = _appointment.UpdateAppointment(_appointment);
            if (_appointment.AppointmentId == 0)
            {
                MessageBox.Show("Appointment was not added.");
            }
            else
            {
                //Return to Appointment Navigation Page
                MessageBox.Show("Appointment was updated.");
                AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
                appointmentNavigationPage.Show();
                this.Hide();
            }
        }//End Submit Button Method



        private void LocationComboBox_DropDownClosed(object sender, EventArgs e)
        {
            //Time Zone Abbreviation Conditional
            if (LocationComboBox.Text == "Phoenix")
            {
                _timeZone = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");

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
            _startEasternDateTime = DateTime.Parse(times[0].Substring(0, 11));
            _startLocalDateTime = DateTime.Parse(times[1].Substring(1, 11));
            _endEasternDateTime = _startEasternDateTime.AddHours(1);
            _endLocalDateTime = _startLocalDateTime.AddHours(1);

            //Assign both times to the endtimecombobox
            EndTimeComboBox.Text = _endEasternDateTime.ToString("hh:mm:ss tt") + " " + _easternTimeZoneAbbreviation + " / " + _endLocalDateTime.ToString("hh:mm:ss tt") + " " + _localTimeZoneAbbreviation;
        }
    }
}
