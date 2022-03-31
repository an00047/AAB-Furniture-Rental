using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AAB_Furniture_Rentals.DAL;
using AAB_Furniture_Rentals.Model;

namespace AAB_Furniture_Rentals.Controller
{
    /// <summary>
    /// A static controller class that should be utilized for all employee related queries
    /// </summary>
    public static class StyleController
    {
        private static FurnitureStyleDAL localStylesDAL;
        /// <summary>
        /// Initializes the <see cref="EmployeeController"/> class.
        /// </summary>
        static StyleController()
        {
            localStylesDAL = new FurnitureStyleDAL();
        }


        public static List<FurnitureStyle> GetAllStyles()
        {
            var test = localStylesDAL.GetAllStyles();
            return localStylesDAL.GetAllStyles();
        }

    }
}
