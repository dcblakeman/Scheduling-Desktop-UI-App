namespace Scheduling_Desktop_UI_App.Customer_mainNavigationPages
{
    partial class AddCustomerPage
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(59, 65);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(59, 205);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 1;
            this.streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(59, 250);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // addCustomerGroupBox
            // 
            this.addCustomerGroupBox.Controls.Add(this.submitButton);
            this.addCustomerGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.addCustomerGroupBox.Controls.Add(this.zipCodeTextBox);
            this.addCustomerGroupBox.Controls.Add(this.stateTextBox);
            this.addCustomerGroupBox.Controls.Add(this.cityTextBox);
            this.addCustomerGroupBox.Controls.Add(this.streetTextBox);
            this.addCustomerGroupBox.Controls.Add(this.lastNameTextBox);
            this.addCustomerGroupBox.Controls.Add(this.firstNameTextBox);
            this.addCustomerGroupBox.Controls.Add(this.lastNameLabel);
            this.addCustomerGroupBox.Controls.Add(this.firstNameLabel);
            this.addCustomerGroupBox.Controls.Add(this.phoneNumberLabel);
            this.addCustomerGroupBox.Controls.Add(this.streetLabel);
            this.addCustomerGroupBox.Controls.Add(this.zipCodeLabel);
            this.addCustomerGroupBox.Controls.Add(this.stateLabel);
            this.addCustomerGroupBox.Controls.Add(this.cityLabel);
            this.addCustomerGroupBox.Location = new System.Drawing.Point(171, 113);
            this.addCustomerGroupBox.Name = "addCustomerGroupBox";
            this.addCustomerGroupBox.Size = new System.Drawing.Size(515, 460);
            this.addCustomerGroupBox.TabIndex = 4;
            this.addCustomerGroupBox.TabStop = false;
            this.addCustomerGroupBox.Text = "Add Customer";
            // 
            // submitButton
            // 
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitButton.Location = new System.Drawing.Point(334, 383);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 29);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(155, 152);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(278, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.Text = "999-999-9999";
            this.phoneNumberTextBox.Enter += new System.EventHandler(this.phoneNumberTextBox_Enter);
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.phoneNumberTextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(155, 109);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(155, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(59, 109);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(59, 159);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 1;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(59, 342);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLabel.TabIndex = 2;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(59, 298);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(155, 198);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(278, 20);
            this.streetTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(155, 243);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(278, 20);
            this.cityTextBox.TabIndex = 3;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(155, 291);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(278, 20);
            this.stateTextBox.TabIndex = 3;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(155, 335);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(278, 20);
            this.zipCodeTextBox.TabIndex = 3;
            // 
            // AddCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 972);
            this.Controls.Add(this.addCustomerGroupBox);
            this.Name = "AddCustomerPage";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.submitButton_Click);
            this.addCustomerGroupBox.ResumeLayout(false);
            this.addCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.GroupBox addCustomerGroupBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
    }
}