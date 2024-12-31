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
            this.CustomersButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.MainNavigationPageLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(274, 176);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(227, 23);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.Location = new System.Drawing.Point(274, 238);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(227, 23);
            this.AppointmentsButton.TabIndex = 0;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.UseVisualStyleBackColor = true;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // MainNavigationPageLabel
            // 
            this.MainNavigationPageLabel.AutoSize = true;
            this.MainNavigationPageLabel.Location = new System.Drawing.Point(345, 124);
            this.MainNavigationPageLabel.Name = "MainNavigationPageLabel";
            this.MainNavigationPageLabel.Size = new System.Drawing.Size(84, 13);
            this.MainNavigationPageLabel.TabIndex = 1;
            this.MainNavigationPageLabel.Text = "Main Navigation";
            this.MainNavigationPageLabel.Click += new System.EventHandler(this.NavigationPageLabel_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(609, 327);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.MainNavigationPageLabel);
            this.Controls.Add(this.AppointmentsButton);
            this.Controls.Add(this.CustomersButton);
            this.Name = "MainNavigationPage";
            this.Text = "Main Navigation";
            this.Load += new System.EventHandler(this.mainNavigationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button AppointmentsButton;
        private System.Windows.Forms.Label MainNavigationPageLabel;
        private System.Windows.Forms.Button LogoutButton;
    }
}