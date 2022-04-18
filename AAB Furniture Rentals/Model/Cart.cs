

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


        //TODO: needs MemberID, EmployeeId, dueDate <-- at checkout. 
        public List<Furniture> FurnitureList { get; }
        private Rental RentalTransaction;


        public Cart() {
            this.RentalTransaction = new Rental();
            this.FurnitureList = new List<Furniture>();
        }
        /// <summary>
        /// retreives Furniture information from the DB based on Furniture ID
        /// ensures there is an appropriate quantity (qty of 1, needs multiple clicks
        /// </summary>
        /// <param name="furnitureID"></param>
        public bool AddFurnitureToCart(Furniture furnitureAdd ) {

            //check DB to see if Qty is still available
            //


            return true;
        }

        public void AbandonCart(){
        
        }

    }
}
