using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using AAB_Furniture_Rentals.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.UserControls
{
    /// <summary>
    /// Manages the user interface displayed for the furniture search function
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class EmployeeFurnitureUserControl : UserControl
    {
        Cart currentCart;
        
    
        /// <summary>
        /// Constrouctor method for the employeeUser furniture control
        /// </summary>
        public EmployeeFurnitureUserControl()
        {
            InitializeComponent();
            this.currentCart = null;
            this.ViewCartButton.Enabled = false;
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
                if (this.currentCart == null)
                {
                    // make a new cart object
                    this.currentCart = new Cart();
                }
                if ((Furniture)this.searchDataGridView.SelectedRows[0].DataBoundItem == null) {
                    throw new Exception("You must search for, and then select a piece of furniture on the list");
                }
                Furniture selectedFurniture = (Furniture)this.searchDataGridView.SelectedRows[0].DataBoundItem;
                this.currentCart.AddFurnitureToCart(selectedFurniture);

                this.RefreshDataGrid();
                this.ViewCartButton.Enabled = true;
            }
            catch (Exception ex) {
                this.currentCart = null;
                MessageBox.Show(ex.Message, "Error!");
                this.RefreshDataGrid();
            }

        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            
            if (this.currentCart != null) {

                Form CartDialog = new CartDialog(this.currentCart);
                CartDialog.ShowDialog();

                this.currentCart = null;
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
            if (this.currentCart != null)
            {
                this.currentCart.PutFurnitureBackIntoInventory();
                this.currentCart = null;
                this.RefreshSearchComboBoxes();
            }
            this.RefreshDataGrid();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
