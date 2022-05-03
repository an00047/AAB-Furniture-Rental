using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Controls the IsReturned query data
    /// </summary>
    class IsReturnedController
    {
        private static IsReturnedDAL localIsReturnedDAL;

        static IsReturnedController()
        {
            localIsReturnedDAL = new IsReturnedDAL();
        }

        /// <summary>
        /// Gets the is returned by member identifier.
        /// </summary>
        /// <param name="searchMemberID">The search member identifier.</param>
        /// <returns></returns>
        public static List<IsReturned> GetIsReturnedByMemberID(int searchMemberID)
        {
            if (searchMemberID < 0)
            {
                throw new ArgumentException("searchMember cannot be negative");
            }
            return localIsReturnedDAL.GetIsReturnedByMemberID(searchMemberID);
        }
    }
}
