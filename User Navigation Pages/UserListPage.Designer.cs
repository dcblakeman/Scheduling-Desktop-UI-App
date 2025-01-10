namespace Scheduling_Desktop_UI_App
{
    partial class UserListPage
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
            this.UserListGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.UserListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserListGroupBox
            // 
            this.UserListGroupBox.Controls.Add(this.DeleteUserButton);
            this.UserListGroupBox.Controls.Add(this.UpdateUserButton);
            this.UserListGroupBox.Controls.Add(this.AddUserButton);
            this.UserListGroupBox.Controls.Add(this.UserDataGridView);
            this.UserListGroupBox.Location = new System.Drawing.Point(38, 28);
            this.UserListGroupBox.Name = "UserListGroupBox";
            this.UserListGroupBox.Size = new System.Drawing.Size(718, 410);
            this.UserListGroupBox.TabIndex = 0;
            this.UserListGroupBox.TabStop = false;
            this.UserListGroupBox.Text = "User List";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(53, 278);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(107, 52);
            this.DeleteUserButton.TabIndex = 3;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Location = new System.Drawing.Point(53, 175);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(107, 52);
            this.UpdateUserButton.TabIndex = 4;
            this.UpdateUserButton.Text = "Update User";
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(53, 77);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(107, 52);
            this.AddUserButton.TabIndex = 5;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Location = new System.Drawing.Point(238, 77);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersWidth = 62;
            this.UserDataGridView.RowTemplate.Height = 28;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(418, 253);
            this.UserDataGridView.TabIndex = 2;
            this.UserDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            // 
            // UserListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserListGroupBox);
            this.Name = "UserListPage";
            this.Text = "User List";
            this.UserListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserListGroupBox;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.DataGridView UserDataGridView;
    }
}