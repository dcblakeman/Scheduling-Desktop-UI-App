using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using Scheduling_Desktop_UI_App.Classes;


namespace Scheduling_Desktop_UI_App
{
    public partial class UserRegisterPage : Form
    {
        //Create Logged In User Object
        private User _user;

        //Create New Registered user object
        private User _newUser = new User();

        //Create Connection Object
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
        public UserRegisterPage()
        {
            InitializeComponent();
            //Get next userId
            _newUser.UserId = _newUser.GetNextUserId();
            //Populate UserIdTextBox
            UserIdTextBox.Text = _newUser.UserId.ToString();
        }

        public UserRegisterPage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login Form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //New User object
            User newUser = new User();
            //Validate Password
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if(PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            //Insert User into mysql database
            newUser.UserName = UserNameTextBox.Text;
            newUser.Password = PasswordTextBox.Text;

            try
            {
                //Open connection
                conn.Open();
                //Create query
                string query = "INSERT INTO user (userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@username, @password, 1, now(), 'test', now(), 'test')";
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Add parameters
                cmd.Parameters.AddWithValue("@username", newUser.UserName);
                cmd.Parameters.AddWithValue("@password", newUser.Password);
                cmd.Parameters.AddWithValue("@active", 1);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@createdBy", newUser);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", newUser);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Registered Successfully.");

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Return to Login Form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void UserRegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
