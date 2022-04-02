
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
            this.components = new System.ComponentModel.Container();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this._cs6232_g4DataSet = new AAB_Furniture_Rentals._cs6232_g4DataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.memberTableAdapter();
            this.tableAdapterManager = new AAB_Furniture_Rentals._cs6232_g4DataSetTableAdapters.TableAdapterManager();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(343, 261);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(85, 23);
            this.editCustomerButton.TabIndex = 11;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(226, 261);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(93, 23);
            this.newCustomerButton.TabIndex = 10;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(296, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
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
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(79, 90);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(318, 150);
            this.customerDataGridView.TabIndex = 12;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(180, 43);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(97, 20);
            this.customerTextBox.TabIndex = 8;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(104, 47);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(70, 13);
            this.employeeLabel.TabIndex = 7;
            this.employeeLabel.Text = "Employee ID:";
            // 
            // AdminSearchUpdateAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.employeeLabel);
            this.Name = "AdminSearchUpdateAddEmployee";
            this.Size = new System.Drawing.Size(506, 325);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button searchButton;
        private _cs6232_g4DataSet _cs6232_g4DataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private _cs6232_g4DataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private _cs6232_g4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label employeeLabel;
    }
}
