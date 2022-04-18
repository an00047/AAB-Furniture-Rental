using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;


namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Controller for the IsRented DAL
    /// </summary>
    public static class IsRentedController

    {
        private static IsRentedDAL localIsRentedDAL;
        /// <summary>
        /// Initializes the IsRentedDAL object
        /// </summary>
        static IsRentedController()
        {
            localIsRentedDAL = new IsRentedDAL();
        }

        /// <summary>
        /// Returns all Furniture from the Is_Rented database based on Transaction ID. Must have a valid TransactionID number
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public static List<Furniture> GetAllFurnitureByTransactionID(int transactionID)
        {
            if (!(transactionID > 0))
            {
                throw new Exception("Transaction ID must be a valid number");
            }

            return localIsRentedDAL.GetAllFurnitureByTransactionID(transactionID);
        }


    }
}
