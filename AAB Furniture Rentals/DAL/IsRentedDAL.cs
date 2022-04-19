
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// isRented handler
    /// </summary>
    class IsRentedDAL
    {
        internal void InsertIsRentedTable(List<IsRentedModel> isRentedList)
        {
            isRentedList.ForEach((entry)=> { 
            



            });
        }

        internal int InsertNewRentalTransaction(Rental newRental)
        {
            string query = "INSERT INTO " +
              "rentals (memberId, employeeID, datetime_due) " +
              "OUTPUT Inserted.rentalTransactionID" +
              "VALUES(@MEMBER_ID, @EMPLOYEE_ID, @DUE_DATE) ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.AddWithValue("@MEMBER_ID", newRental.MemberID);
                    command.Parameters.AddWithValue("@EMPLOYEE_ID", newRental.EmployeeID);
                    command.Parameters.AddWithValue("@DUE_DATE", newRental.DueDate);
                  

                   var retrunedValue = command.ExecuteScalar();

                    return 1;
                }
            }
        }
    }
}
