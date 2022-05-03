using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.UserControls
{
    /// <summary>
    /// rental user control
    /// </summary>
    public partial class EmployeeRentalsUserControl : UserControl
    {
        /// <summary>
        /// rental control Constructor method. 
        /// </summary>
        public EmployeeRentalsUserControl()
        {
            InitializeComponent();
            this.RentalsRB.Checked = true;
            this.SearchNumric.Minimum = 1;
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
          
            int memberID = int.Parse(this.SearchNumric.Text);
            this.customerTransactionDataGridView.Rows.Clear();
                try
                {
                    if (this.RentalsRB.Checked)
                    {
                        List<IsRented> rentals = IsRentedController.GetIsRentedByMemberID(memberID);
                        if (rentals.Count == 0) {
                            throw new Exception("No Rental Transactions by that member were found. \n Please try again.");
                        }
                        int rentalIndex = 0;
                        rentals.ForEach(currentRental =>
                        {
                            this.customerTransactionDataGridView.Rows.Add();
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["TransactionID"].Value = currentRental.TransactionID;
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["TransactionDate"].Value = RentalController.GetRentalByTransactionID(currentRental.TransactionID).DateTimeCreated.ToString("MM-dd-yy");
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["FurnitureID"].Value = currentRental.FurnitureID;
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["FurnitureStyle"].Value = FurnitureController.GetFurnitureByID(currentRental.FurnitureID).Style;
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["FurnitureCategory"].Value = FurnitureController.GetFurnitureByID(currentRental.FurnitureID).Category;
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["FurnitureDescription"].Value = FurnitureController.GetFurnitureByID(currentRental.FurnitureID).Description;
                            this.customerTransactionDataGridView.Rows[rentalIndex].Cells["QuantityInOut"].Value = currentRental.QuantityOut;
                            rentalIndex++;
                        });
                        rentalIndex = 0;
                    }
                    else if (this.ReturnRB.Checked)
                    {
                        List<IsReturned> isReturned = IsReturnedController.GetIsReturnedByMemberID(memberID);

                        if (isReturned.Count == 0)
                        {
                            throw new Exception("No Return Transactions by that Member were found. \n Please try again.");
                        }
                    int returnIndex = 0;
                        isReturned.ForEach(currentIsReturned =>
                        {
                            this.customerTransactionDataGridView.Rows.Add();
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["TransactionID"].Value = currentIsReturned.ReturnTransactionID;
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["TransactionDate"].Value = ReturnsController.GetReturnByTransactionID(currentIsReturned.ReturnTransactionID).DateTimeCreated.ToString("MM-dd-yy");
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["FurnitureID"].Value = currentIsReturned.IsRentedFurnitureID;
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["FurnitureStyle"].Value = FurnitureController.GetFurnitureByID(currentIsReturned.IsRentedFurnitureID).Style;
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["FurnitureCategory"].Value = FurnitureController.GetFurnitureByID(currentIsReturned.IsRentedFurnitureID).Category;
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["FurnitureDescription"].Value = FurnitureController.GetFurnitureByID(currentIsReturned.IsRentedFurnitureID).Description;
                            this.customerTransactionDataGridView.Rows[returnIndex].Cells["QuantityInOut"].Value = currentIsReturned.QuantityIn;

                            returnIndex++;
                        });
                        returnIndex = 0;
                    }
                } catch(Exception ex){
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }

    }
}
