namespace Scheduling_Desktop_UI_App.User_Pages
{
    partial class UserListViewPage
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.ListUsersCancelButton = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.ListUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.UserListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserListGroupBox
            // 
            this.UserListGroupBox.Controls.Add(this.AddUserButton);
            this.UserListGroupBox.Controls.Add(this.UpdateUserButton);
            this.UserListGroupBox.Controls.Add(this.ListUsersCancelButton);
            this.UserListGroupBox.Controls.Add(this.DeleteUser);
            this.UserListGroupBox.Controls.Add(this.ListUsersDataGridView);
            this.UserListGroupBox.Location = new System.Drawing.Point(79, 64);
            this.UserListGroupBox.Name = "UserListGroupBox";
            this.UserListGroupBox.Size = new System.Drawing.Size(687, 392);
            this.UserListGroupBox.TabIndex = 1;
            this.UserListGroupBox.TabStop = false;
            this.UserListGroupBox.Text = "User List";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Enabled = false;
            this.AddUserButton.Location = new System.Drawing.Point(80, 55);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(117, 44);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Enabled = false;
            this.UpdateUserButton.Location = new System.Drawing.Point(80, 131);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(117, 44);
            this.UpdateUserButton.TabIndex = 2;
            this.UpdateUserButton.Text = "Update User";
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // ListUsersCancelButton
            // 
            this.ListUsersCancelButton.Location = new System.Drawing.Point(80, 283);
            this.ListUsersCancelButton.Name = "ListUsersCancelButton";
            this.ListUsersCancelButton.Size = new System.Drawing.Size(117, 44);
            this.ListUsersCancelButton.TabIndex = 2;
            this.ListUsersCancelButton.Text = "Cancel";
            this.ListUsersCancelButton.UseVisualStyleBackColor = true;
            this.ListUsersCancelButton.Click += new System.EventHandler(this.ListUsersCancelButton_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Enabled = false;
            this.DeleteUser.Location = new System.Drawing.Point(80, 207);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(117, 44);
            this.DeleteUser.TabIndex = 2;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // ListUsersDataGridView
            // 
            this.ListUsersDataGridView.AllowUserToAddRows = false;
            this.ListUsersDataGridView.AllowUserToResizeColumns = false;
            this.ListUsersDataGridView.AllowUserToResizeRows = false;
            this.ListUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUsersDataGridView.Location = new System.Drawing.Point(232, 55);
            this.ListUsersDataGridView.Name = "ListUsersDataGridView";
            this.ListUsersDataGridView.ReadOnly = true;
            this.ListUsersDataGridView.RowHeadersVisible = false;
            this.ListUsersDataGridView.RowHeadersWidth = 62;
            this.ListUsersDataGridView.RowTemplate.Height = 28;
            this.ListUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListUsersDataGridView.Size = new System.Drawing.Size(373, 274);
            this.ListUsersDataGridView.TabIndex = 0;
            this.ListUsersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUsersDataGridView_CellContentClick);
            // 
            // UserListViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 512);
            this.Controls.Add(this.UserListGroupBox);
            this.Name = "UserListViewPage";
            this.Text = "UserListViewPage";
            this.Load += new System.EventHandler(this.UserListViewPage_Load);
            this.UserListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserListGroupBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button ListUsersCancelButton;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.DataGridView ListUsersDataGridView;
    }
}