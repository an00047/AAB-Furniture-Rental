using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System.Collections.Generic;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// Controls the state data
    /// </summary>
    class StateController
    {

        private static StateDAL localStateDAL;
        /// <summary>
        /// Initializes the <see cref="CategoryController"/> class.
        /// </summary>
        static StateController()
        {
            localStateDAL = new StateDAL();
        }

        /// <summary>
        /// Gets all states.
        /// </summary>
        /// <returns></returns>
        public static List<State> GetAllStates()
        {
            return localStateDAL.GetAllStates();
        }
    }
}
