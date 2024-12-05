using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Device.Location;
using BundlerMinifier;
using MySql.Data.MySqlClient;
using System.Resources;
using System.Reflection;
using System.Threading;


namespace Scheduling_Desktop_UI_App
{
    public partial class LoginForm : Form
    {
        private readonly GeoCoordinateWatcher _watcher;
        public LoginForm()
        {
            InitializeComponent();

            // Set up the GeoCoordinateWatcher
            _watcher = new GeoCoordinateWatcher();
            _watcher.StatusChanged += Watcher_StatusChanged;
            _watcher.PositionChanged += Watcher_PositionChanged;
            _watcher.Start();
        }

        private static void Watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Console.WriteLine($"Position changed to: Latitude {e.Position.Location.Latitude}, Longitude {e.Position.Location.Longitude}");
        }

        private static void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            Console.WriteLine($"Status changed to: {e.Status}");
        }

        private void LoginForm_Load(object sender, EventArgs e)

        {
            // Optional: Check if location data is available immediately after loading the form
            GeoCoordinate coordinate = _watcher.Position.Location;

            if (coordinate.IsUnknown)
            {
                MessageBox.Show("Location is not available. Please wait...");
            }
            else
            {
                MessageBox.Show($"Initial Location: Latitude {coordinate.Latitude}, Longitude {coordinate.Longitude}");
            }
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Password_Label_Click(object sender, EventArgs e)
        {

        }

        private void SchedulingAppLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=schedulingdb;User ID=root;Password=password;Pooling=true;";

            // Set up the resource manager to access resource files
            ResourceManager resourceManager = new ResourceManager("Scheduling_Desktop_UI_App.Properties.Resources", typeof(Program).Assembly);

            // Get the user's UI culture
            CultureInfo uiCulture = CultureInfo.CurrentUICulture;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM user WHERE userName = @userName AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userName", UsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Retrieve the translation for the key "Greeting"
                        string translatedMessage = resourceManager.GetString("LoginSuccessfulMessage", uiCulture);

                        // Output the translated message
                        MessageBox.Show(translatedMessage);
                        // Navigate to the next form or main application window.
                        MainNavigationPage navigation_page = new MainNavigationPage();
                        navigation_page.Show();
                        this.Hide();


                    }
                    else
                    {
                        // Retrieve the translation for the key "Greeting"
                        string translatedMessage = resourceManager.GetString("LoginErrorMessage", uiCulture);

                        // Output the translated message
                        MessageBox.Show(translatedMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
