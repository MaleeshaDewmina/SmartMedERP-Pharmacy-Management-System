using System;

namespace SmartMedERP.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }

        public string MedicineName { get; set; }

        public string GenericName { get; set; }

        public string BrandName { get; set; }

        public int CategoryId { get; set; }

        public int SupplierId { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal TaxPercentage { get; set; }

        public decimal DiscountPercentage { get; set; }

        public int StockQuantity { get; set; }

        public int ReorderLevel { get; set; }

        public string BatchNumber { get; set; }

        public DateTime ManufactureDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool PrescriptionRequired { get; set; }

        public string Barcode { get; set; }

        public string QRCode { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}