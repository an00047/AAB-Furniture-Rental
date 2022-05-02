
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
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCustomerIDLabel = new System.Windows.Forms.Label();
            this._cs6232_g4DataSet1 = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.customerTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerchTransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.ReturnRB = new System.Windows.Forms.RadioButton();
            this.RentalsRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionDataGridView)).BeginInit();
            this.SerchTransactionGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(309, 133);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(65, 21);
            this.searchComboBox.TabIndex = 1;
            // 
            // searchCustomerIDTextBox
            // 
            this.searchCustomerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchCustomerIDTextBox.Location = new System.Drawing.Point(73, 7);
            this.searchCustomerIDTextBox.Name = "searchCustomerIDTextBox";
            this.searchCustomerIDTextBox.Size = new System.Drawing.Size(56, 20);
            this.searchCustomerIDTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.searchButton.Location = new System.Drawing.Point(132, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 20);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchCustomerIDLabel
            // 
            this.searchCustomerIDLabel.AutoSize = true;
            this.searchCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.searchCustomerIDLabel.Location = new System.Drawing.Point(2, 10);
            this.searchCustomerIDLabel.Name = "searchCustomerIDLabel";
            this.searchCustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.searchCustomerIDLabel.TabIndex = 4;
            this.searchCustomerIDLabel.Text = "Member ID: ";
            // 
            // _cs6232_g4DataSet1
            // 
            this._cs6232_g4DataSet1.DataSetName = "_cs6232_g4DataSet";
            this._cs6232_g4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTransactionDataGridView
            // 
            this.customerTransactionDataGridView.AllowUserToAddRows = false;
            this.customerTransactionDataGridView.AllowUserToDeleteRows = false;
            this.customerTransactionDataGridView.AllowUserToResizeColumns = false;
            this.customerTransactionDataGridView.AllowUserToResizeRows = false;
            this.customerTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerTransactionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.FurnitureID,
            this.FurnitureStyle,
            this.Column1,
            this.FurnitureCategory,
            this.FurnitureDescription,
            this.TransactionDate,
            this.QuantityInOut});
            this.customerTransactionDataGridView.Location = new System.Drawing.Point(3, 39);
            this.customerTransactionDataGridView.Name = "customerTransactionDataGridView";
            this.customerTransactionDataGridView.ReadOnly = true;
            this.customerTransactionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.customerTransactionDataGridView.Size = new System.Drawing.Size(450, 192);
            this.customerTransactionDataGridView.TabIndex = 5;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "TransactionID";
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.Width = 99;
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "FurnitureID";
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            this.FurnitureID.Width = 84;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.HeaderText = "FurnitureStyle";
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.ReadOnly = true;
            this.FurnitureStyle.Width = 96;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.HeaderText = "FurnitureCategory";
            this.FurnitureCategory.Name = "FurnitureCategory";
            this.FurnitureCategory.ReadOnly = true;
            this.FurnitureCategory.Width = 115;
            // 
            // FurnitureDescription
            // 
            this.FurnitureDescription.HeaderText = "FurnitureDescription";
            this.FurnitureDescription.Name = "FurnitureDescription";
            this.FurnitureDescription.ReadOnly = true;
            this.FurnitureDescription.Width = 126;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "TransactionDate";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 111;
            // 
            // QuantityInOut
            // 
            this.QuantityInOut.HeaderText = "QuantityIn/Out";
            this.QuantityInOut.Name = "QuantityInOut";
            this.QuantityInOut.ReadOnly = true;
            this.QuantityInOut.Width = 102;
            // 
            // SerchTransactionGroupBox
            // 
            this.SerchTransactionGroupBox.Controls.Add(this.ReturnRB);
            this.SerchTransactionGroupBox.Controls.Add(this.RentalsRB);
            this.SerchTransactionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SerchTransactionGroupBox.Name = "SerchTransactionGroupBox";
            this.SerchTransactionGroupBox.Size = new System.Drawing.Size(167, 30);
            this.SerchTransactionGroupBox.TabIndex = 6;
            this.SerchTransactionGroupBox.TabStop = false;
            this.SerchTransactionGroupBox.Text = "Transaction Type:";
            // 
            // ReturnRB
            // 
            this.ReturnRB.AutoSize = true;
            this.ReturnRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnRB.Location = new System.Drawing.Point(95, 12);
            this.ReturnRB.Name = "ReturnRB";
            this.ReturnRB.Size = new System.Drawing.Size(73, 21);
            this.ReturnRB.TabIndex = 6;
            this.ReturnRB.TabStop = true;
            this.ReturnRB.Text = "Return ";
            this.ReturnRB.UseVisualStyleBackColor = true;
            // 
            // RentalsRB
            // 
            this.RentalsRB.AutoSize = true;
            this.RentalsRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalsRB.Location = new System.Drawing.Point(22, 13);
            this.RentalsRB.Name = "RentalsRB";
            this.RentalsRB.Size = new System.Drawing.Size(71, 21);
            this.RentalsRB.TabIndex = 5;
            this.RentalsRB.TabStop = true;
            this.RentalsRB.Text = "Rental ";
            this.RentalsRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchCustomerIDLabel);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchCustomerIDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(265, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 30);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // EmployeeRentalsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SerchTransactionGroupBox);
            this.Controls.Add(this.customerTransactionDataGridView);
            this.Controls.Add(this.searchComboBox);
            this.Name = "EmployeeRentalsUserControl";
            this.Size = new System.Drawing.Size(460, 231);
            this.Load += new System.EventHandler(this.EmployeeRentalsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionDataGridView)).EndInit();
            this.SerchTransactionGroupBox.ResumeLayout(false);
            this.SerchTransactionGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.TextBox searchCustomerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchCustomerIDLabel;
        private _cs6232_g4DataSet _cs6232_g4DataSet1;
        private System.Windows.Forms.DataGridView customerTransactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInOut;
        private System.Windows.Forms.GroupBox SerchTransactionGroupBox;
        private System.Windows.Forms.RadioButton ReturnRB;
        private System.Windows.Forms.RadioButton RentalsRB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
