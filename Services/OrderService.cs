using System;
using SmartMedERP.Models;
using SmartMedERP.Repositories;

namespace SmartMedERP.Services
{
    /*
     * Handles order-related business logic.
     * This service validates order details before sending them to the repository.
     */
    public class OrderService
    {
        private readonly OrderRepository orderRepository =
            new OrderRepository();

        // Validates and places an order with stock validation.
        public void PlaceOrder(Order order)
        {
            if (order == null)
            {
                throw new InvalidOperationException(
                    "Order details are missing.");
            }

            // An order must contain at least one medicine item.
            if (order.Items == null || order.Items.Count == 0)
            {
                throw new InvalidOperationException(
                    "Order must contain at least one medicine.");
            }

            // Ensures all ordered quantities are valid before saving.
            foreach (OrderItem item in order.Items)
            {
                if (item.Quantity <= 0)
                {
                    throw new InvalidOperationException(
                        "Invalid quantity for " +
                        item.MedicineName);
                }
            }

            /*
             * The repository saves the order and reduces medicine stock.
             * Stock validation is done during saving to prevent over-selling.
             */
            orderRepository.SaveOrderWithStockValidation(order);
        }

        // Calculates item total after applying discount and tax.
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