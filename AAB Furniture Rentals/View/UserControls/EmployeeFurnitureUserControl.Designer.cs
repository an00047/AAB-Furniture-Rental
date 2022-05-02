
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clear = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewCartButton = new System.Windows.Forms.Button();
            this.AbandonCartButton = new System.Windows.Forms.Button();
            this.AddToCartGroupBox = new System.Windows.Forms.GroupBox();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.InCartWarning = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tutorialLabel = new System.Windows.Forms.Label();
            this.serchBygroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alreadyInCartPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.AddToCartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.serchBygroup.SuspendLayout();
            this.alreadyInCartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.clear.Location = new System.Drawing.Point(378, 8);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(67, 21);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddToCartButton.Location = new System.Drawing.Point(86, 14);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(74, 21);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add to Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // styleComboBox
            // 
            this.styleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(173, 17);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(79, 21);
            this.styleComboBox.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(86, 17);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(76, 21);
            this.categoryComboBox.TabIndex = 4;
            // 
            // idComboBox
            // 
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.ItemHeight = 13;
            this.idComboBox.Location = new System.Drawing.Point(12, 17);
            this.idComboBox.MaximumSize = new System.Drawing.Size(62, 0);
            this.idComboBox.MinimumSize = new System.Drawing.Size(62, 0);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(62, 21);
            this.idComboBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.searchButton.Location = new System.Drawing.Point(296, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 21);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.searchDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchDataGridView.Location = new System.Drawing.Point(4, 51);
            this.searchDataGridView.MultiSelect = false;
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(458, 139);
            this.searchDataGridView.TabIndex = 12;
            this.searchDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            this.searchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            this.searchDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            this.searchDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            this.searchDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchDataGridView_CellContentClick);
            this.searchDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchDataGridView_CellContentClick);
            this.searchDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.searchDataGridView_DataBindingComplete);
            // 
            // ViewCartButton
            // 
            this.ViewCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ViewCartButton.Location = new System.Drawing.Point(6, 16);
            this.ViewCartButton.Name = "ViewCartButton";
            this.ViewCartButton.Size = new System.Drawing.Size(88, 21);
            this.ViewCartButton.TabIndex = 13;
            this.ViewCartButton.Text = "VIEW CART";
            this.ViewCartButton.UseVisualStyleBackColor = true;
            this.ViewCartButton.Click += new System.EventHandler(this.ViewCartButton_Click);
            // 
            // AbandonCartButton
            // 
            this.AbandonCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AbandonCartButton.Location = new System.Drawing.Point(100, 16);
            this.AbandonCartButton.Name = "AbandonCartButton";
            this.AbandonCartButton.Size = new System.Drawing.Size(88, 21);
            this.AbandonCartButton.TabIndex = 14;
            this.AbandonCartButton.Text = "Abandon Cart";
            this.AbandonCartButton.UseVisualStyleBackColor = true;
            this.AbandonCartButton.Click += new System.EventHandler(this.AbandonCartButton_Click);
            // 
            // AddToCartGroupBox
            // 
            this.AddToCartGroupBox.Controls.Add(this.qtyUpDown);
            this.AddToCartGroupBox.Controls.Add(this.QtyLabel);
            this.AddToCartGroupBox.Controls.Add(this.AddToCartButton);
            this.AddToCartGroupBox.Location = new System.Drawing.Point(6, 192);
            this.AddToCartGroupBox.Name = "AddToCartGroupBox";
            this.AddToCartGroupBox.Size = new System.Drawing.Size(164, 40);
            this.AddToCartGroupBox.TabIndex = 16;
            this.AddToCartGroupBox.TabStop = false;
            this.AddToCartGroupBox.Text = "Add To Cart";
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(31, 15);
            this.qtyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(49, 20);
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
            this.QtyLabel.Location = new System.Drawing.Point(5, 19);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(26, 13);
            this.QtyLabel.TabIndex = 16;
            this.QtyLabel.Text = "Qty:";
            // 
            // InCartWarning
            // 
            this.InCartWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InCartWarning.AutoSize = true;
            this.InCartWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InCartWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.InCartWarning.Location = new System.Drawing.Point(40, 0);
            this.InCartWarning.Name = "InCartWarning";
            this.InCartWarning.Size = new System.Drawing.Size(16, 18);
            this.InCartWarning.TabIndex = 30;
            this.InCartWarning.Text = "?";
            this.InCartWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewCartButton);
            this.groupBox2.Controls.Add(this.AbandonCartButton);
            this.groupBox2.Location = new System.Drawing.Point(267, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 40);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Checkout";
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.AutoSize = true;
            this.tutorialLabel.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.tutorialLabel.Location = new System.Drawing.Point(287, 29);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(171, 15);
            this.tutorialLabel.TabIndex = 26;
            this.tutorialLabel.Text = "*Select Line Items of Interest";
            this.tutorialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serchBygroup
            // 
            this.serchBygroup.Controls.Add(this.button1);
            this.serchBygroup.Controls.Add(this.idComboBox);
            this.serchBygroup.Controls.Add(this.clear);
            this.serchBygroup.Controls.Add(this.tutorialLabel);
            this.serchBygroup.Controls.Add(this.styleComboBox);
            this.serchBygroup.Controls.Add(this.categoryComboBox);
            this.serchBygroup.Controls.Add(this.searchButton);
            this.serchBygroup.Location = new System.Drawing.Point(4, 4);
            this.serchBygroup.Name = "serchBygroup";
            this.serchBygroup.Size = new System.Drawing.Size(461, 41);
            this.serchBygroup.TabIndex = 28;
            this.serchBygroup.TabStop = false;
            this.serchBygroup.Text = "Search By:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // alreadyInCartPanel
            // 
            this.alreadyInCartPanel.Controls.Add(this.InCartWarning);
            this.alreadyInCartPanel.Location = new System.Drawing.Point(3, 194);
            this.alreadyInCartPanel.Name = "alreadyInCartPanel";
            this.alreadyInCartPanel.Size = new System.Drawing.Size(258, 42);
            this.alreadyInCartPanel.TabIndex = 31;
            // 
            // EmployeeFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alreadyInCartPanel);
            this.Controls.Add(this.serchBygroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddToCartGroupBox);
            this.Controls.Add(this.searchDataGridView);
            this.Name = "EmployeeFurnitureUserControl";
            this.Size = new System.Drawing.Size(471, 239);
            this.Load += new System.EventHandler(this.EmployeeFurnitureUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.AddToCartGroupBox.ResumeLayout(false);
            this.AddToCartGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.serchBygroup.ResumeLayout(false);
            this.serchBygroup.PerformLayout();
            this.alreadyInCartPanel.ResumeLayout(false);
            this.alreadyInCartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Button ViewCartButton;
        private System.Windows.Forms.Button AbandonCartButton;
        private System.Windows.Forms.GroupBox AddToCartGroupBox;
        private System.Windows.Forms.NumericUpDown qtyUpDown;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tutorialLabel;
        private System.Windows.Forms.GroupBox serchBygroup;
        private System.Windows.Forms.Label InCartWarning;
        private System.Windows.Forms.Panel alreadyInCartPanel;
        private System.Windows.Forms.Button button1;
    }
}
