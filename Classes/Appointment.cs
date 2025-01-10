using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class Appointment
    {
        Appointment() { }
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public string UserId { get; set; }
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
        public Timestamp LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public int InsertAppointment(int customerId, string userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end, string userName)
        {
            this.CustomerId = customerId;
            this.UserId = userId;
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Contact = contact;
            this.Type = type;
            this.Url = url;
            this.Start = start;
            this.End = end;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = userName;
            this.LastUpdate = Timestamp.FromDateTime(DateTime.Now);
            this.LastUpdateBy = userName;

            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

            //Open connection object
            conn.Open();

            //Create command object
            MySqlCommand cmd = new MySqlCommand("INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", conn);

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
            cmd.Parameters.AddWithValue("@createDate", this.CreateDate);
            cmd.Parameters.AddWithValue("@createdBy", this.CreatedBy);
            cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
            cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);

            //Create query to retrieve appointmentId
            string getAppointmentIdQuery = "SELECT appointmentId FROM appointment WHERE title = @title";
            MySqlCommand cmd2 = new MySqlCommand(getAppointmentIdQuery, conn);

            //Add parameters
            cmd2.Parameters.AddWithValue("@title", this.Title);

            //Execute command to run query to retrieve appointmentId
            this.AppointmentId = Convert.ToInt32(cmd2.ExecuteScalar());

            //Close connection
            conn.Close();

            //Return AppointmentId
            return AppointmentId;
        }
        public Appointment UpdateAppointment(int appointmentId, int customerId, string userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end, User user)
        {
            this.AppointmentId = appointmentId;
            this.CustomerId = customerId;
            this.UserId = userId;
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Contact = contact;
            this.Type = type;
            this.Url = url;
            this.Start = start;
            this.End = end;
            this.LastUpdate = Timestamp.FromDateTime(DateTime.Now);
            this.LastUpdateBy = user.UserName;
            return new Appointment();
        }
        public void DeleteAppointment(int appointmentId)
        {
            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

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
        public Appointment GetAppointment(int appointmentId)
        {
            this.AppointmentId = appointmentId;
            return new Appointment();
        }
        public List<Appointment> GetAll()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

    }
}
