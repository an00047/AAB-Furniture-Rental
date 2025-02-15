﻿using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// manages access to the IsRented Database table
    /// </summary>
    class IsReturnedDAL
    {
        /// <summary>
        /// Gets the is returned by member identifier.
        /// </summary>
        /// <param name="searchMemberID">The search member identifier.</param>
        /// <returns>The list of isReturned items with matching memberID</returns>
        public List<IsReturned> GetIsReturnedByMemberID(int searchMemberID)
        {
            if (searchMemberID < 0)
            {
                throw new ArgumentException("searchMemberID cannot be negative");
            }
            List<IsReturned> returns = new List<IsReturned>();
            string selectStatement = @"SELECT * FROM is_returned
                                        JOIN rentals ON is_returned.is_rented_transactionID = rentals.rentalTransactionID
                                        WHERE rentals.memberID = @memberID
                                        ORDER BY is_returned.is_rented_transactionID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", searchMemberID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        var quantityIn = reader.GetOrdinal("quantityIn");
                        var isRentedTransactionID = reader.GetOrdinal("is_rented_transactionID");
                        var isRentedFurnitureID = reader.GetOrdinal("is_rented_furnitureID");
                        var returnTransactionID = reader.GetOrdinal("returns_returnTransactionID");


                        while (reader.Read())
                        {
                            int _quantityIn = Convert.ToInt32(reader.GetValue(quantityIn));
                            int _isRentedTransactionID = reader.GetInt32(isRentedTransactionID);
                            int _isRentedFurnitureID = reader.GetInt32(isRentedFurnitureID);
                            int _returnTransactionID = reader.GetInt32(returnTransactionID);


                            IsReturned newReturn = new IsReturned(
                                 quantityIn: _quantityIn,
                                 isRentedTransactionID: _isRentedTransactionID,
                                 isRentedFurnitureID: _isRentedFurnitureID,
                                 returnTransactionID: _returnTransactionID
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
