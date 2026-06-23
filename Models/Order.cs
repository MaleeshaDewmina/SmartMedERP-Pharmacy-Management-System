using System;
using System.Collections.Generic;

namespace SmartMedERP.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        public decimal SubTotal { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal DeliveryFee { get; set; }

        public decimal GrandTotal { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}