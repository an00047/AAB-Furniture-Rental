
namespace AAB_Furniture_Rentals.View.UserControls
{
    partial class EmployeeCustomersTabUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerListView = new System.Windows.Forms.ListView();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(54, 13);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Customer:";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(114, 10);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(97, 20);
            this.customerTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(233, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // customerListView
            // 
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(28, 48);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(309, 111);
            this.customerListView.TabIndex = 3;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(140, 176);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(93, 23);
            this.newCustomerButton.TabIndex = 4;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(239, 176);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(85, 23);
            this.addCustomerButton.TabIndex = 5;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeCustomersTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.customerLabel);
            this.Name = "EmployeeCustomersTabUserControl";
            this.Size = new System.Drawing.Size(370, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
    }
}
