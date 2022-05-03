
using System;
using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// Login Data handler for the DB
    /// </summary>
    class LoginDataDAL
    {
        string EncryptionKey = "DatabasesAreAwsome";
        /// <summary>
        /// updates the username and password in the login_data table
        /// </summary>
        /// <param name="newUsername">the new username</param>
        /// <param name="newPassword">the new password</param>
        /// <param name="oldUsername">the old password</param>
        public void UpdateUsernameAndPassword(string newUsername, string newPassword, string oldUsername)
        {
            if (newUsername == "" || oldUsername == "")
            {
                throw new ArgumentException("username and password Cannot be empty");
            }
            if (newPassword != "")
            {
                newPassword = EncryptionHandler.Encrypt(newPassword, this.EncryptionKey);
                string query = "UPDATE login_data SET " +

                    "username = @username, " +
                    "password = @password " +
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

                    "username = @username " +
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

        /// <summary>
        /// inserts new login data
        /// </summary>
        /// <param name="username">the username</param>
        /// <param name="password">the password</param>
        public void InsertNewLoginData(string username, string password)
        {
            if (username == null || password == null)
            {
                throw new ArgumentException("username and password Cannot be empty");
            }
            password = EncryptionHandler.Encrypt(password, this.EncryptionKey);
            string query = "INSERT INTO " +
                  "login_data (username, password ) " +
                  "VALUES(@username, @password ) ";

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
