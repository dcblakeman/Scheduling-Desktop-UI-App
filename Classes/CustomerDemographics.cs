using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal class CustomerDemographics
    {
        //Get Names from Ids
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public int CustomerId { get; set; }

        private Customer _customer = new Customer();
        private City _city = new City();
        private Country _country = new Country();
        private Address _address = new Address();

        public CustomerDemographics()
        {
        }

        //Create method that returns customer information based on customerid, addressid, cityid, countryid and assign its respective values to each class
        public CustomerDemographics(int customerId)
        {


        }

        //Get customer demographics from ids
        public CustomerDemographics GetCustomerDemographics(int customerId)
        {
            CustomerDemographics customerDemographics = new CustomerDemographics();
            //Get Customer Information from Customer Id
            _customer = _customer.GetCustomer(customerId);
            //Get Address Information from Address Id
            _address = _address.GetAddress(_customer.AddressId);
            //Get City Information from City Id
            City _city = new City();
            _city = _city.GetCity(_address.CityId);
            //Get Country Information from Country Id
            Country _country = new Country();
            _country = _country.GetCountry(_city.CountryId);

            //Assign values to customer object
            customerDemographics.CustomerId = _customer.CustomerId;
            customerDemographics.CustomerName = _customer.CustomerName;
            customerDemographics.CustomerAddress1 = _address.Address1;
            customerDemographics.CustomerAddress2 = _address.Address2;
            customerDemographics.CustomerCity = _city.CityName;
            customerDemographics.CustomerCountry = _country.CountryName;

            //Return just the names and Id
            return customerDemographics;
        }
    }
}
