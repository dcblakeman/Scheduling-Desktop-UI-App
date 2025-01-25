using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App
{
    public partial class CustomerProfilePage : Form
    {
        //Customer object
        Customer _customer;
        Address _address;
        City _city;
        Country _country;
        //User Object
        User _user;
        private User user;
        private Customer customer;

        public CustomerProfilePage(User user, Customer customer, Address address, City city, Country country)
        {
            InitializeComponent();
            //AppointmentDateTimesAndNamesObject
            AppointmentDateTimesAndNames appointmentDateTimesAndNames = new AppointmentDateTimesAndNames();

            //New Appointment Object
            Appointment appointment = new Appointment();
            _user = user;
            _customer = customer;
            _address = new Address();
            _city = new City();
            _country = new Country();


            //Load customerappointmentsdatagridview
            CustomerAppointmentsDataGridView.DataSource = appointmentDateTimesAndNames.GetAppointmentDateTimesAndNames(customer.CustomerId);

            
        }

        public CustomerProfilePage(User user, Customer customer)
        {
            this.user = user;
            this.customer = customer;
        }

        private void CustomerProfileCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Make sure all fields are filled out
            if (CustomerNameTextBox.Text == "" || Address1TextBox.Text == "" || CityTextBox.Text == "" || CountryTextBox.Text == "" || PostalCodeTextBox.Text == "" || PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();
        }

        private void CustomerAppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerProfilePage_Load(object sender, EventArgs e)
        {
            //Get Address by addressId
            _address = _address.GetAddress(_customer.AddressId);
            //Get City by cityId
            _city = _city.GetCity(_address.CityId);
            //Get Country by countryId
            _country = _country.GetCountry(_city.CountryId);
            //Populate customerappointmentsdatagridview with customer's appointments using customerappointmenttable class
            CustomerIdTextBox.Text = _customer.CustomerId.ToString();
            CustomerNameTextBox.Text = _customer.CustomerName;
            Address1TextBox.Text = _address.Address1;
            Address2TextBox.Text = _address.Address2;
            CityTextBox.Text = _city.CityName;
            CountryTextBox.Text = _country.CountryName;
            PhoneNumberTextBox.Text = _address.Phone;

        }

        private void UpdateCustomerGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
