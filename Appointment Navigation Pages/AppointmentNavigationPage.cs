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
    public partial class AppointmentNavigationPage : Form
    {
        public AppointmentNavigationPage()
        {
            InitializeComponent();
        }

        private void ToNavigationPageButton_Click(object sender, EventArgs e)
        {
            //Create Navigation page Object
            MainNavigationPage mainNavigationPage = new MainNavigationPage();
            //Show the navigation page
            mainNavigationPage.Show();
            //Hide the appointment navigation page
            this.Hide();
        }
    }
}
