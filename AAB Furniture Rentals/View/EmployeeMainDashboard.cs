using System;
using System.Windows.Forms;

namespace AAB_Furniture_Rentals.View
{
    /// <summary>
    /// The main host page for the employyee user interface
    /// </summary>
    public partial class EmployeeMainDashboard : Form
    {

      
        bool logOut;
        LoginCredentials currentLogin;
        /// <summary>
        /// COnstructor method for the employee dashboard
        /// </summary>
        /// <param name="newLoginCredentials"></param>
        public EmployeeMainDashboard(LoginCredentials newLoginCredentials)
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

        private void EmployeeMainDashboard_FormClose(object sender, FormClosedEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }

        private void EmployeeMainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
