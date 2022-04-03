
namespace AAB_Furniture_Rentals.View.UserControls
{
    partial class AdminSearchUpdateAddEmployee
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
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(493, 183);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(93, 23);
            this.newEmployeeButton.TabIndex = 10;
            this.newEmployeeButton.Text = "New Employee";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.newEmployeeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(491, 89);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Select Employee";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // customerDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerDataGridView.Location = new System.Drawing.Point(81, 54);
            this.customerDataGridView.Name = "customerDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataGridView.Size = new System.Drawing.Size(405, 152);
            this.customerDataGridView.TabIndex = 12;
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(493, 68);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(93, 20);
            this.employeeTextBox.TabIndex = 8;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(505, 54);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(70, 13);
            this.employeeLabel.TabIndex = 7;
            this.employeeLabel.Text = "Employee ID:";
            // 
            // AdminSearchUpdateAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newEmployeeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.employeeTextBox);
            this.Controls.Add(this.employeeLabel);
            this.Name = "AdminSearchUpdateAddEmployee";
            this.Size = new System.Drawing.Size(596, 228);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.Label employeeLabel;
    }
}
