using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Controller for the RentalsDAL
    /// </summary>

    public static class RentalController
    {
        private static RentalsDAL localRentalsDAL;
        /// <summary>
        /// Initializes the RentalsDAL object 
        /// </summary>
        static RentalController()
        {
            localRentalsDAL = new RentalsDAL();
        }
        /// <summary>
        /// Returns all Rentals from a specifical customerID. Must have a valid customerID.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static List<Rental> GetAllRentalsByCustomerID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }

            return localRentalsDAL.GetAllRentalsByCustomerID(customerID);
        }


    }
}