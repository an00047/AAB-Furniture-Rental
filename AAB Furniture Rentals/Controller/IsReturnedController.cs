using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{
    class IsReturnedController
    {
        private static IsReturnedDAL localIsReturnedDAL;

        static IsReturnedController()
        {
            localIsReturnedDAL = new IsReturnedDAL();
        }

        public static List<IsReturned> GetIsReturnedByMemberID(int searchMemberID)
        {
            return localIsReturnedDAL.GetIsReturnedByMemberID(searchMemberID);
        }
    }
}
