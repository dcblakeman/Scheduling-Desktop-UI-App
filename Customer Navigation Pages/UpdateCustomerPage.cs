using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    public partial class UpdateCustomerPage : Form
    {
        public UpdateCustomerPage()
        {
            InitializeComponent();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            //Navigate to Update Customer Form
            UpdateCustomerPage updateCustomerPage = new UpdateCustomerPage();
            updateCustomerPage.Show();
            this.Hide();
        }

        private void UpdateCustomerPage_Load(object sender, EventArgs e)
        {
        }

        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Customer Navigation Page
            this.Close();
        }
    }


}
