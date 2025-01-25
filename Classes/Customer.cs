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
        public Customer InsertCustomer(Customer customer)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create command object
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    cmd.Parameters.AddWithValue("@addressId", customer.AddressId);
                    cmd.Parameters.AddWithValue("@active", customer.Active);
                    cmd.Parameters.AddWithValue("@createDate", customer.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", customer.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", customer.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", customer.LastUpdateBy);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                    return customer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting customer");
                return null;
            }
        }
        public void UpdateCustomer(Customer customer)
        {
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
                    cmd.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    cmd.Parameters.AddWithValue("@addressId", customer.AddressId);
                    cmd.Parameters.AddWithValue("@active", customer.Active);
                    cmd.Parameters.AddWithValue("@lastUpdate", customer.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", customer.LastUpdateBy);
                    cmd.Parameters.AddWithValue("@customerId", customer.CustomerId);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating customer");
            }
        }
        public void DeleteCustomer(Customer customer)
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
                    cmd.Parameters.AddWithValue("@customerId", customer.CustomerId);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error deleting customer");
            }
        }

        //Get customer from database based on customerid
        public Customer GetCustomer(int customerId)
        {
            Customer customer = new Customer();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getCustomerQuery = "SELECT * FROM customer WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getCustomerQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    //Execute command
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Read data
                    while (reader.Read())
                    {
                        customer.CustomerId = reader.GetInt32("customerId");
                        customer.CustomerName = reader.GetString("customerName");
                        customer.AddressId = reader.GetInt32("addressId");
                        customer.Active = reader.GetInt32("active");
                        customer.CreateDate = reader.GetDateTime("createDate");
                        customer.CreatedBy = reader.GetString("createdBy");
                        customer.LastUpdate = reader.GetDateTime("lastUpdate");
                        customer.LastUpdateBy = reader.GetString("lastUpdateBy");
                    }
                    Console.WriteLine("Customer found: " + customer.LastUpdateBy);
                    //Close connection
                    conn.Close();
                    return customer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting customer");
                return null;
            }
        }//End GetCustomer Method

        //Get All Users from Database
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getAllCustomersQuery = "SELECT * FROM customer";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getAllCustomersQuery, conn);
                    //Execute command
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Read data
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerId = reader.GetInt32("customerId");
                        customer.CustomerName = reader.GetString("customerName");
                        customer.AddressId = reader.GetInt32("addressId");
                        customer.Active = reader.GetInt32("active");
                        customer.CreateDate = reader.GetDateTime("createDate");
                        customer.CreatedBy = reader.GetString("createdBy");
                        customer.LastUpdate = reader.GetDateTime("lastUpdate");
                        customer.LastUpdateBy = reader.GetString("lastUpdateBy");
                        customers.Add(customer);
                    }
                    //Close connection
                    conn.Close();
                    return customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting customers");
                return null;
            }
        }//End GetAllCustomers Method

        //Get All Customer Information
        public List<Customer> GetAllCustomerInformation()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getAllCustomersQuery = "SELECT customer.customerId, customer.customerName, address.address, address.address2, city.city, country.country, address.postalCode, address.phone, customer.active, customer.createDate, customer.createdBy, customer.lastUpdate, customer.lastUpdateBy FROM customer JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getAllCustomersQuery, conn);
                    //Execute command
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Read data
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerId = reader.GetInt32("customerId");
                        customer.CustomerName = reader.GetString("customerName");
                        customer.AddressId = reader.GetInt32("addressId");
                        customer.Active = reader.GetInt32("active");
                        customer.CreateDate = reader.GetDateTime("createDate");
                        customer.CreatedBy = reader.GetString("createdBy");
                        customer.LastUpdate = reader.GetDateTime("lastUpdate");
                        customer.LastUpdateBy = reader.GetString("lastUpdateBy");
                        customers.Add(customer);
                    }
                    //Close connection
                    conn.Close();
                    return customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting customers");
                return null;
            }
        }//End GetAllCustomers Method
    }
}
