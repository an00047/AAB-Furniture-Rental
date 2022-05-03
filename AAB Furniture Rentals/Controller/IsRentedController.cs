using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;


namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Standards controller class meant to hold all IsRented queries
    /// </summary>
    class IsRentedController
    {
     
        private static IsRentedDAL localIsRentedDAL;

        static IsRentedController()
        {
            localIsRentedDAL = new IsRentedDAL();
        }

        /// <summary>
        /// Gets the is rented by member identifier.
        /// </summary>
        /// <param name="newMemberID">The new member identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">newMemberID cannot be negative</exception>
        public static List<IsRented> GetIsRentedByMemberID(int newMemberID)
        {
            if (newMemberID < 0)
            {
                throw new ArgumentException("newMemberID cannot be negative");
            }
            return localIsRentedDAL.GetIsRentedByMemberID(newMemberID);
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