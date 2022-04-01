using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all employee related queries
    /// </summary>
    public static class EmployeeController
    {
        private static EmployeesDAL localEmployeeDAL;
        /// <summary>
        /// Initializes the <see cref="EmployeeController"/> class.
        /// </summary>
        static EmployeeController()
        {
            localEmployeeDAL = new EmployeesDAL();
        }


        public static List<Employee> GetAllEmployees()
        {
            var test = localEmployeeDAL.GetAllEmployees();
            return localEmployeeDAL.GetAllEmployees();
        }

        /// <summary>
    /// Validates the employee login.
    /// </summary>
    /// <returns>True if the login credentials correspond to valid Employee</returns>
    public static bool ValidateEmployeeLogin(string userName, string password)
        {
            return localEmployeeDAL.ValidateEmployeeLogin( userName,  password);
        }
        /// <summary>
        /// Validates the admin login.
        /// </summary>
        /// <returns>True if the login credentials correspond to valid system admin</returns>
        public static Employee GetEmployeeByUserName(string userName)
        {
           return localEmployeeDAL.GetEmployeeByUserName(userName);
           
        }

    }
}
