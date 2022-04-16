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
    public partial class EmployeeRentalsUserControl : UserControl
    {
        public EmployeeRentalsUserControl()
        {
            InitializeComponent();
        }

        private void EmployeeRentalsUserControl_Load(object sender, EventArgs e)
        {
            this.ResetSearchComboBox();
        }

        private void ResetSearchComboBox()
        {
            this.searchComboBox.Items.Add("Rentals");
            this.searchComboBox.Items.Add("Returns");
            this.searchComboBox.SelectedText = "Search by...";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int memberID = int.Parse(this.searchCustomerIDTextBox.Text);
            
            if (this.searchComboBox.SelectedIndex == 0)
            {
                List<Rental> rentals = RentalController.GetRentalsByMemberID(memberID);
                this.customerTransactionDataGridView.DataSource = rentals;

            } else if (this.searchComboBox.SelectedIndex == 1)
            {
                List<IsReturned> isReturned = IsReturnedController.GetIsReturnedByMemberID(memberID);
                int index = 0;
                isReturned.ForEach(currentIsReturned =>
                {
                    
                    this.customerTransactionDataGridView.Rows[index].Cells["ReturnTransactionID"].Value = currentIsReturned.ReturnTransactionID;
                    this.customerTransactionDataGridView.Rows[index].Cells["DateTimeReturned"].Value = ReturnsController.GetReturnByTransactionID(currentIsReturned.ReturnTransactionID).DateTimeCreated;
                    this.customerTransactionDataGridView.Rows[index].Cells["FurnitureID"].Value = currentIsReturned.IsRentedFurnitureID;
                    this.customerTransactionDataGridView.Rows[index].Cells["FurnitureStyle"].Value = FurnitureController.GetFurnitureByID(currentIsReturned.IsRentedFurnitureID).Style;
                    this.customerTransactionDataGridView.Rows[index].Cells["FurnitureCategory"].Value = FurnitureController.GetFurnitureByID(currentIsReturned.IsRentedFurnitureID).Category;
                    this.customerTransactionDataGridView.Rows[index].Cells["FurnitureDescription"].Value = FurnitureController.GetFurnitureByID(currentIsReturned.IsRentedFurnitureID).Description;
                    this.customerTransactionDataGridView.Rows[index].Cells["QuantityReturned"].Value = currentIsReturned.QuantityIn;



                });
            } else { 
            }
        }

    }
}
