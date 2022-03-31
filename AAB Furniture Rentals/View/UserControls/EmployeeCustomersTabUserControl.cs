
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View.UserControls
{
    public partial class EmployeeCustomersTabUserControl : UserControl
    {
        public EmployeeCustomersTabUserControl()
        {
            InitializeComponent();
        }

        private void NewCustomerButton_Click(object sender, System.EventArgs e)
        {
            Form newCustomerDialog = new CustomerDialog("Add");
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
            Form editCustomerDialog = new CustomerDialog("Edit");
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
    }
}
