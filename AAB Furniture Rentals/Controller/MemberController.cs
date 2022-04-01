using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{

    class MemberController
    {
        private static MembersDAL localMemberDAL;

        static MemberController() 
            {
            localMemberDAL = new MembersDAL();
            }

        public Member GetCustomerByID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
            localMemberDAL.CheckCustomerID(customerID);
           return localMemberDAL.GetCustomerByID(customerID);
        }

        public void CheckCustomerID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
            localMemberDAL.CheckCustomerID(customerID);
        }

        public void AddCustomer(Member customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is not valid.");
            }

            localMemberDAL.AddCustomer(customer);
        }

        public void EditCustomer(Member customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is not valid");
            }

            localMemberDAL.EditCustomer(customer);
        }

        public List<Member> GetAllCustomers()
        {
            return localMemberDAL.GetAllMembers();
        }
       
    }
}
