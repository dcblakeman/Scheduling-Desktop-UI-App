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
        private readonly Customer Customer = new Customer();
        private readonly Address Address = new Address();
        private readonly City City = new City();
        private readonly Country Country = new Country();
        private readonly string connString = ConfigurationManager.ConnectionStrings["SchedulingUIConnection"].ConnectionString;
        private readonly string query = "SELECT * FROM customer";
        private readonly MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SchedulingUIConnection"].ConnectionString);

        public AddCustomerPage()
        {
            InitializeComponent();
        }

        private void AddCustomerPage_Load(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "999-999-9999")
            {
                phoneNumberTextBox.Text = "";
                phoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                phoneNumberTextBox.Text = "999-999-9999";
                phoneNumberTextBox.ForeColor = Color.Gray;
            } else if (!string.Equals(phoneNumberTextBox.Text, "999-999-9999"))
            {
                phoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void ZipCodeTextBox_Enter(object sender, EventArgs e)
        {
            if (postalCodeTextBox.Text == "99999")
            {
                postalCodeTextBox.Text = "";
                postalCodeTextBox.ForeColor = Color.Black;
            }
        }

        private void ZipCodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(postalCodeTextBox.Text))
            {
                postalCodeTextBox.Text = "99999";
                postalCodeTextBox.ForeColor = Color.Gray;
            }
            else if (!string.Equals(postalCodeTextBox.Text, "99999"))
            {
                postalCodeTextBox.ForeColor = Color.Black;
            }
        }

        private void InsertCustomer(Customer customer, Address address, City city, Country country)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                
                string insertCustomerQuery = "INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                MySqlCommand cmd = new MySqlCommand(insertCustomerQuery, conn);
                cmd.Parameters.AddWithValue("@customerId", customer.CustomerId);
                cmd.Parameters.AddWithValue("@customerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@addressId", customer.AddressId);
                cmd.Parameters.AddWithValue("@active", customer.Active);
                cmd.Parameters.AddWithValue("@createDate", customer.CreateDate);
                cmd.Parameters.AddWithValue("@createdBy", customer.CreatedBy);
                cmd.Parameters.AddWithValue("@lastUpdate", customer.LastUpdate);
                cmd.Parameters.AddWithValue("@lastUpdateBy", customer.LastUpdateBy);
                customer.CustomerId = (int)cmd.LastInsertedId;
                conn.Open();
                conn.Close();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
