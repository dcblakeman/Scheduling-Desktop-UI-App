namespace Scheduling_Desktop_UI_App.User_Pages
{
    partial class UserUpdatePage
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
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RegisterUserCancelButton = new System.Windows.Forms.Button();
            this.ActiveTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.UserIdLabel);
            this.UserGroupBox.Controls.Add(this.ActiveLabel);
            this.UserGroupBox.Controls.Add(this.ConfirmPasswordLabel);
            this.UserGroupBox.Controls.Add(this.UpdateButton);
            this.UserGroupBox.Controls.Add(this.RegisterUserCancelButton);
            this.UserGroupBox.Controls.Add(this.ActiveTextBox);
            this.UserGroupBox.Controls.Add(this.ConfirmPasswordTextBox);
            this.UserGroupBox.Controls.Add(this.PasswordTextBox);
            this.UserGroupBox.Controls.Add(this.UserIdTextBox);
            this.UserGroupBox.Controls.Add(this.UserNameTextBox);
            this.UserGroupBox.Controls.Add(this.PasswordLabel);
            this.UserGroupBox.Controls.Add(this.UserName);
            this.UserGroupBox.Location = new System.Drawing.Point(66, 34);
            this.UserGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.UserGroupBox.Size = new System.Drawing.Size(312, 179);
            this.UserGroupBox.TabIndex = 1;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "User";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(67, 31);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(38, 13);
            this.UserIdLabel.TabIndex = 16;
            this.UserIdLabel.Text = "UserId";
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AutoSize = true;
            this.ActiveLabel.Location = new System.Drawing.Point(68, 132);
            this.ActiveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(37, 13);
            this.ActiveLabel.TabIndex = 15;
            this.ActiveLabel.Text = "Active";
            this.ActiveLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(14, 106);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPasswordLabel.TabIndex = 15;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            this.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(110, 155);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RegisterUserCancelButton
            // 
            this.RegisterUserCancelButton.Location = new System.Drawing.Point(191, 156);
            this.RegisterUserCancelButton.Name = "RegisterUserCancelButton";
            this.RegisterUserCancelButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterUserCancelButton.TabIndex = 6;
            this.RegisterUserCancelButton.Text = "Cancel";
            this.RegisterUserCancelButton.UseVisualStyleBackColor = true;
            this.RegisterUserCancelButton.Click += new System.EventHandler(this.RegisterUserCancelButton_Click);
            // 
            // ActiveTextBox
            // 
            this.ActiveTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ActiveTextBox.Location = new System.Drawing.Point(110, 129);
            this.ActiveTextBox.Name = "ActiveTextBox";
            this.ActiveTextBox.Size = new System.Drawing.Size(157, 20);
            this.ActiveTextBox.TabIndex = 4;
            this.ActiveTextBox.Text = "1";
            this.ActiveTextBox.TextChanged += new System.EventHandler(this.ActiveTextBox_TextChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(111, 103);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.ConfirmPasswordTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(111, 78);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(111, 28);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ReadOnly = true;
            this.UserIdTextBox.Size = new System.Drawing.Size(157, 20);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(111, 53);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(52, 81);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(50, 56);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // UserUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 254);
            this.Controls.Add(this.UserGroupBox);
            this.Name = "UserUpdatePage";
            this.Text = "User Update Page";
            this.Load += new System.EventHandler(this.UserUpdatePage_Load);
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RegisterUserCancelButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.TextBox ActiveTextBox;
    }
}