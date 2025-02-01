namespace Scheduling_Desktop_UI_App.User_Navigation_Pages
{
    partial class UserNavigationPage
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
            this.UserUpdateButton = new System.Windows.Forms.Button();
            this.UserListCancelButton = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.UserListDataGridView = new System.Windows.Forms.DataGridView();
            this.UserListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserListGroupBox
            // 
            this.UserListGroupBox.Controls.Add(this.AddUserButton);
            this.UserListGroupBox.Controls.Add(this.UserUpdateButton);
            this.UserListGroupBox.Controls.Add(this.UserListCancelButton);
            this.UserListGroupBox.Controls.Add(this.DeleteUser);
            this.UserListGroupBox.Controls.Add(this.UserListDataGridView);
            this.UserListGroupBox.Location = new System.Drawing.Point(87, 40);
            this.UserListGroupBox.Name = "UserListGroupBox";
            this.UserListGroupBox.Size = new System.Drawing.Size(687, 392);
            this.UserListGroupBox.TabIndex = 0;
            this.UserListGroupBox.TabStop = false;
            this.UserListGroupBox.Text = "User List";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(80, 55);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(117, 44);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserUpdateButton
            // 
            this.UserUpdateButton.Location = new System.Drawing.Point(80, 131);
            this.UserUpdateButton.Name = "UserUpdateButton";
            this.UserUpdateButton.Size = new System.Drawing.Size(117, 44);
            this.UserUpdateButton.TabIndex = 2;
            this.UserUpdateButton.Text = "Update User";
            this.UserUpdateButton.UseVisualStyleBackColor = true;
            this.UserUpdateButton.Click += new System.EventHandler(this.UserUpdateButton_Click);
            // 
            // UserListCancelButton
            // 
            this.UserListCancelButton.Location = new System.Drawing.Point(80, 283);
            this.UserListCancelButton.Name = "UserListCancelButton";
            this.UserListCancelButton.Size = new System.Drawing.Size(117, 44);
            this.UserListCancelButton.TabIndex = 2;
            this.UserListCancelButton.Text = "Cancel";
            this.UserListCancelButton.UseVisualStyleBackColor = true;
            this.UserListCancelButton.Click += new System.EventHandler(this.UserListCancelButton_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(80, 207);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(117, 44);
            this.DeleteUser.TabIndex = 2;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // UserListDataGridView
            // 
            this.UserListDataGridView.AllowUserToAddRows = false;
            this.UserListDataGridView.AllowUserToResizeColumns = false;
            this.UserListDataGridView.AllowUserToResizeRows = false;
            this.UserListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDataGridView.Location = new System.Drawing.Point(232, 55);
            this.UserListDataGridView.Name = "UserListDataGridView";
            this.UserListDataGridView.ReadOnly = true;
            this.UserListDataGridView.RowHeadersVisible = false;
            this.UserListDataGridView.RowHeadersWidth = 62;
            this.UserListDataGridView.RowTemplate.Height = 28;
            this.UserListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserListDataGridView.Size = new System.Drawing.Size(373, 274);
            this.UserListDataGridView.TabIndex = 0;
            this.UserListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDataGridView_CellContentClick);
            // 
            // UserListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.UserListGroupBox);
            this.Name = "UserListPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User List";
            this.Load += new System.EventHandler(this.UserListPage_Load);
            this.UserListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserListGroupBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button UserUpdateButton;
        private System.Windows.Forms.Button UserListCancelButton;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.DataGridView UserListDataGridView;
    }
}