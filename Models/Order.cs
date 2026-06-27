using System;
using System.Collections.Generic;

namespace SmartMedERP.Models
{
    /*
     * Represents a customer order in the SmartMed ERP system.
     * This model stores order totals, delivery details, payment details,
     * prescription information and related order items.
     */
    public class Order
    {
        // Unique order ID.
        public int OrderId { get; set; }

        // Customer who placed the order.
        public int CustomerId { get; set; }

        // Date and time the order was created.
        public DateTime OrderDate { get; set; }

        // Current order status such as Pending, Processing or Completed.
        public string Status { get; set; }

        // Total amount before discount, tax and delivery fee.
        public decimal SubTotal { get; set; }

        // Total discount amount applied to the order.
        public decimal DiscountAmount { get; set; }

        // Total tax amount applied to the order.
        public decimal TaxAmount { get; set; }

        // Delivery charge for the order.
        public decimal DeliveryFee { get; set; }

        // Final payable amount.
        public decimal GrandTotal { get; set; }

        // List of medicines included in the order.
        public List<OrderItem> Items { get; set; }

        // Customer delivery address.
        public string DeliveryAddress { get; set; }

        // Contact phone number for delivery.
        public string DeliveryPhone { get; set; }

        // Delivery option selected by the customer.
        public string DeliveryMethod { get; set; }

        // Optional delivery instruction from the customer.
        public string DeliveryNote { get; set; }

        // Selected payment method.
        public string PaymentMethod { get; set; }

        // Payment status such as Pending or Paid.
        public string PaymentStatus { get; set; }

        // Shows whether the order contains prescription medicines.
        public bool PrescriptionRequired { get; set; }

        // Uploaded prescription file path.
        public string PrescriptionFilePath { get; set; }

        // Prescription verification status.
        public string PrescriptionStatus { get; set; }

        // Admin note added during order or prescription review.
        public string AdminNote { get; set; }

        // Admin user ID who verified the prescription.
        public int? VerifiedBy { get; set; }

        // Date and time the prescription was verified.
        public DateTime? VerifiedAt { get; set; }
    }
}