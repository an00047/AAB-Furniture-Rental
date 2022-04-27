using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Controller
{
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

        public static List<State> GetAllStates()
        {
            return localStateDAL.GetAllStates();
        }
    }
}
