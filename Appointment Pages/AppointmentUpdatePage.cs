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
        private DateTime _daySelected = new DateTime();
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

        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populate the appointmentdatagridview
            AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();
            AppointmentsDataGridView.DataSource = null;
            AppointmentsDataGridView.DataSource = appointmentDateTimesAndNames.GetAppointmentDateTimesAndNames(AppointmentCalendar.SelectionRange.Start);

            //Refresh appointmentsdatagridview
            AppointmentsDataGridView.Refresh();
        }

        private void AddAppointmentGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            _daySelected = AppointmentCalendar.SelectionRange.Start;

            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.DataSource = null;
            //Populate AppointmentDataGridView with appointments scheduled for the selected date
            _appointment.PopulateAppointmentDataGridViewWithDateAndName(_daySelected);
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
            //Populate the appointmentdatagridview
            AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();
            AppointmentsDataGridView.DataSource = null;
            AppointmentsDataGridView.DataSource = appointmentDateTimesAndNames.GetAppointmentDateTimesAndNames(_appointment.Start);

            //Refresh appointmentsdatagridview
            AppointmentsDataGridView.Refresh();
        }

        private void CustomerProfileButton_Click(object sender, EventArgs e)
        {
            //Go to customer profile page
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(_user, _customer);
            customerProfilePage.Show();
            this.Hide();


        }
        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Change the End time to one hour after the start time
                DateTime startTime = Convert.ToDateTime(StartTimeComboBox.Text);
                Console.WriteLine(startTime);
                DateTime endTime = startTime.AddHours(1);
                EndTimeTextBox.Text = endTime.ToString();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
