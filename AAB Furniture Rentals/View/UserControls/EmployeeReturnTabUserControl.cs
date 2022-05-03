using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using AAB_Furniture_Rentals.View.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    /// <summary>
    /// This class is a UserControl for processing the Return functionality
    /// </summary>
    public partial class EmployeeReturnTabUserControl : UserControl
    {

        private double Fees;
        private double Refund;
        private List<Furniture> checkedItems;
        private List<Furniture> AllFurniture;
        private List<Rental> AllRentals;
    
        /// <summary>
        /// Initializes the component. Disables the processReturnButton (you cannot process a return without having selected items to return first)
        /// Enables to getTransactionsButton that will display all transactions from a specific Customer.
        /// </summary>
        public EmployeeReturnTabUserControl()
        {
            InitializeComponent();
        
            this.processReturnButton.Enabled = false;
            AllRentals = new List<Rental>();
            AllFurniture = new List<Furniture>();

            this.checkedItems = new List<Furniture>();
           
            this.Fees = 0.00;
            this.Refund = 0.00;
            this.feesTextBox.Text = this.Fees.ToString("0.00");
            this.refundTextBox.Text = this.Refund.ToString("0.00");
         
     

        }

        private void checkMember()
        {
           
            SelectShoppingMemberDialog chooseMemberForm = new SelectShoppingMemberDialog();
            chooseMemberForm.ShowDialog();            

        }

    

    private void ProcessReturnButton_Click(object sender, EventArgs e)
        {
            if (MemberController.CurrentMember == null)
            {
                MessageBox.Show("Customer not selected. Please select a customer.");
            }
            else
            {
                try
                {
                    if (FurnitureController.CurrentReturnCart == null)
                    {
                        // make a new cart object, store it in the controller

                        FurnitureController.CurrentReturnCart = new ReturnCart();
                    }
                    if (this.checkedItems == null)
                    {
                        throw new Exception("You must select a piece of furniture to return!");
                    }


                    Dictionary<Furniture, int> FurnitureAndAmount = new Dictionary<Furniture, int>();

                    var g = checkedItems.GroupBy(i => i);

                    foreach (var grp in g)
                    {
                        FurnitureAndAmount.Add(grp.Key, grp.Count());
                    }

                    FurnitureController.CurrentReturnCart.AddFurnitureToReturnCart(FurnitureAndAmount);
                    FurnitureController.CurrentReturnCart.ProcessInsertReturnTransaction(employeeID: EmployeeController.CurrentEmployee.EmployeeID,
                    memberID: MemberController.CurrentMember.MemberID);

                    MessageBox.Show("Return successful.");
                    this.processReturnButton.Enabled = false;
                    this.PopulateItems();

                }
                catch (Exception ex)
                {
                    FurnitureController.CurrentCart = null;
                    MessageBox.Show(ex.Message, "Error!");
                    this.PopulateItems();
                }
            }
            
        }

        private void calculcateFees(List<Furniture> selectedFurniture)
        {
            this.Fees = 0.00;
            this.Refund = 0.00;
       
            
            foreach (Furniture currentFurniture in selectedFurniture) {
                if (currentFurniture.DueDate < DateTime.Now)
                {
                    TimeSpan daysOverDue = currentFurniture.DueDate.Date - DateTime.Now.Date;
                    this.Fees += currentFurniture.FineRate * Math.Abs((double)daysOverDue.TotalDays);
                }
                if (currentFurniture.DueDate > DateTime.Now)
                {
                    TimeSpan daysEarly = DateTime.Now.Date - currentFurniture.DueDate.Date;
                    this.Refund += currentFurniture.DailyRentalRate * Math.Abs((double)daysEarly.TotalDays);
                }
            }

        }




        private void ChangeMember_Click(object sender, EventArgs e)
        {
            AllRentals.Clear();
            AllFurniture.Clear();

            try
            {
                this.checkMember();
                this.PopulateItems();

            }
            catch (FormatException)
            {
                MessageBox.Show("ID must be a number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            this.itemsReturnedCheckedListBox.Items.Clear();
            this.feesTextBox.Text = "0.00";
            this.refundTextBox.Text = "0.00";
          
            this.processReturnButton.Enabled = false;

        }

        /// <summary>
        /// Populates the check list box with the current furniture based on the member selected.
        /// </summary>
       public void PopulateItems()
        {
            this.itemsReturnedCheckedListBox.Items.Clear();
           
            AllRentals = RentalController.GetAllRentalsByCustomerID(MemberController.CurrentMember.MemberID);
            foreach (Rental currentRental in AllRentals)
            {
                AllFurniture = IsRentedController.GetAllFurnitureByTransactionID(currentRental.RentalTransactionID);


                foreach (Furniture currentFurniture in AllFurniture)
                {
                    Furniture tempFurniture = FurnitureController.GetRatesForReturns(currentFurniture);
                    currentFurniture.DailyRentalRate = tempFurniture.DailyRentalRate;
                    currentFurniture.FineRate = tempFurniture.FineRate;
                    currentFurniture.Style = tempFurniture.Style;
                    currentFurniture.Category = tempFurniture.Category;
                    currentFurniture.DueDate = currentRental.DateTimeDue;
                    currentFurniture.TransactionID = currentRental.RentalTransactionID;
                    currentFurniture.RentalDescription = "Transaction ID: " + currentRental.RentalTransactionID + " | " + "Furniture ID: " + currentFurniture.FurnitureID + " | (" + currentFurniture.Style + " " + currentFurniture.Category + " )";

                    for (int i = 0; i < currentFurniture.QuantityRented; i++)
                    {
                        this.itemsReturnedCheckedListBox.Items.Add(currentFurniture, false);
                    }

                }
            }

            this.itemsReturnedCheckedListBox.DisplayMember = "RentalDescription";



        }

        private void ItemsReturned_Selected(object sender, ItemCheckEventArgs e)
        {
            try
            {

                this.checkedItems.Clear();
                 foreach (var item in itemsReturnedCheckedListBox.CheckedItems)
                this.checkedItems.Add((Furniture)item);

                if (e.NewValue == CheckState.Checked)
                this.checkedItems.Add((Furniture)itemsReturnedCheckedListBox.Items[e.Index]);
                else
                this.checkedItems.Remove((Furniture)itemsReturnedCheckedListBox.Items[e.Index]);

       
                this.calculcateFees(this.checkedItems);
                this.feesTextBox.Text = this.Fees.ToString("0.00");
                this.refundTextBox.Text = this.Refund.ToString("0.00");
                
                if (this.checkedItems.Count > 0)
                {
                    this.processReturnButton.Enabled = true;
                }
                else
                {
                    this.processReturnButton.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }

    
    }


}
