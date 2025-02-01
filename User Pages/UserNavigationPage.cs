using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Classes;
using Scheduling_Desktop_UI_App.User_Pages;
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

namespace Scheduling_Desktop_UI_App.User_Navigation_Pages
{
    public partial class UserNavigationPage : Form
    {
        //Create connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);

        //Selected User
        User _selectedUser = new User();
        //User
        User _user;
        public UserNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
            try
            {
                //Open connection
                conn.Open();
                //Create query to populate datagridview
                string query = "SELECT * FROM user";
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //Create dataset
                DataSet ds = new DataSet();
                //Fill dataset
                adapter.Fill(ds);
                //Set datagridview data source to dataset
                UserListDataGridView.DataSource = ds.Tables[0];
                //Unselect 1st row
                UserListDataGridView.Rows[0].Selected = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListUsersCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login screen
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            int value;
            //Delete user from database
            int userId = Convert.ToInt32(UserListDataGridView.CurrentRow.Cells[0].Value);
            value = _user.DeleteUser(userId);
            if(value == 1)
            {
                //Refresh datagridview
                string selectQuery = "SELECT userId, userName FROM user";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                UserListDataGridView.DataSource = dt;
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show("User Not Deleted");
            }
            
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            //Create UserUpdate Object
            UserUpdatePage userUpdatePage = new UserUpdatePage(_selectedUser, _user);
            userUpdatePage.Show();
            this.Hide();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //Go to UserRegiser page
            if(_user.UserId == 0)
            {
                UserRegisterPage userRegisterPage = new UserRegisterPage();
                userRegisterPage.Show();
                this.Hide();
            } else
            {
                UserRegisterPage userRegisterPage = new UserRegisterPage(_user);
            }
            
        }

        private void UserListPage_Load(object sender, EventArgs e)
        {

        }

        private void UserListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Refresh datagridview
                string selectQuery = "SELECT userId, userName, password, active FROM user";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
                DataSet ds = new DataSet();
                //Make sure password isn't visible
                UserListDataGridView.Columns[2].Visible = false;
                adapter.Fill(ds);
                UserListDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UserListCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login screen
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get selected user by userid
                int userId = Convert.ToInt32(UserListDataGridView.CurrentRow.Cells[0].Value);
                _selectedUser = _selectedUser.GetUser(userId);

                //Go to UpdateUserPage
                UserUpdatePage updateUserPage = new UserUpdatePage(_selectedUser, _user);
                updateUserPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
