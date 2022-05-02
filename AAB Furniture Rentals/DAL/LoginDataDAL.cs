
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// Login Data handler for the DB
    /// </summary>
    class LoginDataDAL
    {
        public void UpdateUsernameAndPassword(string newUsername, string newPassword, int employeeID)
        {
            string query = "UPDATE employee SET " +

                "username = @username, " +
                "password = @password, " +
                "WHERE employeeID=@EMPLOYEE_ID ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.AddWithValue("@EMPLOYEE_ID", employeeID);
                    command.Parameters.AddWithValue("@username", newUsername);
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.ExecuteScalar();

                }
            }
        }
    }
}
