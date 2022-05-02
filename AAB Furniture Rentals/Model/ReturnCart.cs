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
             this.IsReturnedList.Add(newIsReturnedAdapter);
             this.FurnitureList.Add(RentedItem);

            }
            //this.ReturnFurnitureToInvetory();
        }
        /// <summary>
        /// Adds the items checked out back into the inventory, then zeroizes all the properties
        /// 
        /// </summary>
        public void ReturnFurnitureToInvetory()
        {

            // add each furniture in the last back... 

            this.FurnitureList.ForEach((item) =>
            {
                Furniture inventoryItem = FurnitureController.GetFurnitureByID(item.FurnitureID);
                inventoryItem.QuantityOnHand += item.QuantityOnHand;
                FurnitureController.UpdateFurnitureItem(inventoryItem);

            });


            this.IsReturnedList = new List<IsReturnedModel>();
            this.FurnitureList = new List<Furniture>();


        }
        /// <summary>
        /// populates the IsRented List with the transaction id. It already has the furniture and quantity,
        /// it just doesnt have the transaction id, becasue this needs to be processed seperately upon checkout. 
        /// </summary>
        /// <param name="transactionID"></param>
        public void AddTransactionToIsRentedList(int transactionID)
        {
            this.IsReturnedList.ForEach((item) => {
                item.IsRentedTransactionID = transactionID;
            });
        }
        /// <summary>
        /// Updates the IsReturned Database
        /// </summary>
      //  public void ProcessIsReturnedList() => FurnitureController.ProcessIsReturnedList(this.IsReturnedList);

        /// <summary>
        /// generates the transaction in the Database. Returns the Id. 
        /// </summary>
        /// <returns></returns>
      //  public int ProcessReturnTransaction(int memberID, int employeeID, DateTime dueDate)
      //  {
      //      Rental newRentaltransaction = new Rental();
      //      newRentaltransaction.MemberID = memberID;
      //      newRentaltransaction.EmployeeID = employeeID;
      //      newRentaltransaction.DueDate = dueDate;

      //      return FurnitureController.ProcessReturnTransaction(newRentaltransaction);
      //  }

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
 