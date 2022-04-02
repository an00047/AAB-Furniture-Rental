using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.UserControls
{
    public partial class EmployeeFurnitureUserControl : UserControl
    {
        public EmployeeFurnitureUserControl()
        {
            InitializeComponent();
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



        }

        private void SearchButton_Click(object sender, EventArgs e)
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
    }
}
