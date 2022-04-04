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

namespace AAB_Furniture_Rentals.View.UserControls
{/// <summary>
/// class that does admin stuff
/// </summary>
    public partial class AdminSearchUpdateAddEmployee : UserControl
    {
        /// <summary>
        /// current employee constructor
        /// </summary>
        private Employee currentEmployee;
        public AdminSearchUpdateAddEmployee()
        {
            InitializeComponent();
            this.RefreshDataGrid();
        }

        /// <summary>
        /// really cool magical gridhandler that fixes everything
        /// </summary>
        private void RefreshDataGrid()
        {    
            this.customerDataGridView.DataSource = EmployeeController.GetAllEmployees();
        }

        /// <summary>
        /// button that searches 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.currentEmployee =  EmployeeController.GetEmployeeByID(int.Parse(this.employeeTextBox.Text));
                
                Form viewEmployeeDialog = new EmployeeDialog(this.currentEmployee);
                
                DialogResult result = viewEmployeeDialog.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    this.RefreshDataGrid();
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Employee ID must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.RefreshDataGrid();
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            Form newEmployeeDialog = new EmployeeDialog();
            newEmployeeDialog.ShowDialog();
            this.RefreshDataGrid();
        }

    }
}
