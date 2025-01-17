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
        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (PhoneNumberTextBox.Text == "999-999-9999")
            {
                PhoneNumberTextBox.Text = "";
                PhoneNumberTextBox.ForeColor = Color.Black;
            }
        }
        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text))
            {
                PhoneNumberTextBox.Text = "999-999-9999";
                PhoneNumberTextBox.ForeColor = Color.Gray;
            } else if (!string.Equals(PhoneNumberTextBox.Text, "999-999-9999"))
            {
                PhoneNumberTextBox.ForeColor = Color.Black;
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
                int CountryId = country.InsertCountry(country, _user);
                    
                //Create City Object
                City city = new City();
                city.CityName = CityTextBox.Text;
                city.CountryId = CountryId;
                city.CreateDate = DateTime.Now;
                city.CreatedBy = _user.UserName;
                city.LastUpdate = DateTime.Now;
                city.LastUpdateBy = _user.UserName;
                //Insert City and return CityId
                int CityId = city.InsertCity(city, _user);

                //Create Address Object
                Address address = new Address();
                address.Address1 = Address1TextBox.Text;
                address.Address2 = Address2TextBox.Text;
                address.CityId = CityId;
                address.PostalCode = PostalCodeTextBox.Text;
                address.Phone = PhoneNumberTextBox.Text;
                address.CreateDate = DateTime.Now;
                address.CreatedBy = _user.UserName;
                address.LastUpdate = DateTime.Now;
                address.LastUpdateBy = _user.UserName;
                //Insert Address and return AddressId
                int AddressId = address.InsertAddress(address, _user);

                //Create Customer Object
                Customer customer = new Customer();
                customer.CustomerName = FirstNameTextBox.Text + ' ' + LastNameTextBox;
                customer.AddressId = AddressId;
                customer.Active = 1;
                customer.CreateDate = DateTime.Now;
                customer.CreatedBy = _user.UserName;
                customer.LastUpdate = DateTime.Now;
                customer.LastUpdateBy = _user.UserName;

                //Insert Customer
                customer.InsertCustomer(customer, _user);

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
    }
}
