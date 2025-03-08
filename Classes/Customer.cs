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
        public int InsertCustomer(Customer customer)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    

                    //Check and see if customer has already been entered into mysql db
                    string checkCustomerQuery = "SELECT customerId FROM customer WHERE customerName = @customerName";
                    MySqlCommand cmdCheck = new MySqlCommand(checkCustomerQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    //Open connection
                    Console.WriteLine("Opening Insert Customer Connection");
                    conn.Open();
                    MySqlDataReader reader = cmdCheck.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //If customer already exists, return the customerId
                        while (reader.Read())
                        {
                            customer.CustomerId = reader.GetInt32("customerId");
                        }
                        Console.WriteLine("Closing Insert Customer Connection. Customer already exists in database.");
                        MessageBox.Show("Customer is already in database.");
                        conn.Close();
                        return customer.CustomerId;
                    }
                    //Closing check Customer Connection
                    conn.Close();
                    
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

                    //Open connection, execute command, close connection
                    Console.WriteLine("Inserting Customer");
                    conn.Open();
                    int added = cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Insert Customer Connection Closed. Customer has been added.");

                    //Check to make sure customer was added
                    if (added != 1)
                    {
                        throw new Exception("Insert failed");
                    }

                    //Create a pop up box stating customer was inserted
                    MessageBox.Show("Customer Added");
                    return customer.CustomerId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**Error inserting customer**");
                return 0;
            }
        }
        public int UpdateCustomer(Customer customer)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
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

                    //Open connection, execute query, close connection
                    conn.Open();
                    int value = cmd.ExecuteNonQuery();
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating customer");
                return 0; 
            }
        }
        public int DeleteCustomer(int customerId)
        {
            //Delete customer
            int value;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Create query string
                    string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(deleteCustomerQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    //Open connection, execute command, close connection
                    conn.Open();
                    value = cmd.ExecuteNonQuery();
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error deleting customer");
                return 0;
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
                    
                    //Create query string
                    string getCustomerQuery = "SELECT * FROM customer WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getCustomerQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    //Open connection, execute reader, close connection
                    conn.Open();
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

        //Get Next CustomerId
        public int GetNextCustomerId()
        {
            int nextCustomerId = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    
                    //Create query string
                    string getNextCustomerIdQuery = "SELECT MAX(customerId) FROM customer";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getNextCustomerIdQuery, conn);

                    //Open connection, execute reader, close connection
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Read data
                    while (reader.Read())
                    {
                        nextCustomerId = reader.GetInt32("MAX(customerId)") + 1;
                    }
                    //Close connection
                    conn.Close();
                    return nextCustomerId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting next customer id");
                return 0;
            }
        }//End GetNextCustomerId Method

        public MySqlDataAdapter GetAllCustomers()
        {
            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
            //Create data adapter object
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Create query string
            string getAllCustomersQuery = "SELECT * FROM customer";
            //Create command
            MySqlCommand cmd = new MySqlCommand(getAllCustomersQuery, conn);
            //Assign command to adapter
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Get all customers and return them in a list
        public List<Customer> GetAllCustomersList()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Create query string
                    string getAllCustomersQuery = "SELECT * FROM customer";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getAllCustomersQuery, conn);
                    //Open connection, execute reader, close connection
                    conn.Open();
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
                Console.WriteLine("Error getting all customers");
                return null;
            }
        }
        internal bool HasAppointments(int customerId)
        {
            //Check to see if customer has any appointments in mysql
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Create query string
                    string checkAppointmentsQuery = "SELECT customerId FROM appointment WHERE customerId = @customerId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(checkAppointmentsQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    //Open connection, execute reader, close connection
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Check to see if customer has any appointments
                    if (reader.HasRows)
                    {
                        conn.Close();
                        return true;
                    }
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error checking for appointments");
                return false;
            }
        }
    }
}
