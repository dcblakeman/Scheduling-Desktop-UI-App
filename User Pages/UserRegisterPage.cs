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
            newUser.Active = Convert.ToInt32(ActiveTextBox.Text);

            //Check to see who added user - user themselves, or another user
            if(_user != null)
            {
                newUser.CreateDate = DateTime.Now;
                newUser.CreatedBy = _user.UserName;
                newUser.LastUpdate = DateTime.Now;
                newUser.LastUpdateBy = _user.UserName;
            }
            else
            {
                newUser.CreateDate = DateTime.Now;
                newUser.CreatedBy = newUser.UserName;
                newUser.LastUpdate = DateTime.Now;
                newUser.LastUpdateBy = newUser.UserName;
            }

            
            //Check to see if userName is already in use
            if (!newUser.InsertUser(newUser))
            {
                MessageBox.Show("Username already in use. Please choose a different username.");
                return;
            } else
            {
                MessageBox.Show("User added successfully!");
            }

            //Return to Login Form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void UserRegisterPage_Load(object sender, EventArgs e)
        {
            //Assign next user Id to userID text box
            UserIdTextBox.Text = _newUser.UserId.ToString();
        }

        private void ActiveTextBox_TextChanged(object sender, EventArgs e)
        {
            //Make sure only a 1 or 0 is entered
            if (ActiveTextBox.Text != "1" && ActiveTextBox.Text != "0")
            {
                MessageBox.Show("Please enter a 1 or 0.");
                ActiveTextBox.Text = "";
            }
        }

        private void UserGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
