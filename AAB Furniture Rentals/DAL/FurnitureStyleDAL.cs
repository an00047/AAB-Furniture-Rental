using AAB_Furniture_Rentals.Model;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// handler class for interracting with the FurnitureStyle table in the DB
    /// </summary>
    class FurnitureStyleDAL
    {
        /// <summary>
        /// Gets all Styles.
        /// </summary>
        /// <returns>A list of all Styles </returns>
        public List<FurnitureStyle> GetAllStyles()
        {

            List<FurnitureStyle> FurnitureStylesList = new List<FurnitureStyle>();

            string selectStatement = "SELECT * FROM furniture_style";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        var style = reader.GetOrdinal("style_type");


                        while (reader.Read())
                        {

                            string _style = reader.GetString(style);



                            FurnitureStyle Style = new FurnitureStyle(_style.Trim());

                            FurnitureStylesList.Add(Style);
                        }
                    }
                }
            }

            return FurnitureStylesList;
        }

    }
}
