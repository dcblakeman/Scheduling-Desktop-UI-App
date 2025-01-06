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
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.mainNavigationPageButton = new System.Windows.Forms.Button();
            this.customerNavigationLabel = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.QuitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(53, 160);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(53, 274);
            this.updateCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.updateCustomerButton.TabIndex = 2;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(53, 388);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.deleteCustomerButton.TabIndex = 3;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // mainNavigationPageButton
            // 
            this.mainNavigationPageButton.Location = new System.Drawing.Point(711, 433);
            this.mainNavigationPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainNavigationPageButton.Name = "mainNavigationPageButton";
            this.mainNavigationPageButton.Size = new System.Drawing.Size(195, 35);
            this.mainNavigationPageButton.TabIndex = 5;
            this.mainNavigationPageButton.Text = "Main Navigation Page";
            this.mainNavigationPageButton.UseVisualStyleBackColor = true;
            this.mainNavigationPageButton.Click += new System.EventHandler(this.NavigationFormButton_Click);
            // 
            // customerNavigationLabel
            // 
            this.customerNavigationLabel.AutoSize = true;
            this.customerNavigationLabel.Location = new System.Drawing.Point(511, 92);
            this.customerNavigationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNavigationLabel.Name = "customerNavigationLabel";
            this.customerNavigationLabel.Size = new System.Drawing.Size(156, 20);
            this.customerNavigationLabel.TabIndex = 1;
            this.customerNavigationLabel.Text = "Customer Navigation";
            this.customerNavigationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(297, 160);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 62;
            this.customerDataGridView.Size = new System.Drawing.Size(609, 263);
            this.customerDataGridView.TabIndex = 4;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(297, 433);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(195, 35);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CustomerNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 593);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerNavigationLabel);
            this.Controls.Add(this.mainNavigationPageButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerNavigationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Navigation";
            this.Load += new System.EventHandler(this.CustomerNavigationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button mainNavigationPageButton;
        private System.Windows.Forms.Label customerNavigationLabel;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button QuitButton;
    }
}