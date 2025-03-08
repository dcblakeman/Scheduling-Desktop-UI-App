using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int UpdateUser(User user, User selectedUser)
        {
            UserId = selectedUser.UserId;
            UserName = selectedUser.UserName;
            Password = selectedUser.Password;
            Active = selectedUser.Active;
            LastUpdate = DateTime.Now;
            LastUpdateBy = user.UserName;
            int value;
            try
            {
                //Create connection object
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
                
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

                //Open connection and execute query
                conn.Open();
                value = cmd.ExecuteNonQuery();
                conn.Close();
                return value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error updating user.");
                return 0;
            }
        }
        public int UserAuthentication(User user)
        {
            //Assign to local object
            this.UserName = user.UserName;
            this.Password = user.Password;

            try
            {
                //Check and see if the user.UserName and password are correct in the database
                //Create connection object
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
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
                        //Return userId from userName
                        string getUserIdQuery = "SELECT userId FROM user WHERE userName = @userName";
                        MySqlCommand cmd2 = new MySqlCommand(getUserIdQuery, conn);
                        cmd2.Parameters.AddWithValue("@userName", this.UserName);
                        int userId = Convert.ToInt32(cmd2.ExecuteScalar());
                        //Close connection
                        conn.Close();
                        return userId;
                    }
                    else
                    {
                        //Close connection
                        conn.Close();

                        //Return 0
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error authenticating user");
                return 0;
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
                    
                    //Create query string
                    string getUserQuery = "SELECT * FROM user WHERE userId = @userId";
                    //Create command
                    MySqlCommand cmd = new MySqlCommand(getUserQuery, conn);
                    //Add parameters
                    cmd.Parameters.AddWithValue("@userId", userId);

                    //Open connection and execute reader
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.UserId = reader.GetInt32("userId");
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
        public List<User> GetAllUsersList()
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

        //Insert User Method
        public bool InsertUser(User user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    //Check and see if user is already in the mysql db
                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE userName = @userName";
                    MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, conn);
                    checkUserCmd.Parameters.AddWithValue("@userName", user.UserName);
                    int count;
                    count = Convert.ToInt32(checkUserCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        //User already exists
                        MessageBox.Show("User already exists.");
                        conn.Close();
                        return false;
                    }
                    string insertUserQuery = "INSERT INTO user (userId, userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@userId, @userName, @password, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                    MySqlCommand cmd = new MySqlCommand(insertUserQuery, conn);
                    cmd.Parameters.AddWithValue("@userId", user.UserId);
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@active", user.Active);
                    cmd.Parameters.AddWithValue("@createDate", user.CreateDate);
                    cmd.Parameters.AddWithValue("@createdBy", user.CreatedBy);
                    cmd.Parameters.AddWithValue("@lastUpdate", user.LastUpdate);
                    cmd.Parameters.AddWithValue("@lastUpdateBy", user.LastUpdateBy);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error inserting user");
                return false;
            }
        }//End InsertUser Method

        //DeleteUser Method
        public int DeleteUser(int userId)
        {
            int value;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string deleteUserQuery = "DELETE FROM user WHERE userId = @userId";
                    MySqlCommand cmd = new MySqlCommand(deleteUserQuery, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    value = cmd.ExecuteNonQuery();
                    conn.Close();
                    return value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error deleting user");
                return 0;
            }
        }//End DeleteUser Method

        public SortedDictionary<User, Appointment> GetUsersAppointments()
        {
            SortedDictionary<User, Appointment> keyValuePairs = new SortedDictionary<User, Appointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString))
                {
                    conn.Open();
                    string getKeyValuePairsQuery = "SELECT user.userName, appointment.start, appointment.end, appointment.type FROM appointment JOIN user ON appointment.userId = user.userId";
                    MySqlCommand cmd = new MySqlCommand(getKeyValuePairsQuery, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            Appointment appointment = new Appointment();
                            user.UserName = reader.GetString("userName");
                            appointment.Start = reader.GetDateTime("start");
                            appointment.End = reader.GetDateTime("end");
                            appointment.Type = reader.GetString("type");
                            keyValuePairs.Add(user, appointment);
                        }
                    }
                    conn.Close();
                    return keyValuePairs;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Error getting key value pairs");
                return null;
            }
        }//End GetKeyValuePairs Method

    }
}
