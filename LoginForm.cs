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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Scheduling_Desktop_UI_App.Classes;
using System.IO;


namespace Scheduling_Desktop_UI_App
{
    public partial class LoginForm : Form
    {
        private readonly GeoCoordinateWatcher _watcher;
        private static readonly string logFilePath = "Login_History.txt";
        string userName;

        // Retrieve the connection string from the App.config file
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString;

        // Set up the resource manager to access resource files
        private readonly ResourceManager resourceManager = new ResourceManager("Scheduling_Desktop_UI_App.Properties.Resources", typeof(Program).Assembly);

        //Get current UI Culture
        private readonly CultureInfo uiCulture = Thread.CurrentThread.CurrentUICulture;

        // Get the current culture (language/region) of the system.
        private readonly CultureInfo currentCulture = CultureInfo.CurrentCulture;

        public LoginForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;

            // Set up the GeoCoordinateWatcher
            _watcher = new GeoCoordinateWatcher();
            _watcher.StatusChanged += Watcher_StatusChanged;
            _watcher.PositionChanged += Watcher_PositionChanged;
            _watcher.Start();

            // Print out the name of the current UI culture.
            Console.WriteLine($"Current UI language: {uiCulture.DisplayName}");

            // Print out a user-friendly name for the locale.
            Console.WriteLine($"Current system language: {currentCulture.DisplayName}"); 
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
        private void Login_Click(object sender, EventArgs e)
        {
            //Create User object
            User user = new User();
            user.UserName = UsernameTextBox.Text;
            user.Password = PasswordTextBox.Text;

            bool UserAuthenticated = user.UserAuthentication(user.UserName, user.Password);

            // Check if the query returned a result
            if (UserAuthenticated == true)
        {
                // Retrieve the translation for the key "Greeting"
                string translatedMessage = resourceManager.GetString("LoginSuccessfulMessage", currentCulture);

                // Output the translated message
                MessageBox.Show(translatedMessage);

                // Navigate to the next form or main application window and hide login window
                MainNavigationPage mainNavigationPage = new MainNavigationPage(user.UserName);
                mainNavigationPage.Show();
                this.Hide();

                // Log the login time
                DateTime loginTime = DateTime.Now;
                // Create a log entry
                string logEntry = $"{loginTime:yyyy-MM-dd HH:mm:ss} - {user.UserName}";
                // Write the log entry to the log file
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            else
            {
                // Retrieve the translation for the key "Greeting"
                string translatedMessage = resourceManager.GetString("LoginErrorMessage", currentCulture);

                // Output the translated message
                MessageBox.Show(translatedMessage);
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Open the Register User Page
            RegisterUserPage registerUserPage = new RegisterUserPage(userName);
            registerUserPage.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserList_Click(object sender, EventArgs e)
        {
            //Go to UserListPage
            UserListPage userListPage = new UserListPage(userName);
            userListPage.Show();
            this.Hide();
        }
    }
}
