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
            furnitureStyles.Insert(0, new FurnitureStyle("-Styles-"));
            this.styleComboBox.DisplayMember = "Style";
            this.styleComboBox.DataSource = furnitureStyles;



            List<FurnitureCategory> furnitureCategories = CategoryController.GetAllCategories();
            furnitureCategories.Insert(0, new FurnitureCategory("-Categories-"));
            this.categoryComboBox.DisplayMember = "Category";
            this.categoryComboBox.DataSource = furnitureCategories;

            List<Furniture> furnitures = FurnitureController.GetAllFurnitures();
            furnitures.Insert(0, new Furniture(0, "", "", "", 0, 0, 0));
            this.idComboBox.DataSource = furnitures;
            this.idComboBox.DisplayMember = "FurnitureID";
            this.idComboBox.ValueMember = "FurnitureID";
            
        }

    }
}
