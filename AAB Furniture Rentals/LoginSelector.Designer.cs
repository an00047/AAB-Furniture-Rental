
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
            this.LoginAsEmployeeBtn = new System.Windows.Forms.Button();
            this.LoginAsAdminBtn = new System.Windows.Forms.Button();
            this.LoginTextLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.LoginAsEmployeeBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoginAsAdminBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginTextLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LoginAsEmployeeBtn
            // 
            this.LoginAsEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginAsEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsEmployeeBtn.Location = new System.Drawing.Point(91, 80);
            this.LoginAsEmployeeBtn.Name = "LoginAsEmployeeBtn";
            this.LoginAsEmployeeBtn.Size = new System.Drawing.Size(126, 41);
            this.LoginAsEmployeeBtn.TabIndex = 0;
            this.LoginAsEmployeeBtn.Text = "Employee";
            this.LoginAsEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // LoginAsAdminBtn
            // 
            this.LoginAsAdminBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginAsAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsAdminBtn.Location = new System.Drawing.Point(91, 147);
            this.LoginAsAdminBtn.Name = "LoginAsAdminBtn";
            this.LoginAsAdminBtn.Size = new System.Drawing.Size(126, 41);
            this.LoginAsAdminBtn.TabIndex = 1;
            this.LoginAsAdminBtn.Text = "Admin";
            this.LoginAsAdminBtn.UseVisualStyleBackColor = true;
            // 
            // LoginTextLabel
            // 
            this.LoginTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextLabel.Location = new System.Drawing.Point(104, 22);
            this.LoginTextLabel.Name = "LoginTextLabel";
            this.LoginTextLabel.Size = new System.Drawing.Size(100, 23);
            this.LoginTextLabel.TabIndex = 2;
            this.LoginTextLabel.Text = "LOGIN";
            this.LoginTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAB Furniture Store: Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LoginAsEmployeeBtn;
        private System.Windows.Forms.Button LoginAsAdminBtn;
        private System.Windows.Forms.Label LoginTextLabel;
    }
}

