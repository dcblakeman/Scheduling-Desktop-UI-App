using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class Calendar
    {
        //Calendar Constructor
        public Calendar()
        {
        }

        //Click on calendar day to bring up available appointment times from 9am to 5pm
        public void GetAvailableAppointmentTimes()
        {
            //Create a list of available appointment times
            List<string> availableAppointmentTimes = new List<string>();
            //Add available appointment times to the list
            availableAppointmentTimes.Add("9:00 AM");
            availableAppointmentTimes.Add("10:00 AM");
            availableAppointmentTimes.Add("11:00 AM");
            availableAppointmentTimes.Add("12:00 PM");
            availableAppointmentTimes.Add("1:00 PM");
            availableAppointmentTimes.Add("2:00 PM");
            availableAppointmentTimes.Add("3:00 PM");
            availableAppointmentTimes.Add("4:00 PM");
            availableAppointmentTimes.Add("5:00 PM");
            //Return the list of available appointment times
            foreach (string time in availableAppointmentTimes)
            {
                Console.WriteLine(time);
            }
        }

    }
}
