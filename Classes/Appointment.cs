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
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

        public Appointment InsertAppointment(Appointment appointment)
        {
            try
            {
                using (conn)
                {
                    //Open connection object
                    conn.Open();

                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", conn);

                    //Add parameters
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
                    cmd.Parameters.AddWithValue("@createDate", appointment.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", appointment.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", appointment.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", appointment.LastUpdateBy);
                    //Close connection
                    conn.Close();
                    return appointment;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting appointment");
                return null;
            }
        }
        public void UpdateAppointment(Appointment appointment)
        {
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
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating appointment");
            }
        }
        public void DeleteAppointment(int appointmentId)
        {
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
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
        public List<Appointment> GetAppointmentsByCustomerId(int customerId)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string selectAllCustomerAppointmentsQuery = "SELECT * FROM appointment WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(selectAllCustomerAppointmentsQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    //Create data reader
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Read data
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment
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
                            appointments.Add(appointment);
                        }
                    }
                    //Close connection
                    conn.Close();
                    return appointments;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting all customer appointments");
                return null;
            }
        }//End GetAllCustomerAppointments Method

        //Get all appointments by date
        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string selectAllAppointmentsByDateQuery = "SELECT * FROM appointment WHERE start BETWEEN @date AND @tomorrow";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(selectAllAppointmentsByDateQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@tomorrow", date.AddDays(1));
                    //Create data reader
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Read data
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment
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
                            appointments.Add(appointment);
                        }
                    }
                    //Close connection
                    conn.Close();
                    return appointments;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting all appointments by date");
                return null;
            }
        }//End GetAllAppointmentsByDate Method

        public MySqlDataAdapter PopulateAppointmentDataGridViewWithDateAndName(DateTime date)
        {
            try
            {
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
