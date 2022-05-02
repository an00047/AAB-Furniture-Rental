
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
            this.searchButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this._cs6232_g4DataSet = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.memberTableAdapter();
            this.tableAdapterManager = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.TableAdapterManager();
            this.searchTypeLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SetCurrentMemberButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CustIdRadioBtn = new System.Windows.Forms.RadioButton();
            this.SelectCustomerByBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SelectCustomerByBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(203, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(19, 291);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(174, 51);
            this.newCustomerButton.TabIndex = 4;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(479, 291);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(174, 23);
            this.editCustomerButton.TabIndex = 5;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
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
            // searchTypeLabel
            // 
            this.searchTypeLabel.AutoSize = true;
            this.searchTypeLabel.Location = new System.Drawing.Point(220, 10);
            this.searchTypeLabel.Name = "searchTypeLabel";
            this.searchTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.searchTypeLabel.TabIndex = 0;
            this.searchTypeLabel.Text = "Customer ID:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(203, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(97, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.CustomerTextBox_Changed);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(19, 97);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(661, 188);
            this.customerDataGridView.TabIndex = 6;
            this.customerDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_CellMouseClick);
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(432, 44);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(83, 21);
            this.searchTypeComboBox.TabIndex = 7;
            this.searchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // SetCurrentMemberButton
            // 
            this.SetCurrentMemberButton.Location = new System.Drawing.Point(479, 320);
            this.SetCurrentMemberButton.Name = "SetCurrentMemberButton";
            this.SetCurrentMemberButton.Size = new System.Drawing.Size(174, 22);
            this.SetCurrentMemberButton.TabIndex = 9;
            this.SetCurrentMemberButton.Text = "Set As \"Current Shopper\"";
            this.SetCurrentMemberButton.UseVisualStyleBackColor = true;
            this.SetCurrentMemberButton.Click += new System.EventHandler(this.SetCurrentMemberButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Customer First and Last Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Customer Phone Number";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // CustIdRadioBtn
            // 
            this.CustIdRadioBtn.AutoSize = true;
            this.CustIdRadioBtn.Location = new System.Drawing.Point(17, 16);
            this.CustIdRadioBtn.Name = "CustIdRadioBtn";
            this.CustIdRadioBtn.Size = new System.Drawing.Size(83, 17);
            this.CustIdRadioBtn.TabIndex = 12;
            this.CustIdRadioBtn.TabStop = true;
            this.CustIdRadioBtn.Text = "Customer ID";
            this.CustIdRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SelectCustomerByBox
            // 
            this.SelectCustomerByBox.Controls.Add(this.CustIdRadioBtn);
            this.SelectCustomerByBox.Controls.Add(this.radioButton2);
            this.SelectCustomerByBox.Controls.Add(this.radioButton1);
            this.SelectCustomerByBox.Controls.Add(this.searchTextBox);
            this.SelectCustomerByBox.Controls.Add(this.searchButton);
            this.SelectCustomerByBox.Controls.Add(this.searchTypeLabel);
            this.SelectCustomerByBox.Location = new System.Drawing.Point(19, 9);
            this.SelectCustomerByBox.Name = "SelectCustomerByBox";
            this.SelectCustomerByBox.Size = new System.Drawing.Size(316, 82);
            this.SelectCustomerByBox.TabIndex = 13;
            this.SelectCustomerByBox.TabStop = false;
            this.SelectCustomerByBox.Text = "Select Customer By: ";
            // 
            // EmployeeCustomersTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectCustomerByBox);
            this.Controls.Add(this.SetCurrentMemberButton);
            this.Controls.Add(this.searchTypeComboBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.newCustomerButton);
            this.Name = "EmployeeCustomersTabUserControl";
            this.Size = new System.Drawing.Size(693, 357);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.SelectCustomerByBox.ResumeLayout(false);
            this.SelectCustomerByBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button editCustomerButton;
        private _cs6232_g4DataSet _cs6232_g4DataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private _cs6232_g4DataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private _cs6232_g4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label searchTypeLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.Button SetCurrentMemberButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton CustIdRadioBtn;
        private System.Windows.Forms.GroupBox SelectCustomerByBox;
    }
}
