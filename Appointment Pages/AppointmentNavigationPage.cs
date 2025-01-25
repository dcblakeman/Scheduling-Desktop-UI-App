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
        User _user;
        Customer _customer;
        //Appointment date selected
        Appointment _appointment = new Appointment();
        DateTime _daySelected = DateTime.Today;
        CustomerDemographics customerAppointmentTable = new CustomerDemographics();
        AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();

        //Create object to hold selected appointmentdatagridview row
        //Appointment _appointment;

        public AppointmentNavigationPage()
        {
            InitializeComponent();
        }
        public AppointmentNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
        }
        public AppointmentNavigationPage(User user, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
            
        }
        public AppointmentNavigationPage(User user, Appointment appointment, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _appointment = appointment;
            _customer = customer;
        }


        private void AppointmentNavigationPage_Load(object sender, EventArgs e)
        {
            //ShowToday();
            //Load Today's appointments by date
            _appointment.PopulateAppointmentDataGridViewWithDateAndName(_daySelected);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(_customer == null)
                {
                    MessageBox.Show("Please select a customer to add an appointment");
                    return;
                }

                //Open Add Appointment Page and pass the user object
                AppointmentAddPage addAppointmentPage = new AppointmentAddPage(_user, _customer);
                addAppointmentPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Make sure an appointment has been selected
                if (AppointmentsDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an appointment to update");
                    return;
                }
                else
                {
                    //Assign column fields to appointment object
                    _appointment.AppointmentId = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value);
                    //Create a query to Get appointment information from database using customerName and start columns from selected AppointmentsDataGridView row
                    string query = "SELECT * FROM appointment WHERE appointmentId = @_appointment.AppointmentId";

                    //Open Connection
                    conn.Open();

                    //Create command
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    //Add parameters
                    cmd.Parameters.AddWithValue("@_appointment.AppointmentId", _appointment.AppointmentId);

                    //Read results into an appointment object
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            AppointmentId = Convert.ToInt32(reader["appointmentId"]),
                            CustomerId = Convert.ToInt32(reader["customerId"]),
                            UserId = Convert.ToInt32(reader["userId"]),
                            Title = reader["title"].ToString(),
                            Description = reader["description"].ToString(),
                            Location = reader["location"].ToString(),
                            Contact = reader["contact"].ToString(),
                            Type = reader["type"].ToString(),
                            Start = Convert.ToDateTime(reader["start"]),
                            End = Convert.ToDateTime(reader["end"]),
                            CreateDate = Convert.ToDateTime(reader["createDate"]),
                            CreatedBy = reader["createdBy"].ToString(),
                            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]),
                            LastUpdateBy = reader["lastUpdateBy"].ToString()
                        };
                        Console.WriteLine("Test");
                        //Open Update Appointment Page and pass the user object and appointment
                        AppointmentUpdatePage appointmentUpdatePage = new AppointmentUpdatePage(_user, _appointment, _customer);
                        
                        appointmentUpdatePage.Show();
                        this.Hide();
                    }
                    
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                else
                {
                    _appointment.DeleteAppointment(Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void MainNavigationPageButton_Click(object sender, EventArgs e)
        {
            //Go to main nagivation page
            MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
            mainNavigationPage.Show();
            this.Hide();
        }

        private void AppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Assign appointmentcalendarselection to _daySelected
            _daySelected = AppointmentCalendar.SelectionRange.Start;
            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.DataSource = null;
            //Populate AppointmentDataGridView with appointments scheduled for the selected date
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter = _appointment.PopulateAppointmentDataGridViewWithDateAndName(_daySelected);
            adapter.Fill(dt);
            AppointmentsDataGridView.DataSource = dt;
            //Refresh AppointmentDataGridView
            AppointmentsDataGridView.Refresh();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            //Go to customer navigation page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();

        }

        //private void PopulateAppointmentDataGridViewWithDateAndName()
        //{
        //    try
        //    {
        //        string query = @"SELECT appointmentId AS `Appointment_Id`, start AS `Appointment_Time`, customerName AS `Customer_Name`, type AS `Appointment_Type` FROM appointment, customer WHERE appointment.customerId = customer.customerId AND start BETWEEN @startOfDay AND @endOfDay";
        //        //Open connection
        //        conn.Open();
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@startOfDay", _daySelected.Date);
        //        cmd.Parameters.AddWithValue("@endOfDay", _daySelected.Date.AddDays(1).AddSeconds(-1));
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        AppointmentsDataGridView.DataSource = dt;
        //        conn.Close();
        //    }catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}
