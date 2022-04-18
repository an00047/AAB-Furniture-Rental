
using AAB_Furniture_Rentals.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// isRented handler
    /// </summary>
    public class IsRentedDAL
    {

        public List<Furniture> GetAllFurnitureByTransactionID(int customerID)
        {

            string selectStatement =
              "SELECT furnitureID, quantityOut " +
              "FROM Is_Rented " +
              "WHERE transactionID = @transactionID ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {

                List<Furniture> allFurniture = new List<Furniture>();
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@transactionID", customerID);
                    selectCommand.Parameters["@transactionID"].Value = customerID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Furniture currentFurniture = new Furniture();
                            currentFurniture.FurnitureID = (int)reader["furnitureID"];
                            currentFurniture.QuantityRented = (int)reader["quantityOut"];
                            allFurniture.Add(currentFurniture);

                        }

                    }

                }


                return allFurniture;

            }
        }

    }
}






