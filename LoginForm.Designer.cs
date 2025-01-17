namespace Scheduling_Desktop_UI_App
{
    partial class LoginForm
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
            this.loginFormGroupBox = new System.Windows.Forms.GroupBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.loginFormGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormGroupBox
            // 
            this.loginFormGroupBox.Controls.Add(this.registerButton);
            this.loginFormGroupBox.Controls.Add(this.loginButton);
            this.loginFormGroupBox.Controls.Add(this.UserList);
            this.loginFormGroupBox.Controls.Add(this.QuitButton);
            this.loginFormGroupBox.Controls.Add(this.PasswordTextBox);
            this.loginFormGroupBox.Controls.Add(this.UserNameTextBox);
            this.loginFormGroupBox.Controls.Add(this.Password_Label);
            this.loginFormGroupBox.Controls.Add(this.UserName);
            this.loginFormGroupBox.Location = new System.Drawing.Point(20, 8);
            this.loginFormGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginFormGroupBox.Name = "loginFormGroupBox";
            this.loginFormGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginFormGroupBox.Size = new System.Drawing.Size(377, 220);
            this.loginFormGroupBox.TabIndex = 0;
            this.loginFormGroupBox.TabStop = false;
            this.loginFormGroupBox.Text = "Scheduling Login Form";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(200, 106);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(119, 106);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // UserList
            // 
            this.UserList.Location = new System.Drawing.Point(119, 135);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(75, 23);
            this.UserList.TabIndex = 11;
            this.UserList.Text = "User List";
            this.UserList.UseVisualStyleBackColor = true;
            this.UserList.Click += new System.EventHandler(this.UserList_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(200, 135);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(119, 77);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(119, 53);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.UserNameTextBox.TabIndex = 6;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(49, 81);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(49, 55);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "UserName";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 250);
            this.Controls.Add(this.loginFormGroupBox);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginFormGroupBox.ResumeLayout(false);
            this.loginFormGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginFormGroupBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button UserList;
    }
}

