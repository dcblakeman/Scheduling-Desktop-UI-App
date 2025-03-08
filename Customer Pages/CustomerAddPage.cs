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
        private Customer _customer = new Customer();
        private Address _address = new Address();
        private City _city = new City();
        private Country _country = new Country();

        public CustomerAddPage(User user)
        {
            InitializeComponent();
            _user = user;
            //Get next customerId from mysql db
            CustomerIdTextBox.Text = _customer.GetNextCustomerId().ToString();

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
            //Make sure none of the fields are blank
            if (string.IsNullOrWhiteSpace(CustomerNameTextBox.Text) || string.IsNullOrWhiteSpace(AddressTextBox1.Text) || string.IsNullOrWhiteSpace(CityTextBox.Text) || string.IsNullOrWhiteSpace(PostalCodeTextBox.Text) || string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(CountryTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            //Regex for phone number
            if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumberTextBox.Text, @"^\d{3}-\d{3}-\d{4}$"))
            {
                PhoneNumberTextBox.ForeColor = Color.Red;
                MessageBox.Show("Please enter a valid phone number in the format 999-999-9999");
                return;
            }

            //Regex for postal code
            if (!System.Text.RegularExpressions.Regex.IsMatch(PostalCodeTextBox.Text, @"^\d{5}$"))
            {
                PostalCodeTextBox.ForeColor = Color.Red;
                MessageBox.Show("Please enter a valid postal code in the format 99999");
                return;
            }

            Console.WriteLine("Submit Button Clicked");
            try
            {
                //Create country object
                _country = new Country
                {
                    CountryName = CountryTextBox.Text.Trim(),
                    CreateDate = DateTime.Now,
                    CreatedBy = _user.UserName,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = _user.UserName
                };
                //Insert Country and return CountryId
                Console.WriteLine("Inserting Country");
                _country.CountryId = _country.InsertCountry(_country);

                _city = new City
                {
                    CityName = CityTextBox.Text.Trim(),
                    CountryId = _country.CountryId,
                    CreateDate = DateTime.Now,
                    CreatedBy = _user.UserName,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = _user.UserName
                };
                //Insert City and return CityId
                Console.WriteLine("Inserting City");
                _city.CityId = _city.InsertCity(_city);
                Console.WriteLine("Returned City Id:" + _city.CityId);

                //Create Address Object
                _address = new Address
                {
                    Address1 = AddressTextBox1.Text.Trim(),
                    Address2 = Address2TextBox.Text.Trim(),
                    CityId = _city.CityId,
                    PostalCode = PostalCodeTextBox.Text.Trim(),
                    Phone = PhoneNumberTextBox.Text.Trim(),
                    CreateDate = DateTime.Now,
                    CreatedBy = _user.UserName,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = _user.UserName
                };
                //Insert Address and return AddressId
                Console.WriteLine("Inserting Address");
                _address.AddressId = _address.InsertAddress(_address);
                Console.WriteLine("AddressId: " + _address.AddressId);
                //Create Customer Object
                _customer = new Customer
                {
                    CustomerName = CustomerNameTextBox.Text.Trim(),
                    AddressId = _address.AddressId,
                    Active = 1,
                    CreateDate = DateTime.Now,
                    CreatedBy = _user.UserName,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = _user.UserName
                };
                //Insert Customer and return CustomerId
                Console.WriteLine("Inserting Customer");
                _customer.CustomerId = _customer.InsertCustomer(_customer);

                //Return to Customer Navigation Page
                CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage(_user);
                customerNavigationPage.Show();
                this.Hide();
            }
            catch (Exception ex)
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
                    MessageBox.Show("Please enter a valid phone number in the format 999-999-9999");
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

        private void PostalCodeTextBox_Enter(object sender, EventArgs e)
        {
            //Clear text box
            if(PostalCodeTextBox.Text == "99999")
            {
                PostalCodeTextBox.Clear();
                PostalCodeTextBox.ForeColor = Color.Black;
            }
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

        private void CountryTextBox_Enter(object sender, EventArgs e)
        {
            //clear text box
            CountryTextBox.Clear();
        }

        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            //If the text box is empty, fill it with 'US'
            if (string.IsNullOrWhiteSpace(CountryTextBox.Text))
            {
                CountryTextBox.Text = "US";
                CountryTextBox.ForeColor = Color.Gray;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.ForeColor = Color.Black;
        }

        private void Address2TextBox_Enter(object sender, EventArgs e)
        {
            if(Address2TextBox.Text == "Optional")
            {
                Address2TextBox.Text = "";
                Address2TextBox.ForeColor = Color.Black;
            }
        }

        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if(PhoneNumberTextBox.Text == "999-999-9999")
            {
                PhoneNumberTextBox.Text = "";
                PhoneNumberTextBox.ForeColor = Color.Black;
            }
        }
    }
}
