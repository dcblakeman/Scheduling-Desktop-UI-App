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
using Scheduling_Desktop_UI_App.User_Navigation_Pages;
using Scheduling_Desktop_UI_App.User_Pages;


namespace Scheduling_Desktop_UI_App
{
    public partial class LoginPage : Form
    {
        private readonly GeoCoordinateWatcher _watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

        // Optional: Check if location data is available immediately after loading the form
        GeoCoordinate coordinate;

        private static readonly string logFilePath = "Login_History.txt";
        
        Country _country = new Country();
        City _city = new City();
        Address _address = new Address();
        Customer _customer = new Customer();
        Appointment _appointment = new Appointment();

        // Set up the resource manager to access resource files
        private readonly ResourceManager resourceManager = new ResourceManager("Scheduling_Desktop_UI_App.Properties.Resources", typeof(Program).Assembly);

        //Get current UI Culture
        private readonly CultureInfo uiCulture = Thread.CurrentThread.CurrentUICulture;

        // Get the current culture (language/region) of the system.
        private readonly CultureInfo currentCulture = CultureInfo.CurrentCulture;

        //Empty Constructor\
        public LoginPage()
        {
            InitializeComponent();

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
            //Show system user in console
            Console.WriteLine($"System User: {Environment.UserName}");

            //Create watcher object
            _watcher.StatusChanged += Watcher_StatusChanged;
            _watcher.PositionChanged += Watcher_PositionChanged;
            _watcher.Start();

            // Optional: Check if location data is available immediately after loading the form
            coordinate = _watcher.Position.Location;
            if (coordinate.IsUnknown)
            {
                Console.WriteLine("Unknown location");
            }
            else
            {
                MessageBox.Show($"Initial Location: Latitude {coordinate.Latitude}, Longitude {coordinate.Longitude}");
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Open the Register User Page
            UserRegisterPage userRegisterPage = new UserRegisterPage();
            userRegisterPage.Show();
            this.Hide();
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop watcher
            _watcher.Stop();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReportsButton_Click(object sender, EventArgs e)
        {
            //Open the Reports Page
            GenerateReportsPage reportsPage = new GenerateReportsPage();
            reportsPage.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Assign fields to user properties
            User _user = new User();
            _user.UserName = UserNameTextBox.Text;
            _user.Password = PasswordTextBox.Text;

            bool UserAuthenticated = _user.UserAuthentication(_user);

            // Check if the query returned a result
            if (UserAuthenticated == true)
            {
                // Retrieve the translation for the key "Greeting"
                string translatedMessage = resourceManager.GetString("LoginSuccessfulMessage", currentCulture);

                // Output the translated message
                MessageBox.Show(translatedMessage);

                // Navigate to the next form or main application window and hide login window
                MainNavigationPage mainNavigationPage = new MainNavigationPage(_user);
                mainNavigationPage.Show();
                this.Hide();

                // Log the login time
                DateTime loginTime = DateTime.Now;
                // Create a log entry
                string logEntry = $"{loginTime:yyyy-MM-dd HH:mm:ss} - {_user.UserName}";
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

        private void UserListViewButton_Click(object sender, EventArgs e)
        {
            //Go to UserLlistViewPage
            UserListViewPage userListViewPage = new UserListViewPage();
            userListViewPage.Show();
            this.Hide();
        }
    }
}
