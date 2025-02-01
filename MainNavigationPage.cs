using Scheduling_Desktop_UI_App.Classes;
using Scheduling_Desktop_UI_App.User_Navigation_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App
{
    public partial class MainNavigationPage : Form
    {
        User _user;
        Customer _customer;
        public MainNavigationPage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public MainNavigationPage(User user, Customer customer)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            //Navigate to Customers Form
            CustomerNavigationPage customersForm = new CustomerNavigationPage(_user);
            customersForm.Show();
            this.Hide();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            
            //Navigate to Appointments Form
            if(_customer == null)
            {
                //If the customer is null, navigate to the Appointment Navigation Page with just the user
                AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user);
                appointmentNavigationPage.Show();
                this.Hide();
            }
            else
            {
                //If the customer is not null, navigate to the Appointment Navigation Page with the user and customer
                AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(_user, _customer);
                appointmentNavigationPage.Show();
                this.Hide();
            }
            
        }

        private void MainNavigationPage_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            //Go to UserListPage
            UserNavigationPage listUsersPage = new UserNavigationPage(_user);
            listUsersPage.Show();
            this.Hide();
        }
    }
}
