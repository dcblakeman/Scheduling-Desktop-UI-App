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
        public Address InsertAddress(Address address)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open Connection
                    conn.Open();

                    //Create Query to insert information
                    string insertAddressQuery = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(insertAddressQuery, conn);

                    //Add Parameters
                    cmd.Parameters.AddWithValue("@address", address.Address1);
                    cmd.Parameters.AddWithValue("@address2", address.Address2);
                    cmd.Parameters.AddWithValue("@cityId", address.CityId);
                    cmd.Parameters.AddWithValue("@postalCode", address.PostalCode);
                    cmd.Parameters.AddWithValue("@phone", address.Phone);
                    cmd.Parameters.AddWithValue("@createDate", address.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", address.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", address.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", address.LastUpdateBy);

                    //Create query to return AddressId
                    string getAddressIdQuery = "SELECT addressId FROM address WHERE address = @address";

                    //Create command object
                    MySqlCommand cmd2 = new MySqlCommand(getAddressIdQuery, conn);

                    //Add parameters
                    cmd2.Parameters.AddWithValue("@address", address.Address1);

                    //Execute command to run query to retrieve AddressId
                    address.AddressId = Convert.ToInt32(cmd2.ExecuteScalar());

                    //Close connection
                    conn.Close();

                    //Return AddressId
                    return address;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting address");
                return null;
            }
        }

        //Update Address
        public void UpdateAddress(Address address)
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open Connection
                    conn.Open();
                    //Create Query to update information
                    string updateAddressQuery = "UPDATE address SET address = @address, address2 = @address2, cityId = @cityId, postalCode = @postalCode, phone = @phone, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE addressId = @addressId";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(updateAddressQuery, conn);
                    //Add Parameters
                    cmd.Parameters.AddWithValue("@addressId", address.AddressId);
                    cmd.Parameters.AddWithValue("@address", address.Address1);
                    cmd.Parameters.AddWithValue("@address2", address.Address2);
                    cmd.Parameters.AddWithValue("@cityId", address.CityId);
                    cmd.Parameters.AddWithValue("@postalCode", address.PostalCode);
                    cmd.Parameters.AddWithValue("@phone", address.Phone);
                    cmd.Parameters.AddWithValue("@lastUpdate", address.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", address.LastUpdateBy);
                    //Execute Command
                    cmd.ExecuteNonQuery();
                    //Close Connection
                    conn.Close();
                }
        }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting address");
            }
        }

        //Delete Address
        public void DeleteAddress(Address address)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId";
                    MySqlCommand cmd = new MySqlCommand(deleteAddressQuery, conn);
                    cmd.Parameters.AddWithValue("@addressId", address.AddressId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting address");
            }
        }

        //Get address from sql database based on addressid
        public Address GetAddress(int addressId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string getAddressQuery = "SELECT * FROM address WHERE addressId = @addressId";
                    MySqlCommand cmd = new MySqlCommand(getAddressQuery, conn);
                    cmd.Parameters.AddWithValue("@addressId", addressId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    Address address = new Address();
                    while (reader.Read())
                    {
                        address.AddressId = reader.GetInt32("addressId");
                        address.Address1 = reader.GetString("address");
                        address.Address2 = reader.GetString("address2");
                        address.CityId = reader.GetInt32("cityId");
                        address.PostalCode = reader.GetString("postalCode");
                        address.Phone = reader.GetString("phone");
                        address.CreateDate = reader.GetDateTime("createDate");
                        address.CreatedBy = reader.GetString("createdBy");
                        address.LastUpdate = reader.GetDateTime("lastUpdate");
                        address.LastUpdateBy = reader.GetString("lastUpdateBy");
                    }
                    conn.Close();
                    return address;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting address");
                return null;
            }
        }
    }
}
