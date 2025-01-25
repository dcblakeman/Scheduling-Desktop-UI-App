namespace Scheduling_Desktop_UI_App
{
    partial class CustomerNavigationPage
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
            this.CustomerNavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersDataGridView = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.mainNavigationPageButton = new System.Windows.Forms.Button();
            this.CustomerProfileButton = new System.Windows.Forms.Button();
            this.AppointmentNavigationPageButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomerNavigationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNavigationGroupBox
            // 
            this.CustomerNavigationGroupBox.Controls.Add(this.CustomersDataGridView);
            this.CustomerNavigationGroupBox.Controls.Add(this.quitButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.CustomerDataGridView);
            this.CustomerNavigationGroupBox.Controls.Add(this.mainNavigationPageButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.CustomerProfileButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.AppointmentNavigationPageButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.deleteCustomerButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.updateCustomerButton);
            this.CustomerNavigationGroupBox.Controls.Add(this.AddCustomerButton);
            this.CustomerNavigationGroupBox.Location = new System.Drawing.Point(92, 37);
            this.CustomerNavigationGroupBox.Name = "CustomerNavigationGroupBox";
            this.CustomerNavigationGroupBox.Size = new System.Drawing.Size(844, 509);
            this.CustomerNavigationGroupBox.TabIndex = 7;
            this.CustomerNavigationGroupBox.TabStop = false;
            this.CustomerNavigationGroupBox.Text = "Customer Navigation";
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AutoSize = true;
            this.CustomersDataGridView.Location = new System.Drawing.Point(459, 56);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(86, 20);
            this.CustomersDataGridView.TabIndex = 7;
            this.CustomersDataGridView.Text = "Customers";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(620, 368);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(195, 35);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToAddRows = false;
            this.CustomerDataGridView.AllowUserToResizeColumns = false;
            this.CustomerDataGridView.AllowUserToResizeRows = false;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(206, 95);
            this.CustomerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerDataGridView.MultiSelect = false;
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.ReadOnly = true;
            this.CustomerDataGridView.RowHeadersVisible = false;
            this.CustomerDataGridView.RowHeadersWidth = 62;
            this.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDataGridView.Size = new System.Drawing.Size(609, 263);
            this.CustomerDataGridView.TabIndex = 4;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
            this.CustomerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellContentClick);
            // 
            // mainNavigationPageButton
            // 
            this.mainNavigationPageButton.Location = new System.Drawing.Point(206, 368);
            this.mainNavigationPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainNavigationPageButton.Name = "mainNavigationPageButton";
            this.mainNavigationPageButton.Size = new System.Drawing.Size(195, 35);
            this.mainNavigationPageButton.TabIndex = 5;
            this.mainNavigationPageButton.Text = "Main Navigation Page";
            this.mainNavigationPageButton.UseVisualStyleBackColor = true;
            this.mainNavigationPageButton.Click += new System.EventHandler(this.MainNavigationPageButton_Click);
            // 
            // CustomerProfileButton
            // 
            this.CustomerProfileButton.Location = new System.Drawing.Point(8, 230);
            this.CustomerProfileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerProfileButton.Name = "CustomerProfileButton";
            this.CustomerProfileButton.Size = new System.Drawing.Size(172, 35);
            this.CustomerProfileButton.TabIndex = 3;
            this.CustomerProfileButton.Text = "Customer Profile";
            this.CustomerProfileButton.UseVisualStyleBackColor = true;
            this.CustomerProfileButton.Click += new System.EventHandler(this.CustomerProfileButton_Click);
            // 
            // AppointmentNavigationPageButton
            // 
            this.AppointmentNavigationPageButton.Location = new System.Drawing.Point(7, 275);
            this.AppointmentNavigationPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentNavigationPageButton.Name = "AppointmentNavigationPageButton";
            this.AppointmentNavigationPageButton.Size = new System.Drawing.Size(172, 35);
            this.AppointmentNavigationPageButton.TabIndex = 3;
            this.AppointmentNavigationPageButton.Text = "Appointments";
            this.AppointmentNavigationPageButton.UseVisualStyleBackColor = true;
            this.AppointmentNavigationPageButton.Click += new System.EventHandler(this.AppointmentNavigationPageButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(8, 185);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.deleteCustomerButton.TabIndex = 3;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(8, 140);
            this.updateCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.updateCustomerButton.TabIndex = 2;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(7, 95);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomerNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 592);
            this.Controls.Add(this.CustomerNavigationGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerNavigationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Navigation";
            this.Load += new System.EventHandler(this.CustomerNavigationPage_Load);
            this.CustomerNavigationGroupBox.ResumeLayout(false);
            this.CustomerNavigationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox CustomerNavigationGroupBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Button mainNavigationPageButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Label CustomersDataGridView;
        private System.Windows.Forms.Button CustomerProfileButton;
        private System.Windows.Forms.Button AppointmentNavigationPageButton;
    }
}