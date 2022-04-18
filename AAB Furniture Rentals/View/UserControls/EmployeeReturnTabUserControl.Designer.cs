
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.processReturnButton = new System.Windows.Forms.Button();
            this.itemsReturnedCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(211, 63);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID:";
            // 
            // itemsReturnedLabel
            // 
            this.itemsReturnedLabel.AutoSize = true;
            this.itemsReturnedLabel.Location = new System.Drawing.Point(211, 106);
            this.itemsReturnedLabel.Name = "itemsReturnedLabel";
            this.itemsReturnedLabel.Size = new System.Drawing.Size(82, 13);
            this.itemsReturnedLabel.TabIndex = 1;
            this.itemsReturnedLabel.Text = "Items Returned:";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Location = new System.Drawing.Point(211, 263);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(33, 13);
            this.feesLabel.TabIndex = 2;
            this.feesLabel.Text = "Fees:";
            // 
            // refundsLabel
            // 
            this.refundsLabel.AutoSize = true;
            this.refundsLabel.Location = new System.Drawing.Point(211, 327);
            this.refundsLabel.Name = "refundsLabel";
            this.refundsLabel.Size = new System.Drawing.Size(50, 13);
            this.refundsLabel.TabIndex = 3;
            this.refundsLabel.Text = "Refunds:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(312, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(243, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 7;
            // 
            // processReturnButton
            // 
            this.processReturnButton.Location = new System.Drawing.Point(433, 379);
            this.processReturnButton.Name = "processReturnButton";
            this.processReturnButton.Size = new System.Drawing.Size(122, 23);
            this.processReturnButton.TabIndex = 8;
            this.processReturnButton.Text = "Process Return";
            this.processReturnButton.UseVisualStyleBackColor = true;
            this.processReturnButton.Click += new System.EventHandler(this.ProcessReturnButton_Click);
            // 
            // itemsReturnedCheckedListBox
            // 
            this.itemsReturnedCheckedListBox.FormattingEnabled = true;
            this.itemsReturnedCheckedListBox.Location = new System.Drawing.Point(312, 106);
            this.itemsReturnedCheckedListBox.Name = "itemsReturnedCheckedListBox";
            this.itemsReturnedCheckedListBox.Size = new System.Drawing.Size(243, 124);
            this.itemsReturnedCheckedListBox.TabIndex = 9;
            // 
            // EmployeeReturnTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemsReturnedCheckedListBox);
            this.Controls.Add(this.processReturnButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.refundsLabel);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.itemsReturnedLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "EmployeeReturnTabUserControl";
            this.Size = new System.Drawing.Size(791, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label itemsReturnedLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label refundsLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button processReturnButton;
        private System.Windows.Forms.CheckedListBox itemsReturnedCheckedListBox;
    }
}
