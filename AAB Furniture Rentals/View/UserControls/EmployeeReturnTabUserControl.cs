using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
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
        private List<Furniture> AllFurniture;
        private List<Rental> AllRentals;
        private List<Furniture> SelectedItems;
        /// <summary>
        /// Initializes the component. Disables the processReturnButton (you cannot process a return without having selected items to return first)
        /// Enables to getTransactionsButton that will display all transactions from a specific Customer.
        /// </summary>
        public EmployeeReturnTabUserControl()
        {
            InitializeComponent();
            this.getTransactionsButton.Enabled = true;
            this.processReturnButton.Enabled = false;
            AllRentals = new List<Rental>();
            AllFurniture = new List<Furniture>();

            Fees = 0;
            Refund = 0;
        }

        private void ProcessReturnButton_Click(object sender, EventArgs e)
        {
            //Process the selected items for the return...
        }

        private void calculcateFees(Furniture currentFurniture)
        {

            if (currentFurniture.DueDate < DateTime.Now)
            {
                TimeSpan daysOverDue = currentFurniture.DueDate.Date - DateTime.Now.Date;


                Fees += currentFurniture.FineRate * (double)daysOverDue.TotalDays;
            }
            if (currentFurniture.DueDate > DateTime.Now)
            {
                TimeSpan daysEarly = DateTime.Now.Date - currentFurniture.DueDate.Date;

                Refund += currentFurniture.DailyRentalRate * Math.Abs((double)daysEarly.TotalDays);
            }

        }

        private void getTransactionsButton_Click(object sender, EventArgs e)
        {
            AllRentals.Clear();
            AllFurniture.Clear();

            try
            {
                int customerID = int.Parse(this.idTextBox.Text);
                AllRentals = RentalController.GetAllRentalsByCustomerID(customerID);



                foreach (Rental currentRental in AllRentals)
                {
                    AllFurniture = IsRentedController.GetAllFurnitureByTransactionID(currentRental.TransactionID);


                    foreach (Furniture currentFurniture in AllFurniture)
                    {
                        Furniture tempFurniture = FurnitureController.GetRatesForReturns(currentFurniture);
                        currentFurniture.DailyRentalRate = tempFurniture.DailyRentalRate;
                        currentFurniture.FineRate = tempFurniture.FineRate;
                        currentFurniture.Style = tempFurniture.Style;
                        currentFurniture.Category = tempFurniture.Category;
                        currentFurniture.DueDate = currentRental.DueDate;
                        currentFurniture.TransactionID = currentRental.TransactionID;
                        currentFurniture.RentalDescription = currentRental.TransactionID + " :(1) " + currentFurniture.Style + " " + currentFurniture.Category + "( " + currentFurniture.FurnitureID + " )";

                        for (int i = 0; i < currentFurniture.QuantityRented; i++)
                        {
                            this.itemsReturnedCheckedListBox.Items.Add(currentFurniture, false);
                        }

                        this.getTransactionsButton.Enabled = false;


                    }
                }

                this.itemsReturnedCheckedListBox.DisplayMember = "RentalDescription";




            }
            catch (FormatException)
            {
                MessageBox.Show("ID must be a number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            this.itemsReturnedCheckedListBox.Items.Clear();
            this.feesTextBox.Clear();
            this.refundTextBox.Clear();
            this.getTransactionsButton.Enabled = true;
            this.processReturnButton.Enabled = false;

        }

        private void ItemsReturned_Selected(object sender, EventArgs e)
        {
            try
            {   
                SelectedItems = new List<Furniture>();
       
                foreach (var index in itemsReturnedCheckedListBox.SelectedItems)
                {
                    Furniture tempFurniture = (Furniture)index;
                    this.calculcateFees(tempFurniture);
                    SelectedItems.Add(tempFurniture);

                }
                this.feesTextBox.Text = this.Fees.ToString("#.##");
                this.refundTextBox.Text = this.Refund.ToString("#.##");
                
                if (SelectedItems.Count > 0)
                {
                    this.processReturnButton.Enabled = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
    }


}
