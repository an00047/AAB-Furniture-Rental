
namespace AAB_Furniture_Rentals.View
{
    partial class AdminMainDashboard
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
            this.reportTab = new System.Windows.Forms.TabPage();
            this.adminReportUserControl1 = new AAB_Furniture_Rentals.View.UserControls.AdminReportUserControl();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.adminSearchUpdateAddEmployee1 = new AAB_Furniture_Rentals.View.UserControls.AdminSearchUpdateAddEmployee();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailsBox = new System.Windows.Forms.GroupBox();
            this.EmployeeNameValue = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDValue = new System.Windows.Forms.Label();
            this.EmpployeeIDLabel = new System.Windows.Forms.Label();
            this.reportTab.SuspendLayout();
            this.AdminTabControl.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.EmployeeDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.adminReportUserControl1);
            this.reportTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(788, 329);
            this.reportTab.TabIndex = 1;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // adminReportUserControl1
            // 
            this.adminReportUserControl1.AutoSize = true;
            this.adminReportUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminReportUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminReportUserControl1.Location = new System.Drawing.Point(3, 3);
            this.adminReportUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminReportUserControl1.Name = "adminReportUserControl1";
            this.adminReportUserControl1.Size = new System.Drawing.Size(782, 323);
            this.adminReportUserControl1.TabIndex = 0;
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.employeesTab);
            this.AdminTabControl.Controls.Add(this.reportTab);
            this.AdminTabControl.Location = new System.Drawing.Point(6, 43);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(796, 355);
            this.AdminTabControl.TabIndex = 2;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.adminSearchUpdateAddEmployee1);
            this.employeesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesTab.Location = new System.Drawing.Point(4, 22);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTab.Size = new System.Drawing.Size(788, 329);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // adminSearchUpdateAddEmployee1
            // 
            this.adminSearchUpdateAddEmployee1.Location = new System.Drawing.Point(-109, -31);
            this.adminSearchUpdateAddEmployee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminSearchUpdateAddEmployee1.Name = "adminSearchUpdateAddEmployee1";
            this.adminSearchUpdateAddEmployee1.Size = new System.Drawing.Size(901, 355);
            this.adminSearchUpdateAddEmployee1.TabIndex = 0;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutLabel.Location = new System.Drawing.Point(285, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLabel.TabIndex = 3;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // EmployeeDetailsBox
            // 
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeNameValue);
            this.EmployeeDetailsBox.Controls.Add(this.logoutLabel);
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeNameLabel);
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeIDValue);
            this.EmployeeDetailsBox.Controls.Add(this.EmpployeeIDLabel);
            this.EmployeeDetailsBox.Location = new System.Drawing.Point(443, 12);
            this.EmployeeDetailsBox.Name = "EmployeeDetailsBox";
            this.EmployeeDetailsBox.Size = new System.Drawing.Size(350, 45);
            this.EmployeeDetailsBox.TabIndex = 24;
            this.EmployeeDetailsBox.TabStop = false;
            this.EmployeeDetailsBox.Text = "Employee Details: ";
            // 
            // EmployeeNameValue
            // 
            this.EmployeeNameValue.AutoSize = true;
            this.EmployeeNameValue.Font = new System.Drawing.Font("ModeNine", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameValue.ForeColor = System.Drawing.Color.Black;
            this.EmployeeNameValue.Location = new System.Drawing.Point(47, 21);
            this.EmployeeNameValue.Name = "EmployeeNameValue";
            this.EmployeeNameValue.Size = new System.Drawing.Size(16, 15);
            this.EmployeeNameValue.TabIndex = 19;
            this.EmployeeNameValue.Text = "?";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(6, 21);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(41, 13);
            this.EmployeeNameLabel.TabIndex = 18;
            this.EmployeeNameLabel.Text = "Name: ";
            // 
            // EmployeeIDValue
            // 
            this.EmployeeIDValue.AutoSize = true;
            this.EmployeeIDValue.Font = new System.Drawing.Font("ModeNine", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDValue.ForeColor = System.Drawing.Color.Black;
            this.EmployeeIDValue.Location = new System.Drawing.Point(262, 19);
            this.EmployeeIDValue.Name = "EmployeeIDValue";
            this.EmployeeIDValue.Size = new System.Drawing.Size(16, 15);
            this.EmployeeIDValue.TabIndex = 17;
            this.EmployeeIDValue.Text = "?";
            // 
            // EmpployeeIDLabel
            // 
            this.EmpployeeIDLabel.AutoSize = true;
            this.EmpployeeIDLabel.Location = new System.Drawing.Point(186, 20);
            this.EmpployeeIDLabel.Name = "EmpployeeIDLabel";
            this.EmpployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmpployeeIDLabel.TabIndex = 16;
            this.EmpployeeIDLabel.Text = "Employee ID:";
            // 
            // AdminMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 405);
            this.Controls.Add(this.EmployeeDetailsBox);
            this.Controls.Add(this.AdminTabControl);
            this.MaximumSize = new System.Drawing.Size(821, 444);
            this.MinimumSize = new System.Drawing.Size(821, 444);
            this.Name = "AdminMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard: ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainDashboard_FormClose);
            this.reportTab.ResumeLayout(false);
            this.reportTab.PerformLayout();
            this.AdminTabControl.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.EmployeeDetailsBox.ResumeLayout(false);
            this.EmployeeDetailsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage employeesTab;
        private UserControls.AdminSearchUpdateAddEmployee adminSearchUpdateAddEmployee1;
        private UserControls.AdminReportUserControl adminReportUserControl1;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.GroupBox EmployeeDetailsBox;
        private System.Windows.Forms.Label EmployeeNameValue;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDValue;
        private System.Windows.Forms.Label EmpployeeIDLabel;
    }
}