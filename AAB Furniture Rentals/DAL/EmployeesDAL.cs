using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.DAL
{
    class EmployeesDAL
    {

        /// <summary>
        /// Gets all Employees.
        /// </summary>
        /// <returns>A list of all Employees </returns>
        public List<Employee> GetAllEmployees()
        {

            List<Employee> EmployeeList = new List<Employee>();

            string selectStatement = "SELECT * FROM Employees";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int employeeID = reader.GetOrdinal("employeeID");
                        int fname = reader.GetOrdinal("fname");
                        int lname = reader.GetOrdinal("lname");
                        int sex = reader.GetOrdinal("sex");
                        int dob = reader.GetOrdinal("dob");
                        int address = reader.GetOrdinal("address");
                        int city = reader.GetOrdinal("city");
                        int state = reader.GetOrdinal("state");
                        int zip = reader.GetOrdinal("zip");
                        int phone = reader.GetOrdinal("phone");
                        int active = reader.GetOrdinal("active");
                        int login_data_username = reader.GetOrdinal("login_data_username");

                        while (reader.Read())
                        {

                            string _employeeID = reader.GetString(employeeID);
                            string _fname = reader.GetString(fname);
                            string _lname = reader.GetString(lname);
                            string _sex = reader.GetString(sex);
                            DateTime _dob = reader.GetDateTime(dob);
                            string _address = reader.GetString(address);
                            string _city = reader.GetString(city);
                            string _state = reader.GetString(state);
                            string _zip = reader.GetString(zip);
                            string _phone = reader.GetString(phone);
                            bool _active = reader.GetBoolean(active);
                            string _login_data_username = reader.GetString(login_data_username);


                            Employee Employee = new Employee(
                                employeeID: _employeeID.Trim(),
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
                                login_data_username: _login_data_username.Trim()
                                );

                            EmployeeList.Add(Employee);
                        }
                    }
                }
            }

            return EmployeeList;
        }


    }
}
