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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    public partial class CustomerAddPage : Form
    {
        private User _user;
        //Create Connection Object
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

        public CustomerAddPage(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void AddCustomerPage_Load(object sender, EventArgs e)
        {
        }

        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text))
            {
                PhoneNumberTextBox.Text = "999-999-9999";
                PhoneNumberTextBox.ForeColor = Color.Gray;
            }
        }
        private void ZipCodeTextBox_Enter(object sender, EventArgs e)
        {
            if (PostalCodeTextBox.Text == "99999")
            {
                PostalCodeTextBox.Text = "";
                PostalCodeTextBox.ForeColor = Color.Black;
            }
        }
        private void ZipCodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PostalCodeTextBox.Text))
            {
                PostalCodeTextBox.Text = "99999";
                PostalCodeTextBox.ForeColor = Color.Gray;
            }
            else if (!string.Equals(PostalCodeTextBox.Text, "99999"))
            {
                PostalCodeTextBox.ForeColor = Color.Black;
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                conn.Open();

                //Create country object
                Country country = new Country
                {
                    CountryName = CountryTextBox.Text,
                    CreateDate = DateTime.Now,
                    CreatedBy = _user.UserName,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = _user.UserName
                };
                //Insert Country and return CountryId
                country = country.InsertCountry(country);
                    
                //Create City Object
                City city = new City();
                city.CityName = CityTextBox.Text;
                city.CountryId = country.CountryId;
                city.CreateDate = DateTime.Now;
                city.CreatedBy = _user.UserName;
                city.LastUpdate = DateTime.Now;
                city.LastUpdateBy = _user.UserName;
                //Insert City and return CityId
                city = city.InsertCity(city);

                //Create Address Object
                Address address = new Address();
                address.Address1 = AddressTextBox1.Text;
                address.Address2 = Address2TextBox.Text;
                address.CityId = city.CityId;
                address.PostalCode = PostalCodeTextBox.Text;
                address.Phone = PhoneNumberTextBox.Text;
                address.CreateDate = DateTime.Now;
                address.CreatedBy = _user.UserName;
                address.LastUpdate = DateTime.Now;
                address.LastUpdateBy = _user.UserName;
                //Insert Address and return AddressId
                address = address.InsertAddress(address);

                //Create Customer Object
                Customer customer = new Customer();
                customer.CustomerName = CustomerNameTextBox.Text;
                customer.AddressId = address.AddressId;
                customer.Active = 1;
                customer.CreateDate = DateTime.Now;
                customer.CreatedBy = _user.UserName;
                customer.LastUpdate = DateTime.Now;
                customer.LastUpdateBy = _user.UserName;
                //Insert Customer and return CustomerId
                customer = customer.InsertCustomer(customer);

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
            customerNavigationPage.Show();
            this.Hide();
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

        private void Address2TextBox_Leave(object sender, EventArgs e)
        {
            //if the textbox is empty, add placeholder text
            if (string.IsNullOrWhiteSpace(Address2TextBox.Text))
            {
                Address2TextBox.Text = "Optional";
                Address2TextBox.ForeColor = Color.Gray;
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
    }
}
