using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
namespace AAB_Furniture_Rentals.Controller
{

    class MemberController
    {
        private static MembersDAL localMemberController;

        static MemberController() 
            {
            localMemberController = new MembersDAL();
            }

        public Member GetCustomerByID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
           localMemberController.CheckCustomerID(customerID);
           return localMemberController.GetCustomerByID(customerID);
        }

        public void CheckCustomerID(int customerID)
        {
            if (!(customerID > 0))
            {
                throw new Exception("Customer ID must be a valid number");
            }
            localMemberController.CheckCustomerID(customerID);
        }
       
    }
}
