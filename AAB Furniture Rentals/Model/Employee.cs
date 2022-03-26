using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    class Employee
    {
        public string employeeID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string sex { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public bool active { get; set; }
        public string login_data_username { get; set; }

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
            string login_data_username
            )
        {
        }
    }
}
