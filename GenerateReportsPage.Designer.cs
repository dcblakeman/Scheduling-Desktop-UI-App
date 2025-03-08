namespace Scheduling_Desktop_UI_App
{
    partial class GenerateReportsPage
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
            this.MonthlyReportsButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GenerateReportsCancelButton = new System.Windows.Forms.Button();
            this.ActiveCustomersCountButton = new System.Windows.Forms.Button();
            this.UsersSchedulesButton = new System.Windows.Forms.Button();
            this.AppointmentTypeCountButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ReportResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReportsDataGridView = new System.Windows.Forms.DataGridView();
            this.MonthlyReportsButtonsGroupBox.SuspendLayout();
            this.ReportResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthlyReportsButtonsGroupBox
            // 
            this.MonthlyReportsButtonsGroupBox.Controls.Add(this.button2);
            this.MonthlyReportsButtonsGroupBox.Controls.Add(this.GenerateReportsCancelButton);
            this.MonthlyReportsButtonsGroupBox.Controls.Add(this.ActiveCustomersCountButton);
            this.MonthlyReportsButtonsGroupBox.Controls.Add(this.UsersSchedulesButton);
            this.MonthlyReportsButtonsGroupBox.Controls.Add(this.AppointmentTypeCountButton);
            this.MonthlyReportsButtonsGroupBox.Location = new System.Drawing.Point(75, 29);
            this.MonthlyReportsButtonsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MonthlyReportsButtonsGroupBox.Name = "MonthlyReportsButtonsGroupBox";
            this.MonthlyReportsButtonsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.MonthlyReportsButtonsGroupBox.Size = new System.Drawing.Size(204, 177);
            this.MonthlyReportsButtonsGroupBox.TabIndex = 0;
            this.MonthlyReportsButtonsGroupBox.TabStop = false;
            this.MonthlyReportsButtonsGroupBox.Text = "Monthly Reports";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GenerateReportsCancelButton
            // 
            this.GenerateReportsCancelButton.Location = new System.Drawing.Point(27, 136);
            this.GenerateReportsCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateReportsCancelButton.Name = "GenerateReportsCancelButton";
            this.GenerateReportsCancelButton.Size = new System.Drawing.Size(152, 25);
            this.GenerateReportsCancelButton.TabIndex = 0;
            this.GenerateReportsCancelButton.Text = "Cancel";
            this.GenerateReportsCancelButton.UseVisualStyleBackColor = true;
            this.GenerateReportsCancelButton.Click += new System.EventHandler(this.GenerateReportsCancelButton_Click);
            // 
            // ActiveCustomersCountButton
            // 
            this.ActiveCustomersCountButton.Location = new System.Drawing.Point(27, 99);
            this.ActiveCustomersCountButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveCustomersCountButton.Name = "ActiveCustomersCountButton";
            this.ActiveCustomersCountButton.Size = new System.Drawing.Size(152, 25);
            this.ActiveCustomersCountButton.TabIndex = 0;
            this.ActiveCustomersCountButton.Text = "Active Customers Count";
            this.ActiveCustomersCountButton.UseVisualStyleBackColor = true;
            this.ActiveCustomersCountButton.Click += new System.EventHandler(this.ActiveCustomersCountButton_Click);
            // 
            // UsersSchedulesButton
            // 
            this.UsersSchedulesButton.Location = new System.Drawing.Point(27, 62);
            this.UsersSchedulesButton.Margin = new System.Windows.Forms.Padding(2);
            this.UsersSchedulesButton.Name = "UsersSchedulesButton";
            this.UsersSchedulesButton.Size = new System.Drawing.Size(152, 25);
            this.UsersSchedulesButton.TabIndex = 0;
            this.UsersSchedulesButton.Text = "Users\' Schedules";
            this.UsersSchedulesButton.UseVisualStyleBackColor = true;
            this.UsersSchedulesButton.Click += new System.EventHandler(this.UsersSchedulesButton_Click);
            // 
            // AppointmentTypeCountButton
            // 
            this.AppointmentTypeCountButton.Location = new System.Drawing.Point(27, 27);
            this.AppointmentTypeCountButton.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentTypeCountButton.Name = "AppointmentTypeCountButton";
            this.AppointmentTypeCountButton.Size = new System.Drawing.Size(152, 25);
            this.AppointmentTypeCountButton.TabIndex = 0;
            this.AppointmentTypeCountButton.Text = "Appointment Type Count";
            this.AppointmentTypeCountButton.UseVisualStyleBackColor = true;
            this.AppointmentTypeCountButton.Click += new System.EventHandler(this.AppointmentTypeCountButton_Click);
            // 
            // ReportResultsGroupBox
            // 
            this.ReportResultsGroupBox.Controls.Add(this.ReportsDataGridView);
            this.ReportResultsGroupBox.Location = new System.Drawing.Point(313, 29);
            this.ReportResultsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ReportResultsGroupBox.Name = "ReportResultsGroupBox";
            this.ReportResultsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ReportResultsGroupBox.Size = new System.Drawing.Size(413, 177);
            this.ReportResultsGroupBox.TabIndex = 1;
            this.ReportResultsGroupBox.TabStop = false;
            this.ReportResultsGroupBox.Text = "Report Results";
            // 
            // ReportsDataGridView
            // 
            this.ReportsDataGridView.AllowUserToAddRows = false;
            this.ReportsDataGridView.AllowUserToDeleteRows = false;
            this.ReportsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ReportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsDataGridView.Location = new System.Drawing.Point(16, 27);
            this.ReportsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ReportsDataGridView.Name = "ReportsDataGridView";
            this.ReportsDataGridView.ReadOnly = true;
            this.ReportsDataGridView.RowHeadersVisible = false;
            this.ReportsDataGridView.RowHeadersWidth = 62;
            this.ReportsDataGridView.RowTemplate.Height = 28;
            this.ReportsDataGridView.Size = new System.Drawing.Size(377, 134);
            this.ReportsDataGridView.TabIndex = 0;
            this.ReportsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportsDataGridView_CellContentClick);
            // 
            // GenerateReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 235);
            this.Controls.Add(this.ReportResultsGroupBox);
            this.Controls.Add(this.MonthlyReportsButtonsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateReportsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Reports";
            this.MonthlyReportsButtonsGroupBox.ResumeLayout(false);
            this.ReportResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MonthlyReportsButtonsGroupBox;
        private System.Windows.Forms.Button AppointmentTypeCountButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ActiveCustomersCountButton;
        private System.Windows.Forms.Button UsersSchedulesButton;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button GenerateReportsCancelButton;
        private System.Windows.Forms.GroupBox ReportResultsGroupBox;
        private System.Windows.Forms.DataGridView ReportsDataGridView;
    }
}