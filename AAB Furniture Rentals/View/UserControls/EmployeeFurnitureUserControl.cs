using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using AAB_Furniture_Rentals.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.UserControls
{
    /// <summary>
    /// Manages the user interface displayed for the furniture search function
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class EmployeeFurnitureUserControl : UserControl
    {

        //private List<int> ListOfRowsAddedToCart;

        /// <summary>
        /// Constrouctor method for the employeeUser furniture control
        /// </summary>
        public EmployeeFurnitureUserControl()
        {
            InitializeComponent();
          
            this.ViewCartButton.Enabled = false;
            this.InCartWarning.Visible = true;
            this.InCartWarning.Text = "Item already in cart. \n Go to Cart to edit/update the order \n OR select a different item";
            this.alreadyInCartPanel.Visible = false;
            this.QtyZeroLabel.Text = "Qty = 0";
            this.QtyZeroLabel.Visible = false;
            //Makes a Cart, if one didnt already exist
            if (FurnitureController.CurrentCart == null)
            {
                FurnitureController.CurrentCart = new Cart();
            }

        }


        private void EmployeeFurnitureUserControl_Load(object sender, EventArgs e)
        {
            List<FurnitureStyle> furnitureStyles = StyleController.GetAllStyles();
            this.styleComboBox.DisplayMember = "Style";
            this.styleComboBox.DataSource = furnitureStyles;
            this.styleComboBox.ValueMember = "Style";

            this.styleComboBox.SelectedItem = null;
            this.styleComboBox.SelectedText = "-Styles-";



            List<FurnitureCategory> furnitureCategories = CategoryController.GetAllCategories();
            this.categoryComboBox.DisplayMember = "Category";
            this.categoryComboBox.DataSource = furnitureCategories;
            this.categoryComboBox.ValueMember = "Category";

            this.categoryComboBox.SelectedItem = null;
            this.categoryComboBox.SelectedText = "-Categories-";

            List<Furniture> furnitures = FurnitureController.GetAllFurnitures();
            this.idComboBox.DataSource = furnitures;
            this.idComboBox.DisplayMember = "FurnitureID";
            this.idComboBox.ValueMember = "FurnitureID";

            this.idComboBox.SelectedItem = null;
            this.idComboBox.SelectedText = "-Furniture ID-";


            furnitures = FurnitureController.GetFurnitureByParameter(
                   "",
                   "",
                   null);


            this.ManualDatabind(furnitures);
            this.BlackListCartItmes();


        }
        private void ManualDatabind(List<Furniture> furnitures) {

            this.searchDataGridView.DataSource = furnitures;
            this.searchDataGridView.Columns["DueDate"].Visible = false;
            this.searchDataGridView.Columns["QuantityRented"].Visible = false;
            this.searchDataGridView.Columns["TransactionID"].Visible = false;
            this.searchDataGridView.Columns["RentalDescription"].Visible = false;

            this.searchDataGridView.Columns["Category"].HeaderText = "CATGRY";
            this.searchDataGridView.Columns["DailyRentalRate"].HeaderText = "$/Day";
            this.searchDataGridView.Columns["FurnitureID"].HeaderText = "Furniture ID";
            this.searchDataGridView.Columns["QuantityOnHand"].HeaderText = "Qty. Avialable";




        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string style = "";
                string category = "";
                int? id = null;

                if (this.styleComboBox.SelectedItem != null)
                {
                    style = this.styleComboBox.Text;
                }
                if (this.categoryComboBox.SelectedItem != null)
                {
                    category = this.categoryComboBox.Text;
                }
                if (this.idComboBox.SelectedItem != null)
                {
                    id = int.Parse(this.idComboBox.Text);
                }

                List<Furniture> furnitures = FurnitureController.GetFurnitureByParameter(
                    style,
                    category,
                    id);

                this.alreadyInCartPanel.Visible = false;
                this.ManualDatabind(furnitures);
                this.BlackListCartItmes();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        
        private void RefreshSearchComboBoxes()
        {
            List<FurnitureStyle> furnitureStyles = StyleController.GetAllStyles();
            this.styleComboBox.DisplayMember = "Style";
            this.styleComboBox.DataSource = furnitureStyles;
            this.styleComboBox.ValueMember = "Style";

            this.styleComboBox.SelectedItem = null;
            this.styleComboBox.SelectedText = "-Styles-";

            List<FurnitureCategory> furnitureCategories = CategoryController.GetAllCategories();
            this.categoryComboBox.DisplayMember = "Category";
            this.categoryComboBox.DataSource = furnitureCategories;
            this.categoryComboBox.ValueMember = "Category";

            this.categoryComboBox.SelectedItem = null;
            this.categoryComboBox.SelectedText = "-Categories-";

            List<Furniture> furnitures = FurnitureController.GetAllFurnitures();
            this.idComboBox.DataSource = furnitures;
            this.idComboBox.DisplayMember = "FurnitureID";
            this.idComboBox.ValueMember = "FurnitureID";

            this.idComboBox.SelectedItem = null;
            this.idComboBox.SelectedText = "-Furniture ID-";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.RefreshSearchComboBoxes();
            this.alreadyInCartPanel.Visible = false;
            this.searchDataGridView.DataSource = null;
            this.RefreshDataGrid();
            this.BlackListCartItmes();

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Makes a Cart, if one didnt already exist
                if (FurnitureController.CurrentCart == null)
                {
                    FurnitureController.CurrentCart = new Cart();
                }
                if ((Furniture)this.searchDataGridView.SelectedRows[0].DataBoundItem == null) {
                    throw new Exception("You must search for, and then select a piece of furniture on the list");
                }

               
                Furniture selectedFurniture = (Furniture)this.searchDataGridView.SelectedRows[0].DataBoundItem;
                bool quantityWasAvailable = FurnitureController.CurrentCart.AddFurnitureToCart(selectedFurniture, Decimal.ToInt32(this.qtyUpDown.Value));
                if (!quantityWasAvailable)
                {
                    MessageBox.Show("Not Enough inventory to facilitate this request. Please choose something else to rent", "Oh- No!");
                    this.AddToCartGroupBox.Enabled = false;
                }

                this.alreadyInCartPanel.Visible = false;
                this.ViewCartButton.Enabled = true;
                this.RefreshDataGrid();
                this.BlackListCartItmes();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Error!");
                this.RefreshDataGrid();
                this.BlackListCartItmes();
            }
        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            
            if (FurnitureController.CurrentCart != null) {

                Form CartDialog = new CartDialog();

                // this will be HUGE in a bit
                var result = CartDialog.ShowDialog();

                
                this.RefreshSearchComboBoxes();
                this.searchDataGridView.DataSource = null;
                this.RefreshDataGrid();
                this.alreadyInCartPanel.Visible = false;

            } else {
                //you need to add something to the cart
                MessageBox.Show("There is nothing in your Cart!");
            }
        
        }


        private void AbandonCartButton_Click(object sender, EventArgs e)
        {
            if (FurnitureController.CurrentCart != null)
            {
               


                // FurnitureController.CurrentCart.PutFurnitureBackIntoInventory();
                
                this.AddToCartGroupBox.Enabled = false;
                this.RefreshSearchComboBoxes();
                this.WhiteListCartItmes();
                FurnitureController.CurrentCart = null;
            }
           
        }

        //. todo: duplicate,clean up after merge
        private void RefreshDataGrid() {
          
            try
            {
                string style = "";
                string category = "";
                int? id = null;

                if (this.styleComboBox.SelectedItem != null)
                {
                    style = this.styleComboBox.Text;
                }
                if (this.categoryComboBox.SelectedItem != null)
                {
                    category = this.categoryComboBox.Text;
                }
                if (this.idComboBox.SelectedItem != null)
                {
                    id = int.Parse(this.idComboBox.Text);
                }

                List<Furniture> furnitures = FurnitureController.GetFurnitureByParameter(
                    style,
                    category,
                    id);


                this.ManualDatabind(furnitures);
                this.BlackListCartItmes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MouseEventActions() {
            int currentRow = this.searchDataGridView.CurrentCell.RowIndex;
            if (searchDataGridView.Rows[currentRow].DefaultCellStyle.BackColor == Color.OrangeRed)
            {
                this.alreadyInCartPanel.Visible = true;
                this.AddToCartGroupBox.Enabled = false;
                this.searchDataGridView.ClearSelection();
            }
            else
            {
                decimal qty = Convert.ToDecimal(searchDataGridView.Rows[currentRow].Cells[5].Value);
                _ = qty > 0 ? this.qtyUpDown.Maximum = qty : this.qtyUpDown.Maximum = 1;
                if (qty == 0) {
                    this.AddToCartGroupBox.Enabled = false;
                    this.QtyZeroLabel.Visible = true;
                } else {
                    this.AddToCartGroupBox.Enabled = true;
                    this.QtyZeroLabel.Visible = false;
                }
                                   
                this.alreadyInCartPanel.Visible = false;
            }
        }

        //overloading the mouse click envents in order to achieve consistancy in row selection
        private void searchDataGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e) => this.MouseEventActions();
        //overloading the mouse click envents in order to achieve consistancy  in row selection
        private void searchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) => this.MouseEventActions();
      
        private void searchDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.AddToCartGroupBox.Enabled = false;
            this.searchDataGridView.ClearSelection();
        }

        private void BlackListCartItmes() {

            if (FurnitureController.CurrentCart != null) {
                FurnitureController.CurrentCart.FurnitureList.ForEach((item) => {

                    foreach (DataGridViewRow row in searchDataGridView.Rows) {
                        if (row.Cells[0].Value.Equals(item.FurnitureID)) {
                            searchDataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.OrangeRed;
                        }
                    }

                });
            }
            this.AddToCartGroupBox.Enabled = false;
            this.searchDataGridView.ClearSelection();
        }

        private void WhiteListCartItmes()
        {
            if (FurnitureController.CurrentCart != null)
            {
                FurnitureController.CurrentCart.FurnitureList.ForEach((item) =>
                {
                    foreach (DataGridViewRow row in searchDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.Equals(item.FurnitureID))
                        {
                            searchDataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                });
            }

            this.searchDataGridView.ClearSelection();
            this.AddToCartGroupBox.Enabled = false;
            this.ViewCartButton.Enabled = false;
        }

    

     
       
    }
}
