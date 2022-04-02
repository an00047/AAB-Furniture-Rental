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

namespace AAB_Furniture_Rentals.View.UserControls
{
    public partial class AdminSearchUpdateAddEmployee : UserControl
    {

        private Employee currentEmployee;
        public AdminSearchUpdateAddEmployee()
        {
            InitializeComponent();
            this.editEmployeeButton.Enabled = false;
        }

        private void NewCustomerButton_Click(object sender, System.EventArgs e)
        {
            Form newEmployeeDialog = new EmployeeDialog();
            newEmployeeDialog.ShowDialog();

        }

        private void EditCustomerButton_Click(object sender, System.EventArgs e)
        {

            Form editEmployeeDialog = new EmployeeDialog(this.currentEmployee);
            DialogResult result = editEmployeeDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid(int.Parse(this.employeeTextBox.Text));
            }

        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            try
            {

                var customerID = int.Parse(this.employeeTextBox.Text);
                this.RefreshDataGrid(customerID);
                this.editEmployeeButton.Enabled = true;

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
            currentEmployee = MemberController.GetCustomerByID(customerID);
            customerList.Add(currentEmployee);
            this.customerDataGridView.DataSource = customerList;
        }

        private void CustomerTextBox_Changed(object sender, EventArgs e)
        {
            this.editEmployeeButton.Enabled = false;
        }
    }
}
