using System;
using System.Collections.Generic;
using SmartMedERP.Models;
using SmartMedERP.Repositories;

namespace SmartMedERP.Services
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository =
            new OrderRepository();

        public void PlaceOrder(Order order)
        {
            int orderId =
                orderRepository.CreateOrder(order);

            foreach (OrderItem item in order.Items)
            {
                item.OrderId = orderId;

                orderRepository.AddOrderItem(item);

                orderRepository.ReduceStock(
                    item.MedicineId,
                    item.Quantity);
            }
        }

        public decimal CalculateItemTotal(
            decimal unitPrice,
            int quantity,
            decimal discountPercentage,
            decimal taxPercentage,
            out decimal discountAmount,
            out decimal taxAmount)
        {
            decimal subTotal =
                unitPrice * quantity;

            discountAmount =
                subTotal * discountPercentage / 100;

            decimal afterDiscount =
                subTotal - discountAmount;

            taxAmount =
                afterDiscount * taxPercentage / 100;

            return afterDiscount + taxAmount;
        }
    }
}