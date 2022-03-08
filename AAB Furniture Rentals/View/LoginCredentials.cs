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
    public partial class LoginCredentials : Form
    {
        LoginSelector loginSelectorInstance;
        public LoginCredentials(LoginSelector selectorInstance)
        {
            InitializeComponent();
            loginSelectorInstance = selectorInstance;
            this.LoginAsLabel.Text = selectorInstance.employeeSelection + " Login:";
        }

        private void LoginAsBtn_Click(object sender, EventArgs e)
        {

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
