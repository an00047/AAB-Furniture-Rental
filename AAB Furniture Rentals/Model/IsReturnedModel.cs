namespace AAB_Furniture_Rentals.Model
{
    internal class IsReturnedModel
    {
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

        /// <summary>
        /// empty constructor method. 
        /// </summary>
        public IsReturnedModel() { }

    }
}
