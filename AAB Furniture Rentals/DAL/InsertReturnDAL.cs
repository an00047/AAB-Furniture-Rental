﻿using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Returns.DAL
{

    /// <summary>
    /// Responsible for inserting returns into the database
    /// </summary>
    class InsertReturnDAL
    {
        /// <summary>
        /// Inserts the return transaction.
        /// </summary>
        /// <param name="newReturn">The new return.</param>
        /// <param name="isReturnedList">The is return list.</param>
        public int InsertReturnTransaction(Returns newReturn, List<IsReturnedModel> isReturnedList)
        {
            if (newReturn == null || isReturnedList == null)
            {
                throw new ArgumentException("newReturn and isReturnedList Cannot be empty");
            }
            int ReturnID = 0;
            string query = "INSERT INTO " +
             "Returns (datetime_created, employee_employeeID) " +
             "OUTPUT Inserted.ReturnTransactionID " +
             "VALUES(@DATETIME_CREATED, @EMPLOYEE_ID) ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    
                    command.Parameters.AddWithValue("@DATETIME_CREATED", newReturn.DateTimeCreated);
                    command.Parameters.AddWithValue("@EMPLOYEE_ID", newReturn.EmployeeID);



                    ReturnID = (int)command.ExecuteScalar();


                }
            }

            if (ReturnID > 0)
            {

                isReturnedList.ForEach((entry) =>
                {

                    string isReturnedQuery = "INSERT INTO " +
                "is_returned (returns_returnTransactionID, quantityIn, is_rented_transactionID, is_rented_furnitureID) " +
                "VALUES(@RETURNTRANSACTION_ID, @QUANTITY_IN, @ISRENTED_TRANSACTION_ID, @ISRENTED_FURNITURE_ID) ";

                    using (SqlConnection connection = RentMeDBConnection.GetConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(isReturnedQuery, connection))

                        {
                            command.Parameters.AddWithValue("@RETURNTRANSACTION_ID", ReturnID);
                            command.Parameters.AddWithValue("@QUANTITY_IN", entry.QuantityIn);
                            command.Parameters.AddWithValue("@ISRENTED_TRANSACTION_ID", entry.IsRentedTransactionID);
                            command.Parameters.AddWithValue("@ISRENTED_FURNITURE_ID", entry.IsRentedFurnitureID);
                            command.ExecuteScalar();
                        }
                    }

                    string updateFurnitureQuery =
                       "UPDATE furniture SET quantity = furniture.quantity + @quantityIn " +
                       "WHERE furniture.furnitureID = @furnitureID ";

                    using (SqlConnection connection = RentMeDBConnection.GetConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(updateFurnitureQuery, connection))

                        {
                            command.Parameters.AddWithValue("@quantityIn", entry.QuantityIn);
                            command.Parameters.AddWithValue("@furnitureID", entry.IsRentedFurnitureID);

                            command.ExecuteScalar();
                        }
                    }


                    string updateIsRentedQuery =
                       "UPDATE is_rented SET quantityOut = is_rented.quantityOut - @quantityIn " +
                       "WHERE is_rented.furnitureID = @furnitureID " +
                       "AND is_rented.transactionID = @transactionID";
                    using (SqlConnection connection = RentMeDBConnection.GetConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(updateIsRentedQuery, connection))

                        {
                            command.Parameters.AddWithValue("transactionID", entry.IsRentedTransactionID);
                            command.Parameters.AddWithValue("@quantityIn", entry.QuantityIn);
                            command.Parameters.AddWithValue("@furnitureID", entry.IsRentedFurnitureID);

                            command.ExecuteScalar();
                        }
                    }
                });

            }


            return ReturnID;
        }
    }
}

