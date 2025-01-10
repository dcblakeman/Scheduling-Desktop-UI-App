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
            this.CustomersButton.Location = new System.Drawing.Point(101, 131);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(340, 35);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.Location = new System.Drawing.Point(101, 176);
            this.AppointmentsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(340, 35);
            this.AppointmentsButton.TabIndex = 0;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.UseVisualStyleBackColor = true;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // MainNavigationPageLabel
            // 
            this.MainNavigationPageLabel.AutoSize = true;
            this.MainNavigationPageLabel.Location = new System.Drawing.Point(212, 94);
            this.MainNavigationPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainNavigationPageLabel.Name = "MainNavigationPageLabel";
            this.MainNavigationPageLabel.Size = new System.Drawing.Size(121, 20);
            this.MainNavigationPageLabel.TabIndex = 1;
            this.MainNavigationPageLabel.Text = "Main Navigation";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(101, 221);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(340, 35);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 351);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.MainNavigationPageLabel);
            this.Controls.Add(this.AppointmentsButton);
            this.Controls.Add(this.CustomersButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainNavigationPage";
            this.Text = "Main Navigation";
            this.Load += new System.EventHandler(this.MainNavigationPage_Load);
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