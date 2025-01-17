using MySql.Data.MySqlClient;
using Scheduling_Desktop_UI_App.Classes;
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
    public partial class ListUsersPage : Form
    {
        //Create connection
        private MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString);
        //Row index
        int _index;
        //Selected User
        User _SelectedUser;
        public ListUsersPage()
        {
            InitializeComponent();
            try
            {
                //Open connection
                conn.Open();
                //Create query to populate datagridview
                string query = "SELECT userId, userName, active FROM user";
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //Create dataset
                DataSet ds = new DataSet();
                //Fill dataset
                adapter.Fill(ds);
                //Set datagridview data source to dataset
                ListUsersDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ListUsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Refresh datagridview
                string selectQuery = "SELECT userId, userName, password, active FROM user";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
                DataSet ds = new DataSet();
                //Make sure password isn't visible
                ListUsersDataGridView.Columns[2].Visible = false;
                adapter.Fill(ds);
                ListUsersDataGridView.DataSource = ds.Tables[0];
                //Unselect 1st row
                ListUsersDataGridView.Rows[0].Selected = false;
                //Make 3rd row selected
                ListUsersDataGridView.Rows[_index].Selected = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ListUsersCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login screen
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            //Delete user from database
            string userId = ListUsersDataGridView.CurrentRow.Cells[0].Value.ToString();
            _index = ListUsersDataGridView.CurrentCell.RowIndex;
            string query = $"DELETE FROM user WHERE userId = {userId}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Refresh datagridview
            string selectQuery = "SELECT userId, userName FROM user";
            MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ListUsersDataGridView.DataSource = ds.Tables[0];
            //Unselect 1st row
            ListUsersDataGridView.Rows[0].Selected = false;
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get selected user
                User selectedUser = new User();
                selectedUser.UserId = Convert.ToInt32(ListUsersDataGridView.CurrentRow.Cells[0].Value);

                //Go to UpdateUserPage
                UpdateUserPage updateUserPage = new UpdateUserPage(selectedUser);
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
