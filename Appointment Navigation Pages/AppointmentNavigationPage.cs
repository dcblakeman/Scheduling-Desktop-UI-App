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
        User user;
        public AppointmentNavigationPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AppointmentNavigationPage_Load(object sender, EventArgs e)
        {
            try
            {
                //Populate the Upcoming Appointments Data Grid View with appointment table in mysql
                AppointmentsDataGridView.DataSource = null;
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
                AppointmentsDataGridView.DataSource = ds.Tables[0];
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            //Add Appointment Page
            AppointmentAddPage addAppointmentPage = new AppointmentAddPage(user);
            addAppointmentPage.Show();
            this.Hide();
        }

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AppointmentNavigationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            //Open Update Appointment Page
            AppointmentUpdatePage updateAppointmentPage = new AppointmentUpdatePage(user);
            updateAppointmentPage.Show();
            this.Hide();
        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Make sure a row is selected from AppointmentsDtaGridView
                if (AppointmentsDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete");
                    return;
                }
                //Create query to delete appointment
                string deleteQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                //Create command
                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                //Add parameters
                cmd.Parameters.AddWithValue("@appointmentId", AppointmentsDataGridView.SelectedRows[0].Cells[0].Value);
                //Execute query
                cmd.ExecuteNonQuery();
                //Refresh the data grid view
                AppointmentsDataGridView.DataSource = null;
                //Create query to select all appointments
                string selectQuery = "SELECT * FROM appointment";
                //Create command
                cmd = new MySqlCommand(selectQuery, conn);
                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //Create a dataset
                DataSet ds = new DataSet();
                //Fill the dataset
                adapter.Fill(ds);
                //Set the data source of the data grid view to the dataset
                AppointmentsDataGridView.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select row
            AppointmentsDataGridView.Rows[e.RowIndex].Selected = true;

        }

        private void AppointmentsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void MainNavigationPageButton_Click(object sender, EventArgs e)
        {
            //Go to main nagivation page
            MainNavigationPage mainNavigationPage = new MainNavigationPage(user);
            mainNavigationPage.Show();
            this.Hide();
        }
    }
}
