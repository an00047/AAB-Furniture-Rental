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

             
                this.currentCart.ProcessInsertRentalTransaction(
                    employeeID: Int32.Parse(this.EmployeeTextBox.Text), 
                    memberID: Int32.Parse(this.MemberTextBox.Text), 
                    dueDate: this.returnDateTimePicker.Value
                    );

                //Rental newRentaltransaction = new Rental();
                //newRentaltransaction.MemberID = Int32.Parse(this.MemberTextBox.Text);
                //newRentaltransaction.EmployeeID = Int32.Parse(this.EmployeeTextBox.Text);
                //newRentaltransaction.DueDate = this.returnDateTimePicker.Value;

                //this.currentCart.ProcessInsertRentalTransaction(newRentaltransaction);
                ///this.currentCart.ProcessIsRentedList();

                //Show Success Message then Close. 
                MessageBox.Show("Checkout Complete!");
                this.currentCart = null;
              
                this.Close();
                
            } catch(Exception ex) {
               
                MessageBox.Show(ex.Message); 
            }
        }

        private void AbandonCartButton_Click(object sender, EventArgs e)
        {
          
            this.Close();
           
        }

        private void CartDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.currentCart != null) {
                this.currentCart.PutFurnitureBackIntoInventory();
            }
           

        }
    }
}
