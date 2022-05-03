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

        /// <summary>
        /// builds the is_returned list and the new returns; then hands off to the controller. 
        /// </summary>
        /// <param name="memberID"></param>
        /// <param name="employeeID"></param>
        public void ProcessInsertReturnTransaction(int memberID, int employeeID)
        {
            Returns newReturnedtransaction = new Returns();
            newReturnedtransaction.MemberID = memberID;
            newReturnedtransaction.EmployeeID = employeeID;
            newReturnedtransaction.DateTimeCreated = DateTime.Now;
            this.ReturnedDate = newReturnedtransaction.DateTimeCreated;
            this.ReturnTransactionID = FurnitureController.InsertReturnTransaction(newReturnedtransaction, this.IsReturnedList);

            this.IsReturnedList = new List<IsReturnedModel>();
            this.FurnitureList = new List<Furniture>();
        }
      
 
    }
}
 