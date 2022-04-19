
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.furnitureTab = new System.Windows.Forms.TabPage();
            this.searchTransactions = new System.Windows.Forms.TabPage();
            this.employeeRentalsUserControl2 = new AAB_Furniture_Rentals.UserControls.EmployeeRentalsUserControl();
            this.employeeFurnitureUserControl = new AAB_Furniture_Rentals.UserControls.EmployeeFurnitureUserControl();
            this.rentalsTab = new System.Windows.Forms.TabPage();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.employeeCustomersTabUserControl = new AAB_Furniture_Rentals.View.UserControls.EmployeeCustomersTabUserControl();
            this.returnsTab = new System.Windows.Forms.TabPage();
            
            this.employeeFurnitureUserControl1 = new AAB_Furniture_Rentals.UserControls.EmployeeFurnitureUserControl();
            this.employeeReturnTabUserControl1 = new AAB_Furniture_Rentals.View.UserControls.EmployeeReturnTabUserControl();
            this.AdminTabControl.SuspendLayout();
            this.furnitureTab.SuspendLayout();
            this.searchTransactions.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.returnsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutLabel.Location = new System.Drawing.Point(476, 41);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLabel.TabIndex = 5;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(700, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.furnitureTab);
            this.AdminTabControl.Controls.Add(this.searchTransactions);
            this.AdminTabControl.Controls.Add(this.customersTab);
            this.AdminTabControl.Controls.Add(this.returnsTab);
            this.AdminTabControl.Location = new System.Drawing.Point(1, 89);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(695, 402);
            this.AdminTabControl.TabIndex = 3;
            // 
            // furnitureTab
            // 
            this.furnitureTab.Controls.Add(this.employeeFurnitureUserControl1);
            this.furnitureTab.Controls.Add(this.employeeFurnitureUserControl);
            this.furnitureTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureTab.Location = new System.Drawing.Point(4, 22);
            this.furnitureTab.Name = "furnitureTab";
            this.furnitureTab.Padding = new System.Windows.Forms.Padding(3);
            this.furnitureTab.Size = new System.Drawing.Size(687, 376);
            this.furnitureTab.TabIndex = 0;
            this.furnitureTab.Text = "Furniture";
            this.furnitureTab.UseVisualStyleBackColor = true;
            // 
            // employeeFurnitureUserControl
            // 
            this.employeeFurnitureUserControl.Location = new System.Drawing.Point(-20, 8);
            this.employeeFurnitureUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeFurnitureUserControl.Name = "employeeFurnitureUserControl";
            this.employeeFurnitureUserControl.Size = new System.Drawing.Size(707, 380);
            this.employeeFurnitureUserControl.TabIndex = 0;
           
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
            // searchTransactions
            //

            this.searchTransactions.Controls.Add(this.employeeRentalsUserControl2);
            this.searchTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTransactions.Location = new System.Drawing.Point(4, 22);
            this.searchTransactions.Name = "searchTransactions";
            this.searchTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.searchTransactions.Size = new System.Drawing.Size(526, 329);
            this.searchTransactions.TabIndex = 1;
            this.searchTransactions.Text = "Rentals";
            this.searchTransactions.UseVisualStyleBackColor = true;
            // 
            // employeeRentalsUserControl2
            // 
            this.employeeRentalsUserControl2.Location = new System.Drawing.Point(-89, -57);
            this.employeeRentalsUserControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeRentalsUserControl2.Name = "employeeRentalsUserControl2";
            this.employeeRentalsUserControl2.Size = new System.Drawing.Size(646, 450);
            this.employeeRentalsUserControl2.TabIndex = 0;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.employeeCustomersTabUserControl);
            this.customersTab.Location = new System.Drawing.Point(4, 22);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(687, 376);
            this.customersTab.TabIndex = 2;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // employeeCustomersTabUserControl
            // 
            this.employeeCustomersTabUserControl.Location = new System.Drawing.Point(62, 30);
            this.employeeCustomersTabUserControl.Name = "employeeCustomersTabUserControl";
            this.employeeCustomersTabUserControl.Size = new System.Drawing.Size(413, 314);
            this.employeeCustomersTabUserControl.TabIndex = 0;
            // 
            // returnsTab
            // 
            this.returnsTab.Controls.Add(this.employeeReturnTabUserControl1);
            this.returnsTab.Location = new System.Drawing.Point(4, 22);
            this.returnsTab.Name = "returnsTab";
            this.returnsTab.Size = new System.Drawing.Size(526, 329);
            this.returnsTab.TabIndex = 3;
            this.returnsTab.Text = "Returns";
            this.returnsTab.UseVisualStyleBackColor = true;
            // 
            // cartButton
            // 
               // this.cartButton.AutoSize = true;
            //this.cartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cartButton.Location = new System.Drawing.Point(460, 64);
            //this.cartButton.Name = "cartButton";
            //this.cartButton.Size = new System.Drawing.Size(75, 30);
            //this.cartButton.TabIndex = 6;
            //this.cartButton.Text = "Cart";
            //this.cartButton.UseVisualStyleBackColor = true;
            // 
            // employeeFurnitureUserControl1
            // 
            this.employeeFurnitureUserControl1.Location = new System.Drawing.Point(-386, -120);
            this.employeeFurnitureUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeFurnitureUserControl1.Name = "employeeFurnitureUserControl1";
            this.employeeFurnitureUserControl1.Size = new System.Drawing.Size(1051, 419);
            this.employeeFurnitureUserControl1.TabIndex = 0;
            // 
            // employeeReturnTabUserControl1
            // 
            this.employeeReturnTabUserControl1.Location = new System.Drawing.Point(89, 34);
            this.employeeReturnTabUserControl1.Name = "employeeReturnTabUserControl1";
            this.employeeReturnTabUserControl1.Size = new System.Drawing.Size(330, 268);
            this.employeeReturnTabUserControl1.TabIndex = 0;
            // 
            // EmployeeMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 491);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.AdminTabControl);
            this.Name = "EmployeeMainDashboard";
            this.Text = "EmployeeMainDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeMainDashboard_FormClose);
            this.AdminTabControl.ResumeLayout(false);
            this.furnitureTab.ResumeLayout(false);
            this.searchTransactions.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
            this.returnsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage searchTransactions;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.TabPage returnsTab;
        private UserControls.EmployeeCustomersTabUserControl employeeCustomersTabUserControl;
        private AAB_Furniture_Rentals.UserControls.EmployeeFurnitureUserControl employeeFurnitureUserControl;
        private AAB_Furniture_Rentals.UserControls.EmployeeRentalsUserControl employeeRentalsUserControl2;
        private System.Windows.Forms.TabPage furnitureTab;
        private AAB_Furniture_Rentals.UserControls.EmployeeFurnitureUserControl employeeFurnitureUserControl1;
        private UserControls.EmployeeReturnTabUserControl employeeReturnTabUserControl1;
    }
}