using AAB_Furniture_Rentals.Model;

using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// DB handler for the Categories table
    /// </summary>
   public class FurnitureCategoriesDAL
    {
        /// <summary>
        /// Gets all Employees.
        /// </summary>
        /// <returns>A list of all Employees </returns>
        public List<FurnitureCategory> GetAllCategories()
        {

            List<FurnitureCategory> FurnitureCategoryList = new List<FurnitureCategory>();

            string selectStatement = "SELECT * FROM furniture_categories";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                       
                        var category = reader.GetOrdinal("category_type");
                       

                        while (reader.Read())
                        {

                            string _category = reader.GetString(category);



                            FurnitureCategory Category = new FurnitureCategory(_category.Trim());

                            FurnitureCategoryList.Add(Category);
                        }
                    }
                }
            }

            return FurnitureCategoryList;
        }


    }
}
