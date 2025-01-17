namespace Scheduling_Desktop_UI_App.User_Navigation_Pages
{
    partial class ListUsersPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ListUsersCancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddUserButton);
            this.groupBox1.Controls.Add(this.UpdateUserButton);
            this.groupBox1.Controls.Add(this.ListUsersCancelButton);
            this.groupBox1.Controls.Add(this.DeleteUser);
            this.groupBox1.Controls.Add(this.ListUsersDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(87, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Users";
            // 
            // ListUsersDataGridView
            // 
            this.ListUsersDataGridView.AllowUserToAddRows = false;
            this.ListUsersDataGridView.AllowUserToResizeColumns = false;
            this.ListUsersDataGridView.AllowUserToResizeRows = false;
            this.ListUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUsersDataGridView.Location = new System.Drawing.Point(259, 72);
            this.ListUsersDataGridView.Name = "ListUsersDataGridView";
            this.ListUsersDataGridView.ReadOnly = true;
            this.ListUsersDataGridView.RowHeadersWidth = 62;
            this.ListUsersDataGridView.RowTemplate.Height = 28;
            this.ListUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListUsersDataGridView.Size = new System.Drawing.Size(373, 274);
            this.ListUsersDataGridView.TabIndex = 0;
            this.ListUsersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUsersDataGridView_CellContentClick);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(43, 227);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(117, 44);
            this.DeleteUser.TabIndex = 2;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Location = new System.Drawing.Point(43, 146);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(117, 44);
            this.UpdateUserButton.TabIndex = 2;
            this.UpdateUserButton.Text = "Update User";
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(43, 72);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(117, 44);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // ListUsersCancelButton
            // 
            this.ListUsersCancelButton.Location = new System.Drawing.Point(43, 302);
            this.ListUsersCancelButton.Name = "ListUsersCancelButton";
            this.ListUsersCancelButton.Size = new System.Drawing.Size(117, 44);
            this.ListUsersCancelButton.TabIndex = 2;
            this.ListUsersCancelButton.Text = "Cancel";
            this.ListUsersCancelButton.UseVisualStyleBackColor = true;
            this.ListUsersCancelButton.Click += new System.EventHandler(this.ListUsersCancelButton_Click);
            // 
            // ListUsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 571);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListUsersPage";
            this.Text = "ListUsersPage";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button ListUsersCancelButton;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.DataGridView ListUsersDataGridView;
    }
}