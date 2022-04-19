
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
        public int TransactionID { get; set; }
        /// <summary>
        /// the members referecne key
        /// </summary>
        public int MemberID { get; set; }
        /// <summary>
        /// the employee reference key
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// datetime the record was created int he database
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// the date the member is supposed tt brin their items back
        /// </summary>
        public DateTime DueDate { get; set; }

    }
}
