using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// The representation of a returns item from the database
    /// </summary>
    public class Returns
    {
        public int ReturnTransactionID { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int EmployeeID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Returns"/> class.
        /// </summary>
        /// <param name="returnTransactionID">The return transaction identifier.</param>
        /// <param name="dateTimeCreated">The date time created.</param>
        /// <param name="employeeID">The employee identifier.</param>
        public Returns(int returnTransactionID, DateTime dateTimeCreated, int employeeID)
        {
            this.ReturnTransactionID = returnTransactionID;
            this.DateTimeCreated = dateTimeCreated;
            this.EmployeeID = employeeID;
        }
    }
}
