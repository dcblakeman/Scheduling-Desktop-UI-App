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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentUpdatePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentCalendarGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.AppointmentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.StartTimeComboBox = new System.Windows.Forms.ComboBox();
            this.EndTimeComboBox = new System.Windows.Forms.TextBox();
            this.AppointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerProfileButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentCancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.AppointmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.AppointmentCalendarGroupBox.SuspendLayout();
            this.AppointmentDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentsGroupBox
            // 
            this.AppointmentsGroupBox.Controls.Add(this.AppointmentsDataGridView);
            resources.ApplyResources(this.AppointmentsGroupBox, "AppointmentsGroupBox");
            this.AppointmentsGroupBox.Name = "AppointmentsGroupBox";
            this.AppointmentsGroupBox.TabStop = false;
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.AllowUserToResizeColumns = false;
            this.AppointmentsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.AppointmentsDataGridView, "AppointmentsDataGridView");
            this.AppointmentsDataGridView.MultiSelect = false;
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.AppointmentsDataGridView.RowHeadersVisible = false;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // AppointmentCalendarGroupBox
            // 
            this.AppointmentCalendarGroupBox.Controls.Add(this.AppointmentCalendar);
            resources.ApplyResources(this.AppointmentCalendarGroupBox, "AppointmentCalendarGroupBox");
            this.AppointmentCalendarGroupBox.Name = "AppointmentCalendarGroupBox";
            this.AppointmentCalendarGroupBox.TabStop = false;
            // 
            // AppointmentCalendar
            // 
            resources.ApplyResources(this.AppointmentCalendar, "AppointmentCalendar");
            this.AppointmentCalendar.Name = "AppointmentCalendar";
            this.AppointmentCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentCalendar_DateChanged);
            // 
            // AppointmentDetailsGroupBox
            // 
            this.AppointmentDetailsGroupBox.Controls.Add(this.LocationComboBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.StartTimeComboBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.EndTimeComboBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.AppointmentTypeComboBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.CustomerProfileButton);
            this.AppointmentDetailsGroupBox.Controls.Add(this.UpdateAppointmentCancelButton);
            this.AppointmentDetailsGroupBox.Controls.Add(this.SubmitButton);
            this.AppointmentDetailsGroupBox.Controls.Add(this.ContactTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.DescriptionTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.TitleTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.UserIdTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.CustomerIdTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.AppointmentIdTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.AppointmentIdLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.EndTimeLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.CustomerIdLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.StartTimeLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.UserIdLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.TitleLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.TypeLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.DescriptionLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.ContactLabel);
            this.AppointmentDetailsGroupBox.Controls.Add(this.LocationLabel);
            resources.ApplyResources(this.AppointmentDetailsGroupBox, "AppointmentDetailsGroupBox");
            this.AppointmentDetailsGroupBox.Name = "AppointmentDetailsGroupBox";
            this.AppointmentDetailsGroupBox.TabStop = false;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            resources.GetString("LocationComboBox.Items"),
            resources.GetString("LocationComboBox.Items1"),
            resources.GetString("LocationComboBox.Items2")});
            resources.ApplyResources(this.LocationComboBox, "LocationComboBox");
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.DropDownClosed += new System.EventHandler(this.LocationComboBox_DropDownClosed);
            // 
            // StartTimeComboBox
            // 
            this.StartTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTimeComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.StartTimeComboBox, "StartTimeComboBox");
            this.StartTimeComboBox.Name = "StartTimeComboBox";
            this.StartTimeComboBox.DropDownClosed += new System.EventHandler(this.StartTimeComboBox_DropDownClosed);
            // 
            // EndTimeComboBox
            // 
            resources.ApplyResources(this.EndTimeComboBox, "EndTimeComboBox");
            this.EndTimeComboBox.Name = "EndTimeComboBox";
            this.EndTimeComboBox.ReadOnly = true;
            // 
            // AppointmentTypeComboBox
            // 
            this.AppointmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppointmentTypeComboBox.FormattingEnabled = true;
            this.AppointmentTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("AppointmentTypeComboBox.Items"),
            resources.GetString("AppointmentTypeComboBox.Items1"),
            resources.GetString("AppointmentTypeComboBox.Items2"),
            resources.GetString("AppointmentTypeComboBox.Items3"),
            resources.GetString("AppointmentTypeComboBox.Items4")});
            resources.ApplyResources(this.AppointmentTypeComboBox, "AppointmentTypeComboBox");
            this.AppointmentTypeComboBox.Name = "AppointmentTypeComboBox";
            // 
            // CustomerProfileButton
            // 
            resources.ApplyResources(this.CustomerProfileButton, "CustomerProfileButton");
            this.CustomerProfileButton.Name = "CustomerProfileButton";
            this.CustomerProfileButton.UseVisualStyleBackColor = true;
            this.CustomerProfileButton.Click += new System.EventHandler(this.CustomerProfileButton_Click);
            // 
            // UpdateAppointmentCancelButton
            // 
            resources.ApplyResources(this.UpdateAppointmentCancelButton, "UpdateAppointmentCancelButton");
            this.UpdateAppointmentCancelButton.Name = "UpdateAppointmentCancelButton";
            this.UpdateAppointmentCancelButton.UseVisualStyleBackColor = true;
            this.UpdateAppointmentCancelButton.Click += new System.EventHandler(this.UpdateAppointmentCancelButton_Click);
            // 
            // SubmitButton
            // 
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ContactTextBox
            // 
            resources.ApplyResources(this.ContactTextBox, "ContactTextBox");
            this.ContactTextBox.Name = "ContactTextBox";
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
            this.Controls.Add(this.AppointmentDetailsGroupBox);
            this.Controls.Add(this.AppointmentsGroupBox);
            this.Controls.Add(this.AppointmentCalendarGroupBox);
            this.Name = "AppointmentUpdatePage";
            this.Load += new System.EventHandler(this.AppointmentUpdatePage_Load);
            this.AppointmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.AppointmentCalendarGroupBox.ResumeLayout(false);
            this.AppointmentDetailsGroupBox.ResumeLayout(false);
            this.AppointmentDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox AppointmentsGroupBox;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.GroupBox AppointmentCalendarGroupBox;
        private System.Windows.Forms.MonthCalendar AppointmentCalendar;
        private System.Windows.Forms.GroupBox AppointmentDetailsGroupBox;
        private System.Windows.Forms.ComboBox StartTimeComboBox;
        private System.Windows.Forms.TextBox EndTimeComboBox;
        private System.Windows.Forms.ComboBox AppointmentTypeComboBox;
        private System.Windows.Forms.Button CustomerProfileButton;
        private System.Windows.Forms.Button UpdateAppointmentCancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ContactTextBox;
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
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox LocationComboBox;
    }
}