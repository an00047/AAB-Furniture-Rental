using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all member related queries
    /// </summary>

    public static class MemberController
    {
        private static MembersDAL localMemberDAL;
     
        /// <summary>
        /// Initializes the <see cref="MemberController"/> class.
        /// </summary>
        static MemberController() 
            {
            localMemberDAL = new MembersDAL();
            }

        /// <summary>
        /// Returns a member by the customerID
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static Member GetCustomerByID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
            localMemberDAL.CheckCustomerID(customerID);
           return localMemberDAL.GetCustomerByID(customerID);
        }
        /// <summary>
        /// Checks to make sure that customerID exists in the database.
        /// </summary>
        /// <param name="customerID"></param>
        public static void CheckCustomerID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
            localMemberDAL.CheckCustomerID(customerID);
        }
        /// <summary>
        /// Adds a member to the database
        /// </summary>
        /// <param name="customer"></param>
        public static void AddCustomer(Member customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is not valid.");
            }

            localMemberDAL.AddCustomer(customer);
        }
        /// <summary>
        /// Edits a member in the database
        /// </summary>
        /// <param name="customer"></param>
        public static void EditCustomer(Member customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is not valid");
            }

            localMemberDAL.EditCustomer(customer);
        }
        /// <summary>
        /// Returns all members in the database
        /// </summary>
        /// <returns></returns>
        public static List<Member> GetAllCustomers()
        {
            return localMemberDAL.GetAllMembers();
        }
       
        public static Member GetCustomerByPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == "" || phoneNumber == null)
            {
                throw new Exception("Phone number cannot be empty");
            }
            localMemberDAL.CheckCustomerPhoneNumber(phoneNumber);
            return localMemberDAL.GetCustomerByPhoneNumber(phoneNumber);
        }

        public static Member GetCustomerByFirstAndLastName(string firstName, string lastName)
        {
            if (firstName == "" || firstName == null || lastName == "" || lastName == null)
            {
                throw new Exception("Name cannot be empty");
            }
            localMemberDAL.CheckCustomerName(firstName, lastName);
            return localMemberDAL.GetCustomerByFirstAndLastName(firstName, lastName);
        }
    }
}
