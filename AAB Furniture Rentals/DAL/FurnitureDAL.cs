using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// DB handler for the funirute table
    /// </summary>
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

        /// <summary>
        /// Gets the furniture by parameters.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="category">The category.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>A list of furniture</returns>
        public List<Furniture> GetFurnitureByParameter(string style, string category, int? id)
        {

            List<Furniture> FurnitureList = new List<Furniture>();

            string selectStatement = @"SELECT *
                       FROM furniture 
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

        /// <summary>
        /// gets furniture by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Furniture GetFurnitureByID(int id) {

            Furniture currentFurniture = null;

            string selectStatement = "SELECT * FROM furniture WHERE furnitureID = @id";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())

            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {
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


                            currentFurniture = new Furniture(
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

            return currentFurniture;


        }

        /// <summary>
        /// UPDATE AN ITEM in the furniture inventory (furniture table)
        /// </summary>
        /// <param name="updatedFurniture"></param>
        public void UpdateFurnitureItem(Furniture updatedFurniture) {

            string query = "UPDATE furniture SET " +
           "style_type=@STYLE, " +
           "category_type=@CATEGORY, " +
           "description=@DESCRIPTION, " +
           "daily_rental_rate=@DAILY_RENTAL_RATE, " +
           "quantity=@QUANTITY,  " +
           "fine_rate=@FINE_ACTIVE " +
           "WHERE furnitureID = @ID ";
         

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.AddWithValue("@ID", updatedFurniture.FurnitureID);
                    command.Parameters.AddWithValue("@STYLE", updatedFurniture.Style);
                    command.Parameters.AddWithValue("@CATEGORY", updatedFurniture.Category );
                    command.Parameters.AddWithValue("@DESCRIPTION", updatedFurniture.Description);
                    command.Parameters.AddWithValue("@DAILY_RENTAL_RATE", updatedFurniture.DailyRentalRate);
                    command.Parameters.AddWithValue("@QUANTITY", updatedFurniture.QuantityOnHand);
                    command.Parameters.AddWithValue("@FINE_ACTIVE", updatedFurniture.FineRate);



                    command.ExecuteScalar();


                }
            }





        }
    }
}
