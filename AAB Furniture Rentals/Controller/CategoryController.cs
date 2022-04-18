using System.Collections.Generic;
using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all employee related queries
    /// </summary>
    public static class CategoryController
    {
        private static FurnitureCategoriesDAL localCategoriesDAL;
        /// <summary>
        /// Initializes the <see cref="CategoryController"/> class.
        /// </summary>
        static CategoryController()
        {
            localCategoriesDAL = new FurnitureCategoriesDAL();
        }
        /// <summary>
        /// gets all categories from the associated DAL class
        /// </summary>
        /// <returns></returns>
        public static List<FurnitureCategory> GetAllCategories()
        {
            var test = localCategoriesDAL.GetAllCategories();
            return localCategoriesDAL.GetAllCategories();
        }

    }
}
