using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class Customer
    {
        public Customer() { }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public void InsertCustomer(Customer customer, User user)
        {
            this.CustomerName = customer.CustomerName;
            this.AddressId = customer.AddressId;
            this.Active = customer.Active;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = user.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerName", this.CustomerName);
                    cmd.Parameters.AddWithValue("@addressId", this.AddressId);
                    cmd.Parameters.AddWithValue("@active", this.Active);
                    cmd.Parameters.AddWithValue("@createDate", this.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", this.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void UpdateCustomer(Customer customer, User user)
        {
            this.CustomerId = customer.CustomerId;
            this.CustomerName = customer.CustomerName;
            this.AddressId = customer.AddressId;
            this.Active = customer.Active;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string updateCustomerQuery = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(updateCustomerQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerName", this.CustomerName);
                    cmd.Parameters.AddWithValue("@addressId", this.AddressId);
                    cmd.Parameters.AddWithValue("@active", this.Active);
                    cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);
                    cmd.Parameters.AddWithValue("@customerId", this.CustomerId);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void DeleteCustomer(int customerId)
        {
            //Delete customer
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(deleteCustomerQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public Customer GetCustomer(int customerId)
        {
            this.CustomerId = customerId;
            return new Customer();
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            return customers;
        }

    }
}
