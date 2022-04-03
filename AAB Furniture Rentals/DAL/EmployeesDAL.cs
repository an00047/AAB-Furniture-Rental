using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAB_Furniture_Rentals.Model;


namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// Data access layer that interracts ONLY with the employee MSSQL table
    /// </summary>
    public class EmployeesDAL
    {

        /// <summary>
        /// Gets all Employees.
        /// </summary>
        /// <returns>A list of all Employees </returns>
        public List<Employee> GetAllEmployees()
        {

            List<Employee> EmployeeList = new List<Employee>();

            string selectStatement = "SELECT * FROM employee";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        var employeeID = reader.GetOrdinal("employeeID");
                        var fname = reader.GetOrdinal("fname");
                        var lname = reader.GetOrdinal("lname");
                        var sex = reader.GetOrdinal("sex");
                        var dob = reader.GetOrdinal("dob");
                        var address = reader.GetOrdinal("address");
                        var city = reader.GetOrdinal("city");
                        var state = reader.GetOrdinal("state");
                        var zip = reader.GetOrdinal("zip");
                        var phone = reader.GetOrdinal("phone");
                        var active = reader.GetOrdinal("active");
                        var login_data_username = reader.GetOrdinal("login_data_username");
                        var admin = reader.GetOrdinal("admin");

                        while (reader.Read())
                        {

                            int _employeeID = reader.GetInt32(employeeID);
                            string _fname = reader.GetString(fname);
                            string _lname = reader.GetString(lname);
                            string _sex = reader.GetString(sex);
                            DateTime _dob = reader.GetDateTime(dob);
                            string _address = reader.GetString(address);
                            string _city = reader.GetString(city);
                            string _state = reader.GetString(state);
                            string _zip = reader.GetString(zip);
                            string _phone = reader.GetString(phone);
                            bool _active = ((int)reader.GetInt16(active) == 1) ? true : false;
                            string _username = reader.GetString(login_data_username);
                            bool _admin = ((int)reader.GetInt16(admin) == 1) ? true : false;


                            Employee Employee = new Employee(
                                employeeID: _employeeID,
                                fname: _fname.Trim(),
                                lname: _lname.Trim(),
                                sex: _sex.Trim(),
                                dob: _dob,
                                address: _address.Trim(),
                                city: _city.Trim(),
                                state: _state.Trim(),
                                zip: _zip.Trim(),
                                phone: _phone.Trim(),
                                active: _active,
                                username: _username.Trim(),
                                admin: _admin
                                );

                            EmployeeList.Add(Employee);
                        }
                    }
                }
            }

            return EmployeeList;
        }

        /// <summary>
        /// checks that the employee credentials exist
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns> true is the employee credentials exist, false otherwise </returns>
        public bool ValidateEmployeeLogin(string userName, string password)
        {
            if (userName == null || password == null)
            {
                throw new ArgumentException("username and password Cannot be empty");
            }

            string validateUserAndPassStatement = "SELECT COUNT(*) FROM login_data WHERE username = @USERNAME and password = @PASSWORD";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand validationCommand = new SqlCommand(validateUserAndPassStatement, connection))
                {
                    validationCommand.Parameters.AddWithValue("@USERNAME", userName);
                    validationCommand.Parameters.AddWithValue("@PASSWORD", password);

                    int count = Convert.ToInt32(validationCommand.ExecuteScalar());
                    return count > 0 ? true : false;

                }
            }
        }

        /// <summary>
        /// Builds an Employee Object based on the database / username information
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>employee Object</returns>
        public Employee GetEmployeeByUserName(string userName)
        {
            Employee currentEmployee = null;

            if (userName == null)
            {
                throw new ArgumentException("username Cannot be empty");
            }
            string selectStatement = "SELECT * FROM employee WHERE login_data_username = @USERNAME";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@USERNAME", userName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        var employeeID = reader.GetOrdinal("employeeID");
                        var fname = reader.GetOrdinal("fname");
                        var lname = reader.GetOrdinal("lname");
                        var sex = reader.GetOrdinal("sex");
                        var dob = reader.GetOrdinal("dob");
                        var address = reader.GetOrdinal("address");
                        var city = reader.GetOrdinal("city");
                        var state = reader.GetOrdinal("state");
                        var zip = reader.GetOrdinal("zip");
                        var phone = reader.GetOrdinal("phone");
                        var active = reader.GetOrdinal("active");
                        var login_data_username = reader.GetOrdinal("login_data_username");
                        var admin = reader.GetOrdinal("admin");

                        while (reader.Read())
                        {

                            int _employeeID = reader.GetInt32(employeeID);
                            string _fname = reader.GetString(fname);
                            string _lname = reader.GetString(lname);
                            string _sex = reader.GetString(sex);
                            DateTime _dob = reader.GetDateTime(dob);
                            string _address = reader.GetString(address);
                            string _city = reader.GetString(city);
                            string _state = reader.GetString(state);
                            string _zip = reader.GetString(zip);
                            string _phone = reader.GetString(phone);
                            bool _active = ((int)reader.GetInt16(active) == 1) ? true : false;
                            string _username = reader.GetString(login_data_username);
                            bool _admin = ((int)reader.GetInt16(admin) == 1) ? true : false;


                            currentEmployee = new Employee(
                                employeeID: _employeeID,
                                fname: _fname.Trim(),
                                lname: _lname.Trim(),
                                sex: _sex.Trim(),
                                dob: _dob,
                                address: _address.Trim(),
                                city: _city.Trim(),
                                state: _state.Trim(),
                                zip: _zip.Trim(),
                                phone: _phone.Trim(),
                                active: _active,
                                username: _username.Trim(),
                                admin: _admin
                                );


                        }
                    }
                }
            }

            return currentEmployee;
        }

        public Employee GetEmployeeByID(int employeeID)
        {
            Employee currentEmployee = null;

            if (employeeID < 0)
            {
                throw new ArgumentException("ID cannot beless than zero");
            }
            string selectStatement = "SELECT * FROM employee WHERE employeeID = @EMPLOYEE_ID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@EMPLOYEE_ID", employeeID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                       
                        var fname = reader.GetOrdinal("fname");
                        var lname = reader.GetOrdinal("lname");
                        var sex = reader.GetOrdinal("sex");
                        var dob = reader.GetOrdinal("dob");
                        var address = reader.GetOrdinal("address");
                        var city = reader.GetOrdinal("city");
                        var state = reader.GetOrdinal("state");
                        var zip = reader.GetOrdinal("zip");
                        var phone = reader.GetOrdinal("phone");
                        var active = reader.GetOrdinal("active");
                        var login_data_username = reader.GetOrdinal("login_data_username");
                        var admin = reader.GetOrdinal("admin");

                        while (reader.Read())
                        {

                            int _employeeID = employeeID;
                            string _fname = reader.GetString(fname);
                            string _lname = reader.GetString(lname);
                            string _sex = reader.GetString(sex);
                            DateTime _dob = reader.GetDateTime(dob);
                            string _address = reader.GetString(address);
                            string _city = reader.GetString(city);
                            string _state = reader.GetString(state);
                            string _zip = reader.GetString(zip);
                            string _phone = reader.GetString(phone);
                            bool _active = ((int)reader.GetInt16(active) == 1) ? true : false;
                            string _username = reader.GetString(login_data_username);
                            bool _admin = ((int)reader.GetInt16(admin) == 1) ? true : false;


                            currentEmployee = new Employee(
                                employeeID: _employeeID,
                                fname: _fname.Trim(),
                                lname: _lname.Trim(),
                                sex: _sex.Trim(),
                                dob: _dob,
                                address: _address.Trim(),
                                city: _city.Trim(),
                                state: _state.Trim(),
                                zip: _zip.Trim(),
                                phone: _phone.Trim(),
                                active: _active,
                                username: _username.Trim(),
                                admin: _admin
                                );


                        }
                    }
                }
            }

            return currentEmployee;
        }
    }
 }
