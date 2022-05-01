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


        private List<IsRentedModel> IsRentedList;

        public ReturnCart()
        {
            this.IsRentedList = new List<IsRentedModel>();
            this.FurnitureList = new List<Furniture>();
        }
        /// <summary>
        /// retreives Furniture information from the DB based on Furniture ID
        /// ensures there is an appropriate quantity (qty of 1, needs multiple clicks
        /// </summary>
        /// <param name="furnitureID"></param>
        public void AddFurnitureToReturnCart(Furniture furnitureToAdd, int quantityToAdd)
        {

            int quantityRented = quantityToAdd;
            furnitureToAdd.QuantityOnHand = quantityToAdd;
            // get most recent information on this furniture item
            // it is assumed that if the prices (or anyhting) changes except quantity, the memebr has their "deal" locked in. 
            Furniture InventoryItem = FurnitureController.GetFurnitureByID(furnitureToAdd.FurnitureID);

            //check to see if Qty is still available
            if (InventoryItem.QuantityOnHand < quantityRented)
            {

                if (this.activeInventoryFeatureIsON)
                {
                    this.PutFurnitureBack();
                }
                throw new Exception("Not Enough inventory to facilitate this request. Please choose something else to rent");
            }

            // We have ensured there is enough inventory, 
            InventoryItem.QuantityOnHand = InventoryItem.QuantityOnHand - quantityRented;

            if (this.activeInventoryFeatureIsON)
            {
                FurnitureController.UpdateFurnitureItem(InventoryItem);
            }

            //then build the IsRentedModel (transactionID is currently blank, becasue the DbHasnt generated it yet. will do at checkout.)
            IsRentedModel newIsRentedAdapter = new IsRentedModel();
            newIsRentedAdapter.QuantityOut = quantityRented;
            newIsRentedAdapter.FurnitureID = furnitureToAdd.FurnitureID;
            this.IsRentedList.Add(newIsRentedAdapter);
            this.FurnitureList.Add(furnitureToAdd);



        }
        /// <summary>
        /// Adds the items checked out back into the inventory, then zeroizes all the properties
        /// 
        /// </summary>
        public void PutFurnitureBack()
        {

            // add each furniture in the last back... 

            this.FurnitureList.ForEach((item) =>
            {
                Furniture inventoryItem = FurnitureController.GetFurnitureByID(item.FurnitureID);
                inventoryItem.QuantityOnHand += item.QuantityOnHand;
                FurnitureController.UpdateFurnitureItem(inventoryItem);

            });


            this.IsRentedList = new List<IsRentedModel>();
            this.FurnitureList = new List<Furniture>();


        }
        /// <summary>
        /// populates the IsRented List with the transaction id. It already has the furniture and quantity,
        /// it just doesnt have the transaction id, becasue this needs to be processed seperately upon checkout. 
        /// </summary>
        /// <param name="transactionID"></param>
        public void AddTransactionToIsRentedList(int transactionID)
        {
            this.IsRentedList.ForEach((item) => {
                item.TransactionID = transactionID;
            });
        }
        /// <summary>
        /// Updates the IsRented Database
        /// </summary>
        public void ProcessIsRentedList() => FurnitureController.ProcessIsRentedList(this.IsRentedList);

        /// <summary>
        /// generates the transaction in the Database. Returns the Id. 
        /// </summary>
        /// <returns></returns>
        public int ProcessReturnTransaction(int memberID, int employeeID, DateTime dueDate)
        {
            Rental newRentaltransaction = new Rental();
            newRentaltransaction.MemberID = memberID;
            newRentaltransaction.EmployeeID = employeeID;
            newRentaltransaction.DueDate = dueDate;

            return FurnitureController.ProcessRentalTransaction(newRentaltransaction);
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

        /// <summary>
        /// calculates the daily fine rate
        /// </summary>
        /// <returns></returns>
        public double CalculateDailyFineRate()
        {
            double total = 0;
            this.FurnitureList.ForEach((item) => {
                total += item.FineRate * item.QuantityOnHand;
            });

            return total;
        }
    }
}
 