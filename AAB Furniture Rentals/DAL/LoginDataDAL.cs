
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// Login Data handler for the DB
    /// </summary>
    class LoginDataDAL
    {
        public void UpdateUsernameAndPassword(string newUsername, string newPassword, string oldUsername)
        {
            if (newPassword != "")
            {
                string query = "UPDATE login_data SET " +

                    "username = @username, " +
                    "password = @password, " +
                    "WHERE username = @oldUsername ";

                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        command.Parameters.AddWithValue("@oldUsername", oldUsername);
                        command.Parameters.AddWithValue("@username", newUsername);
                        command.Parameters.AddWithValue("@password", newPassword);
                        command.ExecuteScalar();

                    }
                }
            } else
            {
                string queryUsername = "UPDATE login_data SET " +

                    "username = @username, " +
                    "WHERE username = @oldUsername ";

                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryUsername, connection))

                    {
                        command.Parameters.AddWithValue("@oldUsername", oldUsername);
                        command.Parameters.AddWithValue("@username", newUsername);
                        command.ExecuteScalar();

                    }
                }
            }
        }

        public void InsertNewLoginData(string username, string password)
        {
            string query = "INSERT INTO login_data " +

                "username = @username, " +
                "password = @password, ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteScalar();

                }
            }
        }
    }
}
