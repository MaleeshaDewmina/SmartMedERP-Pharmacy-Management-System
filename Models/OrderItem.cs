namespace SmartMedERP.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public int MedicineId { get; set; }

        public string MedicineName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        public int AvailableStock { get; set; }
    }
}