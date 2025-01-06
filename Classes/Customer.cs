using System;
using System.Collections.Generic;
using System.Data;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class Customer
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
        public Customer InsertCustomer(string customerName, int addressId, int active)
        {
            this.CustomerName = customerName;
            this.AddressId = addressId;
            this.Active = active;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = User.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = User.UserName;
            return new Customer();
        }
        public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            DataTable dt = new DataTable();
            foreach (DataRow dr in dt.Rows)
            {
                Customer customer = new Customer();
                customer.CustomerId = Convert.ToInt32(dr["customerId"]);
                customer.CustomerName = dr["customerName"].ToString();
                customer.AddressId = Convert.ToInt32(dr["addressId"]);
                customer.Active = Convert.ToInt32(dr["active"]);
                customer.CreateDate = Convert.ToDateTime(dr["createDate"]);
                customer.CreatedBy = dr["createdBy"].ToString();
                customer.LastUpdate = Convert.ToDateTime(dr["lastUpdate"]);
                customer.LastUpdateBy = dr["lastUpdateBy"].ToString();
                customerList.Add(customer);
            }
            return customerList;
        }
        public Customer UpdateCustomer(int customerId, string customerName, int addressId, int active)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.AddressId = addressId;
            this.Active = active;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = User.UserName;
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
