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

        public int InsertCountry(Country country, User user)
        {
            //Set CountryName
            this.CountryName = country.CountryName;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = user.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

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
                    cmd.Parameters.AddWithValue("@createdBy", user.UserName);
                    cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", user.UserName);

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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int UpdateCountry(Country country, User user)
        {
            //Set CountryId
            this.CountryId = country.CountryId;
            this.CountryName = country.CountryName;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = user.UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = user.UserName;

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
                    cmd.Parameters.AddWithValue("@lastUpdateBy", user.UserName);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    //Close Connection
                    conn.Close();
                    //Return CountryId
                    return this.CountryId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public void DeleteCountry(int countryId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string deleteCountryQuery = "DELETE FROM country WHERE countryId = @countryId";
                    MySqlCommand cmd = new MySqlCommand(deleteCountryQuery, conn);
                    cmd.Parameters.AddWithValue("@countryId", countryId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Country GetCountry(int countryId)
        {
            this.CountryId = countryId;
            return new Country();  
        }
    }
}
