using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    public partial class UpdateAppointmentPage : Form
    {
        string userName;
        public UpdateAppointmentPage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage(userName);
            appointmentNavigationPage.Show();
            this.Hide();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAppointmentGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
