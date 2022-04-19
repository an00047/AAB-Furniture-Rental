
Database Has changed Slightly; new SQl files are int he DB folder of the VS soln. titled:   cs6232-g4_iteration2t

=========================

EMPLOYEE LOGIN CREDENTIALS: 

   USERNAME: wade_the_great
   PASS: 1234

ADMIN LOGIN CREDENTIALS:

   USERNAME: zeroCool	
   PASS: 1234


NON-ADMIN / NON-ACTIVE EMPLOYEE: 

	
   USERNAME: AcidBurn
   PASS: 1234


==============================


Missing Features:

>  Returns dont yet write to the Database

    Needs statements for database manipulation in order for processing returns and updating furniture/transactions based on returns

    Hook up logic to Process Return button

    Right now the Furniture class has two extra attributes for ease of access. This needs to be rewritten in the Return functionality to avoid a conflict with Separation of Concern


>   Admin Report not started. 







-------------------------------
 Bugs / Known Issues / Backlog: 
-------------------------------


 Furniture Search Tab:     !!! Iteration 1 Comment / task !!! 
    >    Make furniture search not need a scroll. 
         This requires refactor of how the datagridView is populated; that is, 
         I recommend we use a ViewModel class and then Wire it to the cart such that the cart has 
         to use the furniture_ID instead of the whole furniture object as is currently done.


View Cart / Checkout:
     > General Note: Checkout requires employee ID to be input. This is intentional because the employee who is earning
     the theoretical commission on the rental might not be the person at the counter checking a person out.

     >   The CartDialog.CheckoutButton_Click method needs to ensure the employee and member Id's are valid. (they exist) Currently throws a dirty error (isn't very user friendly).

     >  CartDialog Form Still needs to calculate totals (total cost for the rental period)

     >   CartDialog column QuantotyOnHand would be better expressed as just "Quantity" or "Quantity to rent"

     >   CartDialog does not currently group same/similar items and increase QTY (qty is always 1; same item is a new line item)

     >   Currently no way (yet) for a user to remove an item from their cart without deleting the whole Cart (abandon)

     >   closing the cartDialog doesn't currently inform the user that it will abandon the cart and put back th einventory.


Search Customer Tab:
    >   Search does not automatically update after successfully editing a customer and returning to the search tab.

Returns Tab: 

    >    Returns refund and fees continually add to the value when clicked multiple times


Customer Tab: 
    >   does not refresh DatagridView automatically upon editing the customer (edited) 

Data Access Layers:
    >    Clean up  Data Access Layers is  required; there exists some mixed/cross functionality among the different classes. (edited)

GENERAL Note: 
    >  clean up presentation a bit to be more aestetic & uniform. (currently operating uder the axiom "First we make it work, then we make it pretty")
    
Rental.cs: 
    >  rectify RentalTransactionID and TransactionId property (unify them)
    >  rectify DateTimeDue and DueDate property (unify them)
    >  rectify DateTimeCreated and TimeStamp property (unify them)

FurnitureDAL.cs:
    > Double check Furniuter and furniture capitalization change didnt break something. 

IsRentedDAL:
    > double check brackets. had to remove My object Class wrapper

EmployeeMainDashBoard.Designer.cs:
    > 2 difference instances of employeeFurnitureUserControl; Needs to unify  line 92/93, 183-189
