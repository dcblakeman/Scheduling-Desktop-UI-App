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
    public partial class CustomerNavigationPage : Form
    {
        public CustomerNavigationPage()
        {
            InitializeComponent();
        }

        private void ToNavigationFormButton_Click(object sender, EventArgs e)
        {
            MainNavigationPage navigation_Page = new MainNavigationPage();
            navigation_Page.Show();
            this.Hide();

        }
    }
}
