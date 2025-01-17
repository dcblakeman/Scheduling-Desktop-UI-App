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
        public int InsertCity(City city, User user)
        {
            this.CityName = city.CityName;
            this.CountryId = city.CountryId;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = user.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open Connection
                    conn.Open();

                    //Create Query to insert information
                    string insertCityQuery = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(insertCityQuery, conn);

                    //Add Parameters
                    cmd.Parameters.AddWithValue("@city", this.CityName);
                    cmd.Parameters.AddWithValue("@countryId", this.CountryId);
                    cmd.Parameters.AddWithValue("@createDate", this.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", this.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);

                    //Create query to return CityId
                    string getCityIdQuery = "SELECT cityId FROM city WHERE city = @city";

                    //Create command object 
                    MySqlCommand cmd2 = new MySqlCommand(getCityIdQuery, conn);

                    //Add parameters
                    cmd2.Parameters.AddWithValue("@city", this.CityName);

                    //Execute command to run query to retrieve CityId
                    this.CityId = Convert.ToInt32(cmd2.ExecuteScalar());

                    //Close connection
                    conn.Close();

                    //Return CityId
                    return CityId;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateCity(City city, User user)
        {
            this.CityId = city.CityId;
            this.CityName = city.CityName;
            this.CountryId = city.CountryId;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open Connection
                    conn.Open();

                    //Create Query to update information
                    string updateCityQuery = "UPDATE city SET city = @city, countryId = @countryId, lastUpdate, lastUpdateBy WHERE cityId = @cityId";

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(updateCityQuery, conn);

                    //Add Parameters
                    cmd.Parameters.AddWithValue("@cityId", this.CityId);
                    cmd.Parameters.AddWithValue("@city", this.CityName);
                    cmd.Parameters.AddWithValue("@countryId", this.CountryId);
                    cmd.Parameters.AddWithValue("@lastUpdate", this.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", this.LastUpdateBy);

                    //Execute Command
                    cmd.ExecuteNonQuery();

                    //Close Connection
                    conn.Close();

                    //Return CityId
                    return CityId;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCity(int cityId)
        {
            this.CityId = cityId;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string deleteCityQuery = "DELETE FROM city WHERE cityId = @cityId";
                    MySqlCommand cmd = new MySqlCommand(deleteCityQuery, conn);
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public City GetCity(int cityId)
        {
            this.CityId = cityId;
            return new City();
        }
    }
}
