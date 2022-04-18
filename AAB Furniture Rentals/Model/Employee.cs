using System;

namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// the employee object model class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// the object key in the database
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// employee first name
        /// </summary>
        public string Fname { get; set; }
        /// <summary>
        /// employee's last name
        /// </summary>
        public string Lname { get; set; }
        /// <summary>
        /// the employee's gender
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// the employee's dat of birth
        /// </summary>
        public DateTime Dob { get; set; }
        /// <summary>
        /// the employee's numbered address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// the employee's city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// the state the reside in
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// the employees mailing zip code
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// the employee's phone numebr
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// whther or not the employee is active
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// the employees username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// whether or not the employee is an administratir
        /// </summary>
        public bool Admin { get; set; }
        
        /// <summary>
        ///  constructor method for the employee object model
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="sex"></param>
        /// <param name="dob"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="active"></param>
        /// <param name="username"></param>
        /// <param name="admin"></param>
        public Employee(
            int employeeID,
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
        /// <summary>
        /// empty constructor method to init null when desired
        /// </summary>
        public Employee()
        {
        }
    }
}
