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

            List<Furniture> FurnitureList = new List<Furniture>();

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
                            double _daily_rental_rate = Decimal.ToDouble(reader.GetDecimal(daily_rental_rate));
                            int _quantity = reader.GetInt32(quantity);
                            double _fine_rate = Decimal.ToDouble(reader.GetDecimal(fine_rate));
                          

                            Furniture Furniture = new Furniture(
                                furnitureID: _furnitureID,
                                style: _style_type.Trim(),
                                category: _category_type.Trim(),
                                description: _description.Trim(),
                                dailyRentalRate: _daily_rental_rate,
                                quantityOnHand: _quantity,
                                fineRate: _fine_rate
                               
                                );

                            FurnitureList.Add(Furniture);
                        }
                    }
                }
            }

            return FurnitureList;
        }

        public List<Furniture> GetFurnitureByParameter(string style, string category, int? id)
        {

            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement = @"SELECT * FROM furniture 
                       WHERE furnitureID IS NOT NULL ";

            if (style != "")
            {
                selectStatement += "AND furniture.style_type = @style ";
            }

            if (category != "")
            {
                selectStatement += "AND furniture.category_type = @category ";
            }

            if (id != null)
            {
                selectStatement += "AND furniture.furnitureID = @id ";
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())

            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@style", style);

                    selectCommand.Parameters.AddWithValue("@category", category);

                    selectCommand.Parameters.AddWithValue("@id", Convert.ToInt32(id)); 

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
                            double _daily_rental_rate = Decimal.ToDouble(reader.GetDecimal(daily_rental_rate));
                            int _quantity = reader.GetInt32(quantity);
                            double _fine_rate = Decimal.ToDouble(reader.GetDecimal(fine_rate));


                            Furniture Furniture = new Furniture(
                                furnitureID: _furnitureID,
                                style: _style_type.Trim(),
                                category: _category_type.Trim(),
                                description: _description.Trim(),
                                dailyRentalRate: _daily_rental_rate,
                                quantityOnHand: _quantity,
                                fineRate: _fine_rate

                                );

                            FurnitureList.Add(Furniture);
                        }
                    }
                }
            }

            return FurnitureList;
        }


    }
}
