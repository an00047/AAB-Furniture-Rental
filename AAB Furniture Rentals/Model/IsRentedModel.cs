

namespace AAB_Furniture_Rentals.Model
{
    class IsRentedModel
    {
        /// <summary>
        /// the Transaction ID / table Key
        /// </summary>
        public int TransactionID { get; set; }
        /// <summary>
        /// the Furniture id / table key
        /// </summary>
        public int FurnitureID { get; set; }
        /// <summary>
        /// outgoing quantity of this particular piece of furniture
        /// </summary>
        public int QuantityOut { get; set; }

        /// <summary>
        /// empty constructor method. 
        /// </summary>
        public IsRentedModel() { }

    }
}
