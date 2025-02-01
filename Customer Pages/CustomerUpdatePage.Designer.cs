using Scheduling_Desktop_UI_App.Classes;

namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    partial class CustomerUpdatePage
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
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.UpdateCustomerCancelButton = new System.Windows.Forms.Button();
            this.Address1TextBox = new System.Windows.Forms.TextBox();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.Address2Label = new System.Windows.Forms.Label();
            this.Address1Label = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.UpdateCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateCustomerGroupBox
            // 
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerIdTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerIdLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.UpdateCustomerCancelButton);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address1TextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address2TextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address2Label);
            this.UpdateCustomerGroupBox.Controls.Add(this.Address1Label);
            this.UpdateCustomerGroupBox.Controls.Add(this.SubmitButton);
            this.UpdateCustomerGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CountryTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.PostalCodeTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CityTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerNameTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.CustomerNameLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.CountryLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.PostalCodeLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.CityLabel);
            this.UpdateCustomerGroupBox.Location = new System.Drawing.Point(34, 22);
            this.UpdateCustomerGroupBox.Name = "UpdateCustomerGroupBox";
            this.UpdateCustomerGroupBox.Size = new System.Drawing.Size(549, 463);
            this.UpdateCustomerGroupBox.TabIndex = 27;
            this.UpdateCustomerGroupBox.TabStop = false;
            this.UpdateCustomerGroupBox.Text = "Update Customer";
            this.UpdateCustomerGroupBox.Enter += new System.EventHandler(this.UpdateCustomerGroupBox_Enter);
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(196, 72);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.ReadOnly = true;
            this.CustomerIdTextBox.Size = new System.Drawing.Size(253, 26);
            this.CustomerIdTextBox.TabIndex = 46;
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(80, 72);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(92, 20);
            this.CustomerIdLabel.TabIndex = 45;
            this.CustomerIdLabel.Text = "CustomerId";
            // 
            // UpdateCustomerCancelButton
            // 
            this.UpdateCustomerCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateCustomerCancelButton.Location = new System.Drawing.Point(195, 357);
            this.UpdateCustomerCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateCustomerCancelButton.Name = "UpdateCustomerCancelButton";
            this.UpdateCustomerCancelButton.Size = new System.Drawing.Size(88, 40);
            this.UpdateCustomerCancelButton.TabIndex = 44;
            this.UpdateCustomerCancelButton.Text = "Cancel";
            this.UpdateCustomerCancelButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Address1TextBox
            // 
            this.Address1TextBox.AcceptsTab = true;
            this.Address1TextBox.Location = new System.Drawing.Point(196, 142);
            this.Address1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Address1TextBox.Name = "Address1TextBox";
            this.Address1TextBox.Size = new System.Drawing.Size(253, 26);
            this.Address1TextBox.TabIndex = 36;
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Address2TextBox.Location = new System.Drawing.Point(195, 182);
            this.Address2TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(253, 26);
            this.Address2TextBox.TabIndex = 39;
            this.Address2TextBox.Text = "Optional";
            this.Address2TextBox.TextChanged += new System.EventHandler(this.Address2TextBox_TextChanged);
            this.Address2TextBox.Enter += new System.EventHandler(this.Address2TextBox_Enter);
            this.Address2TextBox.Leave += new System.EventHandler(this.Address2TextBox_Leave);
            // 
            // Address2Label
            // 
            this.Address2Label.AutoSize = true;
            this.Address2Label.Location = new System.Drawing.Point(92, 178);
            this.Address2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address2Label.Name = "Address2Label";
            this.Address2Label.Size = new System.Drawing.Size(81, 20);
            this.Address2Label.TabIndex = 38;
            this.Address2Label.Text = "Address2:";
            // 
            // Address1Label
            // 
            this.Address1Label.AutoSize = true;
            this.Address1Label.Location = new System.Drawing.Point(92, 142);
            this.Address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address1Label.Name = "Address1Label";
            this.Address1Label.Size = new System.Drawing.Size(81, 20);
            this.Address1Label.TabIndex = 37;
            this.Address1Label.Text = "Address1:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitButton.Location = new System.Drawing.Point(363, 357);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(88, 40);
            this.SubmitButton.TabIndex = 43;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(196, 322);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(253, 26);
            this.PhoneNumberTextBox.TabIndex = 35;
            this.PhoneNumberTextBox.Text = "999-999-9999";
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CountryTextBox.Location = new System.Drawing.Point(196, 285);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(253, 26);
            this.CountryTextBox.TabIndex = 42;
            this.CountryTextBox.Text = "US";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PostalCodeTextBox.Location = new System.Drawing.Point(196, 249);
            this.PostalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(253, 26);
            this.PostalCodeTextBox.TabIndex = 41;
            this.PostalCodeTextBox.Text = "99999";
            this.PostalCodeTextBox.TextChanged += new System.EventHandler(this.PostalCodeTextBox_TextChanged);
            this.PostalCodeTextBox.Enter += new System.EventHandler(this.PostalCodeTextBox_Enter);
            this.PostalCodeTextBox.Leave += new System.EventHandler(this.PostalCodeTextBox_Leave);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(196, 212);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(253, 26);
            this.CityTextBox.TabIndex = 40;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(196, 106);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(253, 26);
            this.CustomerNameTextBox.TabIndex = 30;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(44, 108);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(128, 20);
            this.CustomerNameLabel.TabIndex = 27;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(52, 322);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(119, 20);
            this.PhoneNumberLabel.TabIndex = 29;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(104, 285);
            this.CountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(68, 20);
            this.CountryLabel.TabIndex = 32;
            this.CountryLabel.Text = "Country:";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(74, 249);
            this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(99, 20);
            this.PostalCodeLabel.TabIndex = 34;
            this.PostalCodeLabel.Text = "Postal Code:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(134, 212);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(39, 20);
            this.CityLabel.TabIndex = 31;
            this.CityLabel.Text = "City:";
            // 
            // CustomerUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 509);
            this.Controls.Add(this.UpdateCustomerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerUpdatePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.CustomerUpdatePage_Load_1);
            this.UpdateCustomerGroupBox.ResumeLayout(false);
            this.UpdateCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UpdateCustomerGroupBox;
        private System.Windows.Forms.TextBox Address1TextBox;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.Label Address2Label;
        private System.Windows.Forms.Label Address1Label;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Button UpdateCustomerCancelButton;
        //private Customer customer;
        //private User user;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.Label CustomerIdLabel;
    }
}