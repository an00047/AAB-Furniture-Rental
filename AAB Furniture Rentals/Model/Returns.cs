using System;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// Defines a Returns object
    /// </summary>
    public class Returns
    {
        /// <summary>
        /// Gets or sets the return transaction identifier.
        /// </summary>
        /// <value>
        /// The return transaction identifier.
        /// </value>
        public int ReturnTransactionID { get; set; }
        /// <summary>
        /// Gets or sets the date time created.
        /// </summary>
        /// <value>
        /// The date time created.
        /// </value>
        public DateTime DateTimeCreated { get; set; }
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Returns"/> class.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <param name="dateTimeCreated">The date time created.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// 
        public int MemberID { get; set; }
        public Returns(int returnTransactionID, DateTime dateTimeCreated, int employeeID)
        {
            this.ReturnTransactionID = returnTransactionID;
            this.DateTimeCreated = dateTimeCreated;
            this.EmployeeID = employeeID;
        }
        public Returns() { }
    
    }
}
