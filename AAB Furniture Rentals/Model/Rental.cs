
using System;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// The representation of a rental item from the database
    /// </summary>
    public class Rental
    {
        public int RentalTransactionID { get; set; }
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeDue { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rental"/> class.
        /// </summary>
        /// <param name="rentalTransactionID">The rental transaction identifier.</param>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="dateTimeCreated">The date time created.</param>
        /// <param name="dateTimeDue">The date time due.</param>
        public Rental(
            int rentalTransactionID,
            int memberID,
            int employeeID,
            DateTime dateTimeCreated,
            DateTime dateTimeDue)
        {
            this.RentalTransactionID = rentalTransactionID;
            this.MemberID = memberID;
            this.EmployeeID = employeeID;
            this.DateTimeCreated = dateTimeCreated;
            this.DateTimeDue = dateTimeDue;
        }


    }
}
