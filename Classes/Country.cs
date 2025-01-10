using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class Country
    {
        public Country() { }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        
        public int InsertCountry(string countryName, string userName)
        {
            //Create connection
            MySqlConnection conn = new MySqlConnection();
            conn.Open();
            
            //Create Query
            string insertCountryQuery = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
            
            //Create Command
            MySqlCommand cmd = new MySqlCommand(insertCountryQuery, conn);
            
            //Add Parameters
            cmd.Parameters.AddWithValue("@country", countryName);
            cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@createdBy", userName);
            cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@lastUpdateBy", userName);
            
            //Execute Command to run query
            cmd.ExecuteNonQuery();

            //Create query to retrieve countryId
            string getCountryIdQuery = "SELECT countryId FROM country WHERE country = @country";
            MySqlCommand cmd2 = new MySqlCommand(getCountryIdQuery, conn);

            //Add Parameters
            cmd2.Parameters.AddWithValue("@country", this.CountryName);

            //Execute command to run query to retrieve countryId
            this.CountryId = Convert.ToInt32(cmd2.ExecuteScalar());

            //Close connection
            conn.Close();

            //Return CountryId
            return this.CountryId;
        }
        public int UpdateCountry(int countryId, string countryName, User user)
        {
            //Open a connection
            MySqlConnection conn = new MySqlConnection();
            conn.Open();

            //Create query string
            string updateCountryQuery = "UPDATE country SET country = @country, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE countryId = @countryId";
            
            //Create command
            MySqlCommand cmd = new MySqlCommand(updateCountryQuery, conn);

            //Add parameters
            cmd.Parameters.AddWithValue("@countryId", countryId);
            cmd.Parameters.AddWithValue("@country", countryName);
            cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@lastUpdateBy", user.UserName);
            
            //Execute command
            cmd.ExecuteNonQuery();

            //Set CountryId
            this.CountryId = countryId;
            this.CountryName = countryName;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = user.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            //Close Connection
            conn.Close();

            //Return CountryId
            return this.CountryId;
        }
        public void DeleteCountry(int countryId)
        {
            //Create Connection
            MySqlConnection conn = new MySqlConnection();

            //Open the connection
            conn.Open();

            //Create Query
            string deleteCountryQuery = "DELETE FROM country WHERE countryId = @countryId";

            //Create Command
            MySqlCommand cmd = new MySqlCommand(deleteCountryQuery, conn);

            //Add Parameters
            cmd.Parameters.AddWithValue("@countryId", countryId);

            //Execute Command
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();

            //Set CountryId
            this.CountryId = countryId;
        }
        public Country GetCountry(int countryId)
        {
            this.CountryId = countryId;
            return new Country();  
        }
    }
}
