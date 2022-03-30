using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAB_Furniture_Rentals.Model
{
    public class Furniture
    {
        public int FurnitureID { get; set; }
        public string Style { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double DailyRentalRate { get; set; }
        public int QuantityOnHand { get; set; }
        public double FineRate { get; set; }


        public Furniture(
            int furnitureID,
            string style,
            string category,
            string description,
            double dailyRentalRate,
            int quantityOnHand,
            double fineRate
           
            )
        {
            this.FurnitureID = furnitureID;
            this.Style = style;
            this.Category = category;
            this.Description = description;
            this.DailyRentalRate = dailyRentalRate;
            this.QuantityOnHand = quantityOnHand;
            this.FineRate = fineRate;





        }
    }
}
