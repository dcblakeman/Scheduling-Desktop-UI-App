﻿namespace Scheduling_Desktop_UI_App
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
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.ToMainNavigationPageButton = new System.Windows.Forms.Button();
            this.CustomerNavigationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(347, 127);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.AddCustomerButton.TabIndex = 0;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Location = new System.Drawing.Point(347, 201);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.UpdateCustomerButton.TabIndex = 0;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Location = new System.Drawing.Point(347, 275);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(115, 23);
            this.DeleteCustomerButton.TabIndex = 0;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // ToMainNavigationPageButton
            // 
            this.ToMainNavigationPageButton.Location = new System.Drawing.Point(598, 350);
            this.ToMainNavigationPageButton.Name = "ToMainNavigationPageButton";
            this.ToMainNavigationPageButton.Size = new System.Drawing.Size(130, 23);
            this.ToMainNavigationPageButton.TabIndex = 0;
            this.ToMainNavigationPageButton.Text = "Main Navigation";
            this.ToMainNavigationPageButton.UseVisualStyleBackColor = true;
            this.ToMainNavigationPageButton.Click += new System.EventHandler(this.ToNavigationFormButton_Click);
            // 
            // CustomerNavigationLabel
            // 
            this.CustomerNavigationLabel.AutoSize = true;
            this.CustomerNavigationLabel.Location = new System.Drawing.Point(352, 63);
            this.CustomerNavigationLabel.Name = "CustomerNavigationLabel";
            this.CustomerNavigationLabel.Size = new System.Drawing.Size(105, 13);
            this.CustomerNavigationLabel.TabIndex = 1;
            this.CustomerNavigationLabel.Text = "Customer Navigation";
            // 
            // CustomerNavigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerNavigationLabel);
            this.Controls.Add(this.ToMainNavigationPageButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.UpdateCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Name = "CustomerNavigationPage";
            this.Text = "Customer Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button ToMainNavigationPageButton;
        private System.Windows.Forms.Label CustomerNavigationLabel;
    }
}