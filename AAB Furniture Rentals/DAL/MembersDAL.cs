using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace AAB_Furniture_Rentals.DAL
{
    /// <summary>
    /// handler for interracting with the Members table in the DB
    /// </summary>
    class MembersDAL
    {
        /// <summary>
        /// Gets the member with a designated memberID.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<Member> GetCustomersByID(int customerID)
        {

            string selectStatement =
              "SELECT memberID, fName, lName, sex, dob, address, phone, city, state, zip " +
              "FROM Member " +
              "WHERE memberID = @customerID ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                List<Member> allMembers = new List<Member>();
               
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@customerID", customerID);
                    selectCommand.Parameters["@customerID"].Value = customerID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Member currentMember = new Member();
                            currentMember.MemberID = (int)reader["memberID"];
                            currentMember.FirstName = reader["fname"].ToString();
                            currentMember.LastName = reader["lname"].ToString();
                            currentMember.Gender = Convert.ToChar(reader["sex"]);
                            currentMember.DateOfBirth = (DateTime)reader["dob"];
                            currentMember.Address = reader["address"].ToString();
                            currentMember.PhoneNumber = reader["phone"].ToString();
                            currentMember.City = reader["city"].ToString();
                            currentMember.State = Convert.ToInt32(reader["state"]);
                            currentMember.Zip = reader["zip"].ToString();
                            allMembers.Add(currentMember);
                        }

                    }

                }


                return allMembers;

            }
        }

        public Member GetCustomerByID(int customerID)
        {

            string selectStatement =
              "SELECT memberID, fName, lName, sex, dob, address, phone, city, state, zip " +
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
                           
                            currentMember.MemberID = (int)reader["memberID"];
                            currentMember.FirstName = reader["fname"].ToString();
                            currentMember.LastName = reader["lname"].ToString();
                            currentMember.Gender = Convert.ToChar(reader["sex"]);
                            currentMember.DateOfBirth = (DateTime)reader["dob"];
                            currentMember.Address = reader["address"].ToString();
                            currentMember.PhoneNumber = reader["phone"].ToString();
                            currentMember.City = reader["city"].ToString();
                            currentMember.State = Convert.ToInt32(reader["state"]);
                            currentMember.Zip = reader["zip"].ToString();
                          
                        }

                    }

                }


                return currentMember;

            }
        }
        /// <summary>
        /// Edits a member with a designated memberID.
        /// </summary>
        /// <param name="customer"></param>
        public void EditCustomer(Member customer)
        {

            string query = "UPDATE Member " +
                "SET fName=@firstName, lname=@lastName, sex=@gender, dob=@dateOfBirth, address=@address, phone=@phoneNumber, city=@city, state=@state, zip=@zip " +
                "WHERE memberID=@memberID ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {

                    command.Parameters.AddWithValue("@firstName", customer.FirstName);
                    command.Parameters["@firstName"].Value = customer.FirstName;

                    command.Parameters.AddWithValue("@lastName", customer.LastName);
                    command.Parameters["@lastName"].Value = customer.LastName;

                    command.Parameters.AddWithValue("@gender", customer.Gender);
                    command.Parameters["@gender"].Value = customer.Gender;

                    command.Parameters.AddWithValue("@dateOfBirth", customer.DateOfBirth);
                    command.Parameters["@dateOfBirth"].Value = customer.DateOfBirth;

                    command.Parameters.AddWithValue("@address", customer.Address);
                    command.Parameters["@address"].Value = customer.Address;

                    command.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
                    command.Parameters["@phoneNumber"].Value = customer.PhoneNumber;

                    command.Parameters.AddWithValue("@memberID", customer.MemberID);
                    command.Parameters["@memberID"].Value = customer.MemberID;

                    command.Parameters.AddWithValue("@city", customer.City);
                    command.Parameters["@city"].Value = customer.City;

                    command.Parameters.AddWithValue("@state", customer.State);
                    command.Parameters["@state"].Value = customer.State;

                    command.Parameters.AddWithValue("@zip", customer.Zip);
                    command.Parameters["@zip"].Value = customer.Zip;

                    command.ExecuteScalar();


                }
            }
        }
        /// <summary>
        /// Adds a new member to the database.
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Member customer)
        {

            string query = "INSERT INTO " +
                "Member (fName, lName, sex, dob, address, phone, city, state, zip) " +
                "VALUES(@firstName, @lastName, @gender, @dateOfBirth, @address, @phoneNumber, @city, @state, @zip)";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {

                    command.Parameters.AddWithValue("@firstName", customer.FirstName);

                    command.Parameters.AddWithValue("@lastName", customer.LastName);

                    command.Parameters.AddWithValue("@gender", customer.Gender);

                    command.Parameters.AddWithValue("@dateOfBirth", customer.DateOfBirth);

                    command.Parameters.AddWithValue("@address", customer.Address);

                    command.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);

                    command.Parameters.AddWithValue("@city", customer.City);

                    command.Parameters.AddWithValue("@state", customer.State);

                    command.Parameters.AddWithValue("@zip", customer.Zip);

                    command.ExecuteScalar();


                }
            }

        }
        /// <summary>
        /// Returns a list of all members in the database.
        /// </summary>
        /// <returns></returns>
        public List<Member> GetAllMembers()
        {
            List<Member> allMembers = new List<Member>();
            string query = "SELECT  memberID, fName, lName, sex, dob, address, phone, city, state, zip " +
                "FROM Member ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {

                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(query, connection))

                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Member currentMember = new Member();
                            currentMember.MemberID = (int)reader["memberID"];
                            currentMember.FirstName = reader["fname"].ToString();
                            currentMember.LastName = reader["lname"].ToString();
                            currentMember.Gender = Convert.ToChar(reader["sex"]);
                            currentMember.DateOfBirth = (DateTime)reader["dob"];
                            currentMember.Address = reader["address"].ToString();
                            currentMember.PhoneNumber = reader["phone"].ToString();
                            currentMember.City = reader["city"].ToString();
                            currentMember.State = Convert.ToInt32(reader["state"]);
                            currentMember.Zip = reader["zip"].ToString();
                            allMembers.Add(currentMember);

                        }
                    }
                }
            }
            return allMembers;
        }
        /// <summary>
        /// Checks to see if a designated memberID exists in the database.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// validates the customer name exists
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public int CheckCustomerName(string firstName, string lastName)
        {

            string selectStatement =
              "SELECT COUNT(*) FROM Member " +
              "WHERE fName=@firstName AND " +
              "lName=@lastName ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))

                {

                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters["@firstName"].Value = firstName;

                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters["@lastName"].Value = lastName;


                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        throw new Exception("There is no customer with that name.");
                    }
                    return count;
                }

            }

        }

        /// <summary>
        /// validates the customer's phone numebr exists.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public int CheckCustomerPhoneNumber(string phoneNumber)
        {

            string selectStatement =
              "SELECT COUNT(*) FROM Member " +
              "WHERE phone=@phoneNumber";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))

                {

                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters["@phoneNumber"].Value = phoneNumber;

     


                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        throw new Exception("There is no customer with that phone number.");
                    }
                    return count;
                }

            }

        }

        /// <summary>
        /// gets the customer based on phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public List<Member> GetCustomersByPhoneNumber(string phoneNumber)
        {
            List<Member> allMembers = new List<Member>();
            string selectStatement =
              "SELECT memberID, fName, lName, sex, dob, address, phone, city, state, zip " +
              "FROM Member " +
              "WHERE phone = @phoneNumber ";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
               
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    selectCommand.Parameters["@phoneNumber"].Value = phoneNumber;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Member currentMember = new Member();
                            currentMember.MemberID = (int)reader["memberID"];
                            currentMember.FirstName = reader["fname"].ToString();
                            currentMember.LastName = reader["lname"].ToString();
                            currentMember.Gender = Convert.ToChar(reader["sex"]);
                            currentMember.DateOfBirth = (DateTime)reader["dob"];
                            currentMember.Address = reader["address"].ToString();
                            currentMember.PhoneNumber = reader["phone"].ToString();
                            currentMember.City = reader["city"].ToString();
                            currentMember.State = Convert.ToInt32(reader["state"]);
                            currentMember.Zip = reader["zip"].ToString();
                            allMembers.Add(currentMember);
                        }

                    }

                }


                return allMembers;

            }
        }

    /// <summary>
    /// gets the customer by first and last name
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <returns></returns>
    public List<Member> GetCustomersByFirstAndLastName(string firstName, string lastName)
    {

            List<Member> allMembers = new List<Member>();
            string selectStatement =
          "SELECT memberID, fName, lName, sex, dob, address, phone, city, state, zip " +
          "FROM Member " +
          "WHERE fName = @firstName AND " +
          "lName = @lastName";


        using (SqlConnection connection = RentMeDBConnection.GetConnection())
        {
           
            connection.Open();
            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

            {

                selectCommand.Parameters.AddWithValue("@firstName", firstName);
                selectCommand.Parameters["@firstName"].Value = firstName;
                    selectCommand.Parameters.AddWithValue("@lastName", lastName);
                    selectCommand.Parameters["@lastName"].Value = lastName;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        Member currentMember = new Member();
                        currentMember.MemberID = (int)reader["memberID"];
                        currentMember.FirstName = reader["fname"].ToString();
                        currentMember.LastName = reader["lname"].ToString();
                        currentMember.Gender = Convert.ToChar(reader["sex"]);
                        currentMember.DateOfBirth = (DateTime)reader["dob"];
                        currentMember.Address = reader["address"].ToString();
                        currentMember.PhoneNumber = reader["phone"].ToString();
                        currentMember.City = reader["city"].ToString();
                        currentMember.State = Convert.ToInt32(reader["state"]);
                        currentMember.Zip = reader["zip"].ToString();
                        allMembers.Add(currentMember);

                        }

                }

            }


            return allMembers;

        }
    }

}
}
