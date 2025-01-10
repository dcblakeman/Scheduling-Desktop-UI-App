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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.mainNavigationPageButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerNavigationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNavigationGroupBox
            // 
            this.customerNavigationGroupBox.Controls.Add(this.quitButton);
            this.customerNavigationGroupBox.Controls.Add(this.customerDataGridView);
            this.customerNavigationGroupBox.Controls.Add(this.mainNavigationPageButton);
            this.customerNavigationGroupBox.Controls.Add(this.deleteCustomerButton);
            this.customerNavigationGroupBox.Controls.Add(this.updateCustomerButton);
            this.customerNavigationGroupBox.Controls.Add(this.addCustomerButton);
            this.customerNavigationGroupBox.Location = new System.Drawing.Point(92, 37);
            this.customerNavigationGroupBox.Name = "customerNavigationGroupBox";
            this.customerNavigationGroupBox.Size = new System.Drawing.Size(845, 509);
            this.customerNavigationGroupBox.TabIndex = 7;
            this.customerNavigationGroupBox.TabStop = false;
            this.customerNavigationGroupBox.Text = "Customer Navigation";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(206, 368);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(195, 35);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(206, 95);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 62;
            this.customerDataGridView.Size = new System.Drawing.Size(609, 263);
            this.customerDataGridView.TabIndex = 10;
            // 
            // mainNavigationPageButton
            // 
            this.mainNavigationPageButton.Location = new System.Drawing.Point(620, 368);
            this.mainNavigationPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainNavigationPageButton.Name = "mainNavigationPageButton";
            this.mainNavigationPageButton.Size = new System.Drawing.Size(195, 35);
            this.mainNavigationPageButton.TabIndex = 11;
            this.mainNavigationPageButton.Text = "Main Navigation Page";
            this.mainNavigationPageButton.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(7, 323);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.deleteCustomerButton.TabIndex = 9;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(7, 203);
            this.updateCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.updateCustomerButton.TabIndex = 8;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(7, 95);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(172, 35);
            this.addCustomerButton.TabIndex = 7;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomerNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 593);
            this.Controls.Add(this.customerNavigationGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerNavigationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Navigation";
            this.Load += new System.EventHandler(this.CustomerNavigationPage_Load);
            this.customerNavigationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox customerNavigationGroupBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button mainNavigationPageButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
    }
}