namespace Scheduling_Desktop_UI_App
{
    partial class MainNavigationPage
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
            this.MainNavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.UsersButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.MainNavigationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainNavigationGroupBox
            // 
            this.MainNavigationGroupBox.Controls.Add(this.UsersButton);
            this.MainNavigationGroupBox.Controls.Add(this.LogoutButton);
            this.MainNavigationGroupBox.Controls.Add(this.AppointmentsButton);
            this.MainNavigationGroupBox.Controls.Add(this.CustomersButton);
            this.MainNavigationGroupBox.Location = new System.Drawing.Point(48, 40);
            this.MainNavigationGroupBox.Name = "MainNavigationGroupBox";
            this.MainNavigationGroupBox.Size = new System.Drawing.Size(392, 241);
            this.MainNavigationGroupBox.TabIndex = 0;
            this.MainNavigationGroupBox.TabStop = false;
            this.MainNavigationGroupBox.Text = "Main Navigation";
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(26, 134);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(340, 35);
            this.UsersButton.TabIndex = 16;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(26, 179);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(340, 35);
            this.LogoutButton.TabIndex = 15;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.Location = new System.Drawing.Point(26, 44);
            this.AppointmentsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(340, 35);
            this.AppointmentsButton.TabIndex = 13;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.UseVisualStyleBackColor = true;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(26, 89);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(340, 35);
            this.CustomersButton.TabIndex = 14;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // MainNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 351);
            this.Controls.Add(this.MainNavigationGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainNavigationPage";
            this.Text = "Main Navigation";
            this.Load += new System.EventHandler(this.MainNavigationPage_Load);
            this.MainNavigationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainNavigationGroupBox;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button AppointmentsButton;
        private System.Windows.Forms.Button CustomersButton;
    }
}