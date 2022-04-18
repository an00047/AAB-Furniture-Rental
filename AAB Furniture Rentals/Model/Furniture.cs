
namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// the furniture Object model class
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// the furniture key in the DB
        /// </summary>
        public int FurnitureID { get; set; }
        /// <summary>
        /// the style of the furniture
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// the category of the furniture
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// the Description of the furniture object
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// the daily rental rate of the funiture object
        /// </summary>
        public double DailyRentalRate { get; set; }
        /// <summary>
        /// the number of furniture 
        /// </summary>
        public int QuantityOnHand { get; set; }
        /// <summary>
        /// the cost for each day the furniture is late
        /// </summary>
        public double FineRate { get; set; }

        /// <summary>
        /// constructor method for the furniture object model
        /// </summary>
        /// <param name="furnitureID"></param>
        /// <param name="style"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="dailyRentalRate"></param>
        /// <param name="quantityOnHand"></param>
        /// <param name="fineRate"></param>
        public Furniture(
            int furnitureID,
            string style,
            string category,
            string description,
            double dailyRentalRate,
            int quantityOnHand,
            double fineRate
           
            )
    {
            this.FurnitureID = furnitureID;
            this.Style = style;
            this.Category = category;
            this.Description = description;
            this.DailyRentalRate = dailyRentalRate;
            this.QuantityOnHand = quantityOnHand;
            this.FineRate = fineRate;
    }

        public Furniture() { }

}
}
