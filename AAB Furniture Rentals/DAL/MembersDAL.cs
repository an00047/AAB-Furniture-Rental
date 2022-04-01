using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.DAL
{
    class MembersDAL
    {
        public Member GetCustomerByID(int customerID)
        {

            string selectStatement =
              "SELECT DISTINCT fName, lName, sex, dob, address, phone " +
              "FROM Member " +
              "WHERE memberID = @customerID ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                Member currentMember = new Member();
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@customerID", customerID);
                    selectCommand.Parameters["@customerID"].Value = customerID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            currentMember.FirstName = reader["fname"].ToString();
                            currentMember.LastName = reader["lname"].ToString();
                            currentMember.Gender = Convert.ToChar(reader["sex"]);
                            currentMember.DateOfBirth = (DateTime)reader["dob"];
                            currentMember.Address = reader["address"].ToString();
                            currentMember.PhoneNumber = reader["phone"].ToString();

                        }
                        
                    }

                }


                return currentMember;

            }
        }


        public int CheckCustomerID(int customerID)
        {

            string selectStatement =
              "SELECT COUNT(*) FROM Member " +
              "WHERE MemberID=@customerID ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))

                {

                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters["@customerID"].Value = customerID;


                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        throw new Exception("There is no customer with that ID.");
                    }
                    return count;
                }

            }

        }
    }
}
