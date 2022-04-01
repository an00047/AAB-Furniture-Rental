
namespace AAB_Furniture_Rentals.UserControls
{
    partial class EmployeeFurnitureUserControl
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
            this.FurnitureListBox = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.buttaddToCartButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FurnitureListBox
            // 
            this.FurnitureListBox.FormattingEnabled = true;
            this.FurnitureListBox.Location = new System.Drawing.Point(429, 137);
            this.FurnitureListBox.MultiColumn = true;
            this.FurnitureListBox.Name = "FurnitureListBox";
            this.FurnitureListBox.Size = new System.Drawing.Size(324, 173);
            this.FurnitureListBox.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear.Location = new System.Drawing.Point(517, 326);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 31);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // buttaddToCartButton
            // 
            this.buttaddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttaddToCartButton.Location = new System.Drawing.Point(642, 326);
            this.buttaddToCartButton.Name = "buttaddToCartButton";
            this.buttaddToCartButton.Size = new System.Drawing.Size(111, 31);
            this.buttaddToCartButton.TabIndex = 2;
            this.buttaddToCartButton.Text = "Add to Cart";
            this.buttaddToCartButton.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(140, 163);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(202, 28);
            this.typeComboBox.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(140, 224);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(202, 28);
            this.categoryComboBox.TabIndex = 4;
            // 
            // idComboBox
            // 
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(140, 282);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(202, 28);
            this.idComboBox.TabIndex = 5;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(69, 171);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(69, 232);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(69, 290);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchButton.Location = new System.Drawing.Point(232, 326);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 31);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchByLabel.Location = new System.Drawing.Point(182, 130);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(84, 20);
            this.searchByLabel.TabIndex = 11;
            this.searchByLabel.Text = "Search by:";
            // 
            // EmployeeFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.buttaddToCartButton);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.FurnitureListBox);
            this.Name = "EmployeeFurnitureUserControl";
            this.Size = new System.Drawing.Size(826, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FurnitureListBox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button buttaddToCartButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchByLabel;
    }
}
