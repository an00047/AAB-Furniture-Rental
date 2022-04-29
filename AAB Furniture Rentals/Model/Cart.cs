

using AAB_Furniture_Rentals.Controller;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Model
{
    // -> i NEED to define a local class Is_Rented (as mentioned),


    /// <summary>
    /// The cart object model is created when the employee Dashboard is created (not within user control)
    ///  -> holds a rental object model instance (sans datetime which is generated upon checkout/ COMPLETION.
    ///  -> holds an "is_rented"  object model List
    ///    -> DURING CREATION, checks that the requested quantity is available; warns if not. 
    ///    -> subtaracts the quantity from the inventory
    ///    -> NOTE: this list will be primary datasource for the "viewCart" functionality
    ///         ---> enables "remove from Cart" to be streamlined in memory
    ///         --> if cart is abandoned on the viewCart page, use list to put quantites back in the database
    ///     -> this fires and adds to the local array every time the "add to cart button" is hit 
    ///  -> The cart object model generates a transaction upon checkout by: 
    ///     --> generate a rental transaction, return it's ID
    ///     --> use rental transaction to: publishing/insert each is_rented to the is_rented table in the DB
    ///     --> Removing the DB quantity from the furnitures table based on the Furniture Id
    /// </summary>
    public class Cart
    {

        /// <summary>
        /// the list of items to be rented in this transaction
        /// </summary>           
        public List<Furniture> FurnitureList { get; set; }
      
       
        private List<IsRentedModel> IsRentedList;
    
        public Cart() {
            this.IsRentedList = new List<IsRentedModel>();
            this.FurnitureList = new List<Furniture>();
        }
        /// <summary>
        /// retreives Furniture information from the DB based on Furniture ID
        /// ensures there is an appropriate quantity (qty of 1, needs multiple clicks
        /// </summary>
        /// <param name="furnitureID"></param>
        public void AddFurnitureToCart(Furniture furnitureToAdd , int quantityToAdd) {
            
            int quantityToRent = quantityToAdd;
            furnitureToAdd.QuantityOnHand = quantityToAdd;
            // get most recent information on this furniture item
            // it is assumed that if the prices (or anyhting) changes except quantity, the memebr has their "deal" locked in. 
            Furniture InventoryItem = FurnitureController.GetFurnitureByID(furnitureToAdd.FurnitureID);

            //check to see if Qty is still available
            if (InventoryItem.QuantityOnHand < quantityToRent) {
                this.PutFurnitureBackIntoInventory(); 
                throw new Exception("Not Enough inventory to facilitate this request. Please choose something else to rent");
            }

            // We have ensured there is enough inventory, subtract that desired quantity from the inventory
            InventoryItem.QuantityOnHand = InventoryItem.QuantityOnHand - quantityToRent;
            FurnitureController.UpdateFurnitureItem(InventoryItem);

            //then build the IsRentedModel (transactionID is currently blank, becasue the DbHasnt generated it yet. will do at checkout.)
            IsRentedModel newIsRentedAdapter = new IsRentedModel();
            newIsRentedAdapter.QuantityOut = quantityToRent;
            newIsRentedAdapter.FurnitureID = furnitureToAdd.FurnitureID;
            this.IsRentedList.Add(newIsRentedAdapter);
            this.FurnitureList.Add(furnitureToAdd);



        }
        /// <summary>
        /// Adds the items checked out back into the inventory, then zeroizes all the properties
        /// 
        /// </summary>
        public void PutFurnitureBackIntoInventory(){
            // add each furniture in the last back... 

            this.FurnitureList.ForEach((item)=> {
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
            this.IsRentedList.ForEach((item)=>{
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
        public int ProcessRentalTransaction(int memberID, int employeeID, DateTime dueDate)
        {
            Rental newRentaltransaction =  new Rental();
            newRentaltransaction.MemberID = memberID;
            newRentaltransaction.EmployeeID = employeeID;
            newRentaltransaction.DueDate = dueDate;

            return FurnitureController.ProcessRentalTransaction(newRentaltransaction);
        }
    }
}
