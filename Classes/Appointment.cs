using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class Appointment
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
        public Appointment InsertAppointment(int customerId, string userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
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
            this.CreatedBy = User.UserName;
            this.LastUpdate = Timestamp.FromDateTime(DateTime.Now);
            this.LastUpdateBy = User.UserName;
            return new Appointment();
        }
        public Appointment UpdateAppointment(int appointmentId, int customerId, string userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
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
            this.LastUpdateBy = User.UserName;
            return new Appointment();
        }
        public Appointment DeleteAppointment(int appointmentId)
        {
            this.AppointmentId = appointmentId;
            return new Appointment();
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
