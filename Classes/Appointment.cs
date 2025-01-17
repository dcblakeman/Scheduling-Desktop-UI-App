using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public void InsertAppointment(Appointment appointment, User user)
        {
            this.AppointmentId = appointment.AppointmentId;
            this.CustomerId = appointment.CustomerId;
            this.UserId = appointment.UserId;
            this.Title = appointment.Title;
            this.Description = appointment.Description;
            this.Location = appointment.Location;
            this.Contact = appointment.Contact;
            this.Type = appointment.Type;
            this.Url = appointment.Url;
            this.Start = appointment.Start;
            this.End = appointment.End;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = user.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            try
            {
                using (conn)
                {
                    //Open connection object
                    conn.Open();

                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", conn);

                    //Add parameters
                    cmd.Parameters.AddWithValue("@appointmentI", this.AppointmentId);
                    cmd.Parameters.AddWithValue("@customerId", this.CustomerId);
                    cmd.Parameters.AddWithValue("@userId", this.UserId);
                    cmd.Parameters.AddWithValue("@title", this.Title);
                    cmd.Parameters.AddWithValue("@description", this.Description);
                    cmd.Parameters.AddWithValue("@location", this.Location);
                    cmd.Parameters.AddWithValue("@contact", this.Contact);
                    cmd.Parameters.AddWithValue("@type", this.Type);
                    cmd.Parameters.AddWithValue("@url", this.Url);
                    cmd.Parameters.AddWithValue("@start", this.Start);
                    cmd.Parameters.AddWithValue("@end", this.End);
                    cmd.Parameters.AddWithValue("@createDate", this.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", this.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Appointment UpdateAppointment(Appointment appointment, User user)
        {
            this.AppointmentId = appointment.AppointmentId;
            this.CustomerId = appointment.CustomerId;
            this.UserId = appointment.UserId;
            this.Title = appointment.Title;
            this.Description = appointment.Description;
            this.Location = appointment.Location;
            this.Contact = appointment.Contact;
            this.Type = appointment.Type;
            this.Url = appointment.Url;
            this.Start = appointment.Start;
            this.End = appointment.End;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection object
                    conn.Open();
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("UPDATE appointment SET customerId = @customerId, userId = @userId, title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId", conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", this.CustomerId);
                    cmd.Parameters.AddWithValue("@userId", this.UserId);
                    cmd.Parameters.AddWithValue("@title", this.Title);
                    cmd.Parameters.AddWithValue("@description", this.Description);
                    cmd.Parameters.AddWithValue("@location", this.Location);
                    cmd.Parameters.AddWithValue("@contact", this.Contact);
                    cmd.Parameters.AddWithValue("@type", this.Type);
                    cmd.Parameters.AddWithValue("@url", this.Url);
                    cmd.Parameters.AddWithValue("@start", this.Start);
                    cmd.Parameters.AddWithValue("@end", this.End);
                    cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);
                    cmd.Parameters.AddWithValue("@appointmentId", this.AppointmentId);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                    return new Appointment();
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
        public List<Appointment> GetAll()
        {   //Get list of appointments for appointmentdatagridview
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

        internal bool CheckForOverlappingAppointments(DateTime value1, DateTime value2)
        {
            throw new NotImplementedException();
        }

        internal bool CheckForOverlappingCustomerAppointments(DateTime value1, DateTime value2, int v)
        {
            throw new NotImplementedException();
        }

        //Notify user when an appointment is in 15 minutes
        public void NotifyUser()
        {
            //Get current time
            DateTime currentTime = DateTime.Now;
            //Get all appointments
            List<Appointment> appointments = GetAll();
            //Check if any appointments are within 15 minutes
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Start > currentTime && appointment.Start < currentTime.AddMinutes(15))
                {
                    //Create alert pop up window
                    MessageBox.Show("You have an appointment in 15 minutes");
                }
            }
        }
        //Get available appointment times

        internal object AddAppointmentTimesToDataGridView(DataGridView AppointmentDataGridView)
        {
            //Open connection
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
            {
                //Show todays records in datagridview
                try
                {
                    //Create query string
                    string getAppointmentsQuery = "SELECT * FROM appointment WHERE start >= @start AND end <= @end";
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand(getAppointmentsQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@start", DateTime.Today);
                    cmd.Parameters.AddWithValue("@end", DateTime.Today.AddDays(1));
                    //Open connection
                    conn.Open();
                    //Create data adapter
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    //Create dataset
                    System.Data.DataTable dt = new System.Data.DataTable();
                    //Fill dataset

                    //Add data to datagridview
                    return AppointmentDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            throw new NotImplementedException();
        }
    }
}
