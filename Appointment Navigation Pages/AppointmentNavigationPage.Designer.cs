namespace Scheduling_Desktop_UI_App
{
    partial class AppointmentNavigationPage
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
            this.ToNavigationPageButton = new System.Windows.Forms.Button();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentNavigationLabel = new System.Windows.Forms.Label();
            this.AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToNavigationPageButton
            // 
            this.ToNavigationPageButton.Location = new System.Drawing.Point(832, 473);
            this.ToNavigationPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToNavigationPageButton.Name = "ToNavigationPageButton";
            this.ToNavigationPageButton.Size = new System.Drawing.Size(172, 35);
            this.ToNavigationPageButton.TabIndex = 1;
            this.ToNavigationPageButton.Text = "Main Navigation Page";
            this.ToNavigationPageButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(116, 428);
            this.DeleteAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(172, 35);
            this.DeleteAppointmentButton.TabIndex = 2;
            this.DeleteAppointmentButton.Text = "Delete Appointment";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(116, 320);
            this.UpdateAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(172, 35);
            this.UpdateAppointmentButton.TabIndex = 3;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(116, 212);
            this.AddAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(172, 35);
            this.AddAppointmentButton.TabIndex = 4;
            this.AddAppointmentButton.Text = "Add Appointment";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentNavigationLabel
            // 
            this.AppointmentNavigationLabel.AutoSize = true;
            this.AppointmentNavigationLabel.Location = new System.Drawing.Point(508, 95);
            this.AppointmentNavigationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppointmentNavigationLabel.Name = "AppointmentNavigationLabel";
            this.AppointmentNavigationLabel.Size = new System.Drawing.Size(178, 20);
            this.AppointmentNavigationLabel.TabIndex = 5;
            this.AppointmentNavigationLabel.Text = "Appointment Navigation";
            // 
            // AppointmentDataGridView
            // 
            this.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGridView.Location = new System.Drawing.Point(438, 212);
            this.AppointmentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentDataGridView.Name = "AppointmentDataGridView";
            this.AppointmentDataGridView.RowHeadersWidth = 62;
            this.AppointmentDataGridView.Size = new System.Drawing.Size(566, 251);
            this.AppointmentDataGridView.TabIndex = 6;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(438, 473);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(172, 35);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // AppointmentNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.AppointmentDataGridView);
            this.Controls.Add(this.AppointmentNavigationLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.ToNavigationPageButton);
            this.Controls.Add(this.DeleteAppointmentButton);
            this.Controls.Add(this.UpdateAppointmentButton);
            this.Controls.Add(this.AddAppointmentButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppointmentNavigationPage";
            this.Text = "Appointments Navigation Page";
            this.Load += new System.EventHandler(this.AppointmentNavigationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToNavigationPageButton;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Label AppointmentNavigationLabel;
        private System.Windows.Forms.DataGridView AppointmentDataGridView;
        private System.Windows.Forms.Button quitButton;
    }
}