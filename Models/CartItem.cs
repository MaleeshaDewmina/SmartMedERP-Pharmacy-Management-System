using System;

namespace SmartMedERP.Models
{
    /*
     * Represents one medicine item saved in a customer's shopping cart.
     * This model is used when loading, updating and converting cart items
     * into order items during checkout.
     */
    public class CartItem
    {
        // Unique cart item record ID.
        public int CartItemId { get; set; }

        // Customer who owns this cart item.
        public int CustomerId { get; set; }

        // Medicine selected by the customer.
        public int MedicineId { get; set; }

        // Display name of the medicine.
        public string MedicineName { get; set; }

        // Quantity selected by the customer.
        public int Quantity { get; set; }

        // Selling price of one medicine unit.
        public decimal UnitPrice { get; set; }

        // Discount percentage applied to the medicine.
        public decimal DiscountPercentage { get; set; }

        // Tax percentage applied to the medicine.
        public decimal TaxPercentage { get; set; }

        // Current available stock for validation.
        public int AvailableStock { get; set; }

        // Indicates whether this medicine requires a prescription.
        public bool PrescriptionRequired { get; set; }

        // Date and time when the cart item was created.
        public DateTime CreatedAt { get; set; }

        // Date and time when the cart item was last updated.
        public DateTime UpdatedAt { get; set; }
    }
}