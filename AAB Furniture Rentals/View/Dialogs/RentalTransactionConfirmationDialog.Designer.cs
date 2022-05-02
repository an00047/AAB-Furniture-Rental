
namespace AAB_Furniture_Rentals.View.Dialogs
{
    partial class RentalTransactionConfirmationDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.customerDetailsBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumValue = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.MemberNameValue = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.MemberIDValue = new System.Windows.Forms.Label();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReturnDateValue = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.DailyFineRate = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.CartTotalValue = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TransactionFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.CloseConfirmationPage = new System.Windows.Forms.Button();
            this.TransactionIDLabel = new System.Windows.Forms.Label();
            this.TransactionIDValue = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeDetailsBox = new System.Windows.Forms.GroupBox();
            this.EmployeeNameValue = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDValue = new System.Windows.Forms.Label();
            this.EmpployeeIDLabel = new System.Windows.Forms.Label();
            this.customerDetailsBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionFurnitureDataGridView)).BeginInit();
            this.EmployeeDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDetailsBox
            // 
            this.customerDetailsBox.Controls.Add(this.PhoneNumValue);
            this.customerDetailsBox.Controls.Add(this.PhoneNumLabel);
            this.customerDetailsBox.Controls.Add(this.MemberNameValue);
            this.customerDetailsBox.Controls.Add(this.MemberNameLabel);
            this.customerDetailsBox.Controls.Add(this.MemberIDValue);
            this.customerDetailsBox.Controls.Add(this.MemberLabel);
            this.customerDetailsBox.Location = new System.Drawing.Point(12, 52);
            this.customerDetailsBox.Name = "customerDetailsBox";
            this.customerDetailsBox.Size = new System.Drawing.Size(178, 81);
            this.customerDetailsBox.TabIndex = 0;
            this.customerDetailsBox.TabStop = false;
            this.customerDetailsBox.Text = "Customer Details: ";
            // 
            // PhoneNumValue
            // 
            this.PhoneNumValue.AutoSize = true;
            this.PhoneNumValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PhoneNumValue.Location = new System.Drawing.Point(48, 59);
            this.PhoneNumValue.Name = "PhoneNumValue";
            this.PhoneNumValue.Size = new System.Drawing.Size(18, 16);
            this.PhoneNumValue.TabIndex = 21;
            this.PhoneNumValue.Text = "?";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(8, 60);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(44, 13);
            this.PhoneNumLabel.TabIndex = 20;
            this.PhoneNumLabel.Text = "Phone: ";
            // 
            // MemberNameValue
            // 
            this.MemberNameValue.AutoSize = true;
            this.MemberNameValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemberNameValue.Location = new System.Drawing.Point(49, 19);
            this.MemberNameValue.Name = "MemberNameValue";
            this.MemberNameValue.Size = new System.Drawing.Size(18, 16);
            this.MemberNameValue.TabIndex = 19;
            this.MemberNameValue.Text = "?";
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Location = new System.Drawing.Point(6, 19);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(41, 13);
            this.MemberNameLabel.TabIndex = 18;
            this.MemberNameLabel.Text = "Name: ";
            // 
            // MemberIDValue
            // 
            this.MemberIDValue.AutoSize = true;
            this.MemberIDValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemberIDValue.Location = new System.Drawing.Point(70, 40);
            this.MemberIDValue.Name = "MemberIDValue";
            this.MemberIDValue.Size = new System.Drawing.Size(18, 16);
            this.MemberIDValue.TabIndex = 17;
            this.MemberIDValue.Text = "?";
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Location = new System.Drawing.Point(6, 39);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(62, 13);
            this.MemberLabel.TabIndex = 16;
            this.MemberLabel.Text = "Member ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReturnDateValue);
            this.groupBox2.Controls.Add(this.ReturnDateLabel);
            this.groupBox2.Controls.Add(this.DailyFineRate);
            this.groupBox2.Controls.Add(this.feeLabel);
            this.groupBox2.Controls.Add(this.CartTotalValue);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Details: ";
            // 
            // ReturnDateValue
            // 
            this.ReturnDateValue.AutoSize = true;
            this.ReturnDateValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReturnDateValue.Location = new System.Drawing.Point(147, 68);
            this.ReturnDateValue.Name = "ReturnDateValue";
            this.ReturnDateValue.Size = new System.Drawing.Size(18, 16);
            this.ReturnDateValue.TabIndex = 9;
            this.ReturnDateValue.Text = "?";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateLabel.Location = new System.Drawing.Point(12, 68);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(138, 13);
            this.ReturnDateLabel.TabIndex = 8;
            this.ReturnDateLabel.Text = "Scheduled to be Returned: ";
            // 
            // DailyFineRate
            // 
            this.DailyFineRate.AutoSize = true;
            this.DailyFineRate.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyFineRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DailyFineRate.Location = new System.Drawing.Point(95, 42);
            this.DailyFineRate.Name = "DailyFineRate";
            this.DailyFineRate.Size = new System.Drawing.Size(18, 16);
            this.DailyFineRate.TabIndex = 7;
            this.DailyFineRate.Text = "?";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLabel.Location = new System.Drawing.Point(12, 43);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(82, 13);
            this.feeLabel.TabIndex = 6;
            this.feeLabel.Text = "Daily Fine Rate:";
            // 
            // CartTotalValue
            // 
            this.CartTotalValue.AutoSize = true;
            this.CartTotalValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CartTotalValue.Location = new System.Drawing.Point(96, 19);
            this.CartTotalValue.Name = "CartTotalValue";
            this.CartTotalValue.Size = new System.Drawing.Size(18, 16);
            this.CartTotalValue.TabIndex = 5;
            this.CartTotalValue.Text = "?";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(35, 18);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Cart Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TransactionFurnitureDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 322);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rentals Information: ";
            // 
            // TransactionFurnitureDataGridView
            // 
            this.TransactionFurnitureDataGridView.AllowUserToAddRows = false;
            this.TransactionFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.TransactionFurnitureDataGridView.AllowUserToResizeColumns = false;
            this.TransactionFurnitureDataGridView.AllowUserToResizeRows = false;
            this.TransactionFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionFurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TransactionFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.QtyRented});
            this.TransactionFurnitureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionFurnitureDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionFurnitureDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TransactionFurnitureDataGridView.Location = new System.Drawing.Point(3, 16);
            this.TransactionFurnitureDataGridView.Name = "TransactionFurnitureDataGridView";
            this.TransactionFurnitureDataGridView.ReadOnly = true;
            this.TransactionFurnitureDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TransactionFurnitureDataGridView.RowTemplate.ReadOnly = true;
            this.TransactionFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionFurnitureDataGridView.Size = new System.Drawing.Size(345, 303);
            this.TransactionFurnitureDataGridView.TabIndex = 0;
            // 
            // CloseConfirmationPage
            // 
            this.CloseConfirmationPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CloseConfirmationPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseConfirmationPage.Location = new System.Drawing.Point(50, 581);
            this.CloseConfirmationPage.Name = "CloseConfirmationPage";
            this.CloseConfirmationPage.Size = new System.Drawing.Size(255, 45);
            this.CloseConfirmationPage.TabIndex = 0;
            this.CloseConfirmationPage.Text = "Close Confirmation Screen";
            this.CloseConfirmationPage.UseVisualStyleBackColor = false;
            this.CloseConfirmationPage.Click += new System.EventHandler(this.CloseConfirmationPage_Click);
            // 
            // TransactionIDLabel
            // 
            this.TransactionIDLabel.AutoSize = true;
            this.TransactionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDLabel.ForeColor = System.Drawing.Color.Black;
            this.TransactionIDLabel.Location = new System.Drawing.Point(94, 8);
            this.TransactionIDLabel.Name = "TransactionIDLabel";
            this.TransactionIDLabel.Size = new System.Drawing.Size(156, 24);
            this.TransactionIDLabel.TabIndex = 2;
            this.TransactionIDLabel.Text = "Transaction ID: ";
            // 
            // TransactionIDValue
            // 
            this.TransactionIDValue.AutoSize = true;
            this.TransactionIDValue.Font = new System.Drawing.Font("ModeNine", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TransactionIDValue.Location = new System.Drawing.Point(246, 10);
            this.TransactionIDValue.Name = "TransactionIDValue";
            this.TransactionIDValue.Size = new System.Drawing.Size(23, 22);
            this.TransactionIDValue.TabIndex = 3;
            this.TransactionIDValue.Text = "?";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Furniture ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.HeaderText = "Furniture Category";
            this.FurnitureCategory.Name = "FurnitureCategory";
            this.FurnitureCategory.ReadOnly = true;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.HeaderText = "Furniture Style";
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.ReadOnly = true;
            // 
            // QtyRented
            // 
            this.QtyRented.HeaderText = "Qty. Rented";
            this.QtyRented.Name = "QtyRented";
            this.QtyRented.ReadOnly = true;
            // 
            // EmployeeDetailsBox
            // 
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeNameValue);
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeNameLabel);
            this.EmployeeDetailsBox.Controls.Add(this.EmployeeIDValue);
            this.EmployeeDetailsBox.Controls.Add(this.EmpployeeIDLabel);
            this.EmployeeDetailsBox.Location = new System.Drawing.Point(196, 52);
            this.EmployeeDetailsBox.Name = "EmployeeDetailsBox";
            this.EmployeeDetailsBox.Size = new System.Drawing.Size(167, 81);
            this.EmployeeDetailsBox.TabIndex = 22;
            this.EmployeeDetailsBox.TabStop = false;
            this.EmployeeDetailsBox.Text = "Employee Details: ";
            // 
            // EmployeeNameValue
            // 
            this.EmployeeNameValue.AutoSize = true;
            this.EmployeeNameValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmployeeNameValue.Location = new System.Drawing.Point(44, 19);
            this.EmployeeNameValue.Name = "EmployeeNameValue";
            this.EmployeeNameValue.Size = new System.Drawing.Size(18, 16);
            this.EmployeeNameValue.TabIndex = 19;
            this.EmployeeNameValue.Text = "?";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(6, 19);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(41, 13);
            this.EmployeeNameLabel.TabIndex = 18;
            this.EmployeeNameLabel.Text = "Name: ";
            // 
            // EmployeeIDValue
            // 
            this.EmployeeIDValue.AutoSize = true;
            this.EmployeeIDValue.Font = new System.Drawing.Font("ModeNine", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmployeeIDValue.Location = new System.Drawing.Point(74, 39);
            this.EmployeeIDValue.Name = "EmployeeIDValue";
            this.EmployeeIDValue.Size = new System.Drawing.Size(18, 16);
            this.EmployeeIDValue.TabIndex = 17;
            this.EmployeeIDValue.Text = "?";
            // 
            // EmpployeeIDLabel
            // 
            this.EmpployeeIDLabel.AutoSize = true;
            this.EmpployeeIDLabel.Location = new System.Drawing.Point(6, 40);
            this.EmpployeeIDLabel.Name = "EmpployeeIDLabel";
            this.EmpployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmpployeeIDLabel.TabIndex = 16;
            this.EmpployeeIDLabel.Text = "Employee ID:";
            // 
            // RentalTransactionConfirmationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 638);
            this.Controls.Add(this.EmployeeDetailsBox);
            this.Controls.Add(this.TransactionIDValue);
            this.Controls.Add(this.TransactionIDLabel);
            this.Controls.Add(this.CloseConfirmationPage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.customerDetailsBox);
            this.Name = "RentalTransactionConfirmationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Confirmation";
            this.customerDetailsBox.ResumeLayout(false);
            this.customerDetailsBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionFurnitureDataGridView)).EndInit();
            this.EmployeeDetailsBox.ResumeLayout(false);
            this.EmployeeDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox customerDetailsBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CloseConfirmationPage;
        private System.Windows.Forms.DataGridView TransactionFurnitureDataGridView;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label MemberIDValue;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.Label DailyFineRate;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label CartTotalValue;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label MemberNameValue;
        private System.Windows.Forms.Label ReturnDateValue;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label TransactionIDLabel;
        private System.Windows.Forms.Label TransactionIDValue;
        private System.Windows.Forms.Label PhoneNumValue;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRented;
        private System.Windows.Forms.GroupBox EmployeeDetailsBox;
        private System.Windows.Forms.Label EmployeeNameValue;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDValue;
        private System.Windows.Forms.Label EmpployeeIDLabel;
    }
}