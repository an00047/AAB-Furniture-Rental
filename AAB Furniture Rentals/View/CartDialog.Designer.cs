
namespace AAB_Furniture_Rentals.View
{
    partial class CartDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AbandonCartButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.FurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberTextBox = new System.Windows.Forms.TextBox();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.Employeelabel = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.retunDateLabel = new System.Windows.Forms.Label();
            this.updateQtyPanel = new System.Windows.Forms.GroupBox();
            this.shortNameLabel = new System.Windows.Forms.Label();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.updateQtyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            this.updateQtyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbandonCartButton
            // 
            this.AbandonCartButton.Location = new System.Drawing.Point(19, 55);
            this.AbandonCartButton.Name = "AbandonCartButton";
            this.AbandonCartButton.Size = new System.Drawing.Size(93, 23);
            this.AbandonCartButton.TabIndex = 16;
            this.AbandonCartButton.Text = "Abandon Cart";
            this.AbandonCartButton.UseVisualStyleBackColor = true;
            this.AbandonCartButton.Click += new System.EventHandler(this.AbandonCartButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.AutoSize = true;
            this.CheckoutButton.Location = new System.Drawing.Point(19, 26);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(96, 23);
            this.CheckoutButton.TabIndex = 15;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // FurnitureDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FurnitureDataGridView.Location = new System.Drawing.Point(36, 83);
            this.FurnitureDataGridView.MultiSelect = false;
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FurnitureDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(560, 190);
            this.FurnitureDataGridView.TabIndex = 17;
            this.FurnitureDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FurnitureDataGridView_CellMouseClick);
            // 
            // MemberTextBox
            // 
            this.MemberTextBox.Location = new System.Drawing.Point(34, 54);
            this.MemberTextBox.Name = "MemberTextBox";
            this.MemberTextBox.Size = new System.Drawing.Size(93, 20);
            this.MemberTextBox.TabIndex = 14;
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Location = new System.Drawing.Point(33, 30);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(62, 13);
            this.MemberLabel.TabIndex = 13;
            this.MemberLabel.Text = "Member ID:";
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(184, 55);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(93, 20);
            this.EmployeeTextBox.TabIndex = 18;
            // 
            // Employeelabel
            // 
            this.Employeelabel.AutoSize = true;
            this.Employeelabel.Location = new System.Drawing.Point(185, 29);
            this.Employeelabel.Name = "Employeelabel";
            this.Employeelabel.Size = new System.Drawing.Size(70, 13);
            this.Employeelabel.TabIndex = 19;
            this.Employeelabel.Text = "Employee ID:";
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Location = new System.Drawing.Point(370, 54);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDateTimePicker.TabIndex = 20;
            // 
            // retunDateLabel
            // 
            this.retunDateLabel.AutoSize = true;
            this.retunDateLabel.Location = new System.Drawing.Point(367, 30);
            this.retunDateLabel.Name = "retunDateLabel";
            this.retunDateLabel.Size = new System.Drawing.Size(150, 13);
            this.retunDateLabel.TabIndex = 21;
            this.retunDateLabel.Text = "Date items are to Be Returned";
            // 
            // updateQtyPanel
            // 
            this.updateQtyPanel.Controls.Add(this.deleteItem);
            this.updateQtyPanel.Controls.Add(this.shortNameLabel);
            this.updateQtyPanel.Controls.Add(this.qtyUpDown);
            this.updateQtyPanel.Controls.Add(this.QtyLabel);
            this.updateQtyPanel.Controls.Add(this.updateQtyButton);
            this.updateQtyPanel.Enabled = false;
            this.updateQtyPanel.Location = new System.Drawing.Point(36, 288);
            this.updateQtyPanel.Name = "updateQtyPanel";
            this.updateQtyPanel.Size = new System.Drawing.Size(165, 104);
            this.updateQtyPanel.TabIndex = 22;
            this.updateQtyPanel.TabStop = false;
            this.updateQtyPanel.Text = "Selected Item";
            // 
            // shortNameLabel
            // 
            this.shortNameLabel.AutoSize = true;
            this.shortNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortNameLabel.Location = new System.Drawing.Point(6, 16);
            this.shortNameLabel.Name = "shortNameLabel";
            this.shortNameLabel.Size = new System.Drawing.Size(17, 17);
            this.shortNameLabel.TabIndex = 18;
            this.shortNameLabel.Text = "?";
            this.shortNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(77, 34);
            this.qtyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(37, 20);
            this.qtyUpDown.TabIndex = 17;
            this.qtyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Location = new System.Drawing.Point(44, 36);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(26, 13);
            this.QtyLabel.TabIndex = 16;
            this.QtyLabel.Text = "Qty:";
            // 
            // updateQtyButton
            // 
            this.updateQtyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.updateQtyButton.Location = new System.Drawing.Point(36, 57);
            this.updateQtyButton.Name = "updateQtyButton";
            this.updateQtyButton.Size = new System.Drawing.Size(93, 21);
            this.updateQtyButton.TabIndex = 2;
            this.updateQtyButton.Text = "Update Quantity";
            this.updateQtyButton.UseVisualStyleBackColor = true;
            this.updateQtyButton.Click += new System.EventHandler(this.updateQtyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckoutButton);
            this.groupBox2.Controls.Add(this.AbandonCartButton);
            this.groupBox2.Location = new System.Drawing.Point(468, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 104);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finalize Rental:";
            // 
            // deleteItem
            // 
            this.deleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.deleteItem.Location = new System.Drawing.Point(36, 83);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(93, 21);
            this.deleteItem.TabIndex = 19;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // CartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.updateQtyPanel);
            this.Controls.Add(this.retunDateLabel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.Employeelabel);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.FurnitureDataGridView);
            this.Controls.Add(this.MemberTextBox);
            this.Controls.Add(this.MemberLabel);
            this.Name = "CartDialog";
            this.Text = "Cart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CartDialog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            this.updateQtyPanel.ResumeLayout(false);
            this.updateQtyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbandonCartButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.DataGridView FurnitureDataGridView;
        private System.Windows.Forms.TextBox MemberTextBox;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.Label Employeelabel;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Label retunDateLabel;
        private System.Windows.Forms.GroupBox updateQtyPanel;
        private System.Windows.Forms.NumericUpDown qtyUpDown;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Button updateQtyButton;
        private System.Windows.Forms.Label shortNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteItem;
    }
}