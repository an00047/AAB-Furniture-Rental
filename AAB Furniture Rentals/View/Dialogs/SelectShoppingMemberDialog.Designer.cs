
namespace AAB_Furniture_Rentals.View.Dialogs
{
    partial class SelectShoppingMemberDialog
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
            this.employeeCustomersTabUserControl1 = new AAB_Furniture_Rentals.View.UserControls.EmployeeCustomersTabUserControl();
            this.SuspendLayout();
            // 
            // employeeCustomersTabUserControl1
            // 
            this.employeeCustomersTabUserControl1.Location = new System.Drawing.Point(7, 12);
            this.employeeCustomersTabUserControl1.Name = "employeeCustomersTabUserControl1";
            this.employeeCustomersTabUserControl1.Size = new System.Drawing.Size(426, 314);
            this.employeeCustomersTabUserControl1.TabIndex = 0;
            // 
            // SelectShoppingMemberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.employeeCustomersTabUserControl1);
            this.Name = "SelectShoppingMemberDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectShoppingMemberDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.EmployeeCustomersTabUserControl employeeCustomersTabUserControl1;
    }
}