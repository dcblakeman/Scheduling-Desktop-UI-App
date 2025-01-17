namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    partial class AppointmentUpdatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentUpdatePage));
            this.UpdateAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AvailableAppointmentsDataGridViewLabel = new System.Windows.Forms.Label();
            this.UpcomingAppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.UpcomingAppointmentsCalendar = new System.Windows.Forms.MonthCalendar();
            this.AddAppointmentCancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentIdTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentIdLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.UpdateAppointmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingAppointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateAppointmentGroupBox
            // 
            this.UpdateAppointmentGroupBox.Controls.Add(this.EndDateTimePicker);
            this.UpdateAppointmentGroupBox.Controls.Add(this.StartDateTimePicker);
            this.UpdateAppointmentGroupBox.Controls.Add(this.AvailableAppointmentsDataGridViewLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.UpcomingAppointmentsDataGridView);
            this.UpdateAppointmentGroupBox.Controls.Add(this.UpcomingAppointmentsCalendar);
            this.UpdateAppointmentGroupBox.Controls.Add(this.AddAppointmentCancelButton);
            this.UpdateAppointmentGroupBox.Controls.Add(this.SubmitButton);
            this.UpdateAppointmentGroupBox.Controls.Add(this.UrlTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.TypeTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.ContactTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.LocationTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.DescriptionTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.TitleTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.UserIdTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.CustomerIdTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.AppointmentIdTextBox);
            this.UpdateAppointmentGroupBox.Controls.Add(this.AppointmentIdLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.EndTimeLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.CustomerIdLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.StartTimeLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.UserIdLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.UrlLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.TitleLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.TypeLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.DescriptionLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.ContactLabel);
            this.UpdateAppointmentGroupBox.Controls.Add(this.LocationLabel);
            resources.ApplyResources(this.UpdateAppointmentGroupBox, "UpdateAppointmentGroupBox");
            this.UpdateAppointmentGroupBox.Name = "UpdateAppointmentGroupBox";
            this.UpdateAppointmentGroupBox.TabStop = false;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.EndDateTimePicker, "EndDateTimePicker");
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.TabStop = false;
            this.EndDateTimePicker.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // StartDateTimePicker
            // 
            resources.ApplyResources(this.StartDateTimePicker, "StartDateTimePicker");
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Value = new System.DateTime(2025, 1, 16, 0, 0, 0, 0);
            this.StartDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // AvailableAppointmentsDataGridViewLabel
            // 
            resources.ApplyResources(this.AvailableAppointmentsDataGridViewLabel, "AvailableAppointmentsDataGridViewLabel");
            this.AvailableAppointmentsDataGridViewLabel.Name = "AvailableAppointmentsDataGridViewLabel";
            // 
            // UpcomingAppointmentsDataGridView
            // 
            this.UpcomingAppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.UpcomingAppointmentsDataGridView, "UpcomingAppointmentsDataGridView");
            this.UpcomingAppointmentsDataGridView.MultiSelect = false;
            this.UpcomingAppointmentsDataGridView.Name = "UpcomingAppointmentsDataGridView";
            this.UpcomingAppointmentsDataGridView.ReadOnly = true;
            this.UpcomingAppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // UpcomingAppointmentsCalendar
            // 
            resources.ApplyResources(this.UpcomingAppointmentsCalendar, "UpcomingAppointmentsCalendar");
            this.UpcomingAppointmentsCalendar.Name = "UpcomingAppointmentsCalendar";
            // 
            // AddAppointmentCancelButton
            // 
            resources.ApplyResources(this.AddAppointmentCancelButton, "AddAppointmentCancelButton");
            this.AddAppointmentCancelButton.Name = "AddAppointmentCancelButton";
            this.AddAppointmentCancelButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // UrlTextBox
            // 
            resources.ApplyResources(this.UrlTextBox, "UrlTextBox");
            this.UrlTextBox.Name = "UrlTextBox";
            // 
            // TypeTextBox
            // 
            resources.ApplyResources(this.TypeTextBox, "TypeTextBox");
            this.TypeTextBox.Name = "TypeTextBox";
            // 
            // ContactTextBox
            // 
            resources.ApplyResources(this.ContactTextBox, "ContactTextBox");
            this.ContactTextBox.Name = "ContactTextBox";
            // 
            // LocationTextBox
            // 
            resources.ApplyResources(this.LocationTextBox, "LocationTextBox");
            this.LocationTextBox.Name = "LocationTextBox";
            // 
            // DescriptionTextBox
            // 
            resources.ApplyResources(this.DescriptionTextBox, "DescriptionTextBox");
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            // 
            // TitleTextBox
            // 
            resources.ApplyResources(this.TitleTextBox, "TitleTextBox");
            this.TitleTextBox.Name = "TitleTextBox";
            // 
            // UserIdTextBox
            // 
            resources.ApplyResources(this.UserIdTextBox, "UserIdTextBox");
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ReadOnly = true;
            // 
            // CustomerIdTextBox
            // 
            resources.ApplyResources(this.CustomerIdTextBox, "CustomerIdTextBox");
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.ReadOnly = true;
            // 
            // AppointmentIdTextBox
            // 
            resources.ApplyResources(this.AppointmentIdTextBox, "AppointmentIdTextBox");
            this.AppointmentIdTextBox.Name = "AppointmentIdTextBox";
            this.AppointmentIdTextBox.ReadOnly = true;
            // 
            // AppointmentIdLabel
            // 
            resources.ApplyResources(this.AppointmentIdLabel, "AppointmentIdLabel");
            this.AppointmentIdLabel.Name = "AppointmentIdLabel";
            // 
            // EndTimeLabel
            // 
            resources.ApplyResources(this.EndTimeLabel, "EndTimeLabel");
            this.EndTimeLabel.Name = "EndTimeLabel";
            // 
            // CustomerIdLabel
            // 
            resources.ApplyResources(this.CustomerIdLabel, "CustomerIdLabel");
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            // 
            // StartTimeLabel
            // 
            resources.ApplyResources(this.StartTimeLabel, "StartTimeLabel");
            this.StartTimeLabel.Name = "StartTimeLabel";
            // 
            // UserIdLabel
            // 
            resources.ApplyResources(this.UserIdLabel, "UserIdLabel");
            this.UserIdLabel.Name = "UserIdLabel";
            // 
            // UrlLabel
            // 
            resources.ApplyResources(this.UrlLabel, "UrlLabel");
            this.UrlLabel.Name = "UrlLabel";
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            // 
            // TypeLabel
            // 
            resources.ApplyResources(this.TypeLabel, "TypeLabel");
            this.TypeLabel.Name = "TypeLabel";
            // 
            // DescriptionLabel
            // 
            resources.ApplyResources(this.DescriptionLabel, "DescriptionLabel");
            this.DescriptionLabel.Name = "DescriptionLabel";
            // 
            // ContactLabel
            // 
            resources.ApplyResources(this.ContactLabel, "ContactLabel");
            this.ContactLabel.Name = "ContactLabel";
            // 
            // LocationLabel
            // 
            resources.ApplyResources(this.LocationLabel, "LocationLabel");
            this.LocationLabel.Name = "LocationLabel";
            // 
            // AppointmentUpdatePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateAppointmentGroupBox);
            this.Name = "AppointmentUpdatePage";
            this.UpdateAppointmentGroupBox.ResumeLayout(false);
            this.UpdateAppointmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingAppointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UpdateAppointmentGroupBox;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label AvailableAppointmentsDataGridViewLabel;
        private System.Windows.Forms.DataGridView UpcomingAppointmentsDataGridView;
        private System.Windows.Forms.MonthCalendar UpcomingAppointmentsCalendar;
        private System.Windows.Forms.Button AddAppointmentCancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.TextBox AppointmentIdTextBox;
        private System.Windows.Forms.Label AppointmentIdLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
    }
}