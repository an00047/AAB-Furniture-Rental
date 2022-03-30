using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
   public class FurnitureStyle
    {
       string Style { get; set; }

        public FurnitureStyle(string newStyle) {
            this.Style = newStyle;
        }
    }
}
