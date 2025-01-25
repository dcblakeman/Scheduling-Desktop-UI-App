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
    public partial class GenerateReportsPage : Form
    {
        public GenerateReportsPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerateReportsCancelButton_Click(object sender, EventArgs e)
        {
            //Return to Login Form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Hide();
        }

        private void AppointmentTypeCountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
