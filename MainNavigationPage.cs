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

namespace Scheduling_Desktop_UI_App
{
    public partial class MainNavigationPage : Form
    {
        string userName;
        public MainNavigationPage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            //Navigate to Customers Form
            CustomerNavigationPage customersForm = new CustomerNavigationPage(userName);
            customersForm.Show();
            this.Hide();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            //Navigate to Appointments Form
            AppointmentNavigationPage appointmentsForm = new AppointmentNavigationPage(userName);
            appointmentsForm.Show();
            this.Hide();
        }

        private void MainNavigationPage_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(userName);
            loginForm.Show();
            this.Hide();
        }
    }
}
