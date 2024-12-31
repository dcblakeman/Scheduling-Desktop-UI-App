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

namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    public partial class AddCustomerPage : Form
    {
        public AddCustomerPage()
        {
            InitializeComponent();
        }

        private void AddCustomerPage_Load(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "999-999-9999")
            {
                phoneNumberTextBox.Text = "";
                phoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                phoneNumberTextBox.Text = "999-999-9999";
                phoneNumberTextBox.ForeColor = Color.Gray;
            }else if (!string.Equals(phoneNumberTextBox.Text, "999-999-9999"))
            {
                phoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Create Regex for phone number
            string phoneNumber = phoneNumberTextBox.Text;
            string pattern = @"^\d{3}-\d{3}-\d{4}$";

            //Add Customer to Database
            //Check if all fields are filled
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || 
                string.IsNullOrEmpty(lastNameTextBox.Text) || 
                string.IsNullOrEmpty(cityTextBox.Text) || 
                string.IsNullOrEmpty(stateTextBox.Text) ||
                string.IsNullOrEmpty(zipCodeTextBox.Text) ||
                string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Please fill all fields");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern))
            {
                MessageBox.Show("Please enter a valid phone number");
            }
            else
            {
                //Create Customer Object
                Customer customer = new Customer();
                customer.CustomerName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
                customer.CreatedBy = { placeholder };
                customer.LastUpdateBy = { placeholder };
                //Create Address Object
                //Add Address to Database
                phoneNumberTextBox.ForeColor = Color.Black;
                Address address = new Address();
                address.Address1 = address1TextBox.Text;
                address.Address2 = address2TextBox.Text;
                address.City = cityTextBox.Text;
                address.State = stateTextBox.Text;
                address.PostalCode = zipCodeTextBox.Text;
                address.Phone = phoneNumberTextBox.Text;
                address.CreatedBy = { placeholder };
                address.LastUpdateBy = { placeholder };
                address.FirstName = firstNameTextBox.Text;
                address.LastName = lastNameTextBox.Text;
                address.Active = 1;
                address.CreateDate = DateTime.Now;
                address.LastUpdate = DateTime.Now;


                //Add Customer to Database

                //Check if customer already exists
                //If customer does not exist, add customer to database
                //If customer exists, update customer information
                MessageBox.Show("Customer Added Successfully");
            }



        }
    }
}
