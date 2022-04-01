using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    public partial class EmployeeMainDashboard : Form
    {
        bool logOut;
        LoginCredentials currentLogin;
        public EmployeeMainDashboard(LoginCredentials newLoginCredentials)
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

        private void EmployeeMainDashboard_FormClose(object sender, FormClosedEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }

    }
}
