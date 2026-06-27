namespace SmartMedERP.Models
{
    /*
     * Represents a supplier in the SmartMed ERP system.
     * Suppliers provide medicines to the pharmacy inventory.
     */
    public class Supplier
    {
        // Unique supplier ID.
        public int SupplierId { get; set; }

        // Name of the supplier or company.
        public string SupplierName { get; set; }

        // Supplier contact phone number.
        public string Phone { get; set; }

        // Supplier email address.
        public string Email { get; set; }

        // Supplier address.
        public string Address { get; set; }
    }
}