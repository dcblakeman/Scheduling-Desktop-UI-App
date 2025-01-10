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
            this.QuitButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.UserList = new System.Windows.Forms.Button();
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
            this.loginFormGroupBox.Controls.Add(this.UsernameTextBox);
            this.loginFormGroupBox.Controls.Add(this.Password_Label);
            this.loginFormGroupBox.Controls.Add(this.Username);
            this.loginFormGroupBox.Location = new System.Drawing.Point(30, 12);
            this.loginFormGroupBox.Name = "loginFormGroupBox";
            this.loginFormGroupBox.Size = new System.Drawing.Size(565, 339);
            this.loginFormGroupBox.TabIndex = 0;
            this.loginFormGroupBox.TabStop = false;
            this.loginFormGroupBox.Text = "Scheduling Login Form";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(300, 163);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 35);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(178, 163);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 35);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(300, 208);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(112, 35);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(178, 118);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(234, 26);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(178, 82);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(234, 26);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(74, 124);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(78, 20);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(74, 85);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 5;
            this.Username.Text = "Username";
            // 
            // UserList
            // 
            this.UserList.Location = new System.Drawing.Point(178, 208);
            this.UserList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(112, 35);
            this.UserList.TabIndex = 11;
            this.UserList.Text = "User List";
            this.UserList.UseVisualStyleBackColor = true;
            this.UserList.Click += new System.EventHandler(this.UserList_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(648, 384);
            this.Controls.Add(this.loginFormGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button UserList;
    }
}

