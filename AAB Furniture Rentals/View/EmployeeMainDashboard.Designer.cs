
namespace AAB_Furniture_Rentals.View
{
    partial class EmployeeMainDashboard
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
            this.logoutLabel = new System.Windows.Forms.Label();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.furnitureTab = new System.Windows.Forms.TabPage();
            this.employeeFurnitureUserControl = new AAB_Furniture_Rentals.UserControls.EmployeeFurnitureUserControl();
            this.searchTransactions = new System.Windows.Forms.TabPage();
            this.employeeRentalsUserControl2 = new AAB_Furniture_Rentals.UserControls.EmployeeRentalsUserControl();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.employeeCustomersTabUserControl = new AAB_Furniture_Rentals.View.UserControls.EmployeeCustomersTabUserControl();
            this.returnsTab = new System.Windows.Forms.TabPage();
            this.employeeReturnTabUserControl1 = new AAB_Furniture_Rentals.View.UserControls.EmployeeReturnTabUserControl();
            this.rentalsTab = new System.Windows.Forms.TabPage();
            this.EmployeeDetailsBox = new System.Windows.Forms.GroupBox();
            this.EmployeeNameValue = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDValue = new System.Windows.Forms.Label();
            this.EmpployeeIDLabel = new System.Windows.Forms.Label();
            this.AdminTabControl.SuspendLayout();
            this.furnitureTab.SuspendLayout();
            this.searchTransactions.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.returnsTab.SuspendLayout();
            this.EmployeeDetailsBox.SuspendLayout();
            this.SuspendLayout();
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
            this.logoutLabel.TabIndex = 5;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminTabControl.Controls.Add(this.furnitureTab);
            this.AdminTabControl.Controls.Add(this.searchTransactions);
            this.AdminTabControl.Controls.Add(this.customersTab);
            this.AdminTabControl.Controls.Add(this.returnsTab);
            this.AdminTabControl.Location = new System.Drawing.Point(3, 51);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(695, 402);
            this.AdminTabControl.TabIndex = 4;
            // 
            // furnitureTab
            // 
            this.furnitureTab.Controls.Add(this.employeeFurnitureUserControl);
            this.furnitureTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureTab.Location = new System.Drawing.Point(4, 22);
            this.furnitureTab.Name = "furnitureTab";
            this.furnitureTab.Padding = new System.Windows.Forms.Padding(3);
            this.furnitureTab.Size = new System.Drawing.Size(687, 376);
            this.furnitureTab.TabIndex = 0;
            this.furnitureTab.Text = "Furniture Search / Cart";
            this.furnitureTab.UseVisualStyleBackColor = true;
            // 
            // employeeFurnitureUserControl
            // 
            this.employeeFurnitureUserControl.Location = new System.Drawing.Point(-4, 0);
            this.employeeFurnitureUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeFurnitureUserControl.Name = "employeeFurnitureUserControl";
            this.employeeFurnitureUserControl.Size = new System.Drawing.Size(706, 380);
            this.employeeFurnitureUserControl.TabIndex = 0;
            // 
            // searchTransactions
            // 
            this.searchTransactions.Controls.Add(this.employeeRentalsUserControl2);
            this.searchTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTransactions.Location = new System.Drawing.Point(4, 22);
            this.searchTransactions.Name = "searchTransactions";
            this.searchTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.searchTransactions.Size = new System.Drawing.Size(687, 376);
            this.searchTransactions.TabIndex = 1;
            this.searchTransactions.Text = "Search Transactions";
            this.searchTransactions.UseVisualStyleBackColor = true;
            // 
            // employeeRentalsUserControl2
            // 
            this.employeeRentalsUserControl2.AutoScroll = true;
            this.employeeRentalsUserControl2.AutoSize = true;
            this.employeeRentalsUserControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.employeeRentalsUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeRentalsUserControl2.Location = new System.Drawing.Point(3, 3);
            this.employeeRentalsUserControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeRentalsUserControl2.Name = "employeeRentalsUserControl2";
            this.employeeRentalsUserControl2.Size = new System.Drawing.Size(681, 370);
            this.employeeRentalsUserControl2.TabIndex = 0;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.employeeCustomersTabUserControl);
            this.customersTab.Location = new System.Drawing.Point(4, 22);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(687, 376);
            this.customersTab.TabIndex = 2;
            this.customersTab.Text = "Members (Select | Create | Edit)";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // employeeCustomersTabUserControl
            // 
            this.employeeCustomersTabUserControl.AutoSize = true;
            this.employeeCustomersTabUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeCustomersTabUserControl.Location = new System.Drawing.Point(0, 0);
            this.employeeCustomersTabUserControl.Name = "employeeCustomersTabUserControl";
            this.employeeCustomersTabUserControl.Size = new System.Drawing.Size(687, 376);
            this.employeeCustomersTabUserControl.TabIndex = 0;
            // 
            // returnsTab
            // 
            this.returnsTab.Controls.Add(this.employeeReturnTabUserControl1);
            this.returnsTab.Location = new System.Drawing.Point(4, 22);
            this.returnsTab.Name = "returnsTab";
            this.returnsTab.Size = new System.Drawing.Size(687, 376);
            this.returnsTab.TabIndex = 3;
            this.returnsTab.Text = "Return Rented Furniture";
            this.returnsTab.UseVisualStyleBackColor = true;
            this.returnsTab.Enter += new System.EventHandler(this.Returns_Enter);
            // 
            // employeeReturnTabUserControl1
            // 
            this.employeeReturnTabUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeReturnTabUserControl1.Location = new System.Drawing.Point(0, 0);
            this.employeeReturnTabUserControl1.Name = "employeeReturnTabUserControl1";
            this.employeeReturnTabUserControl1.Size = new System.Drawing.Size(687, 376);
            this.employeeReturnTabUserControl1.TabIndex = 0;
            // 
            // rentalsTab
            // 
            this.rentalsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsTab.Location = new System.Drawing.Point(4, 22);
            this.rentalsTab.Name = "rentalsTab";
            this.rentalsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentalsTab.Size = new System.Drawing.Size(687, 376);
            this.rentalsTab.TabIndex = 1;
            this.rentalsTab.Text = "Rentals";
            this.rentalsTab.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetailsBox
            // 
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeNameValue);
            this.EmployeeDetailsBox.Controls.Add(this.logoutLabel);
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeNameLabel);
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeIDValue);
            this.EmployeeDetailsBox.Controls.Add(this.EmpployeeIDLabel);
            this.EmployeeDetailsBox.Location = new System.Drawing.Point(343, 4);
            this.EmployeeDetailsBox.Name = "EmployeeDetailsBox";
            this.EmployeeDetailsBox.Size = new System.Drawing.Size(350, 45);
            this.EmployeeDetailsBox.TabIndex = 23;
            this.EmployeeDetailsBox.TabStop = false;
            this.EmployeeDetailsBox.Text = "Employee Details: ";
            // 
            // EmployeeNameValue
            // 
            this.EmployeeNameValue.AutoSize = true;
            this.EmployeeNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameValue.ForeColor = System.Drawing.Color.Black;
            this.EmployeeNameValue.Location = new System.Drawing.Point(47, 21);
            this.EmployeeNameValue.Name = "EmployeeNameValue";
            this.EmployeeNameValue.Size = new System.Drawing.Size(16, 18);
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
            this.EmployeeIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDValue.ForeColor = System.Drawing.Color.Black;
            this.EmployeeIDValue.Location = new System.Drawing.Point(262, 19);
            this.EmployeeIDValue.Name = "EmployeeIDValue";
            this.EmployeeIDValue.Size = new System.Drawing.Size(16, 18);
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
            // EmployeeMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 446);
            this.Controls.Add(this.EmployeeDetailsBox);
            this.Controls.Add(this.AdminTabControl);
            this.MaximumSize = new System.Drawing.Size(716, 485);
            this.MinimumSize = new System.Drawing.Size(716, 485);
            this.Name = "EmployeeMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Main DashBoard:  Turning Customers Into Members is Our Priority";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeMainDashboard_FormClose);
            this.AdminTabControl.ResumeLayout(false);
            this.furnitureTab.ResumeLayout(false);
            this.searchTransactions.ResumeLayout(false);
            this.searchTransactions.PerformLayout();
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            this.returnsTab.ResumeLayout(false);
            this.EmployeeDetailsBox.ResumeLayout(false);
            this.EmployeeDetailsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage searchTransactions;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.TabPage returnsTab;
        private System.Windows.Forms.TabPage rentalsTab;
        private UserControls.EmployeeCustomersTabUserControl employeeCustomersTabUserControl;
        private AAB_Furniture_Rentals.UserControls.EmployeeFurnitureUserControl employeeFurnitureUserControl;
        private AAB_Furniture_Rentals.UserControls.EmployeeRentalsUserControl employeeRentalsUserControl2;
        private System.Windows.Forms.TabPage furnitureTab;
        private UserControls.EmployeeReturnTabUserControl employeeReturnTabUserControl1;
        private System.Windows.Forms.GroupBox EmployeeDetailsBox;
        private System.Windows.Forms.Label EmployeeNameValue;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDValue;
        private System.Windows.Forms.Label EmpployeeIDLabel;
    }
}