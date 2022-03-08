using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    /// <summary>
    /// The Login Form that allows for an employee's credentials to be entered
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginCredentials : Form
    {
        LoginSelector loginSelectorInstance;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCredentials"/> class.
        /// </summary>
        /// <param name="selectorInstance">The selector instance.</param>
        public LoginCredentials(LoginSelector selectorInstance)
        {
            InitializeComponent();
            loginSelectorInstance = selectorInstance;
            this.LoginAsLabel.Text = selectorInstance.employeeSelection + " Login:";
        }

        private void LoginAsBtn_Click(object sender, EventArgs e)
        {
            if (this.loginSelectorInstance.employeeSelection == "Employee")
            {
                if (Controller.EmployeeController.ValidateEmployeeLogin())
                {
                    //After Validating they are an Employee, do somthing...
                    MessageBox.Show("Hi Employee");
                }
                else
                {
                    // After Failed Employee Validation, do something...
                }
            }
            else if (this.loginSelectorInstance.employeeSelection == "Admin")
            {
                if (Controller.EmployeeController.ValidateAdminLogin())
                {
                    //After Validating they are an Admin, do somthing...
                    MessageBox.Show("Hi Admin");
                }
                else
                {
                    // After Failed Admin Validation, do something...
                }
            }

        }


        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.loginSelectorInstance.Show();
        }



        private void LoginCredentials_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

    }
}
