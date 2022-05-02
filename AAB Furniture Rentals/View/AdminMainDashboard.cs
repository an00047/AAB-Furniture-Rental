using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    /// <summary>
    /// the Main admin dashboard that holds various user controls
    /// </summary>
    public partial class AdminMainDashboard : Form

    {
        bool logOut;
        LoginCredentials currentLogin;
        /// <summary>
        /// constructor method for the main admin dashboard
        /// </summary>
        /// <param name="newLoginCredentials"></param>
        public AdminMainDashboard(LoginCredentials newLoginCredentials)
        {
            //Get Name from Database after logging in.
            
            InitializeComponent();
            this.currentLogin = newLoginCredentials;
            Controller.EmployeeController.CurrentEmployee = newLoginCredentials.CurrentEmployee;

            this.EmployeeNameValue.Text = Controller.EmployeeController.CurrentEmployee.Lname + ", " + Controller.EmployeeController.CurrentEmployee.Fname;
            this.EmployeeIDValue.Text = Controller.EmployeeController.CurrentEmployee.EmployeeID.ToString();
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
