using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        public static List<FurnitureCategory> GetAllCategories()
        {
            var test = localCategoriesDAL.GetAllCategories();
            return localCategoriesDAL.GetAllCategories();
        }

    }
}
