using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.DAL
{
    public class FurnitureDAL
    {

        /// <summary>
        /// Gets all Furnitures.
        /// </summary>
        /// <returns>A list of all Furnitures </returns>
        public List<Furniture> GetAllFurniture()
        {

            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement = "SELECT * FROM furniture";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        var furnitureID = reader.GetOrdinal("furnitureID");
                        var style_type = reader.GetOrdinal("style_type");
                        var category_type = reader.GetOrdinal("category_type");
                        var description = reader.GetOrdinal("description");
                        var daily_rental_rate = reader.GetOrdinal("daily_rental_rate");
                        var quantity = reader.GetOrdinal("quantity");
                        var fine_rate = reader.GetOrdinal("fine_rate");

                        while (reader.Read())
                        {

                            int _furnitureID = reader.GetInt32(furnitureID);
                            string _style_type = reader.GetString(style_type);
                            string _category_type = reader.GetString(category_type);
                            string _description = reader.GetString(description);
                            double _daily_rental_rate = reader.GetDouble(daily_rental_rate);
                            int _quantity = reader.GetInt32(quantity);
                            double _fine_rate = reader.GetDouble(fine_rate);
                          

                            Furniture Furniture = new Furniture(
                                furnitureID: _furnitureID,
                                style: _style_type.Trim(),
                                category: _category_type.Trim(),
                                description: _description.Trim(),
                                dailyRentalRate: _daily_rental_rate,
                                quantityOnHand: _quantity,
                                fineRate: _fine_rate
                               
                                );

                            furnitureList.Add(Furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }

        public Furniture GetFurnitureByID(int searchFurnitureID)
        {

            Furniture furniture = null;

            string selectStatement = "SELECT * FROM furniture WHERE furnitureID = @furnitureID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@furnitureID", searchFurnitureID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        var furnitureID = reader.GetOrdinal("furnitureID");
                        var style_type = reader.GetOrdinal("style_type");
                        var category_type = reader.GetOrdinal("category_type");
                        var description = reader.GetOrdinal("description");
                        var daily_rental_rate = reader.GetOrdinal("daily_rental_rate");
                        var quantity = reader.GetOrdinal("quantity");
                        var fine_rate = reader.GetOrdinal("fine_rate");

                        while (reader.Read())
                        {

                            int _furnitureID = reader.GetInt32(furnitureID);
                            string _style_type = reader.GetString(style_type);
                            string _category_type = reader.GetString(category_type);
                            string _description = reader.GetString(description);
                            double _daily_rental_rate = Convert.ToDouble(reader.GetDecimal(daily_rental_rate));
                            int _quantity = reader.GetInt32(quantity);
                            double _fine_rate = Convert.ToDouble(reader.GetDecimal(fine_rate));


                            furniture = new Furniture(
                                furnitureID: _furnitureID,
                                style: _style_type.Trim(),
                                category: _category_type.Trim(),
                                description: _description.Trim(),
                                dailyRentalRate: _daily_rental_rate,
                                quantityOnHand: _quantity,
                                fineRate: _fine_rate

                                );

                        }
                    }
                }
            }

            return furniture;
        }


    }
}
