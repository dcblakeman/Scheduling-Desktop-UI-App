using MySql.Data.MySqlClient;
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
    public partial class AppointmentNavigationPage : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString;
        public AppointmentNavigationPage()
        {
            InitializeComponent();
        }

        private void AppointmentNavigationPage_Load(object sender, EventArgs e)
        {
            // Retrieve the connection string from the App.config file
            string query = "SELECT * FROM appointment"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    AppointmentDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
