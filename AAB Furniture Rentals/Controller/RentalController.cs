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