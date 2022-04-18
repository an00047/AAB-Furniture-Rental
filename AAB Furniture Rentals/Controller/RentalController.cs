using AAB_Furniture_Rentals.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{

       public static class RentalController
    {
            private static RentalsDAL localRentalsDAL;

            static RentalController()
            {
                localRentalsDAL = new RentalsDAL();
            }
    }
}
