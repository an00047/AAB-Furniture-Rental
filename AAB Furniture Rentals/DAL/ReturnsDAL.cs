using AAB_Furniture_Rentals.Model;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// handler for the rentals table inthe DB
    /// </summary>
    class ReturnsDAL
    {
        /// <summary>
        /// Gets the return by transaction identifier.
        /// </summary>
        /// <param name="transactionID">The transaction identifier.</param>
        /// <returns>The return with the matching transaction identifier</returns>
        public Returns GetReturnByTransactionID(int transactionID)
        {
            Returns newReturn = null;
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


                            newReturn = new Returns(
                                 returnTransactionID: _returnTransactionID,
                                 employeeID: _employeeID,
                                 dateTimeCreated: _datetime_created

                                ); ;

                            
                        }
                    }
                }
            }

            return newReturn;
        }
    }
}
