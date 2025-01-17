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
            this.AppointmentNavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentsLabel = new System.Windows.Forms.Label();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.NavigationAppointmentsCalendar = new System.Windows.Forms.MonthCalendar();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MainNavigationPageButton = new System.Windows.Forms.Button();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentNavigationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentNavigationGroupBox
            // 
            this.AppointmentNavigationGroupBox.Controls.Add(this.AppointmentsLabel);
            this.AppointmentNavigationGroupBox.Controls.Add(this.AppointmentsDataGridView);
            this.AppointmentNavigationGroupBox.Controls.Add(this.NavigationAppointmentsCalendar);
            this.AppointmentNavigationGroupBox.Controls.Add(this.QuitButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.MainNavigationPageButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.DeleteAppointmentButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.UpdateAppointmentButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.AddAppointmentButton);
            this.AppointmentNavigationGroupBox.Location = new System.Drawing.Point(48, 34);
            this.AppointmentNavigationGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentNavigationGroupBox.Name = "AppointmentNavigationGroupBox";
            this.AppointmentNavigationGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentNavigationGroupBox.Size = new System.Drawing.Size(1491, 565);
            this.AppointmentNavigationGroupBox.TabIndex = 7;
            this.AppointmentNavigationGroupBox.TabStop = false;
            this.AppointmentNavigationGroupBox.Text = "Appointment Navigation";
            this.AppointmentNavigationGroupBox.Enter += new System.EventHandler(this.AppointmentNavigationGroupBox_Enter);
            // 
            // AppointmentsLabel
            // 
            this.AppointmentsLabel.AutoSize = true;
            this.AppointmentsLabel.Location = new System.Drawing.Point(375, 54);
            this.AppointmentsLabel.Name = "AppointmentsLabel";
            this.AppointmentsLabel.Size = new System.Drawing.Size(108, 20);
            this.AppointmentsLabel.TabIndex = 52;
            this.AppointmentsLabel.Text = "Appointments";
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToOrderColumns = true;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(249, 85);
            this.AppointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentsDataGridView.MultiSelect = false;
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.RowHeadersWidth = 62;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(360, 454);
            this.AppointmentsDataGridView.TabIndex = 51;
            this.AppointmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDataGridView_CellContentClick);
            // 
            // NavigationAppointmentsCalendar
            // 
            this.NavigationAppointmentsCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.NavigationAppointmentsCalendar.Location = new System.Drawing.Point(627, 54);
            this.NavigationAppointmentsCalendar.Margin = new System.Windows.Forms.Padding(14);
            this.NavigationAppointmentsCalendar.Name = "NavigationAppointmentsCalendar";
            this.NavigationAppointmentsCalendar.TabIndex = 50;
            this.NavigationAppointmentsCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentsCalendar_DateChanged);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(24, 380);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(184, 42);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainNavigationPageButton
            // 
            this.MainNavigationPageButton.Location = new System.Drawing.Point(24, 306);
            this.MainNavigationPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainNavigationPageButton.Name = "MainNavigationPageButton";
            this.MainNavigationPageButton.Size = new System.Drawing.Size(184, 42);
            this.MainNavigationPageButton.TabIndex = 8;
            this.MainNavigationPageButton.Text = "Main Navigation Page";
            this.MainNavigationPageButton.UseVisualStyleBackColor = true;
            this.MainNavigationPageButton.Click += new System.EventHandler(this.MainNavigationPageButton_Click);
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(24, 233);
            this.DeleteAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(184, 42);
            this.DeleteAppointmentButton.TabIndex = 9;
            this.DeleteAppointmentButton.Text = "Delete Appointment";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = true;
            this.DeleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(24, 159);
            this.UpdateAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(184, 42);
            this.UpdateAppointmentButton.TabIndex = 10;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
            this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(24, 85);
            this.AddAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(184, 42);
            this.AddAppointmentButton.TabIndex = 11;
            this.AddAppointmentButton.Text = "Add Appointment";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // AppointmentNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 866);
            this.Controls.Add(this.AppointmentNavigationGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppointmentNavigationPage";
            this.Text = "Appointments Navigation Page";
            this.Load += new System.EventHandler(this.AppointmentNavigationPage_Load);
            this.AppointmentNavigationGroupBox.ResumeLayout(false);
            this.AppointmentNavigationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AppointmentNavigationGroupBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MainNavigationPageButton;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Label AppointmentsLabel;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.MonthCalendar NavigationAppointmentsCalendar;
    }
}