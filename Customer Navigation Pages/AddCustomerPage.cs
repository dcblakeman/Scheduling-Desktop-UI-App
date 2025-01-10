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
    public partial class AddCustomerPage : Form
    {
        string userName;

        public AddCustomerPage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        private void AddCustomerPage_Load(object sender, EventArgs e)
        {
            //Set default text for textboxes
            FirstNameTextBox.Text = "First Name";
            FirstNameTextBox.ForeColor = Color.Gray;
            LastNameTextBox.Text = "Last Name";
            LastNameTextBox.ForeColor = Color.Gray;
            Address1TextBox.Text = "Address 1";
            Address1TextBox.ForeColor = Color.Gray;
            Address2TextBox.Text = "Address 2";
            Address2TextBox.ForeColor = Color.Gray;
            CityTextBox.Text = "City";
            CityTextBox.ForeColor = Color.Gray;
            CountryTextBox.Text = "Country";
            CountryTextBox.ForeColor = Color.Gray;
            PostalCodeTextBox.Text = "99999";
            PostalCodeTextBox.ForeColor = Color.Gray;
            PhoneNumberTextBox.Text = "999-999-9999";
            PhoneNumberTextBox.ForeColor = Color.Gray;
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
            //Create Connection Object
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString;
            
            //Open Connection
            connection.Open();

            //Create Command Object
            MySqlCommand command = new MySqlCommand
            {
                Connection = connection
            };

            //Create Transaction Object
            MySqlTransaction transaction = connection.BeginTransaction();
            command.Transaction = transaction;

            //Create Country Object
            Country country = new Country();
            country.CountryName = CountryTextBox.Text;
            country.CreateDate = DateTime.Now;
            country.CreatedBy = userName;
            country.LastUpdate = DateTime.Now;
            country.LastUpdateBy = userName;
            //Insert Country and return CountryId
            int CountryId = country.InsertCountry(country.CountryName, userName);
            
            //Create City Object
            City city = new City();
            city.CityName = CityTextBox.Text;
            city.CountryId = CountryId;
            city.CreateDate = DateTime.Now;
            city.CreatedBy = userName;
            city.LastUpdate = DateTime.Now;
            city.LastUpdateBy = userName;
            //Insert City and return CityId
            int CityId = city.InsertCity(city.CityName, city.CountryId, userName);
            
            //Create Address Object
            Address address = new Address();
            address.Address1 = Address1TextBox.Text;
            address.Address2 = Address2TextBox.Text;
            address.CityId = CityId;
            address.PostalCode = PostalCodeTextBox.Text;
            address.Phone = PhoneNumberTextBox.Text;
            address.CreateDate = DateTime.Now;
            address.CreatedBy = userName;
            address.LastUpdate = DateTime.Now;
            address.LastUpdateBy = userName;
            //Insert Address and return AddressId
            int AddressId = address.InsertAddress(address.Address1, address.Address2, address.CityId, address.PostalCode, address.Phone, userName);

            //Create Customer Object
            Customer customer = new Customer();
            customer.CustomerName = FirstNameTextBox.Text + ' ' + LastNameTextBox;
            customer.AddressId = AddressId;
            customer.Active = 1;
            customer.CreateDate = DateTime.Now;
            customer.CreatedBy = userName;
            customer.LastUpdate = DateTime.Now;
            customer.LastUpdateBy = userName;

            //Insert Customer
            customer.InsertCustomer(customer.CustomerName, customer.AddressId, customer.Active, customer.CreateDate, customer.CreatedBy, customer.LastUpdate, customer.LastUpdateBy, userName);



        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage();
            customerNavigationPage.Show();
            this.Hide();
        }
    }
}
