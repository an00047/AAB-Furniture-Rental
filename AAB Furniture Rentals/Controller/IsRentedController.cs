using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{
    class IsRentedController
    {
        private static IsRentedDAL localIsRentedDAL;

        static IsRentedController()
        {
            localIsRentedDAL = new IsRentedDAL();
        }

        public static List<IsRented> GetIsRentedByMemberID(int newMemberID)
        {
            return localIsRentedDAL.GetIsRentedByMemberID(newMemberID);
        }
    }
}
