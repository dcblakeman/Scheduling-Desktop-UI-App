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

        public int InsertCountry(Country country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //check and see if country has already been entered into mysql db
                    string checkCountryQuery = "SELECT countryId FROM country WHERE country = @country";
                    MySqlCommand cmdCheck = new MySqlCommand(checkCountryQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@country", country.CountryName);
                    Console.WriteLine("Opening Insert Country Connection");
                    conn.Open();
                    MySqlDataReader reader = cmdCheck.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //If country already exists, return the countryId
                        while (reader.Read())
                        {
                            country.CountryId = reader.GetInt32("countryId");
                        }
                        conn.Close();
                        Console.WriteLine("Check Country Connection Closed. Country already exists in database.");
                        
                        return country.CountryId;
                    }
                    //Closing Country Connection
                    conn.Close();
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

                    //Opening connection, Executing command to insert country, Closing connection
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //Create query to retrieve countryId
                    string getCountryIdQuery = "SELECT countryId FROM country WHERE country = @country";
                    MySqlCommand cmd2 = new MySqlCommand(getCountryIdQuery, conn);

                    //Add Parameters
                    cmd2.Parameters.AddWithValue("@country", country.CountryName);

                    //Open connection, Execute command to run query to retrieve countryId, "Close connection
                    conn.Open();
                    country.CountryId = Convert.ToInt32(cmd2.ExecuteScalar());
                    conn.Close();

                    //Close connection
                    Console.WriteLine(" Insert Country Connection Closed. Country Inserted Successfully ");

                    

                    //Return CountryId
                    return country.CountryId;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting Country");
                return 0;
            }
        }
        public int UpdateCountry(Country country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    Console.WriteLine("Opening Update Country Connection");
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
                    int value = cmd.ExecuteNonQuery();
                    //Close Connection
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating Country");
                return 0;
            }
        }
        public void DeleteCountry(Country country)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    Console.WriteLine("Opening Delete Country Connection");
                    conn.Open();
                    string deleteCountryQuery = "DELETE FROM country WHERE countryId = @countryId";
                    MySqlCommand cmd = new MySqlCommand(deleteCountryQuery, conn);
                    cmd.Parameters.AddWithValue("@countryId", country.CountryId);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Closing Delete Country Connection. Country Deleted Successfully");
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
                    Console.WriteLine("Opening Get Country Connection.");
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
                    Console.WriteLine("Closing Get Country Connection. Country Retrieved Successfully");
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
