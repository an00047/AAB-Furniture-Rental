using AAB_Furniture_Rentals.Model;
using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    public partial class CartDialog : Form
    {
        Cart currentCart;
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
            this.currentCart.AssistingEmployeeID = Int32.Parse(this.EmployeeTextBox.Text);
            this.currentCart.MemberID = Int32.Parse(this.MemberTextBox.Text);
           
           int transactionID =  this.SendRentalTransaction();
            this.populateIsRentedList(transactionID);
            this.InsertIsRentedList();

        }

        private void AbandonCartButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// returns the rentalID, which is used to populate the  isRented List
        /// </summary>
        /// <returns></returns>
        private int SendRentalTransaction() { 
            //s

        }
        private void populateIsRentedList(int transactionID) { 
        }
    }
}
