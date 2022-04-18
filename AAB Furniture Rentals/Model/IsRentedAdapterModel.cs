

namespace AAB_Furniture_Rentals.Model
{
    class IsRentedAdapterModel
    {
        /// <summary>
        /// the employee ID / table Key
        /// </summary>
        int EmployeeID { get; set; }
        /// <summary>
        /// the member id / table key
        /// </summary>
        int MemberID { get; set; }
        /// <summary>
        /// outgoing quantity of this particular piece of furniture
        /// </summary>
        int QuantityOut { get; set; }

        /// <summary>
        /// empty constructor method. 
        /// </summary>
        public IsRentedAdapterModel() { }

    }
}
