using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
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

        public static List<Rental> GetRentalsByMemberID(int memberID)
        {
            return localRentalsDAL.GetRentalsByMemberID(memberID);
        }


    }
}



