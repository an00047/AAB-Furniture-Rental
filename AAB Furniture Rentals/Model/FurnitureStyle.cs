
namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// furnitureStyle object model
    /// </summary>
   public class FurnitureStyle
    {
        /// <summary>
        /// the syle name
        /// </summary>
       public string Style { get; set; }

        /// <summary>
        /// constructor method for the style
        /// </summary>
        /// <param name="newStyle"></param>
        public FurnitureStyle(string newStyle) {
            this.Style = newStyle;
        }

    }
}
