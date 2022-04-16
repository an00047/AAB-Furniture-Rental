
namespace AAB_Furniture_Rentals.Model
{
    public class IsReturned
    {
        public int QuantityIn { get; set; }
        public int IsRentedTransactionID { get; set; }
        public int IsRentedFurnitureID { get; set; }
        public int ReturnTransactionID { get; set; }
        public IsReturned(int quantityIn, int isRentedTransactionID, int isRentedFurnitureID, int returnTransactionID)
        {
            this.QuantityIn = quantityIn;
            this.IsRentedTransactionID = isRentedTransactionID;
            this.IsRentedFurnitureID = isRentedFurnitureID;
            this.ReturnTransactionID = returnTransactionID;
        }
    }
}
