
using System;

namespace AAB_Furniture_Rentals.Model
{
    public class Rental
    {
        public int RentalTransactionID { get; set; }
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeDue { get; set; }

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
