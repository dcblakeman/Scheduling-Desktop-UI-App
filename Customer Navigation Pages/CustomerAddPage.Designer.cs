namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    partial class CustomerAddPage
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.Address1TextBox = new System.Windows.Forms.TextBox();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.Address2Label = new System.Windows.Forms.Label();
            this.Address1Label = new System.Windows.Forms.Label();
            this.AddCustomerCancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.AddCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(61, 62);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(61, 179);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City:";
            // 
            // AddCustomerGroupBox
            // 
            this.AddCustomerGroupBox.Controls.Add(this.Address1TextBox);
            this.AddCustomerGroupBox.Controls.Add(this.Address2TextBox);
            this.AddCustomerGroupBox.Controls.Add(this.Address2Label);
            this.AddCustomerGroupBox.Controls.Add(this.Address1Label);
            this.AddCustomerGroupBox.Controls.Add(this.AddCustomerCancelButton);
            this.AddCustomerGroupBox.Controls.Add(this.SubmitButton);
            this.AddCustomerGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.AddCustomerGroupBox.Controls.Add(this.CountryTextBox);
            this.AddCustomerGroupBox.Controls.Add(this.PostalCodeTextBox);
            this.AddCustomerGroupBox.Controls.Add(this.CityTextBox);
            this.AddCustomerGroupBox.Controls.Add(this.LastNameTextBox);
            this.AddCustomerGroupBox.Controls.Add(this.FirstNameTextBox);
            this.AddCustomerGroupBox.Controls.Add(this.LastNameLabel);
            this.AddCustomerGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddCustomerGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.AddCustomerGroupBox.Controls.Add(this.CountryLabel);
            this.AddCustomerGroupBox.Controls.Add(this.PostalCodeLabel);
            this.AddCustomerGroupBox.Controls.Add(this.CityLabel);
            this.AddCustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCustomerGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AddCustomerGroupBox.Name = "AddCustomerGroupBox";
            this.AddCustomerGroupBox.Size = new System.Drawing.Size(514, 309);
            this.AddCustomerGroupBox.TabIndex = 4;
            this.AddCustomerGroupBox.TabStop = false;
            this.AddCustomerGroupBox.Text = "Add Customer";
            // 
            // Address1TextBox
            // 
            this.Address1TextBox.AcceptsTab = true;
            this.Address1TextBox.Location = new System.Drawing.Point(157, 131);
            this.Address1TextBox.Name = "Address1TextBox";
            this.Address1TextBox.Size = new System.Drawing.Size(278, 20);
            this.Address1TextBox.TabIndex = 4;
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Address2TextBox.Location = new System.Drawing.Point(157, 154);
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(278, 20);
            this.Address2TextBox.TabIndex = 5;
            this.Address2TextBox.Text = "Optional";
            // 
            // Address2Label
            // 
            this.Address2Label.AutoSize = true;
            this.Address2Label.Location = new System.Drawing.Point(61, 157);
            this.Address2Label.Name = "Address2Label";
            this.Address2Label.Size = new System.Drawing.Size(51, 13);
            this.Address2Label.TabIndex = 5;
            this.Address2Label.Text = "Address2";
            // 
            // Address1Label
            // 
            this.Address1Label.AutoSize = true;
            this.Address1Label.Location = new System.Drawing.Point(61, 133);
            this.Address1Label.Name = "Address1Label";
            this.Address1Label.Size = new System.Drawing.Size(51, 13);
            this.Address1Label.TabIndex = 5;
            this.Address1Label.Text = "Address1";
            // 
            // AddCustomerCancelButton
            // 
            this.AddCustomerCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCustomerCancelButton.Location = new System.Drawing.Point(157, 248);
            this.AddCustomerCancelButton.Name = "AddCustomerCancelButton";
            this.AddCustomerCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddCustomerCancelButton.TabIndex = 9;
            this.AddCustomerCancelButton.Text = "Cancel";
            this.AddCustomerCancelButton.UseVisualStyleBackColor = true;
            this.AddCustomerCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitButton.Location = new System.Drawing.Point(359, 248);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(157, 107);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(278, 20);
            this.PhoneNumberTextBox.TabIndex = 3;
            this.PhoneNumberTextBox.Text = "999-999-9999";
            this.PhoneNumberTextBox.Enter += new System.EventHandler(this.PhoneNumberTextBox_Enter);
            this.PhoneNumberTextBox.Leave += new System.EventHandler(this.PhoneNumberTextBox_Leave);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(157, 224);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(278, 20);
            this.CountryTextBox.TabIndex = 8;
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(157, 201);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(278, 20);
            this.PostalCodeTextBox.TabIndex = 7;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(157, 177);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(278, 20);
            this.CityTextBox.TabIndex = 6;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(157, 84);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(157, 60);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(61, 86);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(61, 109);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 1;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(61, 226);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(61, 203);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.PostalCodeLabel.TabIndex = 2;
            this.PostalCodeLabel.Text = "Postal Code:";
            // 
            // AddCustomerPage
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 307);
            this.Controls.Add(this.AddCustomerGroupBox);
            this.Name = "AddCustomerPage";
            this.Text = "Add Customer";
            this.AddCustomerGroupBox.ResumeLayout(false);
            this.AddCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.GroupBox AddCustomerGroupBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label Address1Label;
        private System.Windows.Forms.TextBox Address1TextBox;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.Label Address2Label;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Button AddCustomerCancelButton;
    }
}