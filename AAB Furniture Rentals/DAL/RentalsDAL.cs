using AAB_Furniture_Rentals.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    class RentalsDAL
    {
        /// <summary>
        /// Gets the rentals by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<Rental> GetRentalsByMemberID(int newMemberID)
        {
            List<Rental> rentals = new List<Rental>();
            string selectStatement = "SELECT * FROM rentals WHERE memberID = @memberID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", newMemberID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        var rentalTransactionID = reader.GetOrdinal("rentalTransactionID");
                        var memberID = reader.GetOrdinal("memberID");
                        var employeeID = reader.GetOrdinal("employeeID");
                        var datetime_created = reader.GetOrdinal("datetime_created");
                        var datetime_due = reader.GetOrdinal("datetime_due");

                        while (reader.Read())
                        {

                            int _rentalTransactionID = reader.GetInt32(rentalTransactionID);
                            int _memberID = reader.GetInt32(memberID);
                            int _employeeID = reader.GetInt32(employeeID);
                            var _datetime_created = reader.GetDateTime(datetime_created);
                            var _datetime_due = reader.GetDateTime(datetime_due);


                            Rental rental = new Rental(
                                rentalTransactionID: _rentalTransactionID,
                                memberID: _memberID,
                                employeeID: _employeeID,
                                dateTimeCreated: _datetime_created,
                                dateTimeDue: _datetime_due

                                ); ;

                            rentals.Add(rental);
                        }
                    }
                }
            }

            return rentals;
        }
      





    }
}
