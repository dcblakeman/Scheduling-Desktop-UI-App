using MySql.Data.MySqlClient;
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
        Customer _customer = new Customer();
        Address _address = new Address();
        City _city = new City();
        Country _country = new Country();
        //User Object
        User _user;
        Appointment _appointment = new Appointment();

        public CustomerProfilePage(User user, int customerId)
        {
            InitializeComponent();
            //Assign objects to local variables
            _user = user;
            _customer.CustomerId = customerId;

            Console.WriteLine("Customer Profile Page Loaded");
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

            //Check to see if any updates were made
            if (CustomerNameTextBox.Text == _customer.CustomerName && Address1TextBox.Text == _address.Address1 && Address2TextBox.Text == _address.Address2 && CityTextBox.Text == _city.CityName && CountryTextBox.Text == _country.CountryName && PostalCodeTextBox.Text == _address.PostalCode && PhoneNumberTextBox.Text == _address.Phone)
            {
                MessageBox.Show("No changes were made.");
                return;
            }

            //Otherwise, assign text box values to fields
            _customer.CustomerId = Convert.ToInt32(CustomerIdTextBox.Text);
            _customer.CustomerName = CustomerNameTextBox.Text;
            _city.CityName = CityTextBox.Text;
            _country.CountryName = CountryTextBox.Text;
            _address.Address1 = Address1TextBox.Text;
            _address.Address2 = Address2TextBox.Text;
            _address.PostalCode = PostalCodeTextBox.Text;
            _address.Phone = PhoneNumberTextBox.Text;

            //Update Customer Information
            _country.UpdateCountry(_country);
            _city.UpdateCity(_city);
            _address.UpdateAddress(_address);
            _customer.UpdateCustomer(_customer);

            MessageBox.Show("Customer Information Updated");

            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();
        }

        private void CustomerProfilePage_Load(object sender, EventArgs e)
        {
            //Get Customer by customerId
            _customer = _customer.GetCustomer(_customer.CustomerId);
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
            PostalCodeTextBox.Text = _address.PostalCode;
            CountryTextBox.Text = _country.CountryName;
            PhoneNumberTextBox.Text = _address.Phone;

            //Create MySqlDataAdapter and Data Table Objects
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            //Populate customerappointmentsdatagridview with customer's appointments using customerappointmenttable class
            adapter = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);
            adapter.Fill(dt);
            AppointmentsDataGridView.DataSource = dt;

            //Create regex for PhoneNumberTextBox
            string regex = @"^\d{3}-\d{3}-\d{4}$";
            //Check if phone number is in correct format
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumberTextBox.Text, regex))
            {
                //If phone number is in correct format, do nothing
            }
            else
            {
                //If phone number is not in correct format, display message box
                MessageBox.Show("Please enter phone number in the following format: 123-456-7890");
            }
        }

        private void UpdateCustomerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            //Make sure appointment is selected
            if (AppointmentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }
            else
            {
                _appointment.AppointmentId = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value);
                //Delete appointment
                Console.WriteLine("AppointmentId: " + _appointment.AppointmentId);
                _appointment.DeleteAppointment(_appointment.AppointmentId);

                //Refresh datagridview
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                adapter = _appointment.GetAppointmentsByCustomerId(_customer.CustomerId);
                adapter.Fill(dt);
                AppointmentsDataGridView.DataSource = dt;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Automatically add hyphens for phone numbers
                if (PhoneNumberTextBox.Text.Length == 3)
                {
                    PhoneNumberTextBox.Text += "-";
                    PhoneNumberTextBox.SelectionStart = PhoneNumberTextBox.Text.Length;
                }
                if (PhoneNumberTextBox.Text.Length == 7)
                {
                    PhoneNumberTextBox.Text += "-";
                    PhoneNumberTextBox.SelectionStart = PhoneNumberTextBox.Text.Length;
                }
                //Stop user input after 12 characters have been entered
                PhoneNumberTextBox.MaxLength = 12;

                //Regex for phone number
                if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumberTextBox.Text, @"^\d{3}-\d{3}-\d{4}$"))
                {
                    PhoneNumberTextBox.ForeColor = Color.Red;

                }
                else
                {
                    PhoneNumberTextBox.ForeColor = Color.Black;
                }

            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Address2TextBox_Enter(object sender, EventArgs e)
        {
            //Clear text box
            if (Address2TextBox.Text == "Optional")
            {
                Address2TextBox.Text = "";
                Address2TextBox.ForeColor = Color.Black;
            }
        }

        private void Address2TextBox_Leave(object sender, EventArgs e)
        {
            //If the text box is empty
            if (Address2TextBox.Text == "")
            {
                Address2TextBox.Text = "Optional";
                Address2TextBox.ForeColor = Color.Gray;
            }
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
