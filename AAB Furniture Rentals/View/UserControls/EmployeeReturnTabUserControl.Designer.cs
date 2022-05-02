
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
            this.selectInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(182, 21);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(68, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Customer ID:";
            // 
            // itemsReturnedLabel
            // 
            this.itemsReturnedLabel.AutoSize = true;
            this.itemsReturnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsReturnedLabel.Location = new System.Drawing.Point(268, 41);
            this.itemsReturnedLabel.Name = "itemsReturnedLabel";
            this.itemsReturnedLabel.Size = new System.Drawing.Size(144, 20);
            this.itemsReturnedLabel.TabIndex = 1;
            this.itemsReturnedLabel.Text = "Items To Return:";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLabel.Location = new System.Drawing.Point(61, 274);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(43, 17);
            this.feesLabel.TabIndex = 2;
            this.feesLabel.Text = "Fees:";
            // 
            // refundsLabel
            // 
            this.refundsLabel.AutoSize = true;
            this.refundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundsLabel.Location = new System.Drawing.Point(362, 275);
            this.refundsLabel.Name = "refundsLabel";
            this.refundsLabel.Size = new System.Drawing.Size(65, 17);
            this.refundsLabel.TabIndex = 3;
            this.refundsLabel.Text = "Refunds:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(256, 18);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(174, 20);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // feesTextBox
            // 
            this.feesTextBox.Location = new System.Drawing.Point(110, 274);
            this.feesTextBox.Name = "feesTextBox";
            this.feesTextBox.Size = new System.Drawing.Size(199, 20);
            this.feesTextBox.TabIndex = 6;
            // 
            // refundTextBox
            // 
            this.refundTextBox.Location = new System.Drawing.Point(433, 274);
            this.refundTextBox.Name = "refundTextBox";
            this.refundTextBox.Size = new System.Drawing.Size(199, 20);
            this.refundTextBox.TabIndex = 7;
            // 
            // processReturnButton
            // 
            this.processReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReturnButton.Location = new System.Drawing.Point(258, 310);
            this.processReturnButton.Name = "processReturnButton";
            this.processReturnButton.Size = new System.Drawing.Size(172, 38);
            this.processReturnButton.TabIndex = 8;
            this.processReturnButton.Text = "Process Return";
            this.processReturnButton.UseVisualStyleBackColor = true;
            this.processReturnButton.Click += new System.EventHandler(this.ProcessReturnButton_Click);
            // 
            // itemsReturnedCheckedListBox
            // 
            this.itemsReturnedCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsReturnedCheckedListBox.FormattingEnabled = true;
            this.itemsReturnedCheckedListBox.Location = new System.Drawing.Point(55, 60);
            this.itemsReturnedCheckedListBox.Name = "itemsReturnedCheckedListBox";
            this.itemsReturnedCheckedListBox.Size = new System.Drawing.Size(594, 193);
            this.itemsReturnedCheckedListBox.TabIndex = 9;
            this.itemsReturnedCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemsReturned_Selected);
            // 
            // getTransactionsButton
            // 
            this.getTransactionsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.getTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTransactionsButton.Location = new System.Drawing.Point(444, 12);
            this.getTransactionsButton.Name = "getTransactionsButton";
            this.getTransactionsButton.Size = new System.Drawing.Size(45, 28);
            this.getTransactionsButton.TabIndex = 10;
            this.getTransactionsButton.Text = "Get";
            this.getTransactionsButton.UseVisualStyleBackColor = true;
            this.getTransactionsButton.Click += new System.EventHandler(this.getTransactionsButton_Click);
            // 
            // selectInfoLabel
            // 
            this.selectInfoLabel.AutoSize = true;
            this.selectInfoLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.selectInfoLabel.Location = new System.Drawing.Point(269, 254);
            this.selectInfoLabel.Name = "selectInfoLabel";
            this.selectInfoLabel.Size = new System.Drawing.Size(117, 13);
            this.selectInfoLabel.TabIndex = 11;
            this.selectInfoLabel.Text = "*Check Items to Return";
            // 
            // EmployeeReturnTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectInfoLabel);
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
            this.Size = new System.Drawing.Size(725, 360);
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
        private System.Windows.Forms.Label selectInfoLabel;
    }
}
