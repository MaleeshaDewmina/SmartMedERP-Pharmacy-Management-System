namespace SmartMedERP.Models
{
    /*
     * Represents a medicine category in the SmartMed ERP system.
     * Categories are used to organize medicines into groups.
     */
    public class Category
    {
        // Unique category ID.
        public int CategoryId { get; set; }

        // Name of the medicine category.
        public string CategoryName { get; set; }

        // Optional description about the category.
        public string Description { get; set; }

        // Shows whether the category is active.
        public bool IsActive { get; set; }
    }
}