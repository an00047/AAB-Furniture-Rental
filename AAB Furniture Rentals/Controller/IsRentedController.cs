using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Controls the IsRented data 
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
    }
}
