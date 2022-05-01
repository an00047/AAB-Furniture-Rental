using AAB_Furniture_Rentals.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// Responsible for inserting rentals into the database
    /// </summary>
    class InsertRentalDAL

    {
        /// <summary>
        /// Inserts the rental transaction.
        /// </summary>
        /// <param name="newRental">The new rental.</param>
        /// <param name="isRentedList">The is rented list.</param>
        public void InsertRentalTransaction(Rental newRental, List<IsRentedModel> isRentedList)
        {
            int rentalID = 0;
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


                    rentalID = (int)command.ExecuteScalar();


                }
            }

            if (rentalID > 0)
            {
                 
                isRentedList.ForEach((entry) =>
                {

                    string isRentedQuery = "INSERT INTO " +
                "is_rented (transactionID, quantityOut, furnitureID) " +
                "VALUES(@TRANS_ID, @QUANTITY, @FURN_ID) ";

                    using (SqlConnection connection = RentMeDBConnection.GetConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(isRentedQuery, connection))

                        {
                            command.Parameters.AddWithValue("@TRANS_ID", rentalID);
                            command.Parameters.AddWithValue("@QUANTITY", entry.QuantityOut);
                            command.Parameters.AddWithValue("@FURN_ID", entry.FurnitureID);

                            command.ExecuteScalar();
                        }
                    }

                    string updateFurnitureQuery = 
                       "UPDATE furniture SET quantity = furniture.quantity - @quantityOut " +
                       "WHERE furniture.furnitureID = @furnitureID ";

                    using (SqlConnection connection = RentMeDBConnection.GetConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(updateFurnitureQuery, connection))

                        {
                            command.Parameters.AddWithValue("@quantityOut", entry.QuantityOut);
                            command.Parameters.AddWithValue("@furnitureID", entry.FurnitureID);

                            command.ExecuteScalar();
                        }
                    }
                });

            }
        }
    }
}
