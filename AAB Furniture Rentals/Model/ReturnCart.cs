using AAB_Furniture_Rentals.Controller;
using System;
using System.Collections.Generic;


namespace AAB_Furniture_Rentals.Model
{
    public class ReturnCart
    {
        bool activeInventoryFeatureIsON = false;
        /// <summary>
        /// the list of items to be rented in this transaction
        /// </summary>           
        public List<Furniture> FurnitureList { get; set; }


        private List<IsReturnedModel> IsReturnedList;

        public DateTime ReturnedDate { get; private set; }

        /// <summary>
        /// the rental transactionID after checkout
        /// </summary>
        public int ReturnTransactionID { get; private set; }

        /// <summary>
        /// Stores the last cart calculation before checkout
        /// </summary>

        public ReturnCart()
        {
            this.IsReturnedList = new List<IsReturnedModel>();
            this.FurnitureList = new List<Furniture>();
        }
        /// <summary>
        /// retreives Furniture information from the DB based on Furniture ID
        /// ensures there is an appropriate quantity (qty of 1, needs multiple clicks
        /// </summary>
        /// <param name="furnitureID"></param>
        public void AddFurnitureToReturnCart(Dictionary<Furniture, int> furnitureToAdd)
        {
            foreach (KeyValuePair<Furniture, int> item in furnitureToAdd )
            {
                
             Furniture currentFurniture = item.Key;
             int quantityReturned = item.Value;
            
             Furniture RentedItem = FurnitureController.GetFurnitureByID(currentFurniture.FurnitureID);
                 
             IsReturnedModel newIsReturnedAdapter = new IsReturnedModel();
             newIsReturnedAdapter.QuantityIn = quantityReturned;
             newIsReturnedAdapter.IsRentedFurnitureID = currentFurniture.FurnitureID;
             newIsReturnedAdapter.IsRentedTransactionID = currentFurniture.TransactionID; 
             this.IsReturnedList.Add(newIsReturnedAdapter);
             this.FurnitureList.Add(RentedItem);

            }
          
            
        }

        public void ProcessInsertReturnTransaction(int memberID, int employeeID)
        {
            Returns newReturnedtransaction = new Returns();
            newReturnedtransaction.MemberID = memberID;
            newReturnedtransaction.EmployeeID = employeeID;
            newReturnedtransaction.DateTimeCreated = DateTime.Now;
            this.ReturnedDate = newReturnedtransaction.DateTimeCreated;
            this.ReturnTransactionID = FurnitureController.InsertReturnTransaction(newReturnedtransaction, this.IsReturnedList);
        }
      
        /// <summary>
        /// Calculates the total rental cost (w/o taxes)
        /// </summary>
        /// <param name="returnDate"></param>
        /// <returns></returns>
        public double CalculateTotalCost(DateTime returnDate)
        {
            int daysRented = Math.Abs(returnDate.Day - DateTime.Now.Date.Day);
            double total = 0;
            this.FurnitureList.ForEach((item) => {
                total += item.DailyRentalRate * daysRented * item.QuantityOnHand;
            });

            return total;
        }

        public String GetReturnCartContents()
        {
            //Clear lists after returning
            string currentContents = "";
            
            foreach(IsReturnedModel item in this.IsReturnedList)
            {
                currentContents += "\nQuantity: " + item.QuantityIn + " FurnitureID:" + item.IsRentedFurnitureID;
             }

            return currentContents;
        }
        public double GetRefund()
        {
         
            double total = 0;
            this.FurnitureList.ForEach((item) => {
                if(item.DueDate > DateTime.Now)
                {
                    TimeSpan daysRemaining = DateTime.Now.Date - item.DueDate.Date;
                    total += item.DailyRentalRate * daysRemaining.TotalDays * item.QuantityOnHand;
                }
            });

            return total;
        }

        /// <summary>
        /// calculates the daily fine rate
        /// </summary>
        /// <returns></returns>
        public double GetFines()
        {
            double total = 0;
            this.FurnitureList.ForEach((item) => {
                if (item.DueDate < DateTime.Now)
                {
                    double totalFineRate = item.FineRate * item.QuantityOnHand;
                    TimeSpan daysOverDue = item.DueDate.Date - DateTime.Now.Date;
                    total += item.FineRate * Math.Abs((double)daysOverDue.TotalDays);
                }
            });

            return total;
        }
    }
}
 