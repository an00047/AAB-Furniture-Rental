
namespace AAB_Furniture_Rentals.View.UserControls
{
    partial class EmployeeCustomersTabUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.NameRadioBtn = new System.Windows.Forms.RadioButton();
            this.PhoneRadioBtn = new System.Windows.Forms.RadioButton();
            this.CustIdRadioBtn = new System.Windows.Forms.RadioButton();
            this.SelectCustomerByBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.ActiveMemberBox = new System.Windows.Forms.GroupBox();
            this.CustoemrNameValue = new System.Windows.Forms.Label();
            this.CustomerPhoneValue = new System.Windows.Forms.Label();
            this.MemberIDValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerPhoneLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this._cs6232_g4DataSet = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.memberTableAdapter();
            this.tableAdapterManager = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.TableAdapterManager();
            this.tutorialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SelectCustomerByBox.SuspendLayout();
            this.ActiveMemberBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(203, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(19, 326);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(174, 23);
            this.newCustomerButton.TabIndex = 4;
            this.newCustomerButton.Text = "New Member";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(487, 331);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(174, 23);
            this.editCustomerButton.TabIndex = 5;
            this.editCustomerButton.Text = "Edit Member";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(203, 9);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(97, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.CustomerTextBox_Changed);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.Location = new System.Drawing.Point(19, 97);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.customerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(642, 228);
            this.customerDataGridView.TabIndex = 6;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_CellMouseClick);
            this.customerDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_CellMouseClick);
            // 
            // NameRadioBtn
            // 
            this.NameRadioBtn.AutoSize = true;
            this.NameRadioBtn.Location = new System.Drawing.Point(17, 59);
            this.NameRadioBtn.Name = "NameRadioBtn";
            this.NameRadioBtn.Size = new System.Drawing.Size(160, 17);
            this.NameRadioBtn.TabIndex = 10;
            this.NameRadioBtn.TabStop = true;
            this.NameRadioBtn.Text = "Member First and Last Name";
            this.NameRadioBtn.UseVisualStyleBackColor = true;
            this.NameRadioBtn.CheckedChanged += new System.EventHandler(this.SetLabel);
            // 
            // PhoneRadioBtn
            // 
            this.PhoneRadioBtn.AutoSize = true;
            this.PhoneRadioBtn.Location = new System.Drawing.Point(17, 37);
            this.PhoneRadioBtn.Name = "PhoneRadioBtn";
            this.PhoneRadioBtn.Size = new System.Drawing.Size(137, 17);
            this.PhoneRadioBtn.TabIndex = 11;
            this.PhoneRadioBtn.TabStop = true;
            this.PhoneRadioBtn.Text = "Member Phone Number";
            this.PhoneRadioBtn.UseVisualStyleBackColor = true;
            this.PhoneRadioBtn.CheckedChanged += new System.EventHandler(this.SetLabel);
            // 
            // CustIdRadioBtn
            // 
            this.CustIdRadioBtn.AutoSize = true;
            this.CustIdRadioBtn.Location = new System.Drawing.Point(17, 16);
            this.CustIdRadioBtn.Name = "CustIdRadioBtn";
            this.CustIdRadioBtn.Size = new System.Drawing.Size(77, 17);
            this.CustIdRadioBtn.TabIndex = 12;
            this.CustIdRadioBtn.TabStop = true;
            this.CustIdRadioBtn.Text = "Member ID";
            this.CustIdRadioBtn.UseVisualStyleBackColor = true;
            this.CustIdRadioBtn.CheckedChanged += new System.EventHandler(this.SetLabel);
            // 
            // SelectCustomerByBox
            // 
            this.SelectCustomerByBox.Controls.Add(this.clearButton);
            this.SelectCustomerByBox.Controls.Add(this.clear);
            this.SelectCustomerByBox.Controls.Add(this.CustIdRadioBtn);
            this.SelectCustomerByBox.Controls.Add(this.PhoneRadioBtn);
            this.SelectCustomerByBox.Controls.Add(this.NameRadioBtn);
            this.SelectCustomerByBox.Controls.Add(this.searchTextBox);
            this.SelectCustomerByBox.Controls.Add(this.searchButton);
            this.SelectCustomerByBox.Location = new System.Drawing.Point(19, 9);
            this.SelectCustomerByBox.Name = "SelectCustomerByBox";
            this.SelectCustomerByBox.Size = new System.Drawing.Size(381, 82);
            this.SelectCustomerByBox.TabIndex = 13;
            this.SelectCustomerByBox.TabStop = false;
            this.SelectCustomerByBox.Text = "Select Member By: ";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(203, 59);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Reset Filter";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.clear.Location = new System.Drawing.Point(305, 20);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(72, 48);
            this.clear.TabIndex = 15;
            this.clear.Text = "Search All Members";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ActiveMemberBox
            // 
            this.ActiveMemberBox.Controls.Add(this.CustoemrNameValue);
            this.ActiveMemberBox.Controls.Add(this.CustomerPhoneValue);
            this.ActiveMemberBox.Controls.Add(this.MemberIDValue);
            this.ActiveMemberBox.Controls.Add(this.label3);
            this.ActiveMemberBox.Controls.Add(this.CustomerPhoneLabel);
            this.ActiveMemberBox.Controls.Add(this.CustomerNameLabel);
            this.ActiveMemberBox.Location = new System.Drawing.Point(402, 9);
            this.ActiveMemberBox.Name = "ActiveMemberBox";
            this.ActiveMemberBox.Size = new System.Drawing.Size(259, 82);
            this.ActiveMemberBox.TabIndex = 14;
            this.ActiveMemberBox.TabStop = false;
            this.ActiveMemberBox.Text = "Currently Active Member: ";
            // 
            // CustoemrNameValue
            // 
            this.CustoemrNameValue.AutoSize = true;
            this.CustoemrNameValue.Font = new System.Drawing.Font("ModeNine", 11F);
            this.CustoemrNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustoemrNameValue.Location = new System.Drawing.Point(79, 61);
            this.CustoemrNameValue.Name = "CustoemrNameValue";
            this.CustoemrNameValue.Size = new System.Drawing.Size(16, 15);
            this.CustoemrNameValue.TabIndex = 23;
            this.CustoemrNameValue.Text = "?";
            // 
            // CustomerPhoneValue
            // 
            this.CustomerPhoneValue.AutoSize = true;
            this.CustomerPhoneValue.Font = new System.Drawing.Font("ModeNine", 11F);
            this.CustomerPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomerPhoneValue.Location = new System.Drawing.Point(80, 39);
            this.CustomerPhoneValue.Name = "CustomerPhoneValue";
            this.CustomerPhoneValue.Size = new System.Drawing.Size(16, 15);
            this.CustomerPhoneValue.TabIndex = 22;
            this.CustomerPhoneValue.Text = "?";
            // 
            // MemberIDValue
            // 
            this.MemberIDValue.AutoSize = true;
            this.MemberIDValue.Font = new System.Drawing.Font("ModeNine", 11F);
            this.MemberIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemberIDValue.Location = new System.Drawing.Point(67, 18);
            this.MemberIDValue.Name = "MemberIDValue";
            this.MemberIDValue.Size = new System.Drawing.Size(16, 15);
            this.MemberIDValue.TabIndex = 21;
            this.MemberIDValue.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Member ID:  ";
            // 
            // CustomerPhoneLabel
            // 
            this.CustomerPhoneLabel.AutoSize = true;
            this.CustomerPhoneLabel.Location = new System.Drawing.Point(2, 39);
            this.CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            this.CustomerPhoneLabel.Size = new System.Drawing.Size(85, 13);
            this.CustomerPhoneLabel.TabIndex = 2;
            this.CustomerPhoneLabel.Text = "Member Phone: ";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(3, 61);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Member Name: ";
            // 
            // _cs6232_g4DataSet
            // 
            this._cs6232_g4DataSet.DataSetName = "_cs6232_g4DataSet";
            this._cs6232_g4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this._cs6232_g4DataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.furniture_categoriesTableAdapter = null;
            this.tableAdapterManager.furniture_styleTableAdapter = null;
            this.tableAdapterManager.furnitureTableAdapter = null;
            this.tableAdapterManager.is_rentedTableAdapter = null;
            this.tableAdapterManager.is_returnedTableAdapter = null;
            this.tableAdapterManager.login_dataTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.rentalsTableAdapter = null;
            this.tableAdapterManager.returnsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.AutoSize = true;
            this.tutorialLabel.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.tutorialLabel.Location = new System.Drawing.Point(199, 334);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(251, 15);
            this.tutorialLabel.TabIndex = 27;
            this.tutorialLabel.Text = "*Selecting Member on list  Activates Them*";
            this.tutorialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeCustomersTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tutorialLabel);
            this.Controls.Add(this.ActiveMemberBox);
            this.Controls.Add(this.SelectCustomerByBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.newCustomerButton);
            this.Name = "EmployeeCustomersTabUserControl";
            this.Size = new System.Drawing.Size(677, 357);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.SelectCustomerByBox.ResumeLayout(false);
            this.SelectCustomerByBox.PerformLayout();
            this.ActiveMemberBox.ResumeLayout(false);
            this.ActiveMemberBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button editCustomerButton;
        private _cs6232_g4DataSet _cs6232_g4DataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private _cs6232_g4DataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private _cs6232_g4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.RadioButton NameRadioBtn;
        private System.Windows.Forms.RadioButton PhoneRadioBtn;
        private System.Windows.Forms.RadioButton CustIdRadioBtn;
        private System.Windows.Forms.GroupBox SelectCustomerByBox;
        private System.Windows.Forms.GroupBox ActiveMemberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CustomerPhoneLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustoemrNameValue;
        private System.Windows.Forms.Label CustomerPhoneValue;
        private System.Windows.Forms.Label MemberIDValue;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label tutorialLabel;
    }
}
