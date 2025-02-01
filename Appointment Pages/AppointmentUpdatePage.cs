using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private DateTime _appointmentStart = new DateTime();
        private DateTime _appointmentEnd = new DateTime();
        private DateTime _daySelected = DateTime.Today;
        public AppointmentUpdatePage(User user, Appointment appointment, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _appointment = appointment;
            _customer = customer;

            //Populate the update appointment fields
            AppointmentIdTextBox.Text = _appointment.AppointmentId.ToString();
            UserIdTextBox.Text = _appointment.UserId.ToString();
            CustomerIdTextBox.Text = _appointment.CustomerId.ToString();
            TitleTextBox.Text = _appointment.Title;
            DescriptionTextBox.Text = _appointment.Description;
            LocationTextBox.Text = _appointment.Location;
            ContactTextBox.Text = _appointment.Contact;
            AppointmentTypeComboBox.Text = _appointment.Type;
            StartTimeComboBox.Text = _appointment.Start.ToString(); //Convert StartTimeComboBox.Text to String
            EndTimeTextBox.Text = _appointment.End.ToString(); //Convert EndTimeComboBox.Text to String
            CustomerIdTextBox.Text = _appointment.CustomerId.ToString();
            UserIdTextBox.Text = _appointment.UserId.ToString();
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
            int value;
            //See if any changes were made to the original object fields
            if (AppointmentIdTextBox.Text == _appointment.AppointmentId.ToString() && UserIdTextBox.Text == _appointment.UserId.ToString() && CustomerIdTextBox.Text == _appointment.CustomerId.ToString() && TitleTextBox.Text == _appointment.Title && DescriptionTextBox.Text == _appointment.Description && LocationTextBox.Text == _appointment.Location && ContactTextBox.Text == _appointment.Contact && AppointmentTypeComboBox.Text == _appointment.Type && StartTimeComboBox.Text == _appointment.Start.ToString() && EndTimeTextBox.Text == _appointment.End.ToString())
            {
                MessageBox.Show("No changes were made.");
                return;
            }
            //Assign text box values to fields
            _appointment.AppointmentId = Convert.ToInt32(AppointmentIdTextBox.Text);
            _appointment.UserId = Convert.ToInt32(UserIdTextBox.Text);
            _appointment.CustomerId = Convert.ToInt32(CustomerIdTextBox.Text);
            _appointment.Title = TitleTextBox.Text;
            _appointment.Description = DescriptionTextBox.Text;
            _appointment.Location = LocationTextBox.Text;
            _appointment.Contact = ContactTextBox.Text;
            _appointment.Type = AppointmentTypeComboBox.Text;
            _appointment.Start = Convert.ToDateTime(StartTimeComboBox.Text);
            _appointment.End = Convert.ToDateTime(EndTimeTextBox.Text);
            _appointment.LastUpdate = DateTime.Now;
            _appointment.LastUpdateBy = _user.UserName;
            value = _appointment.UpdateAppointment(_appointment);
            if(value == 1)
            {
                MessageBox.Show("Appointment updated successfully.");
            }
            else
            {
                MessageBox.Show("Appointment update failed.");
            }
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
            appointmentNavigationPage.Show();
            this.Hide();
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddAppointmentGroupBox_Enter(object sender, EventArgs e)
        {

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

        private void AppointmentUpdatePage_Load(object sender, EventArgs e)
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
            adapter = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);

            //Fill Adapter with data table information.
            adapter.Fill(dt);

            //Assign data table information to the data grid view
            AppointmentsDataGridView.DataSource = dt;
        }

        private void CustomerProfileButton_Click(object sender, EventArgs e)
        {
            //Go to customer profile page
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, _customer.CustomerId);
            customerProfilePage.Show();
            this.Hide();
        }
        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Set start time  to create a datetime object And account for timezone and dst
                _appointmentStart = Convert.ToDateTime(StartTimeComboBox.Text);

                //Set end appointment time to one hour after appointmentTime accounting for timezone and dst
                _appointmentEnd = _appointmentStart.AddHours(1);
                EndTimeTextBox.Text = _appointmentEnd.ToString("hh:mm:ss");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
