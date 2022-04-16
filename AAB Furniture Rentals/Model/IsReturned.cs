using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// The representation of a IsReturned item from the database
    /// </summary>
    public class IsReturned
    {
        public int QuantityIn { get; set; }
        public int IsRentedTransactionID { get; set; }
        public int IsRentedFurnitureID { get; set; }
        public int ReturnTransactionID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsReturned"/> class.
        /// </summary>
        /// <param name="quantityIn">The quantity in.</param>
        /// <param name="isRentedTransactionID">The is rented transaction identifier.</param>
        /// <param name="isRentedFurnitureID">The is rented furniture identifier.</param>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        public IsReturned(int quantityIn, int isRentedTransactionID, int isRentedFurnitureID, int returnTransactionID)
        {
            this.QuantityIn = quantityIn;
            this.IsRentedTransactionID = isRentedTransactionID;
            this.IsRentedFurnitureID = isRentedFurnitureID;
            this.ReturnTransactionID = returnTransactionID;
        }
    }
}
