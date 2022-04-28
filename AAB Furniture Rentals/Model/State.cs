
namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// A state object
    /// </summary>
    class State
    {
        /// <summary>
        /// The state ID
        /// </summary>
        public int StateID { get; set; }
        /// <summary>
        /// The state code
        /// </summary>
        public string StateCode { get; set; }
        /// <summary>
        /// The state name
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        /// <param name="stateID">The state identifier.</param>
        /// <param name="stateCode">The state code.</param>
        /// <param name="stateName">Name of the state.</param>
        public State(int stateID, string stateCode, string stateName)
        {
            this.StateID = stateID;
            this.StateCode = stateCode;
            this.StateName = stateName;
        }
    }
}
