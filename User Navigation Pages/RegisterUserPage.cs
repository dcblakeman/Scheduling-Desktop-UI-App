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
    public partial class RegisterUserPage : Form
    {
        string userName;
        public RegisterUserPage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login Form
            LoginForm loginForm = new LoginForm(userName);
            loginForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Assign variables
            string userName = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            int active = 1;


            //Create User Object
            User User = new User();
            User.UserName = userName;
            User.Password = password;
            User.Active = active;
            User.CreateDate = DateTime.Now;
            User.CreatedBy = this.userName;
            User.LastUpdate = DateTime.Now;
            User.LastUpdateBy = this.userName;

            try
            {
                //Invoke InsertUser Method
                User.InsertUser(userName, password, active);

                //Success Dialog Box
                MessageBox.Show("Success!");

            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //Return to Login Form
            LoginForm loginForm = new LoginForm(userName);
            loginForm.Show();
            this.Hide();
        }
    }
}
