
using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    public partial class EmployeeCustomersTabUserControl : UserControl
    {
     
        private Member currentCustomer;

        public EmployeeCustomersTabUserControl()
        {
            InitializeComponent();
         
            this.editCustomerButton.Enabled = false;
     
        }

        private void NewCustomerButton_Click(object sender, System.EventArgs e)
        {
            Form newCustomerDialog = new CustomerDialog();
            newCustomerDialog.ShowDialog();

        }

        private void EditCustomerButton_Click(object sender, System.EventArgs e)
        {
            
            Form editCustomerDialog = new CustomerDialog(this.currentCustomer);
            DialogResult result = editCustomerDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid(int.Parse(this.customerTextBox.Text));
            }

        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            try
            {

                var customerID = int.Parse(this.customerTextBox.Text);
                this.RefreshDataGrid(customerID);
                this.editCustomerButton.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void RefreshDataGrid(int customerID)
        {   
            List<Member> customerList = new List<Member>();
            currentCustomer = MemberController.GetCustomerByID(customerID);
            customerList.Add(currentCustomer);
            this.customerDataGridView.DataSource = customerList;
        }

        private void CustomerTextBox_Changed(object sender, EventArgs e)
        {
            this.editCustomerButton.Enabled = false;
        }
    }
  }
