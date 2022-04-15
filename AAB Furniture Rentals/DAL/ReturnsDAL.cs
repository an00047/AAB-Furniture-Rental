using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.DAL
{
    class ReturnsDAL
    {
        public List<Returns> GetReturnsByTransactionID(int transactionID)
        {
            List<Returns> returns = new List<Returns>();
            string selectStatement = @"SELECT * FROM returns 
                                        WHERE returnTransactionID = @transactionID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@transactionID", transactionID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        var returnTransactionID = reader.GetOrdinal("returnTransactionID");
                        var datetime_created = reader.GetOrdinal("datetime_created");
                        var employeeID = reader.GetOrdinal("employee_employeeID");
                        

                        while (reader.Read())
                        {

                            int _returnTransactionID = reader.GetInt32(returnTransactionID);
                            int _employeeID = reader.GetInt32(employeeID);
                            var _datetime_created = reader.GetDateTime(datetime_created);


                            Returns newReturn = new Returns(
                                 returnTransactionID: _returnTransactionID,
                                 employeeID: _employeeID,
                                 dateTimeCreated: _datetime_created

                                ); ;

                            returns.Add(newReturn);
                        }
                    }
                }
            }

            return returns;
        }
    }
}
