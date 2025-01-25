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
            //Update Customer
            _customer.CustomerName = CustomerNameTextBox.Text;
            _address.Address1 = Address1TextBox.Text;
            _address.Address2 = Address2TextBox.Text;
            _city.CityName = CityTextBox.Text;
            _country.CountryName = CountryTextBox.Text;
            _address.PostalCode = PostalCodeTextBox.Text;
            _address.Phone = PhoneNumberTextBox.Text;
            _address.LastUpdate = DateTime.Now;
            _address.LastUpdateBy = _user.UserName;
            _city.LastUpdate = DateTime.Now;
            _city.LastUpdateBy = _user.UserName;
            _country.LastUpdate = DateTime.Now;
            _country.LastUpdateBy = _user.UserName;
            _customer.LastUpdate = DateTime.Now;
            _customer.LastUpdateBy = _user.UserName;
            _customer.UpdateCustomer(_customer);
            _address.UpdateAddress(_address);
            _city.UpdateCity(_city);
            _country.UpdateCountry(_country);

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
    }
}
