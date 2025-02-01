using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class City
    {
        public City() { }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public int InsertCity(City city)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open Connection
                    Console.WriteLine("Opening Insert City Connection");
                    conn.Open();

                    /////////////Check and see if city has already been entered into mysql db///////////
                    string checkCityQuery = "SELECT cityId FROM city WHERE city = @city";
                    MySqlCommand cmdCheck = new MySqlCommand(checkCityQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@city", city.CityName);
                    MySqlDataReader reader = cmdCheck.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //If city already exists, return the cityId
                        while (reader.Read())
                        {
                            city.CityId = reader.GetInt32("cityId");
                        }
                        Console.WriteLine("Closing Insert City Connection. City already exists in database.");
                        conn.Close();
                        return city.CityId;
                    }
                    //Closing cmdcheck Reader
                    conn.Close();

                    Console.WriteLine("City Name: " + city.CityName);
                    Console.WriteLine("Country Id: " + city.CountryId);
                    Console.WriteLine("Create Date: " + city.CreateDate);
                    Console.WriteLine("Created By: " + city.CreatedBy);
                    Console.WriteLine("Last Update: " + city.LastUpdate);
                    Console.WriteLine("Last Update By: " + city.LastUpdateBy);

                    /////////////////////Create Query to insert information/////////////////////////////
                    string insertCityQuery = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(insertCityQuery, conn);

                    //Add Parameters
                    cmd.Parameters.AddWithValue("@city", city.CityName);
                    cmd.Parameters.AddWithValue("@countryId", city.CountryId);
                    cmd.Parameters.AddWithValue("@createDate", city.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", city.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", city.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", city.LastUpdateBy);
                    
                    //Open new connection, run insert city query, close connection
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    ////////////////Create query to get cityId/////////////////////////////////
                    //Create query to return CityId
                    string getCityIdQuery = "SELECT cityId FROM city WHERE city = @city";

                    //Create command object 
                    MySqlCommand cmd2 = new MySqlCommand(getCityIdQuery, conn);

                    //Add parameters
                    cmd2.Parameters.AddWithValue("@city", city.CityName);

                    //Open connection and Execute command to run query to retrieve CityId
                    conn.Open();
                    city.CityId = Convert.ToInt32(cmd2.ExecuteScalar());
                    conn.Close();

                    //Return CityId
                    Console.WriteLine("City Inserted Successfully.");
                    return city.CityId;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error inserting city");
                return 0;
            }
        }
        public int UpdateCity(City city)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Create Query to update information
                    string updateCityQuery = "UPDATE city SET city = @city, countryId = @countryId, lastUpdate, lastUpdateBy WHERE cityId = @cityId";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(updateCityQuery, conn);

                    //Add Parameters
                    cmd.Parameters.AddWithValue("@cityId", city.CityId);
                    cmd.Parameters.AddWithValue("@city", city.CityName);
                    cmd.Parameters.AddWithValue("@countryId", city.CountryId);
                    cmd.Parameters.AddWithValue("@lastUpdate", city.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", city.LastUpdateBy);

                    //Open connection, executing query, closing connection
                    conn.Open();
                    int value = cmd.ExecuteNonQuery();
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating city");
                return 0;
            }
        }

        public void DeleteCity(City city)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string deleteCityQuery = "DELETE FROM city WHERE cityId = @cityId";
                    MySqlCommand cmd = new MySqlCommand(deleteCityQuery, conn);
                    cmd.Parameters.AddWithValue("@cityId", city.CityId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Successfully deleted city");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error deleting city");
            }
        }

        //Get city from sql database based on cityid
        public City GetCity(int cityId)
        {
            City city = new City();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getCityQuery = "SELECT * FROM city WHERE cityId = @cityId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getCityQuery, conn);
                    //Add parameter
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    //Execute reader using using and assign results to city attributes
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            city.CityId = reader.GetInt32("cityId");
                            city.CityName = reader.GetString("city");
                            city.CountryId = reader.GetInt32("countryId");
                            city.CreateDate = reader.GetDateTime("createDate");
                            city.CreatedBy = reader.GetString("createdBy");
                            city.LastUpdate = reader.GetDateTime("lastUpdate");
                            city.LastUpdateBy = reader.GetString("lastUpdateBy");
                        }
                    }
                    //Close connection
                    conn.Close();
                    return city;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting city");
                return null;
            }
        }
    }
}
