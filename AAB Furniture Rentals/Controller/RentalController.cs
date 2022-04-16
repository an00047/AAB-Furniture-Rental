using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    public static class RentalController
    {
        private static RentalsDAL localRentalsDAL;

        static RentalController()
        {
            localRentalsDAL = new RentalsDAL();
        }

        public static Rental GetRentalByTransactionID(int newTransactionID)
        {
            if (newTransactionID < 0)
            {
                throw new ArgumentException("newTransactionID cannot be negative");
            }
            return localRentalsDAL.GetRentalByTransactionID(newTransactionID);
        }


    }
}



