﻿using System;
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
    public partial class AddAppointmentPage : Form
    {
        public AddAppointmentPage()
        {
            InitializeComponent();
        }

        private void AddAppointmentPage_Load(object sender, EventArgs e)
        {
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return to Appointment Navigation Page
            AppointmentNavigationPage appointmentNavigationPage = new AppointmentNavigationPage();
            appointmentNavigationPage.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
