using MySql.Data.MySqlClient;
using NUglify.Helpers;
using Scheduling_Desktop_UI_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    public partial class CustomerUpdatePage : Form
    {
        User _user;
        Customer _customer = new Customer();
        Address _address = new Address();
        City _city = new City();
        Country _country = new Country();

        public CustomerUpdatePage(Customer customer, User user)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
            try
            {
                //Call GetAddress, GetCity, GetCountry Methods
                _address = _address.GetAddress(customer.AddressId);
                _city = _city.GetCity(_address.CityId);
                _country = _country.GetCountry(_city.CountryId);
            }
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Assign object attributes to text boxes
            CustomerIdTextBox.Text = _customer.CustomerId.ToString();
            CustomerNameTextBox.Text = _customer.CustomerName;
            Address1TextBox.Text = _address.Address1;
            Address2TextBox.Text = _address.Address2;
            if(Address2TextBox.Text.IsNullOrWhiteSpace())
            {
                Address2TextBox.Text = "Optional";
                Address2TextBox.ForeColor = Color.Gray;
            }
            CityTextBox.Text = _city.CityName;
            CountryTextBox.Text = _country.CountryName;
            PostalCodeTextBox.Text = _address.PostalCode;
            PhoneNumberTextBox.Text = _address.Phone;
            PhoneNumberTextBox.ForeColor = Color.Black;
        }

        private void CustomerUpdatePage_Load(object sender, EventArgs e)
        {
        }
        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            //Clear text box
            PhoneNumberTextBox.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage();
            customerNavigationPage.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int value;
            //Check to see if any of the fields have been updated
            if (CustomerNameTextBox.Text == _customer.CustomerName && Address1TextBox.Text == _address.Address1 && Address2TextBox.Text == _address.Address2 && CityTextBox.Text == _city.CityName && CountryTextBox.Text == _country.CountryName && PostalCodeTextBox.Text == _address.PostalCode && PhoneNumberTextBox.Text == _address.Phone)
            {
                MessageBox.Show("No changes were made.");
            }
            //Update Country
            if (CountryTextBox.Text != _country.CountryName)
            {
                _country.CountryName = CountryTextBox.Text;
                value = _country.UpdateCountry(_country);
                if (value == 1)
                {
                    MessageBox.Show("Country has been updated");
                    return;
                }
            }
            //Update City
            if (CityTextBox.Text != _city.CityName)
            {
                _city.CityName = CityTextBox.Text;
                value = _city.UpdateCity(_city);
                if (value == 1)
                {
                    MessageBox.Show("City has been updated");
                    return;
                }
            }
            //Update Address
            if (Address1TextBox.Text != _address.Address1 || Address2TextBox.Text != _address.Address2 || PostalCodeTextBox.Text != _address.PostalCode)
            {
                _address.Address1 = Address1TextBox.Text;
                _address.Address2 = Address2TextBox.Text;
                _address.PostalCode = PostalCodeTextBox.Text;
                
                value = _address.UpdateAddress(_address);
                if (value == 1)
                {
                    MessageBox.Show("Address has been updated");
                }
            }
            //Update Phone Number
            if(PhoneNumberTextBox.Text != _address.Phone)
            {
                _address.Phone = PhoneNumberTextBox.Text;
                value = _address.UpdateAddress(_address);
                if (value == 1)
                {
                    MessageBox.Show("Phone number has been updated");
                }
            }
            
            //Update Customer
            if(CustomerNameTextBox.Text != _customer.CustomerName)
            {
                _customer.CustomerName = CustomerNameTextBox.Text;
                value = _customer.UpdateCustomer(_customer);
                if(value == 1)
                {
                    MessageBox.Show("Customer has been updated");
                }
            }
            
            //Return to customer navigation page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();
        }

        private void Address2TextBox_Enter(object sender, EventArgs e)
        {
            if (Address2TextBox.Text == "Optional")
            {
                Address2TextBox.Text = "";
                Address2TextBox.ForeColor = Color.Black;
            }
        }

        private void Address2TextBox_Leave(object sender, EventArgs e)
        {
            if (Address2TextBox.Text == "")
            {
                Address2TextBox.Text = "Optional";
                Address2TextBox.ForeColor = Color.Gray;
            }
        }

        private void CustomerUpdatePage_Load_1(object sender, EventArgs e)
        {

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

        private void Address2TextBox_TextChanged(object sender, EventArgs e)
        {
            Address2TextBox.ForeColor = Color.Black;
        }

        private void PostalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            //Limit input to 5 digits
            PostalCodeTextBox.MaxLength = 5;
            //Limit input to only numbers
            if (!System.Text.RegularExpressions.Regex.IsMatch(PostalCodeTextBox.Text, @"^\d{5}$"))
            {
                PostalCodeTextBox.ForeColor = Color.Red;
            }
            else
            {
                PostalCodeTextBox.ForeColor = Color.Black;
            }
        }

        private void PostalCodeTextBox_Enter(object sender, EventArgs e)
        {
            //Clear text box
            PostalCodeTextBox.Clear();
        }

        private void PostalCodeTextBox_Leave(object sender, EventArgs e)
        {
            //If the text box is empty then fill with "99999" and inactive caption forecolor
            if (PostalCodeTextBox.Text == "")
            {
                PostalCodeTextBox.Text = "99999";
                PostalCodeTextBox.ForeColor = Color.Gray;
            }
        }

        private void UpdateCustomerGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
