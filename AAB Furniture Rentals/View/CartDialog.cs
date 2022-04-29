using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    /// <summary>
    /// displays the current shopping cart; enables checkout
    /// </summary>
    public partial class CartDialog : Form
    {
        /// <summary>
        /// furniture obect retrieved when a cart item is slected. 
        /// </summary>
        Furniture selectedFurniture;
        Cart currentCart;
        /// <summary>
        /// cartDialog constructor
        /// </summary>
        /// <param name="theCart"></param>
        public CartDialog(Cart theCart)
        {
            InitializeComponent();
            this.currentCart = theCart;
            this.RefreshDataGrid();
        }


        /// <summary>
        /// really cool magical gridhandler that fixes everything
        /// </summary>
        private void RefreshDataGrid() => this.FurnitureDataGridView.DataSource = this.currentCart.FurnitureList;

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            try {

                if (this.EmployeeTextBox.Text == "" || this.MemberTextBox.Text == "") {
                    throw new Exception("Employee and Member ID's cannot be blank");
                }


                int transactionID = this.currentCart.ProcessRentalTransaction(
                    employeeID: Int32.Parse(this.EmployeeTextBox.Text),
                    memberID: Int32.Parse(this.MemberTextBox.Text),
                    dueDate: this.returnDateTimePicker.Value
                    );

                this.currentCart.AddTransactionToIsRentedList(transactionID);
                this.currentCart.ProcessIsRentedList();

                //Show Success Message then Close. 
                MessageBox.Show("Checkout Complete!");
                this.currentCart = null;

                this.Close();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void AbandonCartButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void CartDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            //UNCOMMENT IF UTILIZING SMART CART
            //if (this.currentCart != null && ) {
            //    this.currentCart.PutFurnitureBackIntoInventory();
            //}


        }



        private void FurnitureDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            this.updateQtyPanel.Enabled = true;
            this.selectedFurniture = ((Furniture)this.FurnitureDataGridView.SelectedRows[0].DataBoundItem);

            this.shortNameLabel.Text = selectedFurniture.Style + " " + selectedFurniture.Category;
            this.qtyUpDown.Value = selectedFurniture.QuantityOnHand;
            this.qtyUpDown.Maximum = FurnitureController.GetFurnitureByID(this.selectedFurniture.FurnitureID).QuantityOnHand;
        }

        private void updateQtyButton_Click(object sender, EventArgs e)
        {

            try { 
            Furniture InventoryItem = FurnitureController.GetFurnitureByID(this.selectedFurniture.FurnitureID);

            //check to see if Qty is still available
            if (InventoryItem.QuantityOnHand < (int)qtyUpDown.Value)
            {
                throw new Exception("Not Enough inventory to facilitate this request. Please choose something else to rent");
            }

                ((Furniture)this.FurnitureDataGridView.SelectedRows[0].DataBoundItem).QuantityOnHand = (int)qtyUpDown.Value;
              } catch(Exception ex){

                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.FurnitureDataGridView.DataSource = null;
            this.RefreshDataGrid();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {

            try
            {
             currentCart.FurnitureList.Remove((Furniture)FurnitureDataGridView.SelectedRows[0].DataBoundItem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.FurnitureDataGridView.DataSource = null;
            this.RefreshDataGrid();
        }
    }
}
