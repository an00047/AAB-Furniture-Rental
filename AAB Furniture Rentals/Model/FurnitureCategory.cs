using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
   public class FurnitureCategory
    {
       public string Category { get; set; }


        public FurnitureCategory(string newCategory) {
            this.Category = newCategory;
        }
    }
}
