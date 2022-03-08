using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals
{
    public partial class LoginSelector : Form
    {
       public string employeeSelection;
        public LoginSelector()
        {
            InitializeComponent();
        }

        private void LoginAsEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.employeeSelection = "Employee";
            View.LoginCredentials loginCredentials = new View.LoginCredentials(this) ;
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

        private void LoginSelector_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
