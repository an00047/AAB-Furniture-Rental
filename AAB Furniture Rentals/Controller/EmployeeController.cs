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

        /// <summary>
        /// Gets teh full list of employees form the database
        /// </summary>
        /// <returns>List of employees</returns>
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
        /// retrieves an employye object form the DAL based on the username
        /// </summary>
        /// <returns>An employee object with appropriate username</returns>
        public static Employee GetEmployeeByUserName(string userName)
        {
           return localEmployeeDAL.GetEmployeeByUserName(userName);
           
        }

        public static void SaveEmployee(Employee newEmployee) {
            localEmployeeDAL.SaveEmployee(newEmployee);
        }

        public static Employee GetEmployeeByID(int employeeID) {
            return localEmployeeDAL.GetEmployeeByID(employeeID);
        }
    }
}
