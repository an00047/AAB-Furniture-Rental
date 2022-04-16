
using System;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// Rental Object model Class
    /// </summary>
    public class Rental
    {
        /// <summary>
        /// the reference key of the object
        /// </summary>
        int transactionID { get; set; }
        /// <summary>
        /// the members referecne key
        /// </summary>
        int memberID { get; set; }
        /// <summary>
        /// the employee reference key
        /// </summary>
        int employeeID { get; set; }
        /// <summary>
        /// datetime the record was created int he database
        /// </summary>
        DateTime timeStamp { get; set; }
        /// <summary>
        /// the date the member is supposed tt brin their items back
        /// </summary>
        DateTime dueDate { get; set; }

    }
}
