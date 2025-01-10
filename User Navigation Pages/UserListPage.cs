using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Classes;
using Scheduling_Desktop_UI_App.User_Navigation_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App
{
    public partial class UserListPage : Form
    {
        string userName;
        public UserListPage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void UserListPage_Load(object sender, EventArgs e)
        {
            
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //Go to Register User Page
            RegisterUserPage registerUserPage = new RegisterUserPage(userName);
            registerUserPage.Show();
            this.Hide();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            //Take selected datagridvew row information to Update User Page
            UpdateUserPage updateUserPage = new UpdateUserPage();
            updateUserPage.Show();
            this.Hide();
        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select a row in the UserDataGridView
            if (e.RowIndex >= 0)
            {
                User user = new User();
                DataGridViewRow row = this.UserDataGridView.Rows[e.RowIndex];
                user.UserId = Convert.ToInt32(row.Cells["userId"].Value);
                user.UserName = row.Cells["userName"].Value.ToString();
                user.Password = row.Cells["password"].Value.ToString();
                user.Active = Convert.ToInt32(row.Cells["active"].Value);
                user.CreateDate = Convert.ToDateTime(row.Cells["createDate"].Value);
                user.CreatedBy = row.Cells["createdBy"].Value.ToString();
                user.LastUpdate = Convert.ToDateTime(row.Cells["lastUpdate"].Value);
                user.LastUpdateBy = row.Cells["lastUpdateBy"].Value.ToString();
            }
        }
    }
}
