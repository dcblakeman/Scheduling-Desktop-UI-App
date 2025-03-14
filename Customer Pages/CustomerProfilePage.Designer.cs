namespace Scheduling_Desktop_UI_App
{
    partial class CustomerProfilePage
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
            this.UpdateCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.UpdateCustomerCancelButton = new System.Windows.Forms.Button();
            this.Address1TextBox = new System.Windows.Forms.TextBox();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.Address2Label = new System.Windows.Forms.Label();
            this.Address1Label = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CustomerAppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateCustomerGroupBox.SuspendLayout();
            this.CustomerAppointmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateCustomerGroupBox
            // 
            this.UpdateCustomerGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerIdTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerIdLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.UpdateCustomerCancelButton);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address1TextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address2TextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address2Label);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address1Label);
            this.UpdateCustomerGroupBox.Controls.Add(this.SubmitButton);
            this.UpdateCustomerGroupBox.Controls.Add(this.CountryTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.PostalCodeTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CityTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerNameTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerNameLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.CountryLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.PostalCodeLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.CityLabel);
            this.UpdateCustomerGroupBox.Location = new System.Drawing.Point(47, 14);
            this.UpdateCustomerGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateCustomerGroupBox.Name = "UpdateCustomerGroupBox";
            this.UpdateCustomerGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateCustomerGroupBox.Size = new System.Drawing.Size(367, 257);
            this.UpdateCustomerGroupBox.TabIndex = 28;
            this.UpdateCustomerGroupBox.TabStop = false;
            this.UpdateCustomerGroupBox.Text = "Customer Details";
            this.UpdateCustomerGroupBox.Enter += new System.EventHandler(this.UpdateCustomerGroupBox_Enter);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(148, 196);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(170, 20);
            this.PhoneNumberTextBox.TabIndex = 48;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(53, 196);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 47;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(148, 26);
            this.CustomerIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.ReadOnly = true;
            this.CustomerIdTextBox.Size = new System.Drawing.Size(170, 20);
            this.CustomerIdTextBox.TabIndex = 46;
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(71, 26);
            this.CustomerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(60, 13);
            this.CustomerIdLabel.TabIndex = 45;
            this.CustomerIdLabel.Text = "CustomerId";
            // 
            // UpdateCustomerCancelButton
            // 
            this.UpdateCustomerCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateCustomerCancelButton.Location = new System.Drawing.Point(148, 220);
            this.UpdateCustomerCancelButton.Name = "UpdateCustomerCancelButton";
            this.UpdateCustomerCancelButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateCustomerCancelButton.TabIndex = 44;
            this.UpdateCustomerCancelButton.Text = "Cancel";
            this.UpdateCustomerCancelButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerCancelButton.Click += new System.EventHandler(this.CustomerProfileCancelButton_Click);
            // 
            // Address1TextBox
            // 
            this.Address1TextBox.AcceptsTab = true;
            this.Address1TextBox.Location = new System.Drawing.Point(148, 74);
            this.Address1TextBox.Name = "Address1TextBox";
            this.Address1TextBox.Size = new System.Drawing.Size(170, 20);
            this.Address1TextBox.TabIndex = 36;
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Address2TextBox.Location = new System.Drawing.Point(148, 99);
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(170, 20);
            this.Address2TextBox.TabIndex = 39;
            this.Address2TextBox.Text = "Optional";
            this.Address2TextBox.Enter += new System.EventHandler(this.Address2TextBox_Enter);
            this.Address2TextBox.Leave += new System.EventHandler(this.Address2TextBox_Leave);
            // 
            // Address2Label
            // 
            this.Address2Label.AutoSize = true;
            this.Address2Label.Location = new System.Drawing.Point(78, 99);
            this.Address2Label.Name = "Address2Label";
            this.Address2Label.Size = new System.Drawing.Size(54, 13);
            this.Address2Label.TabIndex = 38;
            this.Address2Label.Text = "Address2:";
            // 
            // Address1Label
            // 
            this.Address1Label.AutoSize = true;
            this.Address1Label.Location = new System.Drawing.Point(78, 74);
            this.Address1Label.Name = "Address1Label";
            this.Address1Label.Size = new System.Drawing.Size(54, 13);
            this.Address1Label.TabIndex = 37;
            this.Address1Label.Text = "Address1:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitButton.Location = new System.Drawing.Point(242, 220);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 43;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(148, 173);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(170, 20);
            this.CountryTextBox.TabIndex = 42;
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(148, 148);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(170, 20);
            this.PostalCodeTextBox.TabIndex = 41;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(148, 123);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(170, 20);
            this.CityTextBox.TabIndex = 40;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(148, 51);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.CustomerNameTextBox.TabIndex = 30;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(47, 51);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.CustomerNameLabel.TabIndex = 27;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(87, 173);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 32;
            this.CountryLabel.Text = "Country:";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(66, 148);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.PostalCodeLabel.TabIndex = 34;
            this.PostalCodeLabel.Text = "Postal Code:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(106, 123);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 31;
            this.CityLabel.Text = "City:";
            // 
            // CustomerAppointmentsGroupBox
            // 
            this.CustomerAppointmentsGroupBox.Controls.Add(this.DeleteAppointmentButton);
            this.CustomerAppointmentsGroupBox.Controls.Add(this.AppointmentsDataGridView);
            this.CustomerAppointmentsGroupBox.Location = new System.Drawing.Point(417, 14);
            this.CustomerAppointmentsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerAppointmentsGroupBox.Name = "CustomerAppointmentsGroupBox";
            this.CustomerAppointmentsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerAppointmentsGroupBox.Size = new System.Drawing.Size(761, 257);
            this.CustomerAppointmentsGroupBox.TabIndex = 29;
            this.CustomerAppointmentsGroupBox.TabStop = false;
            this.CustomerAppointmentsGroupBox.Text = "Customer Appointments";
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(20, 220);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(221, 23);
            this.DeleteAppointmentButton.TabIndex = 53;
            this.DeleteAppointmentButton.Text = "Delete Appointment";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = true;
            this.DeleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(20, 26);
            this.AppointmentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            this.AppointmentsDataGridView.RowHeadersVisible = false;
            this.AppointmentsDataGridView.RowHeadersWidth = 62;
            this.AppointmentsDataGridView.RowTemplate.Height = 28;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(724, 187);
            this.AppointmentsDataGridView.TabIndex = 0;
            this.AppointmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDataGridView_CellContentClick);
            // 
            // CustomerProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 285);
            this.Controls.Add(this.CustomerAppointmentsGroupBox);
            this.Controls.Add(this.UpdateCustomerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Profile Page";
            this.Load += new System.EventHandler(this.CustomerProfilePage_Load);
            this.UpdateCustomerGroupBox.ResumeLayout(false);
            this.UpdateCustomerGroupBox.PerformLayout();
            this.CustomerAppointmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UpdateCustomerGroupBox;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Button UpdateCustomerCancelButton;
        private System.Windows.Forms.TextBox Address1TextBox;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.Label Address2Label;
        private System.Windows.Forms.Label Address1Label;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.GroupBox CustomerAppointmentsGroupBox;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}