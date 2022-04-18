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
    public partial class EmployeeReturnTabUserControl : UserControl
    {
        public EmployeeReturnTabUserControl()
        {
            InitializeComponent();
        }

        private void ProcessReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(this.idTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("ID must be a number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
