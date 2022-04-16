using System;

namespace AAB_Furniture_Rentals.Model
{
    public class Returns
    {
        public int ReturnTransactionID { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int EmployeeID { get; set; }

        public Returns(int returnTransactionID, DateTime dateTimeCreated, int employeeID)
        {
            this.ReturnTransactionID = returnTransactionID;
            this.DateTimeCreated = dateTimeCreated;
            this.EmployeeID = employeeID;
        }
    }
}
