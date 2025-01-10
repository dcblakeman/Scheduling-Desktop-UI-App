using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class Address
    {
        public Address() { }
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //Insert Address
        public int InsertAddress(string address1, string address2, int cityId, string postalCode, string phone, string userName)
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.CityId = cityId;
            this.PostalCode = postalCode;
            this.Phone = phone;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = userName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = userName;

            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

            //Open Connection
            conn.Open();

            //Create Query to insert information
            string insertAddressQuery = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

            //Create Command
            MySqlCommand cmd = new MySqlCommand(insertAddressQuery, conn);

            //Add Parameters
            cmd.Parameters.AddWithValue("@address", this.Address1);
            cmd.Parameters.AddWithValue("@address2", this.Address2);
            cmd.Parameters.AddWithValue("@cityId", this.CityId);
            cmd.Parameters.AddWithValue("@postalCode", this.PostalCode);
            cmd.Parameters.AddWithValue("@phone", this.Phone);
            cmd.Parameters.AddWithValue("@createDate", this.CreateDate);
            cmd.Parameters.AddWithValue("@createdBy", this.CreatedBy);
            cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
            cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);

            //Create query to return AddressId
            string getAddressIdQuery = "SELECT addressId FROM address WHERE address = @address";

            //Create command object
            MySqlCommand cmd2 = new MySqlCommand(getAddressIdQuery, conn);

            //Add parameters
            cmd2.Parameters.AddWithValue("@address", this.Address1);

            //Execute command to run query to retrieve AddressId
            this.AddressId = Convert.ToInt32(cmd2.ExecuteScalar());

            //Close connection
            conn.Close();

            //Return AddressId
            return AddressId;
        }

        //Update Address
        public int UpdateAddress(int addressId, string address1, string address2, int cityId, string postalCode, string phone, User user)
        {
            this.AddressId = addressId;
            this.Address1 = address1;
            this.Address2 = address2;
            this.CityId = cityId;
            this.PostalCode = postalCode;
            this.Phone = phone;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;
            return AddressId;
        }

        //Delete Address
        public Address DeleteAddress(int addressId)
        {
            this.AddressId = addressId;
            return new Address();
        }

        //Get Address List
        public Address GetAddress()
        {
            Address address = new Address();
            return address;
        }

    }
}
