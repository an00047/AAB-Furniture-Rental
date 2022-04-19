
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

                string query = "INSERT INTO " +
            "rentals (memberId, employeeID, datetime_due) " +
            "OUTPUT Inserted.rentalTransactionID " +
            "VALUES(@MEMBER_ID, @EMPLOYEE_ID, @DUE_DATE) ";


                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        command.Parameters.AddWithValue("@MEMBER_ID", entry.MemberID);
                        command.Parameters.AddWithValue("@EMPLOYEE_ID", entry.EmployeeID);
                        command.Parameters.AddWithValue("@DUE_DATE", entry.DueDate);


                      command.ExecuteScalar();


                    }
                }


            });
        }

       
    }
}
