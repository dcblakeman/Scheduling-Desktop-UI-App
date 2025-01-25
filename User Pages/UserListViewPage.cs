using Scheduling_Desktop_UI_App.Classes;
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
    public partial class UserListViewPage : Form
    {
        //User object
        private User _user = new User();
        public UserListViewPage()
        {
            InitializeComponent();
            //Call GetAllUsers method
            //Set datagridview data source to list of users
            ListUsersDataGridView.DataSource = _user.GetAllUsers();
        }

        private void ListUsersCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login Form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void ListUsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserListViewPage_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
