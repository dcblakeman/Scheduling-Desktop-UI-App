using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class AppointmentDateTimesAndNames
    {
        public DateTime AppointmentTime { get; set; }
        public string CustomerName { get; set; }

        public AppointmentDateTimesAndNames() { }

        /// ////////////////////Method that returns only appointment times and names by customerid//////////////////////
        public List<AppointmentDateTimesAndNames> GetAppointmentDateTimesAndNames(int customerId)
        {
            //Create CustomerDemographics Object
            CustomerDemographics customerDemographics = new CustomerDemographics();
            customerDemographics = customerDemographics.GetCustomerDemographics(customerId);

            //Create Appointment Object
            Appointment appointment = new Appointment();
            //Get appointments based on customerId
            List<Appointment> customerAppointments = appointment.GetAppointmentsByCustomerId(customerId);

            //Create AppointmentDateTimesAndNames Object
            AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();
            //Create a List of just names and appointments
            List<AppointmentDateTimesAndNames> appointmentDateTimesAndNamesList = new List<AppointmentDateTimesAndNames>();

            //Loop through customer appointments
            foreach (Appointment customerAppointment in customerAppointments)
            {
                //Get Appointment Date and Time
                appointmentDateTimesAndNames.AppointmentTime = customerAppointment.Start;
                //Get Customer Name
                appointmentDateTimesAndNames.CustomerName = customerDemographics.CustomerName;
                //Add to List
                appointmentDateTimesAndNamesList.Add(appointmentDateTimesAndNames);
            }

            return appointmentDateTimesAndNamesList;
        }////////////////////End GetAppointmentDateTimesAndNames method by customerId////////////////////

        /////////////////////Method that returns only appointment times and names by date///////////////////////////////
        public List<AppointmentDateTimesAndNames> GetAppointmentDateTimesAndNames(DateTime date)
        {
            //Create AppointmentDateTimesAndNames Object
            AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();

            //Create Appointment Object
            Appointment appointment = new Appointment();
            //Get appointments based on date
            List<Appointment> appointmentList = appointment.GetAppointmentsByDate(date);

            //Create Customer List
            Customer customer = new Customer();
            List<Customer> customerList = new List<Customer>();

            //Loop through appointments and get customerNames by Id
            foreach (Appointment customerAppointment in appointmentList)
            {
                customer = customer.GetCustomer(customerAppointment.CustomerId);
                customerList.Add(customer);
            }

            //Create a List of just names and appointments
            List<AppointmentDateTimesAndNames> appointmentDateTimesAndNamesList = new List<AppointmentDateTimesAndNames>();
            //Loop through customer appointments
            foreach (Appointment customerAppointment in appointmentList)
            {
                //Get Appointment Date and Time
                appointmentDateTimesAndNames.AppointmentTime = customerAppointment.Start;
                //Get Customer Name
                appointmentDateTimesAndNames.CustomerName = customerAppointment.ToString();
                Console.WriteLine(appointmentDateTimesAndNames.CustomerName);
                //Add to List
                appointmentDateTimesAndNamesList.Add(appointmentDateTimesAndNames);
            }


            return appointmentDateTimesAndNamesList;
        }/////////////////End GetAppointmentDateTimesAndNames by date method//////////////////////////
    }
}
