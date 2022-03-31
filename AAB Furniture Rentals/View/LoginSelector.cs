using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAB_Furniture_Rentals.Controller;

namespace AAB_Furniture_Rentals
{
    /// <summary>
    /// The initial screen that enables either an employee or a system Admin to log in
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginSelector : Form
    {
        /// <summary>
        /// The employee/admin selection
        /// </summary>
        public string employeeSelection;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSelector"/> class.
        /// </summary>
        public LoginSelector()
        {
            InitializeComponent();
        }

        private void LoginAsEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.employeeSelection = "Employee";
            View.LoginCredentials loginCredentials = new View.LoginCredentials(this);
            loginCredentials.Show();
            this.Hide();
        }

        private void LoginAsAdminBtn_Click(object sender, EventArgs e)
        {
            this.employeeSelection = "Admin";
            View.LoginCredentials loginCredentials = new View.LoginCredentials(this);
            loginCredentials.Show();
            this.Hide();
        }

        private void LoginSelector_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeController.GetAllEmployees();
        }
    }
}
