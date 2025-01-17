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
    public partial class UpdateUserPage : Form
    {
        User _selectedUser;
        public UpdateUserPage()
        {
            InitializeComponent();
        }
        public UpdateUserPage(User selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to login screen
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
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

            //Send updated information to database
            _selectedUser.UpdateUser(_selectedUser);

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
            ListUsersPage listUsersPage = new ListUsersPage();
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
    }
}
