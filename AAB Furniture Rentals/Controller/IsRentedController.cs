using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{

    public static class IsRentedController

    {
        private static IsRentedDAL localIsRentedDAL;

        static IsRentedController()
        {
            localIsRentedDAL = new IsRentedDAL();
        }

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
