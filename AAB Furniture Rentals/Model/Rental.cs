using System;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// Rental Object model Class
    /// </summary>
    public class Rental
    {
        /// <summary>
        /// Gets or sets the rental transaction identifier.
        /// </summary>
        /// <value>
        /// The rental transaction identifier.
        /// </value>
        public int RentalTransactionID { get; set; }
        public int TransactionID { get; set; }
        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberID { get; set; }
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }
        /// <summary>
        /// Gets or sets the date time created.
        /// </summary>
        /// <value>
        /// The date time created.
        /// </value>
        public DateTime DateTimeCreated { get; set; }
        /// <summary>
        /// Gets or sets the date time due.
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <value>
        /// The date time due.
        /// </value>
        public DateTime DateTimeDue { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rental"/> class.
        /// </summary>
        public DateTime DueDate { get; set; }
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

        public Rental() { }
    }
}
