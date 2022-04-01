
using AAB_Furniture_Rentals.Controller;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    public partial class EmployeeCustomersTabUserControl : UserControl
    {
        private MemberController memController;
        private Member currentCustomer;
        public EmployeeCustomersTabUserControl()
        {
            InitializeComponent();
            this.memController = new MemberController();
            this.editCustomerButton.Enabled = false;
        }

        private void NewCustomerButton_Click(object sender, System.EventArgs e)
        {
            Form newCustomerDialog = new CustomerDialog();
            DialogResult result = newCustomerDialog.ShowDialog();

            //Add validation
            //if (result == DialogResult.OK)
            //{
            //    //Ok
            //}
            //else if (result == DialogResult.Cancel)
            //{
            //    //Cancel

            //}
        }

        private void EditCustomerButton_Click(object sender, System.EventArgs e)
        {
            
            Form editCustomerDialog = new CustomerDialog(currentCustomer);
            DialogResult result = editCustomerDialog.ShowDialog();

            //Add validation
            //if (result == DialogResult.OK)
            //{
            //    //Ok
            //}
            //else if (result == DialogResult.Cancel)
            //{
            //    //Cancel

            //}
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            try
            {

                var customerID = int.Parse(this.customerTextBox.Text);
                this.RefreshDataGrid(customerID);
                this.editCustomerButton.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void RefreshDataGrid(int customerID)
        {   
      
            List<Member> customerList = new List<Member>();
            currentCustomer = this.memController.GetCustomerByID(customerID);
          
            customerList.Add(this.memController.GetCustomerByID(customerID));
            this.customerDataGridView.DataSource = customerList;}

        private void CustomerTextBox_Changed(object sender, EventArgs e)
        {
            this.editCustomerButton.Enabled = false;

        }
    }
    }
