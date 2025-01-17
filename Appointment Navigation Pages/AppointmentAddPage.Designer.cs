namespace Scheduling_Desktop_UI_App.Appointment_Navigation_Pages
{
    partial class AppointmentAddPage
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "9:00:00 AM"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.White, new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("10:00:00 AM");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("11:00:00 AM");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("12:00:00 PM");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("1:00:00 PM");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("2:00:00 PM");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("3:00:00 PM");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("4:00:00 PM");
            this.AppointmentIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.AddAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentListView = new System.Windows.Forms.ListView();
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
            this.AddAppointmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingAppointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentIdLabel
            // 
            this.AppointmentIdLabel.AutoSize = true;
            this.AppointmentIdLabel.Location = new System.Drawing.Point(34, 46);
            this.AppointmentIdLabel.Name = "AppointmentIdLabel";
            this.AppointmentIdLabel.Size = new System.Drawing.Size(125, 20);
            this.AppointmentIdLabel.TabIndex = 0;
            this.AppointmentIdLabel.Text = "Appointment ID:";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(57, 83);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(103, 20);
            this.CustomerIdLabel.TabIndex = 0;
            this.CustomerIdLabel.Text = "Customer ID:";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(92, 120);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(68, 20);
            this.UserIdLabel.TabIndex = 0;
            this.UserIdLabel.Text = "User ID:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(117, 157);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(42, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(66, 194);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(86, 231);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(74, 20);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location:";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(90, 268);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(69, 20);
            this.ContactLabel.TabIndex = 0;
            this.ContactLabel.Text = "Contact:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(112, 305);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(47, 20);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(114, 342);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(46, 20);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "URL:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(76, 379);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(86, 20);
            this.StartTimeLabel.TabIndex = 0;
            this.StartTimeLabel.Text = "Start Time:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(80, 416);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(80, 20);
            this.EndTimeLabel.TabIndex = 0;
            this.EndTimeLabel.Text = "End Time:";
            // 
            // AddAppointmentGroupBox
            // 
            this.AddAppointmentGroupBox.Controls.Add(this.label1);
            this.AddAppointmentGroupBox.Controls.Add(this.AppointmentListView);
            this.AddAppointmentGroupBox.Controls.Add(this.EndDateTimePicker);
            this.AddAppointmentGroupBox.Controls.Add(this.StartDateTimePicker);
            this.AddAppointmentGroupBox.Controls.Add(this.AvailableAppointmentsDataGridViewLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.UpcomingAppointmentsDataGridView);
            this.AddAppointmentGroupBox.Controls.Add(this.UpcomingAppointmentsCalendar);
            this.AddAppointmentGroupBox.Controls.Add(this.AddAppointmentCancelButton);
            this.AddAppointmentGroupBox.Controls.Add(this.SubmitButton);
            this.AddAppointmentGroupBox.Controls.Add(this.UrlTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.TypeTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.ContactTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.LocationTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.DescriptionTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.TitleTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.UserIdTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.CustomerIdTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.AppointmentIdTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.AppointmentIdLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.EndTimeLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.CustomerIdLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.StartTimeLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.UserIdLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.UrlLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.TitleLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.TypeLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.DescriptionLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.ContactLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.LocationLabel);
            this.AddAppointmentGroupBox.Location = new System.Drawing.Point(132, 94);
            this.AddAppointmentGroupBox.Name = "AddAppointmentGroupBox";
            this.AddAppointmentGroupBox.Size = new System.Drawing.Size(1280, 527);
            this.AddAppointmentGroupBox.TabIndex = 1;
            this.AddAppointmentGroupBox.TabStop = false;
            this.AddAppointmentGroupBox.Text = "Add Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Pick Start Time";
            // 
            // AppointmentListView
            // 
            this.AppointmentListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.AppointmentListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.AppointmentListView.BackgroundImageTiled = true;
            this.AppointmentListView.FullRowSelect = true;
            this.AppointmentListView.GridLines = true;
            this.AppointmentListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AppointmentListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.AppointmentListView.Location = new System.Drawing.Point(514, 307);
            this.AppointmentListView.Name = "AppointmentListView";
            this.AppointmentListView.Size = new System.Drawing.Size(312, 133);
            this.AppointmentListView.TabIndex = 53;
            this.AppointmentListView.UseCompatibleStateImageBehavior = false;
            this.AppointmentListView.View = System.Windows.Forms.View.List;
            this.AppointmentListView.SelectedIndexChanged += new System.EventHandler(this.AppointmentListView_SelectedIndexChanged);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndDateTimePicker.Location = new System.Drawing.Point(172, 414);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(296, 26);
            this.EndDateTimePicker.TabIndex = 51;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDateTimePicker.Location = new System.Drawing.Point(172, 378);
            this.StartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(296, 26);
            this.StartDateTimePicker.TabIndex = 51;
            // 
            // AvailableAppointmentsDataGridViewLabel
            // 
            this.AvailableAppointmentsDataGridViewLabel.AutoSize = true;
            this.AvailableAppointmentsDataGridViewLabel.Location = new System.Drawing.Point(981, 23);
            this.AvailableAppointmentsDataGridViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailableAppointmentsDataGridViewLabel.Name = "AvailableAppointmentsDataGridViewLabel";
            this.AvailableAppointmentsDataGridViewLabel.Size = new System.Drawing.Size(184, 20);
            this.AvailableAppointmentsDataGridViewLabel.TabIndex = 50;
            this.AvailableAppointmentsDataGridViewLabel.Text = "Upcoming Appointments";
            // 
            // UpcomingAppointmentsDataGridView
            // 
            this.UpcomingAppointmentsDataGridView.AllowUserToOrderColumns = true;
            this.UpcomingAppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpcomingAppointmentsDataGridView.Location = new System.Drawing.Point(891, 55);
            this.UpcomingAppointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpcomingAppointmentsDataGridView.MultiSelect = false;
            this.UpcomingAppointmentsDataGridView.Name = "UpcomingAppointmentsDataGridView";
            this.UpcomingAppointmentsDataGridView.RowHeadersWidth = 62;
            this.UpcomingAppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UpcomingAppointmentsDataGridView.Size = new System.Drawing.Size(360, 432);
            this.UpcomingAppointmentsDataGridView.TabIndex = 49;
            this.UpcomingAppointmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpcomingAppointmentsDataGridView_CellContentClick);
            // 
            // UpcomingAppointmentsCalendar
            // 
            this.UpcomingAppointmentsCalendar.Location = new System.Drawing.Point(514, 37);
            this.UpcomingAppointmentsCalendar.Margin = new System.Windows.Forms.Padding(14);
            this.UpcomingAppointmentsCalendar.Name = "UpcomingAppointmentsCalendar";
            this.UpcomingAppointmentsCalendar.TabIndex = 48;
            this.UpcomingAppointmentsCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.UpcomingAppointmentsCalendar_DateChanged);
            // 
            // AddAppointmentCancelButton
            // 
            this.AddAppointmentCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddAppointmentCancelButton.Location = new System.Drawing.Point(171, 454);
            this.AddAppointmentCancelButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AddAppointmentCancelButton.Name = "AddAppointmentCancelButton";
            this.AddAppointmentCancelButton.Size = new System.Drawing.Size(112, 35);
            this.AddAppointmentCancelButton.TabIndex = 45;
            this.AddAppointmentCancelButton.Text = "Cancel";
            this.AddAppointmentCancelButton.UseVisualStyleBackColor = true;
            this.AddAppointmentCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitButton.Location = new System.Drawing.Point(358, 452);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(112, 35);
            this.SubmitButton.TabIndex = 44;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(172, 340);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(296, 26);
            this.UrlTextBox.TabIndex = 1;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(172, 303);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(296, 26);
            this.TypeTextBox.TabIndex = 1;
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(172, 266);
            this.ContactTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(296, 26);
            this.ContactTextBox.TabIndex = 1;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(172, 229);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(296, 26);
            this.LocationTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(172, 192);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(296, 26);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(172, 155);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(296, 26);
            this.TitleTextBox.TabIndex = 1;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(172, 118);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ReadOnly = true;
            this.UserIdTextBox.Size = new System.Drawing.Size(296, 26);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(172, 82);
            this.CustomerIdTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.ReadOnly = true;
            this.CustomerIdTextBox.Size = new System.Drawing.Size(296, 26);
            this.CustomerIdTextBox.TabIndex = 1;
            // 
            // AppointmentIdTextBox
            // 
            this.AppointmentIdTextBox.Location = new System.Drawing.Point(172, 45);
            this.AppointmentIdTextBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AppointmentIdTextBox.Name = "AppointmentIdTextBox";
            this.AppointmentIdTextBox.ReadOnly = true;
            this.AppointmentIdTextBox.Size = new System.Drawing.Size(296, 26);
            this.AppointmentIdTextBox.TabIndex = 1;
            // 
            // AppointmentAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 720);
            this.Controls.Add(this.AddAppointmentGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppointmentAddPage";
            this.Text = "Add Appointment Page";
            this.Load += new System.EventHandler(this.AddAppointmentPage_Load);
            this.AddAppointmentGroupBox.ResumeLayout(false);
            this.AddAppointmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingAppointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AppointmentIdLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.GroupBox AddAppointmentGroupBox;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.TextBox AppointmentIdTextBox;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button AddAppointmentCancelButton;
        private System.Windows.Forms.DataGridView UpcomingAppointmentsDataGridView;
        private System.Windows.Forms.MonthCalendar UpcomingAppointmentsCalendar;
        private System.Windows.Forms.Label AvailableAppointmentsDataGridViewLabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.ListView AppointmentListView;
        private System.Windows.Forms.Label label1;
    }
}