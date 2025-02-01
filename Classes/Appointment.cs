using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class Appointment
    {
        public Appointment() { }
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //Create connection

        public int InsertAppointment(Appointment appointment)
        {
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Make sure this appointment isn't overlapping another appointment on the same day and time
                    string checkAppointmentQuery = "SELECT * FROM appointment WHERE (start BETWEEN @start AND @end) OR (end BETWEEN @start AND @end) AND customerId = @customerId";
                    MySqlCommand cmdCheck = new MySqlCommand(checkAppointmentQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@start", appointment.Start);
                    cmdCheck.Parameters.AddWithValue("@end", appointment.End);
                    cmdCheck.Parameters.AddWithValue("@customerId", appointment.CustomerId);
                    //Open connection object
                    conn.Open();
                    MySqlDataReader reader = cmdCheck.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("This appointment overlaps another appointment for this customer. Please choose a different time.");
                        return 0;
                    }
                    //Close connection
                    conn.Close();
                    //Otherwise, insert appointment into mysql database
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO appointment (customerId, userId, title, description, location, contact, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", conn);

                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", appointment.CustomerId);
                    cmd.Parameters.AddWithValue("@userId", appointment.UserId);
                    cmd.Parameters.AddWithValue("@title", appointment.Title);
                    cmd.Parameters.AddWithValue("@description", appointment.Description);
                    cmd.Parameters.AddWithValue("@location", appointment.Location);
                    cmd.Parameters.AddWithValue("@contact", appointment.Contact);
                    cmd.Parameters.AddWithValue("@type", appointment.Type);
                    //cmd.Parameters.AddWithValue("@url", appointment.Url);
                    cmd.Parameters.AddWithValue("@start", appointment.Start);
                    cmd.Parameters.AddWithValue("@end", appointment.End);
                    cmd.Parameters.AddWithValue("@createDate", appointment.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", appointment.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", appointment.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", appointment.LastUpdateBy);
                    //Execute command
                    Console.WriteLine("Inserting Appointment");
                    //Closing connection
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //Confirm appointment was inserted
                    string getAppointmentIdQuery = "SELECT appointmentId FROM appointment WHERE customerId = @customerId AND start = @start";
                    MySqlCommand cmd2 = new MySqlCommand(getAppointmentIdQuery, conn);
                    cmd2.Parameters.AddWithValue("@customerId", appointment.CustomerId);
                    cmd2.Parameters.AddWithValue("@start", appointment.Start);
                    conn.Open();
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            appointment.AppointmentId = reader2.GetInt32("appointmentId");
                            Console.WriteLine("AppointmentId: " + appointment.AppointmentId);
                        }
                    }else
                    {
                        Console.WriteLine("No AppointmentId was found");
                        
                    }
                    //Close connection
                    conn.Close();
                    return appointment.AppointmentId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting appointment");
                return 0;
            }
        }
        public int UpdateAppointment(Appointment appointment)
        {
            int value;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection object
                    conn.Open();
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("UPDATE appointment SET customerId = @customerId, userId = @userId, title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId", conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@appointmentId", appointment.AppointmentId);
                    cmd.Parameters.AddWithValue("@customerId", appointment.CustomerId);
                    cmd.Parameters.AddWithValue("@userId", appointment.UserId);
                    cmd.Parameters.AddWithValue("@title", appointment.Title);
                    cmd.Parameters.AddWithValue("@description", appointment.Description);
                    cmd.Parameters.AddWithValue("@location", appointment.Location);
                    cmd.Parameters.AddWithValue("@contact", appointment.Contact);
                    cmd.Parameters.AddWithValue("@type", appointment.Type);
                    cmd.Parameters.AddWithValue("@url", appointment.Url);
                    cmd.Parameters.AddWithValue("@start", appointment.Start);
                    cmd.Parameters.AddWithValue("@end", appointment.End);
                    cmd.Parameters.AddWithValue("@lastUpdate", appointment.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", appointment.LastUpdateBy);
                    //Execute command
                    value = cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating appointment");
                return 0;
            }
        }
        public int DeleteAppointment(int appointmentId)
        {
            int value;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection object
                    conn.Open();
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM appointment WHERE appointmentId = @appointmentId", conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    //Execute command
                    value = cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                ex.Source = "Error deleting appointment";
                return 0;
            }
        }

        public int DeleteAppointment(DateTime time)
        {
            int value;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection object
                    conn.Open();
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM appointment WHERE start = @start", conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@start", time);
                    //Execute command
                    value = cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                ex.Source = "Error deleting appointment";
                return 0;
            }
        }
        //Get appointment from sql db based on appointmentid
       public Appointment GetAppointment(int appointmentId)
        {
            Appointment appointment = new Appointment();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string selectAppointmentQuery = "SELECT * FROM appointment WHERE appointmentId = @appointmentId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(selectAppointmentQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    //Create data reader
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Read data
                        while (reader.Read())
                        {
                            appointment = new Appointment
                            {
                                AppointmentId = reader.GetInt32("appointmentId"),
                                CustomerId = reader.GetInt32("customerId"),
                                UserId = reader.GetInt32("userId"),
                                Title = reader.GetString("title"),
                                Description = reader.GetString("description"),
                                Location = reader.GetString("location"),
                                Contact = reader.GetString("contact"),
                                Type = reader.GetString("type"),
                                Url = reader.GetString("url"),
                                Start = reader.GetDateTime("start"),
                                End = reader.GetDateTime("end"),
                                CreateDate = reader.GetDateTime("createDate"),
                                CreatedBy = reader.GetString("createdBy"),
                                LastUpdate = reader.GetDateTime("lastUpdate"),
                                LastUpdateBy = reader.GetString("lastUpdateBy")
                            };
                        }
                    }
                    //Close connection
                    conn.Close();
                    return appointment;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting appointment");
                return null;
            }
        }//End GetAppointment Method

        //Get all of the appointments for one customer
        public MySqlDataAdapter GetAppointmentsByCustomerId(int customerId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                string query = "SELECT * FROM appointment WHERE customerId = @customerId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Close();
                adapter.Fill(dt);
                return adapter;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }//End GetAllCustomerAppointments Method

        //Get all appointments by date
        public MySqlDataAdapter GetAppointmentsByDate(DateTime date)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                string query = "SELECT * FROM appointment WHERE start BETWEEN @date AND @tomorrow";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@tomorrow", date.AddDays(1));
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Close();
                adapter.Fill(dt);
                return adapter;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }//End GetAllAppointmentsByDate Method

        public MySqlDataAdapter PopulateAppointmentDataGridViewWithDateAndName(DateTime date)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                string query = @"SELECT appointmentId AS `Appointment_Id`, start AS `Appointment_Time`, customerName AS `Customer_Name`, type AS `Appointment_Type` FROM appointment, customer WHERE appointment.customerId = customer.customerId AND start BETWEEN @startOfDay AND @endOfDay";
                //Open connection
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startOfDay", date);
                cmd.Parameters.AddWithValue("@endOfDay", date.AddDays(1).AddSeconds(-1));
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Close();
                adapter.Fill(dt);
                return adapter;
                //AppointmentsDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
