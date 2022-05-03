
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
            this.itemsReturnedLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.refundsLabel = new System.Windows.Forms.Label();
            this.feesTextBox = new System.Windows.Forms.TextBox();
            this.refundTextBox = new System.Windows.Forms.TextBox();
            this.processReturnButton = new System.Windows.Forms.Button();
            this.itemsReturnedCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.selectMemberButton = new System.Windows.Forms.Button();
            this.selectInfoLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsReturnedLabel
            // 
            this.itemsReturnedLabel.AutoSize = true;
            this.itemsReturnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsReturnedLabel.Location = new System.Drawing.Point(268, 22);
            this.itemsReturnedLabel.Name = "itemsReturnedLabel";
            this.itemsReturnedLabel.Size = new System.Drawing.Size(148, 20);
            this.itemsReturnedLabel.TabIndex = 1;
            this.itemsReturnedLabel.Text = "All Rented Items:";
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
            this.processReturnButton.Location = new System.Drawing.Point(350, 310);
            this.processReturnButton.Name = "processReturnButton";
            this.processReturnButton.Size = new System.Drawing.Size(172, 38);
            this.processReturnButton.TabIndex = 8;
            this.processReturnButton.Text = "Process Return";
            this.processReturnButton.UseVisualStyleBackColor = true;
            this.processReturnButton.Click += new System.EventHandler(this.ProcessReturnButton_Click);
            // 
            // itemsReturnedCheckedListBox
            // 
            this.itemsReturnedCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsReturnedCheckedListBox.FormattingEnabled = true;
            this.itemsReturnedCheckedListBox.Location = new System.Drawing.Point(55, 60);
            this.itemsReturnedCheckedListBox.Name = "itemsReturnedCheckedListBox";
            this.itemsReturnedCheckedListBox.Size = new System.Drawing.Size(594, 193);
            this.itemsReturnedCheckedListBox.TabIndex = 9;
            this.itemsReturnedCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemsReturned_Selected);
            // 
            // selectMemberButton
            // 
            this.selectMemberButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMemberButton.Location = new System.Drawing.Point(528, 310);
            this.selectMemberButton.Name = "selectMemberButton";
            this.selectMemberButton.Size = new System.Drawing.Size(112, 38);
            this.selectMemberButton.TabIndex = 10;
            this.selectMemberButton.Text = "Select Member";
            this.selectMemberButton.UseVisualStyleBackColor = true;
            this.selectMemberButton.Click += new System.EventHandler(this.ChangeMember_Click);
            // 
            // selectInfoLabel
            // 
            this.selectInfoLabel.AutoSize = true;
            this.selectInfoLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.selectInfoLabel.Location = new System.Drawing.Point(269, 254);
            this.selectInfoLabel.Name = "selectInfoLabel";
            this.selectInfoLabel.Size = new System.Drawing.Size(205, 13);
            this.selectInfoLabel.TabIndex = 11;
            this.selectInfoLabel.Text = "*Check how many of which items to return";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(227, 44);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(232, 13);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = "Select Member to view available items for return";
            // 
            // EmployeeReturnTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.selectInfoLabel);
            this.Controls.Add(this.selectMemberButton);
            this.Controls.Add(this.itemsReturnedCheckedListBox);
            this.Controls.Add(this.processReturnButton);
            this.Controls.Add(this.refundTextBox);
            this.Controls.Add(this.feesTextBox);
            this.Controls.Add(this.refundsLabel);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.itemsReturnedLabel);
            this.Name = "EmployeeReturnTabUserControl";
            this.Size = new System.Drawing.Size(725, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label itemsReturnedLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label refundsLabel;
        private System.Windows.Forms.TextBox feesTextBox;
        private System.Windows.Forms.TextBox refundTextBox;
        private System.Windows.Forms.Button processReturnButton;
        private System.Windows.Forms.CheckedListBox itemsReturnedCheckedListBox;
        private System.Windows.Forms.Button selectMemberButton;
        private System.Windows.Forms.Label selectInfoLabel;
        private System.Windows.Forms.Label instructionsLabel;
    }
}
