﻿using AAB_Furniture_Rentals.DAL;
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
        /// holds reference to the current member the employee is working with
        /// </summary>
        public static Member CurrentMember { get; set; }
        /// <summary>
        /// Initializes the <see cref="MemberController"/> class.
        /// </summary>
        static MemberController() 
            {
            localMemberDAL = new MembersDAL();
            }

        /// <summary>
        /// Returns a list of members by the customerID
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static List<Member> GetCustomersByID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
            localMemberDAL.CheckCustomerID(customerID);
           return localMemberDAL.GetCustomersByID(customerID);
        }

        /// <summary>
        /// Returns the member by the customerID
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
        public static int AddCustomer(Member customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is not valid.");
            }

            return localMemberDAL.AddCustomer(customer);
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
       /// <summary>
       /// gets customer by their phone numebers
       /// </summary>
       /// <param name="phoneNumber"></param>
       /// <returns></returns>
        public static List<Member> GetCustomersByPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == "" || phoneNumber == null)
            {
                throw new Exception("Phone number cannot be empty");
            }
            localMemberDAL.CheckCustomerPhoneNumber(phoneNumber);
            return localMemberDAL.GetCustomersByPhoneNumber(phoneNumber);
        }

        /// <summary>
        /// gets customer by first name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static List<Member> GetCustomersByFirstAndLastName(string firstName, string lastName)
        {
            if (firstName == "" || firstName == null || lastName == "" || lastName == null)
            {
                throw new Exception("Name cannot be empty");
            }
            localMemberDAL.CheckCustomerName(firstName, lastName);
            return localMemberDAL.GetCustomersByFirstAndLastName(firstName, lastName);
        }
    }
}
