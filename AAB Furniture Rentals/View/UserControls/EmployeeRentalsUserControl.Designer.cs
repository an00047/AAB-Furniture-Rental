
namespace AAB_Furniture_Rentals.UserControls
{
    partial class EmployeeRentalsUserControl
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
            this.customerTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCustomerIDLabel = new System.Windows.Forms.Label();
            this.ReturnTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTransactionDataGridView
            // 
            this.customerTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnTransactionID,
            this.DateTimeReturned,
            this.FurnitureID,
            this.FurnitureStyle,
            this.FurnitureCategory,
            this.FurnitureDescription,
            this.QuantityReturned});
            this.customerTransactionDataGridView.Location = new System.Drawing.Point(105, 110);
            this.customerTransactionDataGridView.Name = "customerTransactionDataGridView";
            this.customerTransactionDataGridView.Size = new System.Drawing.Size(238, 97);
            this.customerTransactionDataGridView.TabIndex = 0;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(248, 72);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(62, 21);
            this.searchComboBox.TabIndex = 1;
            // 
            // searchCustomerIDTextBox
            // 
            this.searchCustomerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchCustomerIDTextBox.Location = new System.Drawing.Point(167, 72);
            this.searchCustomerIDTextBox.Name = "searchCustomerIDTextBox";
            this.searchCustomerIDTextBox.Size = new System.Drawing.Size(75, 20);
            this.searchCustomerIDTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.searchButton.Location = new System.Drawing.Point(316, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(60, 22);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchCustomerIDLabel
            // 
            this.searchCustomerIDLabel.AutoSize = true;
            this.searchCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.searchCustomerIDLabel.Location = new System.Drawing.Point(102, 76);
            this.searchCustomerIDLabel.Name = "searchCustomerIDLabel";
            this.searchCustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.searchCustomerIDLabel.TabIndex = 4;
            this.searchCustomerIDLabel.Text = "Customer ID";
            // 
            // ReturnTransactionID
            // 
            this.ReturnTransactionID.HeaderText = "ReturnTransactionID";
            this.ReturnTransactionID.Name = "ReturnTransactionID";
            // 
            // DateTimeReturned
            // 
            this.DateTimeReturned.HeaderText = "DateTimeReturned";
            this.DateTimeReturned.Name = "DateTimeReturned";
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "FurnitureID";
            this.FurnitureID.Name = "FurnitureID";
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.HeaderText = "FurnitureStyle";
            this.FurnitureStyle.Name = "FurnitureStyle";
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.HeaderText = "FurnitureCategory";
            this.FurnitureCategory.Name = "FurnitureCategory";
            // 
            // FurnitureDescription
            // 
            this.FurnitureDescription.HeaderText = "QuantityReturned";
            this.FurnitureDescription.Name = "FurnitureDescription";
            // 
            // QuantityReturned
            // 
            this.QuantityReturned.HeaderText = "QuantityReturned";
            this.QuantityReturned.Name = "QuantityReturned";
            // 
            // EmployeeRentalsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchCustomerIDLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchCustomerIDTextBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.customerTransactionDataGridView);
            this.Name = "EmployeeRentalsUserControl";
            this.Size = new System.Drawing.Size(499, 297);
            this.Load += new System.EventHandler(this.EmployeeRentalsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerTransactionDataGridView;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.TextBox searchCustomerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchCustomerIDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReturned;
    }
}
