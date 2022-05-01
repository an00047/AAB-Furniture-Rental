using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using AAB_Furniture_Rentals.View.Dialogs;
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
        
        /// <summary>
        /// cartDialog constructor
        /// </summary>
        /// <param name="theCart"></param>
        public CartDialog()
        {
            InitializeComponent();
           
            this.returnDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            this.RefreshDataGrid();
            this.CheckMemberSelection();
        }

        private void CheckMemberSelection() {
           
            while (MemberController.CurrentMember == null)
            {
                MessageBox.Show("A member must be selected; Please do so now...");
                SelectShoppingMemberDialog chooseMemberForm = new SelectShoppingMemberDialog();
                chooseMemberForm.ShowDialog();
                
            }

            this.MemberNameValue.Text = MemberController.CurrentMember.FirstName + " " + MemberController.CurrentMember.LastName;
            this.MemberIDValue.Text = MemberController.CurrentMember.MemberID.ToString();
        }

        /// <summary>
        /// really cool magical gridhandler that fixes everything
        /// </summary>
        private void RefreshDataGrid() {

            this.FurnitureDataGridView.DataSource = null;
            this.FurnitureDataGridView.DataSource = FurnitureController.CurrentCart.FurnitureList;
            this.CartTotal.Text = (FurnitureController.CurrentCart.CalculateTotalCost(this.returnDateTimePicker.Value)).ToString("0.00");
            this.fineRate.Text = (FurnitureController.CurrentCart.CalculateDailyFineRate()).ToString("0.00");
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            try {

                CheckMemberSelection();

                FurnitureController.CurrentCart.ProcessInsertRentalTransaction(employeeID: EmployeeController.CurrentEmployee.EmployeeID,
                    memberID: MemberController.CurrentMember.MemberID,
                    dueDate: this.returnDateTimePicker.Value);


                //Show Success Message then Close. 
                MessageBox.Show("Checkout Complete!");
                FurnitureController.CurrentCart = null;

                this.Close();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void AbandonCartButton_Click(object sender, EventArgs e)
        {

            this.Close();

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
            CheckMemberSelection();
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


       
            this.RefreshDataGrid();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {

            try
            {
                FurnitureController.CurrentCart.FurnitureList.Remove((Furniture)FurnitureDataGridView.SelectedRows[0].DataBoundItem);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.updateQtyPanel.Enabled = false;
            this.shortNameLabel.Text = "Nothing Selected";
            this.RefreshDataGrid();
        }

        private void returnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void MemberNameValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectShoppingMemberDialog chooseMemberForm = new SelectShoppingMemberDialog();
            chooseMemberForm.ShowDialog();
            CheckMemberSelection();
        }
    }
}
