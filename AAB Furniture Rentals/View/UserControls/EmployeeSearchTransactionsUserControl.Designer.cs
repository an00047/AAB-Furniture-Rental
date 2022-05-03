
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCustomerIDLabel = new System.Windows.Forms.Label();
            this._cs6232_g4DataSet1 = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.customerTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerchTransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.ReturnRB = new System.Windows.Forms.RadioButton();
            this.RentalsRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchNumric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionDataGridView)).BeginInit();
            this.SerchTransactionGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNumric)).BeginInit();
            this.SuspendLayout();
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(309, 133);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(65, 21);
            this.searchComboBox.TabIndex = 2;
            // 
            // searchCustomerIDTextBox
            // 
            this.searchCustomerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchCustomerIDTextBox.Location = new System.Drawing.Point(58, 94);
            this.searchCustomerIDTextBox.Name = "searchCustomerIDTextBox";
            this.searchCustomerIDTextBox.Size = new System.Drawing.Size(65, 20);
            this.searchCustomerIDTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.searchButton.Location = new System.Drawing.Point(152, 7);
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
            this.searchCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchCustomerIDLabel.Location = new System.Drawing.Point(7, 9);
            this.searchCustomerIDLabel.Name = "searchCustomerIDLabel";
            this.searchCustomerIDLabel.Size = new System.Drawing.Size(84, 17);
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
            this.customerTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerTransactionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.TransactionDate,
            this.FurnitureID,
            this.FurnitureStyle,
            this.FurnitureCategory,
            this.FurnitureDescription,
            this.QuantityInOut});
            this.customerTransactionDataGridView.Location = new System.Drawing.Point(3, 39);
            this.customerTransactionDataGridView.Name = "customerTransactionDataGridView";
            this.customerTransactionDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTransactionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.customerTransactionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customerTransactionDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customerTransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerTransactionDataGridView.Size = new System.Drawing.Size(450, 178);
            this.customerTransactionDataGridView.TabIndex = 4;
            // 
            // TransactionID
            // 
            this.TransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactionID.HeaderText = "Trans. ID";
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            // 
            // TransactionDate
            // 
            this.TransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactionDate.HeaderText = "Transaction Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            // 
            // FurnitureID
            // 
            this.FurnitureID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FurnitureID.HeaderText = "Furniture ID";
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FurnitureStyle.HeaderText = "Furnit. Style";
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.ReadOnly = true;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FurnitureCategory.HeaderText = "Furnit. Category";
            this.FurnitureCategory.Name = "FurnitureCategory";
            this.FurnitureCategory.ReadOnly = true;
            // 
            // FurnitureDescription
            // 
            this.FurnitureDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FurnitureDescription.HeaderText = "Furnit. Description";
            this.FurnitureDescription.Name = "FurnitureDescription";
            this.FurnitureDescription.ReadOnly = true;
            // 
            // QuantityInOut
            // 
            this.QuantityInOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityInOut.HeaderText = "Quantity (In+ | Out-)";
            this.QuantityInOut.Name = "QuantityInOut";
            this.QuantityInOut.ReadOnly = true;
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
            this.groupBox1.Controls.Add(this.SearchNumric);
            this.groupBox1.Controls.Add(this.searchCustomerIDLabel);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(245, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 30);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // SearchNumric
            // 
            this.SearchNumric.Location = new System.Drawing.Point(88, 8);
            this.SearchNumric.Name = "SearchNumric";
            this.SearchNumric.Size = new System.Drawing.Size(43, 20);
            this.SearchNumric.TabIndex = 8;
            this.SearchNumric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Size = new System.Drawing.Size(457, 224);
            this.Load += new System.EventHandler(this.EmployeeRentalsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransactionDataGridView)).EndInit();
            this.SerchTransactionGroupBox.ResumeLayout(false);
            this.SerchTransactionGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNumric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchCustomerIDLabel;
        private _cs6232_g4DataSet _cs6232_g4DataSet1;
        private System.Windows.Forms.DataGridView customerTransactionDataGridView;
        private System.Windows.Forms.GroupBox SerchTransactionGroupBox;
        private System.Windows.Forms.RadioButton ReturnRB;
        private System.Windows.Forms.RadioButton RentalsRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown SearchNumric;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInOut;
    }
}
