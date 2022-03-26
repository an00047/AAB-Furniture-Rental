using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.DAL
{
    class RentalsDAL
    {

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns>A list of all customers </returns>
        public List<Customer> GetAllCustomers()
        {

            List<Customer> customerList = new List<Customer>();

            string selectStatement = "SELECT CustomerID,Name,Address,City,State,ZipCode,Phone,Email FROM Customers";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int name = reader.GetOrdinal("Name");
                        int customerID = reader.GetOrdinal("CustomerID");
                        int address = reader.GetOrdinal("Address");
                        int city = reader.GetOrdinal("City");
                        int state = reader.GetOrdinal("State");
                        int zip = reader.GetOrdinal("ZipCode");
                        int phone = reader.GetOrdinal("Phone");
                        int email = reader.GetOrdinal("Email");

                        while (reader.Read())
                        {

                            string _name = reader.GetString(name);
                            int _customerID = reader.GetInt32(customerID);
                            string _address = reader.GetString(address);
                            string _city = reader.GetString(city);
                            string _state = reader.GetString(state);
                            string _zip = reader.GetString(zip);
                            string _phone = reader.GetString(phone);
                            string _email = reader.GetString(email);

                            Customer customer = new Customer(
                                name: _name,
                                customerID: _customerID,
                                address: _address,
                                city: _city,
                                state: _state,
                                zip: _zip,
                                phone: _phone,
                                email: _email
                                );

                            customerList.Add(customer);
                        }
                    }
                }
            }

            return customerList;
        }







    }
}
