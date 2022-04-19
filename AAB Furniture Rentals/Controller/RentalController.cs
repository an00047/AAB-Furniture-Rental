using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    ///   /// Controls the Rental data
    /// </summary>

    public static class RentalController
    {
            private static RentalsDAL localRentalsDAL;

            static RentalController()
            {
                localRentalsDAL = new RentalsDAL();
            }

            /// <summary>
            /// Gets the rental by transaction identifier.
            /// </summary>
            /// <param name="newTransactionID">The new transaction identifier.</param>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException">newTransactionID cannot be negative</exception>
            public static Rental GetRentalByTransactionID(int newTransactionID)
            {
                if (newTransactionID < 0)
                {
                    throw new ArgumentException("newTransactionID cannot be negative");
                }
                return localRentalsDAL.GetRentalByTransactionID(newTransactionID);
            }

        /// <summary>
        /// GetAllRentals for given customer
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




