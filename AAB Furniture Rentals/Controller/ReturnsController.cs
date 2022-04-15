using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{
    class ReturnsController
    {
        private static ReturnsDAL localReturnsDAL;

        static ReturnsController()
        {
            localReturnsDAL = new ReturnsDAL();
        }

        public static List<Returns> GetReturnsByTransactionID(int transactionID)
        {
            return localReturnsDAL.GetReturnsByTransactionID(transactionID);
        }
    }
}
