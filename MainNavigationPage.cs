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
        User user;
        public MainNavigationPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            //Navigate to Customers Form
            CustomerNavigationPage customersForm = new CustomerNavigationPage(user);
            customersForm.Show();
            this.Hide();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            //Navigate to Appointments Form
            AppointmentNavigationPage appointmentsForm = new AppointmentNavigationPage(user);
            appointmentsForm.Show();
            this.Hide();
        }

        private void MainNavigationPage_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
