using MySql.Data.MySqlClient;
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
    public partial class GenerateReportsPage : Form
    {
        public GenerateReportsPage()
        {
            InitializeComponent();
        }

        private void GenerateReportsCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login Form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void AppointmentTypeCountButton_Click(object sender, EventArgs e)
        {
            //Generate Appointment Type Count Report
            //Refresh data grid view
            ReportsDataGridView.DataSource = null;
            try
            {
                //Get all appointments for this month from mysql db
                //Create Connection
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                conn.Open();

                //Create query to get all appointments for this month
                string query = "SELECT type AS Type, COUNT(type) AS Type_Count FROM appointment WHERE MONTH(start) = MONTH(CURRENT_DATE()) GROUP BY type";

                //Create command
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ReportsDataGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ReportsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersSchedulesButton_Click(object sender, EventArgs e)
        {
            //Generate User Schedule Report
            ReportsDataGridView.DataSource = null;
            try
            {
                //Create Connection
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                conn.Open();
                //Create query to get all appointments for this month
                string query = "SELECT user.userName AS User, appointment.start AS Start, appointment.end AS End, appointment.type AS Type FROM appointment JOIN user ON appointment.userId = user.userId";
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ReportsDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ActiveCustomersCountButton_Click(object sender, EventArgs e)
        {
            //Generate Active Customers Report
            ReportsDataGridView.DataSource = null;
            try
            {
                //Create Connection
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                conn.Open();
                //Create query to get all appointments for this month
                string query = "SELECT COUNT(*) AS Active_Count FROM customer WHERE active = 1";
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ReportsDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
