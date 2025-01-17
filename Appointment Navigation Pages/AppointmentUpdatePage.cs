using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class AppointmentUpdatePage : Form
    {
        private User _user;
        public AppointmentUpdatePage(User user)
        {
            InitializeComponent();
            _user = user;
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
            //Update appointment in mysql database
            Appointment appointment = new Appointment
            {
                AppointmentId = Convert.ToInt32(AppointmentIdTextBox.Text),
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
                LastUpdate = DateTime.Now,
                LastUpdateBy = _user.UserName
            };
            appointment.UpdateAppointment(appointment, _user);
        }
        private void StartDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            //Make sure the day is momday through friday
            if (StartDateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || StartDateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Appointments must be scheduled Monday through Friday.");
                StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
            }

            //Make sure the time is 9am through 5pm eastern standard time
            if (StartDateTimePicker.Value.Hour < 9 || StartDateTimePicker.Value.Hour >= 17)
            {
                MessageBox.Show("Appointments must be scheduled between 9:00 AM and 5:00 PM Eastern Standard Time.");
                StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
            }

            //Make sure appointments don't overlap with each other or with other customer appointments
            if (StartDateTimePicker.Value >= EndDateTimePicker.Value)
            {
                MessageBox.Show("Appointment start time must be before the end time.");
                StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
            }

            //Make sure the times are in hour intervals
            if (StartDateTimePicker.Value.Minute != 0 || EndDateTimePicker.Value.Minute != 0)
            {
                MessageBox.Show("Appointments must start and end on the hour.");
                StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
            }
            else
            {
                // Check for overlapping appointments
                Appointment appointment = new Appointment();
                if (appointment.CheckForOverlappingAppointments(StartDateTimePicker.Value, EndDateTimePicker.Value))
                {
                    MessageBox.Show("Appointment overlaps with another appointment.");
                    StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
                }
                else
                {
                    // Check for overlapping customer appointments
                    //if (appointment.CheckForOverlappingCustomerAppointments(StartDateTimePicker.Value, EndDateTimePicker.Value, Convert.ToInt32(CustomerIdTextBox.Text)))
                    //{
                    //    MessageBox.Show("Appointment overlaps with another customer appointment.");
                    //    StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
                    //}
                }
            }
        }


        private DateTime NextWeekdayAt9AM(DateTime value)
        {
            throw new NotImplementedException();
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Make sure the day is momday through friday
            if (EndDateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || EndDateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Appointments must be scheduled Monday through Friday.");
                EndDateTimePicker.Value = NextWeekdayAt9AM(EndDateTimePicker.Value);
            }

            //Make sure the time is 9am through 5pm eastern standard time
            if (EndDateTimePicker.Value.Hour < 9 || EndDateTimePicker.Value.Hour >= 17)
            {
                MessageBox.Show("Appointments must be scheduled between 9:00 AM and 5:00 PM Eastern Standard Time.");
                EndDateTimePicker.Value = NextWeekdayAt9AM(EndDateTimePicker.Value);
            }

            //Make sure appointments don't overlap with each other or other customer's appointments
            if (EndDateTimePicker.Value <= StartDateTimePicker.Value)
            {
                MessageBox.Show("Appointment end time must be after the start time.");
                EndDateTimePicker.Value = NextWeekdayAt9AM(EndDateTimePicker.Value);
            }

            //Make sure the times are in hour intervals
            if (StartDateTimePicker.Value.Minute != 0 || EndDateTimePicker.Value.Minute != 0)
            {
                MessageBox.Show("Appointments must start and end on the hour.");
                StartDateTimePicker.Value = NextWeekdayAt9AM(StartDateTimePicker.Value);
            }
            else
            {
                // Check for overlapping appointments
                Appointment appointment = new Appointment();
                if (appointment.CheckForOverlappingAppointments(StartDateTimePicker.Value, EndDateTimePicker.Value))
                {
                    MessageBox.Show("Appointment overlaps with another appointment.");
                    EndDateTimePicker.Value = NextWeekdayAt9AM(EndDateTimePicker.Value);
                }
                else
                {
                    // Check for overlapping customer appointments
                    if (appointment.CheckForOverlappingCustomerAppointments(StartDateTimePicker.Value, EndDateTimePicker.Value, Convert.ToInt32(CustomerIdTextBox.Text)))
                    {
                        MessageBox.Show("Appointment overlaps with another customer appointment.");
                        EndDateTimePicker.Value = NextWeekdayAt9AM(EndDateTimePicker.Value);
                    }
                }
            }
        }
         
        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDateTimePicker.Format = DateTimePickerFormat.Custom;
            StartDateTimePicker.CustomFormat = "hh:mm tt";

            //Have dropdown show only in hour intervals
            StartDateTimePicker.ShowUpDown = true;
            StartDateTimePicker.Value = StartDateTimePicker.Value.Date + new TimeSpan(9, 0, 0);


            //Automatically change the EndDateTimePicker.Value to one hour after startdatetimepicker.value
            EndDateTimePicker.Value = StartDateTimePicker.Value.AddHours(1);

        }
    }
}
