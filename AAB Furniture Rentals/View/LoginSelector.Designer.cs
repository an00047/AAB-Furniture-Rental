
namespace AAB_Furniture_Rentals
{
    partial class LoginSelector
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginAsAdminBtn = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginAsEmployeeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LoginAsAdminBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoginAsEmployeeBtn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 202);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LoginAsAdminBtn
            // 
            this.LoginAsAdminBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginAsAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsAdminBtn.Location = new System.Drawing.Point(129, 122);
            this.LoginAsAdminBtn.Name = "LoginAsAdminBtn";
            this.LoginAsAdminBtn.Size = new System.Drawing.Size(126, 41);
            this.LoginAsAdminBtn.TabIndex = 5;
            this.LoginAsAdminBtn.Text = "ADMIN";
            this.LoginAsAdminBtn.UseVisualStyleBackColor = true;
            this.LoginAsAdminBtn.Click += new System.EventHandler(this.LoginAsAdminBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(152, 16);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(80, 26);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "LOGIN";
            // 
            // LoginAsEmployeeBtn
            // 
            this.LoginAsEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginAsEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsEmployeeBtn.Location = new System.Drawing.Point(129, 66);
            this.LoginAsEmployeeBtn.Name = "LoginAsEmployeeBtn";
            this.LoginAsEmployeeBtn.Size = new System.Drawing.Size(126, 41);
            this.LoginAsEmployeeBtn.TabIndex = 1;
            this.LoginAsEmployeeBtn.Text = "EMPLOYEE";
            this.LoginAsEmployeeBtn.UseVisualStyleBackColor = true;
            this.LoginAsEmployeeBtn.Click += new System.EventHandler(this.LoginAsEmployeeBtn_Click);
            // 
            // LoginSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSelector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LoginAsEmployeeBtn;
        private System.Windows.Forms.Button LoginAsAdminBtn;
        public System.Windows.Forms.Label LoginLabel;
    }
}