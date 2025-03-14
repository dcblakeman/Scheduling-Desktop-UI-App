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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AppointmentNavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MainNavigationPageButton = new System.Windows.Forms.Button();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.AppointmentCalendarGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerNavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerProfile = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.SelectCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.AppointmentNavigationGroupBox.SuspendLayout();
            this.AppointmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.AppointmentCalendarGroupBox.SuspendLayout();
            this.CustomerNavigationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentNavigationGroupBox
            // 
            this.AppointmentNavigationGroupBox.Controls.Add(this.QuitButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.MainNavigationPageButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.DeleteAppointmentButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.UpdateAppointmentButton);
            this.AppointmentNavigationGroupBox.Controls.Add(this.AddAppointmentButton);
            this.AppointmentNavigationGroupBox.Location = new System.Drawing.Point(59, 38);
            this.AppointmentNavigationGroupBox.Name = "AppointmentNavigationGroupBox";
            this.AppointmentNavigationGroupBox.Size = new System.Drawing.Size(141, 189);
            this.AppointmentNavigationGroupBox.TabIndex = 7;
            this.AppointmentNavigationGroupBox.TabStop = false;
            this.AppointmentNavigationGroupBox.Text = "Appointment Navigation";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(13, 158);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(115, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainNavigationPageButton
            // 
            this.MainNavigationPageButton.Location = new System.Drawing.Point(13, 122);
            this.MainNavigationPageButton.Name = "MainNavigationPageButton";
            this.MainNavigationPageButton.Size = new System.Drawing.Size(115, 23);
            this.MainNavigationPageButton.TabIndex = 4;
            this.MainNavigationPageButton.Text = "Main Navigation Page";
            this.MainNavigationPageButton.UseVisualStyleBackColor = true;
            this.MainNavigationPageButton.Click += new System.EventHandler(this.MainNavigationPageButton_Click);
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(13, 87);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(115, 23);
            this.DeleteAppointmentButton.TabIndex = 3;
            this.DeleteAppointmentButton.Text = "Delete Appointment";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = true;
            this.DeleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(13, 52);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(115, 23);
            this.UpdateAppointmentButton.TabIndex = 2;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
            this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(13, 16);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(115, 23);
            this.AddAppointmentButton.TabIndex = 1;
            this.AddAppointmentButton.Text = "Add Appointment";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // AppointmentsGroupBox
            // 
            this.AppointmentsGroupBox.Controls.Add(this.AppointmentsDataGridView);
            this.AppointmentsGroupBox.Location = new System.Drawing.Point(59, 230);
            this.AppointmentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentsGroupBox.Name = "AppointmentsGroupBox";
            this.AppointmentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.AppointmentsGroupBox.Size = new System.Drawing.Size(1006, 217);
            this.AppointmentsGroupBox.TabIndex = 9;
            this.AppointmentsGroupBox.TabStop = false;
            this.AppointmentsGroupBox.Text = "Appointments";
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.AllowUserToResizeColumns = false;
            this.AppointmentsDataGridView.AllowUserToResizeRows = false;
            this.AppointmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(13, 16);
            this.AppointmentsDataGridView.MultiSelect = false;
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AppointmentsDataGridView.RowHeadersVisible = false;
            this.AppointmentsDataGridView.RowHeadersWidth = 62;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(974, 188);
            this.AppointmentsDataGridView.TabIndex = 51;
            // 
            // AppointmentCalendar
            // 
            this.AppointmentCalendar.Location = new System.Drawing.Point(11, 16);
            this.AppointmentCalendar.Name = "AppointmentCalendar";
            this.AppointmentCalendar.TabIndex = 51;
            this.AppointmentCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentCalendar_DateChanged);
            // 
            // AppointmentCalendarGroupBox
            // 
            this.AppointmentCalendarGroupBox.Controls.Add(this.AppointmentCalendar);
            this.AppointmentCalendarGroupBox.Location = new System.Drawing.Point(216, 38);
            this.AppointmentCalendarGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentCalendarGroupBox.Name = "AppointmentCalendarGroupBox";
            this.AppointmentCalendarGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.AppointmentCalendarGroupBox.Size = new System.Drawing.Size(235, 189);
            this.AppointmentCalendarGroupBox.TabIndex = 8;
            this.AppointmentCalendarGroupBox.TabStop = false;
            this.AppointmentCalendarGroupBox.Text = "Appointment Calendar";
            // 
            // CustomerNavigationGroupBox
            // 
            this.CustomerNavigationGroupBox.Controls.Add(this.CustomerDataGridView);
            this.CustomerNavigationGroupBox.Controls.Add(this.CustomerProfile);
            this.CustomerNavigationGroupBox.Controls.Add(this.DeleteCustomerButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.UpdateCustomerButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.SelectCustomerButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.AddCustomerButton);
            this.CustomerNavigationGroupBox.Location = new System.Drawing.Point(466, 38);
            this.CustomerNavigationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerNavigationGroupBox.Name = "CustomerNavigationGroupBox";
            this.CustomerNavigationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CustomerNavigationGroupBox.Size = new System.Drawing.Size(599, 189);
            this.CustomerNavigationGroupBox.TabIndex = 15;
            this.CustomerNavigationGroupBox.TabStop = false;
            this.CustomerNavigationGroupBox.Text = "Customer Navigation";
            this.CustomerNavigationGroupBox.Enter += new System.EventHandler(this.CustomerNavigationGroupBox_Enter);
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToAddRows = false;
            this.CustomerDataGridView.AllowUserToDeleteRows = false;
            this.CustomerDataGridView.AllowUserToResizeColumns = false;
            this.CustomerDataGridView.AllowUserToResizeRows = false;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(125, 18);
            this.CustomerDataGridView.MultiSelect = false;
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersVisible = false;
            this.CustomerDataGridView.RowHeadersWidth = 62;
            this.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDataGridView.Size = new System.Drawing.Size(456, 163);
            this.CustomerDataGridView.TabIndex = 4;
            this.CustomerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellContentClick);
            // 
            // CustomerProfile
            // 
            this.CustomerProfile.Location = new System.Drawing.Point(5, 157);
            this.CustomerProfile.Name = "CustomerProfile";
            this.CustomerProfile.Size = new System.Drawing.Size(115, 23);
            this.CustomerProfile.TabIndex = 10;
            this.CustomerProfile.Text = "Customer Profile";
            this.CustomerProfile.UseVisualStyleBackColor = true;
            this.CustomerProfile.Click += new System.EventHandler(this.CustomerProfile_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Location = new System.Drawing.Point(5, 122);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.DeleteCustomerButton.TabIndex = 9;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Location = new System.Drawing.Point(4, 87);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.UpdateCustomerButton.TabIndex = 8;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // SelectCustomerButton
            // 
            this.SelectCustomerButton.Location = new System.Drawing.Point(5, 17);
            this.SelectCustomerButton.Name = "SelectCustomerButton";
            this.SelectCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.SelectCustomerButton.TabIndex = 6;
            this.SelectCustomerButton.Text = "Select Customer";
            this.SelectCustomerButton.UseVisualStyleBackColor = true;
            this.SelectCustomerButton.Click += new System.EventHandler(this.SelectCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(5, 52);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.AddCustomerButton.TabIndex = 7;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // AppointmentNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 468);
            this.Controls.Add(this.CustomerNavigationGroupBox);
            this.Controls.Add(this.AppointmentsGroupBox);
            this.Controls.Add(this.AppointmentCalendarGroupBox);
            this.Controls.Add(this.AppointmentNavigationGroupBox);
            this.Name = "AppointmentNavigationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments Navigation Page";
            this.Load += new System.EventHandler(this.AppointmentNavigationPage_Load);
            this.AppointmentNavigationGroupBox.ResumeLayout(false);
            this.AppointmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.AppointmentCalendarGroupBox.ResumeLayout(false);
            this.CustomerNavigationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AppointmentNavigationGroupBox;
        private System.Windows.Forms.Button MainNavigationPageButton;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.GroupBox AppointmentsGroupBox;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.MonthCalendar AppointmentCalendar;
        private System.Windows.Forms.GroupBox AppointmentCalendarGroupBox;
        private System.Windows.Forms.GroupBox CustomerNavigationGroupBox;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Button CustomerProfile;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button SelectCustomerButton;
        private System.Windows.Forms.Button QuitButton;
    }
}