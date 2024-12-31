using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location; // Add this using directive
using System.Text.Json;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Scheduling_Desktop_UI_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Retrieve the connection string from app.config
                string connectionString = ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString;

                // Use the connection string to create a MySQL connection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established successfully!");

                    // Test query (optional)
                    string query = "SELECT NOW()";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    var result = command.ExecuteScalar();
                    Console.WriteLine("Current Server Time: " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to database. Error: " + ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
