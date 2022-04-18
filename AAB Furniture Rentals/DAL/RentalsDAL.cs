

using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// rentals Table handler
    /// </summary>
    class RentalsDAL
    {
        /// <summary>
        /// Returns the transactionID, the time the transaction took place and the dueDate for the transaction
        /// from a specific Transaction based on customer ID
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
                            currentRental.TransactionID = (int)reader["rentalTransactionID"];
                            currentRental.TimeStamp = (DateTime)reader["dateTime_created"];
                            currentRental.DueDate = (DateTime)reader["dateTime_due"];
                            allRentals.Add(currentRental);

                        }

                    }

                }


                return allRentals;

            }
        }

    }
   }   

