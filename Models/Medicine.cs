using System;

namespace SmartMedERP.Models
{
    /*
     * Represents a medicine item in the pharmacy inventory.
     * This model stores medicine details, pricing, stock,
     * prescription requirement and status information.
     */
    public class Medicine
    {
        // Unique medicine ID.
        public int MedicineId { get; set; }

        // Main medicine name.
        public string MedicineName { get; set; }

        // Generic name of the medicine.
        public string GenericName { get; set; }

        // Brand name of the medicine.
        public string BrandName { get; set; }

        // Linked category ID.
        public int CategoryId { get; set; }

        // Linked supplier ID.
        public int SupplierId { get; set; }

        // Purchase cost of the medicine.
        public decimal CostPrice { get; set; }

        // Selling price charged to customers.
        public decimal SellingPrice { get; set; }

        // Tax percentage applied to the medicine.
        public decimal TaxPercentage { get; set; }

        // Discount percentage applied to the medicine.
        public decimal DiscountPercentage { get; set; }

        // Current stock quantity.
        public int StockQuantity { get; set; }

        // Minimum stock level before low stock alert.
        public int ReorderLevel { get; set; }

        // Batch number for stock tracking.
        public string BatchNumber { get; set; }

        // Date the medicine was manufactured.
        public DateTime ManufactureDate { get; set; }

        // Medicine expiry date.
        public DateTime ExpiryDate { get; set; }

        // Shows whether a prescription is required.
        public bool PrescriptionRequired { get; set; }

        // Barcode value used for medicine identification.
        public string Barcode { get; set; }

        // QR code value used for medicine identification.
        public string QRCode { get; set; }

        // Shows whether the medicine is active for sale.
        public bool IsActive { get; set; }

        // Supports soft delete without permanently removing the record.
        public bool IsDeleted { get; set; }

        // Date and time the medicine record was created.
        public DateTime CreatedAt { get; set; }
    }
}