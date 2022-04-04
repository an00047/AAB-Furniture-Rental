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
        /// Gets the full list of employees form the database
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

        /// <summary>
        /// saveemployee methods interract with the database access layer
        /// </summary>
        /// <param name="newEmployee"></param>
        public static void SaveEmployee(Employee newEmployee) {
            localEmployeeDAL.SaveEmployee(newEmployee);
        }

        /// <summary>
        /// saveEmployee methods interract with the database access layer
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static Employee GetEmployeeByID(int employeeID) {
            return localEmployeeDAL.GetEmployeeByID(employeeID);
        }

        /// <summary>
        /// AddNewEmployee to the database via database access layer.
        /// </summary>
        /// <param name="newEmployee"></param>
        public static void AddNewEmployee(Employee newEmployee)
        {
            localEmployeeDAL.AddEmployee(newEmployee);
        }

        /// <summary>
        ///  Adds user visa the adatabce accesslayer
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void AddUser(string username, string  password) {
            localEmployeeDAL.AddUser(username, password);
        }

  
    }
}
