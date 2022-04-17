using System;
using System.Collections.Generic;
using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all employee related queries
    /// </summary>
    public static class FurnitureController
    {
        private static FurnitureDAL localFurnitureDAL;
        /// <summary>
        /// Initializes the <see cref="FurnitureController"/> class.
        /// </summary>
        static FurnitureController()
        {
            localFurnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// requests all furniture form the associated DAL class
        /// </summary>
        /// <returns></returns>
        public static List<Furniture> GetAllFurnitures()
        {
            var test = localFurnitureDAL.GetAllFurniture();
            return localFurnitureDAL.GetAllFurniture();
        }

        /// <summary>
        /// Gets the furniture by parameter.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="category">The category.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static List<Furniture> GetFurnitureByParameter(string style, string category, int? id)
        {
            if (style == null || category == null)
            {
                throw new ArgumentException("Style and category cannot be null");
            }
            if (id < 0)
            {
                throw new ArgumentException("ID cannot be negative");
            }
            return localFurnitureDAL.GetFurnitureByParameter(style, category, id);

        }

  

    }
}
