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
        public int InsertCustomer(string customerName, int addressId, int active, DateTime createDate, string CreatedBy, DateTime lastUpdate, string lastUpdateBy, string userName)
        {
            this.CustomerName = customerName;
            this.AddressId = addressId;
            this.Active = active;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = userName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = userName;

            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
            
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

            //Create query for customerId using customerName
            string getCustomerIdQuery = "SELECT customerId FROM customer WHERE customerName = @customerName";

            //Create a command object
            MySqlCommand cmd2 = new MySqlCommand(getCustomerIdQuery, conn);
            cmd2.Parameters.AddWithValue("@customerName", this.CustomerName);

            //Get CustomerId
            this.CustomerId = Convert.ToInt32(cmd2.ExecuteScalar());

            //Close connection
            conn.Close();

            //Return CustomerId
            return CustomerId;
        }
        public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            DataTable dt = new DataTable();
            foreach (DataRow dr in dt.Rows)
            {
                Customer customer = new Customer
                {
                    CustomerId = Convert.ToInt32(dr["customerId"]),
                    CustomerName = dr["customerName"].ToString(),
                    AddressId = Convert.ToInt32(dr["addressId"]),
                    Active = Convert.ToInt32(dr["active"]),
                    CreateDate = Convert.ToDateTime(dr["createDate"]),
                    CreatedBy = dr["createdBy"].ToString(),
                    LastUpdate = Convert.ToDateTime(dr["lastUpdate"]),
                    LastUpdateBy = dr["lastUpdateBy"].ToString()
                };
                customerList.Add(customer);
            }
            return customerList;
        }
        public Customer UpdateCustomer(int customerId, string customerName, int addressId, int active, User user)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.AddressId = addressId;
            this.Active = active;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;
            return new Customer();
        }
        public Customer DeleteCustomer(int customerId)
        {
            this.CustomerId = customerId;
            return new Customer();
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
