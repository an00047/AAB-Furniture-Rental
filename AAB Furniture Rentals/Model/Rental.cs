
using System;

namespace AAB_Furniture_Rentals.Model
{

    public class Rental
    {

        int transactionID { get; set; }
        int memberID { get; set; }
        int employeeID { get; set; }
        DateTime timeStamp { get; set; }
        DateTime dueDate { get; set; }



    }
}
