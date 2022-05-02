
namespace AAB_Furniture_Rentals.View.UserControls
{
    partial class EmployeeReturnTabUserControl
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.itemsReturnedLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.refundsLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.feesTextBox = new System.Windows.Forms.TextBox();
            this.refundTextBox = new System.Windows.Forms.TextBox();
            this.processReturnButton = new System.Windows.Forms.Button();
            this.itemsReturnedCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.getTransactionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(24, 30);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(68, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Customer ID:";
            // 
            // itemsReturnedLabel
            // 
            this.itemsReturnedLabel.AutoSize = true;
            this.itemsReturnedLabel.Location = new System.Drawing.Point(24, 73);
            this.itemsReturnedLabel.Name = "itemsReturnedLabel";
            this.itemsReturnedLabel.Size = new System.Drawing.Size(82, 13);
            this.itemsReturnedLabel.TabIndex = 1;
            this.itemsReturnedLabel.Text = "Items Returned:";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Location = new System.Drawing.Point(24, 153);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(33, 13);
            this.feesLabel.TabIndex = 2;
            this.feesLabel.Text = "Fees:";
            // 
            // refundsLabel
            // 
            this.refundsLabel.AutoSize = true;
            this.refundsLabel.Location = new System.Drawing.Point(24, 182);
            this.refundsLabel.Name = "refundsLabel";
            this.refundsLabel.Size = new System.Drawing.Size(50, 13);
            this.refundsLabel.TabIndex = 3;
            this.refundsLabel.Text = "Refunds:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(125, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(171, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // feesTextBox
            // 
            this.feesTextBox.Location = new System.Drawing.Point(125, 153);
            this.feesTextBox.Name = "feesTextBox";
            this.feesTextBox.Size = new System.Drawing.Size(171, 20);
            this.feesTextBox.TabIndex = 4;
            // 
            // refundTextBox
            // 
            this.refundTextBox.Location = new System.Drawing.Point(125, 179);
            this.refundTextBox.Name = "refundTextBox";
            this.refundTextBox.Size = new System.Drawing.Size(171, 20);
            this.refundTextBox.TabIndex = 5;
            // 
            // processReturnButton
            // 
            this.processReturnButton.Location = new System.Drawing.Point(210, 204);
            this.processReturnButton.Name = "processReturnButton";
            this.processReturnButton.Size = new System.Drawing.Size(86, 23);
            this.processReturnButton.TabIndex = 6;
            this.processReturnButton.Text = "Process Return";
            this.processReturnButton.UseVisualStyleBackColor = true;
            this.processReturnButton.Click += new System.EventHandler(this.ProcessReturnButton_Click);
            // 
            // itemsReturnedCheckedListBox
            // 
            this.itemsReturnedCheckedListBox.FormattingEnabled = true;
            this.itemsReturnedCheckedListBox.Location = new System.Drawing.Point(125, 73);
            this.itemsReturnedCheckedListBox.Name = "itemsReturnedCheckedListBox";
            this.itemsReturnedCheckedListBox.Size = new System.Drawing.Size(318, 64);
            this.itemsReturnedCheckedListBox.TabIndex = 3;
            this.itemsReturnedCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemsReturned_Selected);
            // 
            // getTransactionsButton
            // 
            this.getTransactionsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.getTransactionsButton.Location = new System.Drawing.Point(257, 44);
            this.getTransactionsButton.Name = "getTransactionsButton";
            this.getTransactionsButton.Size = new System.Drawing.Size(39, 23);
            this.getTransactionsButton.TabIndex = 2;
            this.getTransactionsButton.Text = "Get";
            this.getTransactionsButton.UseVisualStyleBackColor = true;
            this.getTransactionsButton.Click += new System.EventHandler(this.getTransactionsButton_Click);
            // 
            // EmployeeReturnTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getTransactionsButton);
            this.Controls.Add(this.itemsReturnedCheckedListBox);
            this.Controls.Add(this.processReturnButton);
            this.Controls.Add(this.refundTextBox);
            this.Controls.Add(this.feesTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.refundsLabel);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.itemsReturnedLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "EmployeeReturnTabUserControl";
            this.Size = new System.Drawing.Size(539, 268);
            this.Load += new System.EventHandler(this.EmployeeReturnTabUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label itemsReturnedLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label refundsLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox feesTextBox;
        private System.Windows.Forms.TextBox refundTextBox;
        private System.Windows.Forms.Button processReturnButton;
        private System.Windows.Forms.CheckedListBox itemsReturnedCheckedListBox;
        private System.Windows.Forms.Button getTransactionsButton;
    }
}
