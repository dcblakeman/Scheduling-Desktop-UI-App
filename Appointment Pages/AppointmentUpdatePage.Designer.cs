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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentUpdatePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentCalendarGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.AppointmentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.StartTimeComboBox = new System.Windows.Forms.ComboBox();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerProfileButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentCancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.AppointmentsDataGridView, "AppointmentsDataGridView");
            this.AppointmentsDataGridView.MultiSelect = false;
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AppointmentsDataGridView.RowHeadersVisible = false;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDataGridView_CellContentClick);
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
            this.AppointmentDetailsGroupBox.Controls.Add(this.StartTimeComboBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.EndTimeTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.AppointmentTypeComboBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.CustomerProfileButton);
            this.AppointmentDetailsGroupBox.Controls.Add(this.UpdateAppointmentCancelButton);
            this.AppointmentDetailsGroupBox.Controls.Add(this.SubmitButton);
            this.AppointmentDetailsGroupBox.Controls.Add(this.ContactTextBox);
            this.AppointmentDetailsGroupBox.Controls.Add(this.LocationTextBox);
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
            this.AppointmentDetailsGroupBox.Enter += new System.EventHandler(this.AddAppointmentGroupBox_Enter);
            // 
            // StartTimeComboBox
            // 
            this.StartTimeComboBox.FormattingEnabled = true;
            this.StartTimeComboBox.Items.AddRange(new object[] {
            resources.GetString("StartTimeComboBox.Items"),
            resources.GetString("StartTimeComboBox.Items1"),
            resources.GetString("StartTimeComboBox.Items2"),
            resources.GetString("StartTimeComboBox.Items3"),
            resources.GetString("StartTimeComboBox.Items4"),
            resources.GetString("StartTimeComboBox.Items5"),
            resources.GetString("StartTimeComboBox.Items6"),
            resources.GetString("StartTimeComboBox.Items7")});
            resources.ApplyResources(this.StartTimeComboBox, "StartTimeComboBox");
            this.StartTimeComboBox.Name = "StartTimeComboBox";
            this.StartTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.StartTimeComboBox_SelectedIndexChanged);
            // 
            // EndTimeTextBox
            // 
            resources.ApplyResources(this.EndTimeTextBox, "EndTimeTextBox");
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.ReadOnly = true;
            // 
            // AppointmentTypeComboBox
            // 
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
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.ComboBox AppointmentTypeComboBox;
        private System.Windows.Forms.Button CustomerProfileButton;
        private System.Windows.Forms.Button UpdateAppointmentCancelButton;
        private System.Windows.Forms.Button SubmitButton;
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
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label LocationLabel;
    }
}