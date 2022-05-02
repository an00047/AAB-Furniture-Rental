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

        private List<int> ListOfRowsAddedToCart;

        /// <summary>
        /// Constrouctor method for the employeeUser furniture control
        /// </summary>
        public EmployeeFurnitureUserControl()
        {
            InitializeComponent();
          
            this.ViewCartButton.Enabled = false;
            ListOfRowsAddedToCart = new List<int>();
           
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

            this.searchDataGridView.DataSource = furnitures;

            
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

                this.searchDataGridView.DataSource = furnitures;
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
            this.searchDataGridView.DataSource = null;
            this.RefreshDataGrid();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (FurnitureController.CurrentCart == null)
                {
                    // make a new cart object, store it in the controller
                 
                    FurnitureController.CurrentCart = new Cart();
                }
                if ((Furniture)this.searchDataGridView.SelectedRows[0].DataBoundItem == null) {
                    throw new Exception("You must search for, and then select a piece of furniture on the list");
                }

               
                Furniture selectedFurniture = (Furniture)this.searchDataGridView.SelectedRows[0].DataBoundItem;
                FurnitureController.CurrentCart.AddFurnitureToCart(selectedFurniture, Decimal.ToInt32(this.qtyUpDown.Value));
                DisableRowThatHasBeenAddedToCart();


                this.RefreshDataGrid();
                
            }
            catch (Exception ex) {
                FurnitureController.CurrentCart = null;
                MessageBox.Show(ex.Message, "Error!");
                this.RefreshDataGrid();
            }

        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            
            if (FurnitureController.CurrentCart != null) {

                Form CartDialog = new CartDialog();
                CartDialog.ShowDialog();

                
                this.RefreshSearchComboBoxes();
                this.searchDataGridView.DataSource = null;
                this.RefreshDataGrid();
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
                FurnitureController.CurrentCart = null;
                this.RefreshSearchComboBoxes();

              

            }
            this.ListOfRowsAddedToCart.ForEach((rowindex) => {
                searchDataGridView.Rows[rowindex].DefaultCellStyle.BackColor = Color.White;
            });
            this.ListOfRowsAddedToCart.Clear();
            this.searchDataGridView.ClearSelection();
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


                this.searchDataGridView.DataSource = furnitures;

                //If we ever SORT rows, this will break.
                this.ListOfRowsAddedToCart.ForEach((rowindex)=>{
                    searchDataGridView.Rows[rowindex].DefaultCellStyle.BackColor = Color.OrangeRed;
                    this.searchDataGridView.ClearSelection();
                });
                //this.ViewCartButton.Enabled = false;
                this.searchDataGridView.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableRowThatHasBeenAddedToCart() {


            //int currentRow = this.searchDataGridView.CurrentCell.RowIndex;
            //searchDataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Color.OrangeRed;
            //this.searchDataGridView.ClearSelection();

            int currentRow = this.searchDataGridView.CurrentCell.RowIndex;
            if (currentRow >= 0)
            {
                //check if theindex is in thelist
                if (!this.ListOfRowsAddedToCart.Contains(currentRow))
                {
                    //store the index in a list
                    this.ListOfRowsAddedToCart.Add(currentRow);
                    //Turn it grey becasue it has been added to the cart / List
                    searchDataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Color.OrangeRed;
                    this.searchDataGridView.ClearSelection();
                    //
                }
            }
        }


        private void searchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = this.searchDataGridView.CurrentCell.RowIndex;
            if (searchDataGridView.Rows[currentRow].DefaultCellStyle.BackColor == Color.OrangeRed)
            {
                this.AddToCartGroupBox.Enabled = false;
            }
            else
            {
                this.AddToCartGroupBox.Enabled = true;
            }
        }

        private void searchDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.searchDataGridView.ClearSelection();
        }
    }
}
