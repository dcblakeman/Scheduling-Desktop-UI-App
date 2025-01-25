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
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@userName", UserName);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@active", Active);
                cmd.Parameters.AddWithValue("@lastUpdate", LastUpdate);
                cmd.Parameters.AddWithValue("@lastUpdateBy", LastUpdateBy);
                //Execute command
                cmd.ExecuteNonQuery();

                //User updated successfully
                MessageBox.Show("User updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating user.");
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
                    cmd.Parameters.AddWithValue("@userName", this.UserName);
                    cmd.Parameters.AddWithValue("@password", this.Password);

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
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error authenticating user");
                return false;
            }
        }

        //Get user from database based on userid
        public User GetUser(int userId)
        {
            User user = new User();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getUserQuery = "SELECT * FROM user WHERE userId = @userId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getUserQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@userId", userId);
                    //Execute read command
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.UserId = reader.GetInt32("userId");
                            user.UserName = reader.GetString("userName");
                            user.Password = reader.GetString("password");
                            user.Active = reader.GetInt32("active");
                            user.CreateDate = reader.GetDateTime("createDate");
                            user.CreatedBy = reader.GetString("createdBy");
                            user.LastUpdate = reader.GetDateTime("lastUpdate");
                            user.LastUpdateBy = reader.GetString("lastUpdateBy");
                        }
                    }
                    //Close connection
                    conn.Close();
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting user");
                return null;
            }
        }

        //Alert User
        //Alert User when they are logged on and they have an appointment in 15 minutes
        public void AlertUser(User user)
        {
            //Assign to local object
            this.UserId = user.UserId;
            try
            {
                //Create connection object
                using (conn)
                {
                    //Open connection
                    conn.Open();
                    //Create query to verify username and password
                    string alertQuery = "SELECT COUNT(*) FROM appointment WHERE userId = @userId AND start BETWEEN NOW() AND DATE_ADD(NOW(), INTERVAL 15 MINUTE)";
                    //Create a command object
                    MySqlCommand cmd = new MySqlCommand(alertQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@userId", this.UserId);
                    int count;
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    //if the query returns a result, the user is authenticated
                    if (count > 0)
                    {
                        //User is authenticated
                        //Close connection
                        conn.Close();
                        //Return true
                        MessageBox.Show("You have an appointment in 15 minutes.");
                    }
                    else
                    {
                        //Close connection
                        conn.Close();
                        ///Return false
                        MessageBox.Show("You have no appointments in the next 15 minutes.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error alerting user");
            }
        }//End UserAlertMethod

        //Get next userId
        public int GetNextUserId()
        {
            int nextUserId;
            int maxUsers;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getNextUserIdQuery = "SELECT MAX(userId) FROM user";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getNextUserIdQuery, conn);
                    //Execute command
                    maxUsers = Convert.ToInt32(cmd.ExecuteScalar());
                    //Add one to include row 0
                    nextUserId = maxUsers + 1;
                    //Close connection
                    conn.Close();
                    return nextUserId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting next userId");
                return 0;
            }
        }//End GetNextUserId Method

        //Get all users
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create query string
                    string getAllUsersQuery = "SELECT * FROM user";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getAllUsersQuery, conn);
                    //Execute read command
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.UserId = reader.GetInt32("userId");
                            user.UserName = reader.GetString("userName");
                            user.Password = reader.GetString("password");
                            user.Active = reader.GetInt32("active");
                            user.CreateDate = reader.GetDateTime("createDate");
                            user.CreatedBy = reader.GetString("createdBy");
                            user.LastUpdate = reader.GetDateTime("lastUpdate");
                            user.LastUpdateBy = reader.GetString("lastUpdateBy");
                            users.Add(user);
                        }
                    }
                    //Close connection
                    conn.Close();
                    return users;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting all users");
                return null;
            }
        }//End GetAllUsers Method
    }
}
