

namespace AAB_Furniture_Rentals.Model
{
    class IsRented
    {
            public int QuantityOut { get; set; }
            public int TransactionID { get; set; }
            public int FurnitureID { get; set; }


        public IsRented(int quantityOut, int transactionID, int furnitureID)
            {
                this.QuantityOut = quantityOut;
                this.TransactionID = transactionID;
                this.FurnitureID = furnitureID;
            }
     
    }

}

