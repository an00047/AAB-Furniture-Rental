using AAB_Furniture_Rentals.Controller;
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
           // try {
              
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

                //Show Success Messag then Close. 
                MessageBox.Show("Checkout Complete!");
                this.Close();

         //   }
          //  catch(Exception ex){
          //      MessageBox.Show(ex.Message);
          //  }

        }

        private void AbandonCartButton_Click(object sender, EventArgs e)
        {
            this.currentCart.AbandonCart();

        }
     
    

    }
}
