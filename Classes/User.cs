using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public void InsertUser(string userName, string password, int active)
        {
            this.UserName = userName;
            this.Password = password;
            this.Active = active;
            this.CreateDate = DateTime.Now;
            this.CreatedBy = UserName;
            this.LastUpdate = DateTime.Now;
            this.LastUpdateBy = UserName;

            //Create connection object
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

            //Open Connection
            conn.Open();

            //Create Query to insert information
            string insertUserQuery = "INSERT INTO user (userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@userName, @password, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

            //Create Command
            MySqlCommand cmd = new MySqlCommand(insertUserQuery, conn);

            //Add Parameters
            cmd.Parameters.AddWithValue("@userName", UserName);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@active", Active);
            cmd.Parameters.AddWithValue("@createDate", CreateDate);
            cmd.Parameters.AddWithValue("@createdBy", CreatedBy);
            cmd.Parameters.AddWithValue("@lastUpdate", LastUpdate);
            cmd.Parameters.AddWithValue("@lastUpdateBy", LastUpdateBy);

            //Execute command
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public static void UpdateUser(int userId, string userName, string password, int active, User user)
        {
            user.UserId = userId;
            user.UserName = userName;
            user.Password = password;
            user.Active = active;
            user.LastUpdate = DateTime.Now;
            user.LastUpdateBy = user.UserName;
        }
        public static void DeleteUser(int userId)
        {
            //Create new user instance
            User user = new User();
            user.UserId = userId;
        }
        public static void GetUser(int userId)
        {
            //Create new user instance
            User user = new User();
            user.UserId = userId;
        }
        public bool UserAuthentication(string userName, string password)
        {
            try
            {
                //Check and see if the username and password are correct in the database
                //Create connection object
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();

                    //Create a query
                    string loginQuery = "SELECT * FROM user WHERE userName = @userName AND password = @password";

                    //Create a command object
                    MySqlCommand cmd = new MySqlCommand(loginQuery, conn);

                    //Add parameters
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count;
                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    //if the query returns a result, the user is authenticated
                    if (count > 0)
                    {
                        //User is authenticated
                        //Close connection
                        conn.Close();

                        //Return true
                        return true;
                    }
                    else
                    {
                        //Close connection
                        conn.Close();

                        ///Return false
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
