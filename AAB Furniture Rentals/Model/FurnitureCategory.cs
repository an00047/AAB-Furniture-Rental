
namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// the object model for the fuciture's category
    /// </summary>
   public class FurnitureCategory
    {
       /// <summary>
       /// the category of the furniture
       /// </summary>
       public string Category { get; set; }

        /// <summary>
        /// furniture category constructor method
        /// </summary>
        /// <param name="newCategory"></param>
        public FurnitureCategory(string newCategory) {
            this.Category = newCategory;
        }
    }
}
