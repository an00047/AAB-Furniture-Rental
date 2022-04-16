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


        public static List<Furniture> GetAllFurnitures()
        {
            return localFurnitureDAL.GetAllFurniture();
        }

        public static Furniture GetFurnitureByID(int searchFurnitureID)
        {
            if (searchFurnitureID < 0)
            {
                throw new ArgumentException("FurnitureID cannot be negative");
            }
            return localFurnitureDAL.GetFurnitureByID(searchFurnitureID);
        }

  

    }
}
