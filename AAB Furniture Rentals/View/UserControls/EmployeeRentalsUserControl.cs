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
            this.searchComboBox.Items.Add("All");
            this.searchComboBox.SelectedText = "Search by...";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.searchComboBox.SelectedIndex == 0)
            {

            } else if (this.searchComboBox.SelectedIndex == 1)
            {

            } else { 
            }
        }
    }
}
