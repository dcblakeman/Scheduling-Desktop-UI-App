using Scheduling_Desktop_UI_App.Classes;
using Scheduling_Desktop_UI_App.User_Navigation_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.User_Pages
{
    public partial class UserUpdatePage : Form
    {
        User _user;
        User _selectedUser = new User();
        public UserUpdatePage(User user, User selectedUser)
        {
            InitializeComponent();
            _user = user;
            _selectedUser = selectedUser;
        }

        private void UserUpdatePage_Load(object sender, EventArgs e)
        {
            //Assign object attributes to text boxes
            UserIdTextBox.Text = _selectedUser.UserId.ToString();
            UserNameTextBox.Text = _selectedUser.UserName;
            PasswordTextBox.Text = _selectedUser.Password;
            ConfirmPasswordTextBox.Text = _selectedUser.Password;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int value;
            //Validate populated fields
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            //Validate matching passwords
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            //Check to see if any changes were made to user object fields
            if (UserIdTextBox.Text == _selectedUser.UserId.ToString() && UserNameTextBox.Text == _selectedUser.UserName && PasswordTextBox.Text == _selectedUser.Password)
            {
                MessageBox.Show("No changes were made.");
            } else
            {
                //Assign text boxes to selected user object
                _selectedUser.UserId = Convert.ToInt32(UserIdTextBox.Text);
                _selectedUser.UserName = UserNameTextBox.Text;
                _selectedUser.Password = PasswordTextBox.Text;

                _selectedUser.LastUpdate = DateTime.Now;
                _selectedUser.LastUpdateBy = _user.UserName;
                value = _selectedUser.UpdateUser(_selectedUser, _user);
                if (value == 1)
                {
                    MessageBox.Show("User updated successfully.");
                    UserNavigationPage userNavigationPage = new UserNavigationPage(_user);
                    userNavigationPage.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("User update failed.");
                }
            }
        }//End UpdateButton Click Event

        private void ActiveTextBox_TextChanged(object sender, EventArgs e)
        {
            //Only accept a 1 or a 0 here
            if (ActiveTextBox.Text != "1" && ActiveTextBox.Text != "0")
            {
                MessageBox.Show("Please enter a 1 or a 0.");
                ActiveTextBox.Text = "1";
            }
        }

        private void RegisterUserCancelButton_Click(object sender, EventArgs e)
        {
            if(_user != null)
            {
                //Return to User Navigation Page
                UserNavigationPage userNavigationPage = new UserNavigationPage(_user);
                userNavigationPage.Show();
                this.Hide();
            }
            else
            {
                //Return to Login Page
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
            //Return to User Navigation Page
        }
    }
}
