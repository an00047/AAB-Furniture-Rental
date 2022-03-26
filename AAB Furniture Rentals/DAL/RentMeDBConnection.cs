using System.Data.SqlClient;

namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// Database Connection Handler
    /// </summary>
    class RentMeDBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns> the connection object for DB interaction</returns>

        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=rentme;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }




    }
}
