

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// Defines an IsRented object
    /// </summary>
    class IsRented
    {
        /// <summary>
        /// Gets or sets the quantity out.
        /// </summary>
        /// <value>
        /// The quantity out.
        /// </value>
        public int QuantityOut { get; set; }
        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        public int TransactionID { get; set; }
        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsRented"/> class.
        /// </summary>
        /// <param name="quantityOut">The quantity out.</param>
        /// <param name="transactionID">The transaction identifier.</param>
        /// <param name="furnitureID">The furniture identifier.</param>
        public IsRented(int quantityOut, int transactionID, int furnitureID)
            {
                this.QuantityOut = quantityOut;
                this.TransactionID = transactionID;
                this.FurnitureID = furnitureID;
            }
     
    }

}

