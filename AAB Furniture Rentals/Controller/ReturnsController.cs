using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Controls the Returns data
    /// </summary>
    class ReturnsController
    {
        private static ReturnsDAL localReturnsDAL;
        /// <summary>
        /// constructor method
        /// </summary>
        static ReturnsController()
        {
            localReturnsDAL = new ReturnsDAL();
        }

        /// <summary>
        /// Gets the return by transaction identifier.
        /// </summary>
        /// <param name="transactionID">The transaction identifier.</param>
        /// <returns></returns>

        public static Returns GetReturnByTransactionID(int transactionID)
        {
            if(transactionID < 0)
            {
                throw new ArgumentException("transactionID cannot be negative");
            }
            return localReturnsDAL.GetReturnByTransactionID(transactionID);
        }
    }
}
