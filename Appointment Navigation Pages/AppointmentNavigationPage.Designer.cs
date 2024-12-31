namespace Scheduling_Desktop_UI_App
{
    partial class AppointmentNavigationPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToNavigationPageButton = new System.Windows.Forms.Button();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentNavigationLabel = new System.Windows.Forms.Label();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToNavigationPageButton
            // 
            this.ToNavigationPageButton.Location = new System.Drawing.Point(531, 341);
            this.ToNavigationPageButton.Name = "ToNavigationPageButton";
            this.ToNavigationPageButton.Size = new System.Drawing.Size(187, 23);
            this.ToNavigationPageButton.TabIndex = 1;
            this.ToNavigationPageButton.Text = "Main Navigation";
            this.ToNavigationPageButton.UseVisualStyleBackColor = true;
            this.ToNavigationPageButton.Click += new System.EventHandler(this.ToNavigationPageButton_Click);
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(77, 278);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(115, 23);
            this.DeleteAppointmentButton.TabIndex = 2;
            this.DeleteAppointmentButton.Text = "Delete Appointment";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(77, 208);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(115, 23);
            this.UpdateAppointmentButton.TabIndex = 3;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(77, 138);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(115, 23);
            this.AddAppointmentButton.TabIndex = 4;
            this.AddAppointmentButton.Text = "Add Appointment";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentNavigationLabel
            // 
            this.AppointmentNavigationLabel.AutoSize = true;
            this.AppointmentNavigationLabel.Location = new System.Drawing.Point(339, 62);
            this.AppointmentNavigationLabel.Name = "AppointmentNavigationLabel";
            this.AppointmentNavigationLabel.Size = new System.Drawing.Size(120, 13);
            this.AppointmentNavigationLabel.TabIndex = 5;
            this.AppointmentNavigationLabel.Text = "Appointment Navigation";
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(292, 138);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.Size = new System.Drawing.Size(377, 163);
            this.appointmentsDataGridView.TabIndex = 6;
            // 
            // AppointmentsNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(this.AppointmentNavigationLabel);
            this.Controls.Add(this.ToNavigationPageButton);
            this.Controls.Add(this.DeleteAppointmentButton);
            this.Controls.Add(this.UpdateAppointmentButton);
            this.Controls.Add(this.AddAppointmentButton);
            this.Name = "AppointmentsNavigationPage";
            this.Text = "Appointments Navigation Page";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToNavigationPageButton;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Label AppointmentNavigationLabel;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
    }
}