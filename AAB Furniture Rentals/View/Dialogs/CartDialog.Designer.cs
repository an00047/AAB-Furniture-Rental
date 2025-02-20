﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AbandonCartButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.FurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.retunDateLabel = new System.Windows.Forms.Label();
            this.updateQtyPanel = new System.Windows.Forms.GroupBox();
            this.deleteItem = new System.Windows.Forms.Button();
            this.shortNameLabel = new System.Windows.Forms.Label();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.updateQtyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cartDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.fineRate = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.CartTotalValue = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.MemberGroupBox = new System.Windows.Forms.GroupBox();
            this.MemberNameValue = new System.Windows.Forms.LinkLabel();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.MemberIDValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            this.updateQtyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.cartDetailsGroupBox.SuspendLayout();
            this.MemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbandonCartButton
            // 
            this.AbandonCartButton.Location = new System.Drawing.Point(10, 57);
            this.AbandonCartButton.Name = "AbandonCartButton";
            this.AbandonCartButton.Size = new System.Drawing.Size(142, 23);
            this.AbandonCartButton.TabIndex = 16;
            this.AbandonCartButton.Text = "Return to Inventory";
            this.AbandonCartButton.UseVisualStyleBackColor = true;
            this.AbandonCartButton.Click += new System.EventHandler(this.AbandonCartButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.AutoSize = true;
            this.CheckoutButton.Location = new System.Drawing.Point(10, 26);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(142, 23);
            this.CheckoutButton.TabIndex = 15;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // FurnitureDataGridView
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FurnitureDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FurnitureDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.FurnitureDataGridView.Location = new System.Drawing.Point(7, 87);
            this.FurnitureDataGridView.MultiSelect = false;
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FurnitureDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.FurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(588, 195);
            this.FurnitureDataGridView.TabIndex = 17;
            this.FurnitureDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FurnitureDataGridView_CellMouseClick);
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Location = new System.Drawing.Point(8, 41);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(62, 13);
            this.MemberLabel.TabIndex = 13;
            this.MemberLabel.Text = "Member ID:";
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Location = new System.Drawing.Point(405, 61);
            this.returnDateTimePicker.MinDate = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.returnDateTimePicker.TabIndex = 20;
            this.returnDateTimePicker.ValueChanged += new System.EventHandler(this.ReturnDateTimePicker_ValueChanged);
            // 
            // retunDateLabel
            // 
            this.retunDateLabel.AutoSize = true;
            this.retunDateLabel.Location = new System.Drawing.Point(426, 44);
            this.retunDateLabel.Name = "retunDateLabel";
            this.retunDateLabel.Size = new System.Drawing.Size(153, 13);
            this.retunDateLabel.TabIndex = 21;
            this.retunDateLabel.Text = "Date items are to Be Returned:";
            // 
            // updateQtyPanel
            // 
            this.updateQtyPanel.Controls.Add(this.deleteItem);
            this.updateQtyPanel.Controls.Add(this.shortNameLabel);
            this.updateQtyPanel.Controls.Add(this.qtyUpDown);
            this.updateQtyPanel.Controls.Add(this.QtyLabel);
            this.updateQtyPanel.Controls.Add(this.updateQtyButton);
            this.updateQtyPanel.Enabled = false;
            this.updateQtyPanel.Location = new System.Drawing.Point(7, 288);
            this.updateQtyPanel.Name = "updateQtyPanel";
            this.updateQtyPanel.Size = new System.Drawing.Size(257, 100);
            this.updateQtyPanel.TabIndex = 22;
            this.updateQtyPanel.TabStop = false;
            this.updateQtyPanel.Text = "Selected Item";
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.Color.Firebrick;
            this.deleteItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.ForeColor = System.Drawing.Color.LightGray;
            this.deleteItem.Location = new System.Drawing.Point(139, 38);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(112, 46);
            this.deleteItem.TabIndex = 19;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // shortNameLabel
            // 
            this.shortNameLabel.AutoSize = true;
            this.shortNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortNameLabel.Location = new System.Drawing.Point(6, 16);
            this.shortNameLabel.Name = "shortNameLabel";
            this.shortNameLabel.Size = new System.Drawing.Size(0, 17);
            this.shortNameLabel.TabIndex = 18;
            this.shortNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(48, 38);
            this.qtyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(63, 20);
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
            this.QtyLabel.Location = new System.Drawing.Point(15, 40);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(26, 13);
            this.QtyLabel.TabIndex = 16;
            this.QtyLabel.Text = "Qty:";
            // 
            // updateQtyButton
            // 
            this.updateQtyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.updateQtyButton.Location = new System.Drawing.Point(18, 63);
            this.updateQtyButton.Name = "updateQtyButton";
            this.updateQtyButton.Size = new System.Drawing.Size(93, 21);
            this.updateQtyButton.TabIndex = 2;
            this.updateQtyButton.Text = "Update Quantity";
            this.updateQtyButton.UseVisualStyleBackColor = true;
            this.updateQtyButton.Click += new System.EventHandler(this.UpdateQtyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckoutButton);
            this.groupBox2.Controls.Add(this.AbandonCartButton);
            this.groupBox2.Location = new System.Drawing.Point(438, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finalize Rental:";
            // 
            // cartDetailsGroupBox
            // 
            this.cartDetailsGroupBox.Controls.Add(this.fineRate);
            this.cartDetailsGroupBox.Controls.Add(this.feeLabel);
            this.cartDetailsGroupBox.Controls.Add(this.CartTotalValue);
            this.cartDetailsGroupBox.Controls.Add(this.totalLabel);
            this.cartDetailsGroupBox.Location = new System.Drawing.Point(270, 288);
            this.cartDetailsGroupBox.Name = "cartDetailsGroupBox";
            this.cartDetailsGroupBox.Size = new System.Drawing.Size(162, 100);
            this.cartDetailsGroupBox.TabIndex = 24;
            this.cartDetailsGroupBox.TabStop = false;
            this.cartDetailsGroupBox.Text = "Cart Details";
            // 
            // fineRate
            // 
            this.fineRate.AutoSize = true;
            this.fineRate.Location = new System.Drawing.Point(120, 42);
            this.fineRate.Name = "fineRate";
            this.fineRate.Size = new System.Drawing.Size(13, 13);
            this.fineRate.TabIndex = 3;
            this.fineRate.Text = "?";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLabel.Location = new System.Drawing.Point(18, 41);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(98, 13);
            this.feeLabel.TabIndex = 2;
            this.feeLabel.Text = "Daily Fine Rate:";
            // 
            // CartTotalValue
            // 
            this.CartTotalValue.AutoSize = true;
            this.CartTotalValue.Location = new System.Drawing.Point(120, 20);
            this.CartTotalValue.Name = "CartTotalValue";
            this.CartTotalValue.Size = new System.Drawing.Size(13, 13);
            this.CartTotalValue.TabIndex = 1;
            this.CartTotalValue.Text = "?";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(36, 20);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(67, 13);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Cart Total:";
            // 
            // MemberGroupBox
            // 
            this.MemberGroupBox.Controls.Add(this.MemberNameValue);
            this.MemberGroupBox.Controls.Add(this.MemberNameLabel);
            this.MemberGroupBox.Controls.Add(this.MemberIDValue);
            this.MemberGroupBox.Controls.Add(this.MemberLabel);
            this.MemberGroupBox.Location = new System.Drawing.Point(7, 12);
            this.MemberGroupBox.Name = "MemberGroupBox";
            this.MemberGroupBox.Size = new System.Drawing.Size(180, 64);
            this.MemberGroupBox.TabIndex = 26;
            this.MemberGroupBox.TabStop = false;
            this.MemberGroupBox.Text = "Member Information:";
            // 
            // MemberNameValue
            // 
            this.MemberNameValue.AutoSize = true;
            this.MemberNameValue.Location = new System.Drawing.Point(79, 20);
            this.MemberNameValue.Name = "MemberNameValue";
            this.MemberNameValue.Size = new System.Drawing.Size(55, 13);
            this.MemberNameValue.TabIndex = 17;
            this.MemberNameValue.TabStop = true;
            this.MemberNameValue.Text = "linkLabel1";
            this.MemberNameValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MemberNameValue_LinkClicked);
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Location = new System.Drawing.Point(8, 21);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(41, 13);
            this.MemberNameLabel.TabIndex = 15;
            this.MemberNameLabel.Text = "Name: ";
            // 
            // MemberIDValue
            // 
            this.MemberIDValue.AutoSize = true;
            this.MemberIDValue.Location = new System.Drawing.Point(76, 41);
            this.MemberIDValue.Name = "MemberIDValue";
            this.MemberIDValue.Size = new System.Drawing.Size(13, 13);
            this.MemberIDValue.TabIndex = 14;
            this.MemberIDValue.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(217, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "*Select Line Items of Interest";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberGroupBox);
            this.Controls.Add(this.cartDetailsGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.updateQtyPanel);
            this.Controls.Add(this.retunDateLabel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.FurnitureDataGridView);
            this.Name = "CartDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            this.updateQtyPanel.ResumeLayout(false);
            this.updateQtyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cartDetailsGroupBox.ResumeLayout(false);
            this.cartDetailsGroupBox.PerformLayout();
            this.MemberGroupBox.ResumeLayout(false);
            this.MemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbandonCartButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.DataGridView FurnitureDataGridView;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Label retunDateLabel;
        private System.Windows.Forms.GroupBox updateQtyPanel;
        private System.Windows.Forms.NumericUpDown qtyUpDown;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Button updateQtyButton;
        private System.Windows.Forms.Label shortNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.GroupBox cartDetailsGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label fineRate;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label CartTotalValue;
        private System.Windows.Forms.GroupBox MemberGroupBox;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label MemberIDValue;
        private System.Windows.Forms.LinkLabel MemberNameValue;
        private System.Windows.Forms.Label label1;
    }
}