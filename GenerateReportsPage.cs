using MySql.Data.MySqlClient;
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
        private void ReportsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Use lambda function to get all active customers
        private List<Customer> GetAllActiveCustomersFromList()
        {
            //Create Customer object
            Customer customer = new Customer();

            //Create Customer List Object
            List<Customer> customerList = new List<Customer>();

            //Retrieve customers from database and assign them to customerList
            customerList = customer.GetAllCustomersList();
            //Get all active customers
            List<Customer> activeCustomers = customerList.FindAll(c => c.Active == 1);

            return activeCustomers;
        }

        private void ActiveCustomersCountButton_Click(object sender, EventArgs e)
        {
            //Loop through activeCustomers list and count total active customers then assign them to a column
            DataTable dt = new DataTable();
            dt.Columns.Add("Active_Customers_Count", typeof(int));
            DataRow row = dt.NewRow();
            row["Active_Customers_Count"] = GetAllActiveCustomersFromList().Count;
            dt.Rows.Add(row);

            //Display active customers in data grid view
            //Add Column with Total Count of Active Customers
            ReportsDataGridView.DataSource = dt;
        }

        //Get users and their appointments for the month from dictionary using lambda expression
        private Dictionary<string, List<Appointment>> GetUsersAndAppointments()
        {
            //Create User object
            User user = new User();
            //Create User List Object
            List<User> userList = new List<User>();
            //Retrieve users from database and assign them to userList
            userList = user.GetAllUsersList();
            //Create Appointment object
            Appointment appointment = new Appointment();
            //Create Appointment List Object
            List<Appointment> appointmentList = new List<Appointment>();
            //Retrieve appointments from database and assign them to appointmentList
            appointmentList = appointment.GetAllAppointmentsList();
            //Create Dictionary to store users and their appointments
            Dictionary<string, List<Appointment>> userAppointments = new Dictionary<string, List<Appointment>>();
            //Loop through userList and appointmentList to get users and their appointments
            foreach (User u in userList)
            {
                List<Appointment> userAppointmentsList = appointmentList.FindAll(a => a.UserId == u.UserId);
                userAppointments.Add(u.UserName, userAppointmentsList);
            }
            return userAppointments;
        }

        private void UsersSchedulesButton_Click(object sender, EventArgs e)
        {
            //Assign users and their appointments to a data table
            DataTable dt = new DataTable();
            dt.Columns.Add("User", typeof(string));
            dt.Columns.Add("Start", typeof(DateTime));
            dt.Columns.Add("End", typeof(DateTime));
            dt.Columns.Add("Type", typeof(string));
            //Get users and their appointments
            Dictionary<string, List<Appointment>> userAppointments = GetUsersAndAppointments();
            //Loop through userAppointments and assign them to the data table
            foreach (KeyValuePair<string, List<Appointment>> kvp in userAppointments)
            {
                foreach (Appointment a in kvp.Value)
                {
                    DataRow row = dt.NewRow();
                    row["User"] = kvp.Key;
                    row["Start"] = a.Start;
                    row["End"] = a.End;
                    row["Type"] = a.Type;
                    dt.Rows.Add(row);
                }
            }
            //Display users and their appointments in data grid view
            ReportsDataGridView.DataSource = dt;
        }

        private void AppointmentTypeCountButton_Click(object sender, EventArgs e)
        {
            //Count different appointment types from appointment list using lambda expression
            //Create Appointment object
            Appointment appointment = new Appointment();
            //Create Appointment List Object
            List<Appointment> appointmentList = new List<Appointment>();
            //Retrieve appointments from database and assign them to appointmentList
            appointmentList = appointment.GetAllAppointmentsList();
            //Create a dictionary to store appointment types and their counts
            Dictionary<string, int> appointmentTypeCountDictionary = new Dictionary<string, int>();

            //Turn the dictionary into a list
            appointmentList.ForEach(List => appointmentTypeCountDictionary[List.Type] = appointmentTypeCountDictionary.ContainsKey(List.Type) ? appointmentTypeCountDictionary[List.Type] + 1 : 1);

            //Assign dictionary to datagridview
            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Type_Count", typeof(int));
            foreach (KeyValuePair<string, int> kvp in appointmentTypeCountDictionary)
            {
                DataRow row = dt.NewRow();
                row["Type"] = kvp.Key;
                row["Type_Count"] = kvp.Value;
                dt.Rows.Add(row);
            }
            ReportsDataGridView.DataSource = dt;
        }
    }
}
