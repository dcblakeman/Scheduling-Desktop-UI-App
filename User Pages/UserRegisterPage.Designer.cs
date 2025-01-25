namespace Scheduling_Desktop_UI_App
{
    partial class UserRegisterPage
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
            this.RegisterUserGroupBox = new System.Windows.Forms.GroupBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterUserCancelButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.RegisterUserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterUserGroupBox
            // 
            this.RegisterUserGroupBox.Controls.Add(this.UserIdLabel);
            this.RegisterUserGroupBox.Controls.Add(this.ConfirmPasswordLabel);
            this.RegisterUserGroupBox.Controls.Add(this.RegisterButton);
            this.RegisterUserGroupBox.Controls.Add(this.RegisterUserCancelButton);
            this.RegisterUserGroupBox.Controls.Add(this.ConfirmPasswordTextBox);
            this.RegisterUserGroupBox.Controls.Add(this.PasswordTextBox);
            this.RegisterUserGroupBox.Controls.Add(this.UserIdTextBox);
            this.RegisterUserGroupBox.Controls.Add(this.UserNameTextBox);
            this.RegisterUserGroupBox.Controls.Add(this.Password_Label);
            this.RegisterUserGroupBox.Controls.Add(this.UserName);
            this.RegisterUserGroupBox.Location = new System.Drawing.Point(70, 46);
            this.RegisterUserGroupBox.Name = "RegisterUserGroupBox";
            this.RegisterUserGroupBox.Size = new System.Drawing.Size(598, 275);
            this.RegisterUserGroupBox.TabIndex = 0;
            this.RegisterUserGroupBox.TabStop = false;
            this.RegisterUserGroupBox.Text = "Register User";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(168, 52);
            this.UserIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(57, 20);
            this.UserIdLabel.TabIndex = 16;
            this.UserIdLabel.Text = "UserId";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(88, 168);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(137, 20);
            this.ConfirmPasswordLabel.TabIndex = 15;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            this.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(234, 200);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(112, 35);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterUserCancelButton
            // 
            this.RegisterUserCancelButton.Location = new System.Drawing.Point(356, 200);
            this.RegisterUserCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterUserCancelButton.Name = "RegisterUserCancelButton";
            this.RegisterUserCancelButton.Size = new System.Drawing.Size(112, 35);
            this.RegisterUserCancelButton.TabIndex = 5;
            this.RegisterUserCancelButton.Text = "Cancel";
            this.RegisterUserCancelButton.UseVisualStyleBackColor = true;
            this.RegisterUserCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(234, 163);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(234, 26);
            this.ConfirmPasswordTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(234, 125);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(234, 26);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(234, 48);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ReadOnly = true;
            this.UserIdTextBox.Size = new System.Drawing.Size(234, 26);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(234, 86);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(234, 26);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(146, 129);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(78, 20);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(142, 91);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(85, 20);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // UserRegisterPage
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 363);
            this.Controls.Add(this.RegisterUserGroupBox);
            this.Name = "UserRegisterPage";
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.UserRegisterPage_Load);
            this.RegisterUserGroupBox.ResumeLayout(false);
            this.RegisterUserGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RegisterUserGroupBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button RegisterUserCancelButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.TextBox UserIdTextBox;
    }
}