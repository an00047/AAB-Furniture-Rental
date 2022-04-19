using AAB_Furniture_Rentals.Model;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;


namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// rentals Table handler
    /// </summary>
    class RentalsDAL { 
      /// <summary>
      /// Gets the rentals by transaction identifier.
      /// </summary>
      /// <param name="newTransactionID">The member identifier.</param>
      /// <returns></returns>
    public Rental GetRentalByTransactionID(int newTransactionID)
    {
        Rental rental = null;
        string selectStatement = "SELECT * FROM rentals WHERE rentalTransactionID = @newTransactionID";
        using (SqlConnection connection = RentMeDBConnection.GetConnection())
        {
            connection.Open();
            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {
                selectCommand.Parameters.AddWithValue("@newTransactionID", newTransactionID);
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


                        rental = new Rental(
                            rentalTransactionID: _rentalTransactionID,
                            memberID: _memberID,
                            employeeID: _employeeID,
                            dateTimeCreated: _datetime_created,
                            dateTimeDue: _datetime_due

                            ); ;

                    }
                }
            }
        }

        return rental;
    }
        /// <summary>
        /// Gets all rentals for a given customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<Rental> GetAllRentalsByCustomerID(int customerID)
        {

            string selectStatement =
              "SELECT rentalTransactionID, dateTime_created, dateTime_due " +
              "FROM Rentals " +
              "WHERE memberID = @customerID ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {

                List<Rental> allRentals = new List<Rental>();
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@customerID", customerID);
                    selectCommand.Parameters["@customerID"].Value = customerID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Rental currentRental = new Rental();
                            currentRental.MemberID = customerID;
                            currentRental.RentalTransactionID = (int)reader["rentalTransactionID"];
                            currentRental.DateTimeCreated = (DateTime)reader["dateTime_created"];
                            currentRental.DateTimeDue = (DateTime)reader["dateTime_due"];
                            allRentals.Add(currentRental);

                        }

                    }

                }


                return allRentals;
            }
        }
        /// <summary>
        /// insert New Rental transaction into the DB
        /// </summary>
        /// <param name="newRental"></param>
        /// <returns></returns>
        internal int InsertNewRentalTransaction(Rental newRental)
        {
            string query = "INSERT INTO " +
              "rentals (memberId, employeeID, datetime_due) " +
              "OUTPUT Inserted.rentalTransactionID " +
              "VALUES(@MEMBER_ID, @EMPLOYEE_ID, @DUE_DATE) ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.AddWithValue("@MEMBER_ID", newRental.MemberID);
                    command.Parameters.AddWithValue("@EMPLOYEE_ID", newRental.EmployeeID);
                    command.Parameters.AddWithValue("@DUE_DATE", newRental.DueDate);


                    return (int)command.ExecuteScalar();


                }
            }
        }
    }
}
