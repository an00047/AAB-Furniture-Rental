
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
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AbandonCartButton
            // 
            this.AbandonCartButton.Location = new System.Drawing.Point(659, 395);
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
            this.CheckoutButton.Location = new System.Drawing.Point(659, 366);
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
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FurnitureDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(734, 262);
            this.FurnitureDataGridView.TabIndex = 17;
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
            // CartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Employeelabel);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.AbandonCartButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.FurnitureDataGridView);
            this.Controls.Add(this.MemberTextBox);
            this.Controls.Add(this.MemberLabel);
            this.Name = "CartDialog";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
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
    }
}