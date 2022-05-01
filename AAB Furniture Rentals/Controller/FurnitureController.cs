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
        /// <summary>
        /// holds the current cart object for the member's checkout experiance
        /// </summary>
        public static Cart CurrentCart { get; set; }

        private static FurnitureDAL localFurnitureDAL;
        private static InsertRentalDAL localInsertRentalDAL;
        /// <summary>
        /// Initializes the <see cref="FurnitureController"/> class.
        /// </summary>
        static FurnitureController()
        {
            localFurnitureDAL = new FurnitureDAL();
            localInsertRentalDAL = new InsertRentalDAL();
        }

        /// <summary>
        /// requests all furniture form the associated DAL class
        /// </summary>
        /// <returns></returns>
        public static List<Furniture> GetAllFurnitures()
        {
            return localFurnitureDAL.GetAllFurniture();
        }

        /// <summary>
        /// Inserts the rental transaction.
        /// </summary>
        /// <param name="newRental">The new rental.</param>
        /// <param name="isRentedList">The is rented list.</param>
        /// <exception cref="ArgumentException">
        /// The rental is null
        /// or
        /// The isRentedList is null
        /// </exception>
        internal static void InsertRentalTransaction(Rental newRental, List<IsRentedModel> isRentedList)
        {
            if (newRental == null )
            {
                throw new ArgumentException("The rental is null");
            }
            if (isRentedList == null)
            {
                throw new ArgumentException("The isRentedList is null");

            }

            localInsertRentalDAL.InsertRentalTransaction(newRental, isRentedList);
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
        /// <summary>
        /// Returns the specific furniture rates based on a furniture object from a rental. Must be a valid furniture object.
        /// </summary>
        /// <param name="currentFurniture"></param>
        /// <returns></returns>
        public static Furniture GetRatesForReturns(Furniture currentFurniture)
        {
            if (currentFurniture == null)
            {
                throw new ArgumentException("Furniture is null");
            }

            return localFurnitureDAL.GetRatesForReturns(currentFurniture);
        }
        /// <summary>
        /// gets furniture by ID
        /// </summary>
        /// <param name="searchFurnitureID"></param>
        /// <returns></returns>
        public static Furniture GetFurnitureByID(int searchFurnitureID)
        {
            if (searchFurnitureID < 0)
            {
                throw new ArgumentException("FurnitureID cannot be negative");
            }
            return localFurnitureDAL.GetFurnitureByID(searchFurnitureID);
        }


        ///// <summary>
        ///// gets the furniture item by id
        ///// </summary>
        ///// <param name="furnitureID"></param>
        ///// <returns></returns>
        //public static Furniture GetFurnitureByID(int furnitureID) {
        //    if (furnitureID < 0)
        //    {
        //        throw new ArgumentException("furnitureID cannot be negative");
        //    }
        //    return localFurnitureDAL.GetFurnitureByID(furnitureID);
        //}


        /// <summary>
        /// Updates an existing furniture Item. (Multi-Use)
        /// </summary>
        /// <param name="updatedFurniture"></param>
        public static void UpdateFurnitureItem(Furniture updatedFurniture)
        {
            if (updatedFurniture == null)
            {
                throw new ArgumentException("furniture to update cannot be null");
            }
            localFurnitureDAL.UpdateFurnitureItem(updatedFurniture);
        }
    }
}
