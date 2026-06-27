namespace SmartMedERP.Models
{
    /*
     * Represents a single medicine item inside an order.
     * This model stores quantity, price, discount, tax,
     * total amount and prescription requirement details.
     */
    public class OrderItem
    {
        // Unique order item ID.
        public int OrderItemId { get; set; }

        // Linked order ID.
        public int OrderId { get; set; }

        // Linked medicine ID.
        public int MedicineId { get; set; }

        // Display name of the medicine.
        public string MedicineName { get; set; }

        // Quantity ordered.
        public int Quantity { get; set; }

        // Selling price for one unit.
        public decimal UnitPrice { get; set; }

        // Discount amount for this item.
        public decimal Discount { get; set; }

        // Tax amount for this item.
        public decimal Tax { get; set; }

        // Final total for this item.
        public decimal Total { get; set; }

        // Available stock used for validation before placing the order.
        public int AvailableStock { get; set; }

        // Shows whether this medicine requires a prescription.
        public bool PrescriptionRequired { get; set; }
    }
}