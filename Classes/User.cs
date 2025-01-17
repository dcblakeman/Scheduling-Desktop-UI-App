using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //Create connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
        public void UpdateUser(User _selectedUser)
        {
            UserId = _selectedUser.UserId;
            UserName = _selectedUser.UserName;
            Password = _selectedUser.Password;
            Active = _selectedUser.Active;
            LastUpdate = DateTime.Now;
            LastUpdateBy = _selectedUser.UserName;

            try
            {
                //Open connection
                conn.Open();
                //Create query string
                string updateUserQuery = "UPDATE user SET userName = @UserName, password = @password, active = @active, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE userId = @userId";
                //Create command object
                MySqlCommand cmd = new MySqlCommand(updateUserQuery, conn);
                //Add parameters
                cmd.Parameters.AddWithValue("@userName", UserName);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@active", Active);
                cmd.Parameters.AddWithValue("@lastUpdate", LastUpdate);
                cmd.Parameters.AddWithValue("@lastUpdateBy", LastUpdateBy);
                //Execute command
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UserAuthentication(User user)
        {
            //Assign to local object
            this.UserName = user.UserName;
            this.Password = user.Password;

            try
            {
                //Check and see if the user.UserName and password are correct in the database
                //Create connection object
                using (conn)
                {
                    //Open connection
                    conn.Open();

                    //Create query to verify username and password
                    string loginQuery = "SELECT COUNT(*) FROM user WHERE userName = @userName AND password = @password";

                    //Create a command object
                    MySqlCommand cmd = new MySqlCommand(loginQuery, conn);

                    //Add parameters
                    cmd.Parameters.AddWithValue("@userName", UserName);
                    cmd.Parameters.AddWithValue("@password", Password);

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
