
namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// Defines an IsReturned Object
    /// </summary>
    public class IsReturned
    {
        /// <summary>
        /// Gets or sets the quantity in.
        /// </summary>
        /// <value>
        /// The quantity in.
        /// </value>
        public int QuantityIn { get; set; }
        /// <summary>
        /// Gets or sets the is rented transaction identifier.
        /// </summary>
        /// <value>
        /// The is rented transaction identifier.
        /// </value>
        public int IsRentedTransactionID { get; set; }
        /// <summary>
        /// Gets or sets the is rented furniture identifier.
        /// </summary>
        /// <value>
        /// The is rented furniture identifier.
        /// </value>
        public int IsRentedFurnitureID { get; set; }
        /// <summary>
        /// Gets or sets the return transaction identifier.
        /// </summary>
        /// <value>
        /// The return transaction identifier.
        /// </value>
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
