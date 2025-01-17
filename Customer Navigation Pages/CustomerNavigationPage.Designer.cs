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
            this.customerNavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.mainNavigationPageButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.customerNavigationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNavigationGroupBox
            // 
            this.customerNavigationGroupBox.Controls.Add(this.quitButton);
            this.customerNavigationGroupBox.Controls.Add(this.CustomerDataGridView);
            this.customerNavigationGroupBox.Controls.Add(this.mainNavigationPageButton);
            this.customerNavigationGroupBox.Controls.Add(this.deleteCustomerButton);
            this.customerNavigationGroupBox.Controls.Add(this.updateCustomerButton);
            this.customerNavigationGroupBox.Controls.Add(this.AddCustomerButton);
            this.customerNavigationGroupBox.Location = new System.Drawing.Point(61, 24);
            this.customerNavigationGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNavigationGroupBox.Name = "customerNavigationGroupBox";
            this.customerNavigationGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNavigationGroupBox.Size = new System.Drawing.Size(563, 331);
            this.customerNavigationGroupBox.TabIndex = 7;
            this.customerNavigationGroupBox.TabStop = false;
            this.customerNavigationGroupBox.Text = "Customer Navigation";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(137, 239);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 23);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToResizeColumns = false;
            this.CustomerDataGridView.AllowUserToResizeRows = false;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(137, 62);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersWidth = 62;
            this.CustomerDataGridView.Size = new System.Drawing.Size(406, 171);
            this.CustomerDataGridView.TabIndex = 10;
            this.CustomerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellContentClick);
            // 
            // mainNavigationPageButton
            // 
            this.mainNavigationPageButton.Location = new System.Drawing.Point(413, 239);
            this.mainNavigationPageButton.Name = "mainNavigationPageButton";
            this.mainNavigationPageButton.Size = new System.Drawing.Size(130, 23);
            this.mainNavigationPageButton.TabIndex = 11;
            this.mainNavigationPageButton.Text = "Main Navigation Page";
            this.mainNavigationPageButton.UseVisualStyleBackColor = true;
            this.mainNavigationPageButton.Click += new System.EventHandler(this.MainNavigationPageButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(5, 210);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.deleteCustomerButton.TabIndex = 9;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(5, 132);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.updateCustomerButton.TabIndex = 8;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(5, 62);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.AddCustomerButton.TabIndex = 7;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomerNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.Controls.Add(this.customerNavigationGroupBox);
            this.Name = "CustomerNavigationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Navigation";
            this.Load += new System.EventHandler(this.CustomerNavigationPage_Load);
            this.customerNavigationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox customerNavigationGroupBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Button mainNavigationPageButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
    }
}