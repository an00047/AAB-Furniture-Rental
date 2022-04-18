

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
        public List<Rental> GetAllRentalsByCustomerID(int customerID)
        {
     
            string selectStatement =
              "SELECT transactionID, timeStamp, dueDate " +
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
                            currentRental.TransactionID = (int)reader["transactionID"];
                            currentRental.TimeStamp = (DateTime)reader["timeStamp"];
                            currentRental.DueDate =(DateTime)reader["dueDate"];
                            allRentals.Add(currentRental);

                        }

                    }

                }


                return allRentals;

            }
        }

    }
}
