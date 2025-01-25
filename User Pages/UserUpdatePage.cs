using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduling_Desktop_UI_App.Classes;
using ZstdSharp.Unsafe;

namespace Scheduling_Desktop_UI_App.User_Navigation_Pages
{
    public partial class UserUpdatePage : Form
    {
        User _selectedUser;
        User _user;
        public UserUpdatePage(User selectedUser, User user)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
            _user = user;

            //Assign selectedUser information to text fields
            UserIdTextBox2.Text = _selectedUser.UserId.ToString();
            UserNameTextBox1.Text = _selectedUser.UserName;
            PasswordTextBox1.Text = _selectedUser.Password;
            ActiveUserTextBox.Text = _selectedUser.Active.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to List Users Page
            UserListPage listUsersPage = new UserListPage(_user);
            listUsersPage.ShowDialog();
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Make sure passwordtextbox matches confirm password textbox
            if (PasswordTextBox1.Text != ConfirmPasswordTextBox1.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            //Assign updated username and password to user
            _selectedUser.UserName = UserNameTextBox1.Text;
            _selectedUser.Password = PasswordTextBox1.Text;
            _selectedUser.Active = Convert.ToInt32(ActiveUserTextBox.Text);

            //Send updated information to database
            _selectedUser.UpdateUser(_selectedUser);

            //Return to ListUsersPage
            UserListPage listUsersPage = new UserListPage(_user);
            listUsersPage.ShowDialog();
            this.Hide();
        }

        private void UserUpdatePage_Load(object sender, EventArgs e)
        {
            //Populate textbox fields
            UserIdTextBox2.Text = _selectedUser.UserId.ToString();
            UserNameTextBox.Text = _selectedUser.UserName;
            PasswordTextBox.Text = _selectedUser.Password;
            ActiveUserTextBox.Text = _selectedUser.Active.ToString();
        }

        private void UpdateUserCancelButton_Click(object sender, EventArgs e)
        {
            //Return to User Navigation Page
            UserListPage listUsersPage = new UserListPage(_user);
            listUsersPage.Show();
            this.Hide();

        }

        private void ActiveUserTextBox_TextChanged(object sender, EventArgs e)
        {
            //Make sure textbox.text is either 0 or 1
            if (ActiveUserTextBox.Text != "0" && ActiveUserTextBox.Text != "1")
            {
                MessageBox.Show("Please enter 0 or 1.");
                ActiveUserTextBox.Text = "";
            }
        }

        private void UpdateUserGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserIdTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
