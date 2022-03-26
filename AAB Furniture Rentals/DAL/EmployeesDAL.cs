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
                        int name = reader.GetOrdinal("Name");
                        int EmployeeID = reader.GetOrdinal("EmployeeID");
                        int address = reader.GetOrdinal("Address");
                        int city = reader.GetOrdinal("City");
                        int state = reader.GetOrdinal("State");
                        int zip = reader.GetOrdinal("ZipCode");
                        int phone = reader.GetOrdinal("Phone");
                        int email = reader.GetOrdinal("Email");

                        while (reader.Read())
                        {

                            string _name = reader.GetString(name);
                            int _EmployeeID = reader.GetInt32(EmployeeID);
                            string _address = reader.GetString(address);
                            string _city = reader.GetString(city);
                            string _state = reader.GetString(state);
                            string _zip = reader.GetString(zip);
                            string _phone = reader.GetString(phone);
                            string _email = reader.GetString(email);

                            Employee Employee = new Employee(
                                name: _name,
                                EmployeeID: _EmployeeID,
                                address: _address,
                                city: _city,
                                state: _state,
                                zip: _zip,
                                phone: _phone,
                                email: _email
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
