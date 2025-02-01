namespace Scheduling_Desktop_UI_App
{
    partial class LoginPage
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
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.GenerateReportsButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserListViewButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.QuitButton);
            this.LoginGroupBox.Controls.Add(this.GenerateReportsButton);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.registerButton);
            this.LoginGroupBox.Controls.Add(this.UserNameTextBox);
            this.LoginGroupBox.Controls.Add(this.UserListViewButton);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Controls.Add(this.Password_Label);
            this.LoginGroupBox.Controls.Add(this.UserName);
            this.LoginGroupBox.Location = new System.Drawing.Point(20, 8);
            this.LoginGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginGroupBox.Size = new System.Drawing.Size(313, 190);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(117, 110);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(63, 37);
            this.QuitButton.TabIndex = 15;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // GenerateReportsButton
            // 
            this.GenerateReportsButton.Location = new System.Drawing.Point(185, 110);
            this.GenerateReportsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateReportsButton.Name = "GenerateReportsButton";
            this.GenerateReportsButton.Size = new System.Drawing.Size(63, 37);
            this.GenerateReportsButton.TabIndex = 16;
            this.GenerateReportsButton.Text = "Generate Reports";
            this.GenerateReportsButton.UseVisualStyleBackColor = true;
            this.GenerateReportsButton.Click += new System.EventHandler(this.GenerateReportsButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(117, 53);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(133, 20);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.Text = "test";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(117, 30);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.UserNameTextBox.TabIndex = 6;
            this.UserNameTextBox.Text = "test";
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(49, 79);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(199, 25);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(57, 55);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(56, 13);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(53, 32);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(60, 13);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "UserName:";
            // 
            // UserListViewButton
            // 
            this.UserListViewButton.Location = new System.Drawing.Point(49, 154);
            this.UserListViewButton.Name = "UserListViewButton";
            this.UserListViewButton.Size = new System.Drawing.Size(199, 25);
            this.UserListViewButton.TabIndex = 14;
            this.UserListViewButton.Text = "User List View";
            this.UserListViewButton.UseVisualStyleBackColor = true;
            this.UserListViewButton.Click += new System.EventHandler(this.UserListViewButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(49, 110);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(63, 37);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Register User";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(361, 218);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button GenerateReportsButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button UserListViewButton;
    }
}

