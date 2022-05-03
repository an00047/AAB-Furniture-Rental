using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Returns.DAL
{
    class InsertReturnDAL
    {

        public int InsertReturnTransaction(Returns newReturn, List<IsReturnedModel> isReturnedList)
        {
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

