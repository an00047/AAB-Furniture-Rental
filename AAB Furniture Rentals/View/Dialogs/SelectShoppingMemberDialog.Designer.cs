
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
            this.closeFromButton = new System.Windows.Forms.Button();
            this.employeeCustomersTabUserControl1 = new AAB_Furniture_Rentals.View.UserControls.EmployeeCustomersTabUserControl();
            this.SuspendLayout();
            // 
            // closeFromButton
            // 
            this.closeFromButton.Location = new System.Drawing.Point(530, 361);
            this.closeFromButton.Name = "closeFromButton";
            this.closeFromButton.Size = new System.Drawing.Size(106, 33);
            this.closeFromButton.TabIndex = 1;
            this.closeFromButton.Text = "Close ";
            this.closeFromButton.UseVisualStyleBackColor = true;
            this.closeFromButton.Click += new System.EventHandler(this.closeFromButton_Click);
            // 
            // employeeCustomersTabUserControl1
            // 
            this.employeeCustomersTabUserControl1.Location = new System.Drawing.Point(5, 12);
            this.employeeCustomersTabUserControl1.Name = "employeeCustomersTabUserControl1";
            this.employeeCustomersTabUserControl1.Size = new System.Drawing.Size(673, 359);
            this.employeeCustomersTabUserControl1.TabIndex = 0;
            // 
            // SelectShoppingMemberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 402);
            this.Controls.Add(this.closeFromButton);
            this.Controls.Add(this.employeeCustomersTabUserControl1);
            this.Name = "SelectShoppingMemberDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Shopping Member";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.EmployeeCustomersTabUserControl employeeCustomersTabUserControl1;
        private System.Windows.Forms.Button closeFromButton;
    }
}