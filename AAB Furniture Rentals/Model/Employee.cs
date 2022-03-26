using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    class Employee
    {
        public string EmployeeID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Sex { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string Username { get; set; }
        public bool Admin { get; set; }

        public Employee(
            string employeeID,
            string fname,
            string lname,
            string sex,
            DateTime dob,
            string address,
            string city,
            string state,
            string zip,
            string phone,
            bool active,
            string username,
            bool admin
            )
        {
            this.EmployeeID = employeeID;
            this.Active = active;
            this.Address = address;
            this.Admin = admin;
            this.City = city;
            this.Fname = fname;
            this.Lname = lname;
            this.Dob = dob;
            this.Phone = phone;
            this.Sex = sex;
            this.Zip = zip;
            this.State = state;
            this.Username = username;





        }
    }
}
