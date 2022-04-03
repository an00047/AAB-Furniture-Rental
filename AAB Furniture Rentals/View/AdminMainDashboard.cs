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
    public partial class AdminMainDashboard : Form

       
    {
        bool logOut;
        LoginCredentials currentLogin;
        public AdminMainDashboard(LoginCredentials newLoginCredentials)
        {
            //Get Name from Database after logging in.
            
            InitializeComponent();
            this.currentLogin = newLoginCredentials;
            this.nameLabel.Text = currentLogin.CurrentEmployee.Fname + " " + currentLogin.CurrentEmployee.Lname + " logged in as: " + currentLogin.CurrentEmployee.Username;
            logOut = false;

        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            logOut = true;
            this.currentLogin.LogOut();
            this.Close();
            
            
        }

        private void AdminMainDashboard_FormClose(object sender, FormClosedEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }
    }
}
