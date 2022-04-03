using System;


namespace AAB_Furniture_Rentals.Model
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Member(
            int memberID,
            string fname,
            string lname,
            char sex,
            DateTime dob,
            string address,
            string phone
            )
        {
            this.MemberID = memberID;
            this.Address = address;
            this.FirstName = fname;
            this.LastName = lname;
            this.DateOfBirth = dob;
            this.PhoneNumber = phone;
            this.Gender = sex;
        }

        public Member() { }
    }

}
