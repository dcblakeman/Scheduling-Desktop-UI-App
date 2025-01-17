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

namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    public partial class CustomerUpdatePage : Form
    {
        User _user;
        Customer _customer;

        //Connection string
        private string connectionString = ConfigurationManager.ConnectionStrings["JavaConnection"].ConnectionString;

        public CustomerUpdatePage(Customer customer, User user)
        {
            InitializeComponent();
            _user = user;
            _customer = customer;
        }

        private void CustomerUpdatePage_Load(object sender, EventArgs e)
        {
            //Call Update Customer
            _customer.UpdateCustomer(_customer, _user);
        }
        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Customer Navigation Page
            CustomerNavigationPage customerNavigationPage = new CustomerNavigationPage();
            customerNavigationPage.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Update Customer
            _customer.UpdateCustomer(_customer, _user);

        }
    }
}
