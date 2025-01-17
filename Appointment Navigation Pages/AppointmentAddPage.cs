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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using NUglify.JavaScript.Syntax;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class AppointmentAddPage : Form
    {
        //user.UserName variable
        private User _user;
        //Create Connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
        public AppointmentAddPage(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void AddAppointmentPage_Load(object sender, EventArgs e)
        {
            //Populate the Upcoming Appointments Data Grid View with appointment table in mysql
            //Open connection
            conn.Open();
            //Create query to select all appointments
            string selectQuery = "SELECT * FROM appointment";
            //Create command
            MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
            //Create data adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //Create a dataset
            DataSet ds = new DataSet();
            //Fill the dataset
            adapter.Fill(ds);
            //Set the data source of the data grid view to the dataset
            UpcomingAppointmentsDataGridView.DataSource = ds.Tables[0];
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
            Appointment appointment = new Appointment
            {
                CustomerId = Convert.ToInt32(CustomerIdTextBox.Text),
                UserId = Convert.ToInt32(UserIdTextBox.Text),
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                Location = LocationTextBox.Text,
                Contact = ContactTextBox.Text,
                Type = TypeTextBox.Text,
                Url = UrlTextBox.Text,
                Start = StartDateTimePicker.Value,
                End = EndDateTimePicker.Value,
                CreateDate = DateTime.Now,
                CreatedBy = _user.UserName,
                LastUpdate = DateTime.Now,
                LastUpdateBy = _user.UserName
            };
            appointment.InsertAppointment(appointment, _user);
        }

        private void UpcomingAppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpcomingAppointmentsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Show what date is clicked in the console
            Console.WriteLine(UpcomingAppointmentsCalendar.SelectionRange.Start);

            try
            {
                //Populate the UpcomingAppointmentsDataGridView with the appointments scheduled for the date clicked
                UpcomingAppointmentsDataGridView.DataSource = null;
                //Convert that time to mysql format
                string selectedDate = UpcomingAppointmentsCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
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
                UpcomingAppointmentsDataGridView.DataSource = ds.Tables[0];
                //Refresh datagridview
                UpcomingAppointmentsDataGridView.Refresh();

            } catch(Exception ex)
            {
                //Write exception to console
                Console.WriteLine(ex.Message);
                //Allow user to proceed without error message
                UpcomingAppointmentsDataGridView.DataSource = null;
            }
            
        }

        private void AppointmentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Print 1st appointmentlistview item to console
                Console.WriteLine(AppointmentListView.SelectedItems[0].Text);
                //Put selected appointmentlistview item into startdatetimepicker
                StartDateTimePicker.Value = Convert.ToDateTime(AppointmentListView.SelectedItems[0].Text);
                //Add the selected appointmentlistview item to the enddatetimepicker + 1 hour
                EndDateTimePicker.Value = Convert.ToDateTime(AppointmentListView.SelectedItems[0].Text).AddHours(1);
            } catch(ArgumentOutOfRangeException ex)
            {
                //Write exception to console
                Console.WriteLine(ex.Message);
            }
        }
    }
}
