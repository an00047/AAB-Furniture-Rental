using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all employee related queries
    /// </summary>
    public static class EmployeeController
    {

        /// <summary>
        /// Initializes the <see cref="EmployeeController"/> class.
        /// </summary>
        static EmployeeController()
        {
        }

        /// <summary>
        /// Validates the employee login.
        /// </summary>
        /// <returns>True if the login credentials correspond to valid Employee</returns>
        public static bool ValidateEmployeeLogin()
        {
            return true;
        }
        /// <summary>
        /// Validates the admin login.
        /// </summary>
        /// <returns>True if the login credentials correspond to valid system admin</returns>
        public static bool ValidateAdminLogin()
        {
            return true;
        }

    }
}
