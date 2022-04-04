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

            } else { 
            }
        }

    }
}
