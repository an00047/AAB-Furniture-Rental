
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// isRented handler
    /// </summary>
    class IsRentedDAL
    {
        internal void InsertIsRentedTable(List<IsRentedModel> isRentedList)
        {
            isRentedList.ForEach((entry)=> {

                string query = "INSERT INTO " +
            "is_rented (transactionID, quantityOut, furnitureID) " +
            "VALUES(@TRANS_ID, @QUANTITY, @FURN_ID) ";

                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        command.Parameters.AddWithValue("@TRANS_ID", entry.TransactionID);
                        command.Parameters.AddWithValue("@QUANTITY", entry.QuantityOut);
                        command.Parameters.AddWithValue("@FURN_ID", entry.FurnitureID);

                      command.ExecuteScalar();
                    }
                }


            });
        }

       
    }
}
