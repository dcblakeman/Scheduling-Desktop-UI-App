using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public Country InsertCountry(Country country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();

                    //Create Query
                    string insertCountryQuery = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy, user.UserName) VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy, @user.UserName)";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(insertCountryQuery, conn);

                    //Add Parameters

                    cmd.Parameters.AddWithValue("@country", country.CountryName);
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@createdBy", country.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", country.LastUpdateBy);
                    //Execute Command to run query
                    cmd.ExecuteNonQuery();

                    //Create query to retrieve countryId
                    string getCountryIdQuery = "SELECT countryId FROM country WHERE country = @country";
                    MySqlCommand cmd2 = new MySqlCommand(getCountryIdQuery, conn);

                    //Add Parameters
                    cmd2.Parameters.AddWithValue("@country", country.CountryName);

                    //Execute command to run query to retrieve countryId
                    country.CountryId = Convert.ToInt32(cmd2.ExecuteScalar());

                    //Close connection
                    conn.Close();

                    //Return CountryId
                    return country;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting Country");
                return null;
            }
        }
        public void UpdateCountry(Country country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string updateCountryQuery = "UPDATE country SET country = @country, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE countryId = @countryId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(updateCountryQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@countryId", country.CountryId);
                    cmd.Parameters.AddWithValue("@country", country.CountryName);
                    cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", country.LastUpdateBy);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close Connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating Country");
            }
        }
        public void DeleteCountry(Country country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string deleteCountryQuery = "DELETE FROM country WHERE countryId = @countryId";
                    MySqlCommand cmd = new MySqlCommand(deleteCountryQuery, conn);
                    cmd.Parameters.AddWithValue("@countryId", country.CountryId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error deleting Country");
            }
        }

        //Get country from sql database based on countryid
        public Country GetCountry(int countryId)
        {
            Country country = new Country();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getCountryQuery = "SELECT countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy FROM country WHERE countryId = @countryId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getCountryQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@countryId", countryId);
                    //Execute command
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Read data
                    while (reader.Read())
                    {
                        country.CountryId = reader.GetInt32("countryId");
                        country.CountryName = reader.GetString("country");
                        country.CreateDate = reader.GetDateTime("createDate");
                        country.CreatedBy = reader.GetString("createdBy");
                        country.LastUpdate = reader.GetDateTime("lastUpdate");
                        country.LastUpdateBy = reader.GetString("lastUpdateBy");
                    }
                    //Close connection
                    conn.Close();
                    return country;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting Country");
                return null;
            }
        }
    }
}
