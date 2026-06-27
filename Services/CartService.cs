using System;
using System.Collections.Generic;
using System.Data;
using SmartMedERP.Models;
using SmartMedERP.Repositories;

namespace SmartMedERP.Services
{
    /*
     * Handles customer cart business logic.
     * This service validates cart actions and converts saved cart data
     * into order items used during checkout.
     */
    public class CartService
    {
        private readonly CartRepository cartRepository =
            new CartRepository();

        private readonly OrderService orderService =
            new OrderService();

        // Gets the customer profile ID for the logged-in user account.
        public int GetCustomerIdByUserId(int userId)
        {
            return cartRepository.GetCustomerIdByUserId(userId);
        }

        // Validates cart details before adding a medicine to the saved cart.
        public void AddToCart(
            int customerId,
            int medicineId,
            int quantity)
        {
            if (customerId <= 0)
                throw new Exception("Invalid customer.");

            if (medicineId <= 0)
                throw new Exception("Invalid medicine.");

            if (quantity <= 0)
                throw new Exception("Quantity must be greater than zero.");

            cartRepository.AddOrUpdateCartItem(
                customerId,
                medicineId,
                quantity);
        }

        // Updates the quantity of an existing cart item.
        public void UpdateQuantity(
            int customerId,
            int medicineId,
            int quantity)
        {
            cartRepository.UpdateQuantity(
                customerId,
                medicineId,
                quantity);
        }

        // Removes a selected medicine from the customer cart.
        public void RemoveCartItem(
            int customerId,
            int medicineId)
        {
            cartRepository.RemoveCartItem(
                customerId,
                medicineId);
        }

        // Clears all saved cart items for the customer.
        public void ClearCart(int customerId)
        {
            cartRepository.ClearCart(customerId);
        }

        // Returns the number of items currently saved in the customer cart.
        public int GetCartCount(int customerId)
        {
            return cartRepository.GetCartCount(customerId);
        }

        /*
         * Converts database cart records into OrderItem objects.
         * This allows the same order calculation logic to be reused during checkout.
         */
        public List<OrderItem> GetCartOrderItems(int customerId)
        {
            DataTable table =
                cartRepository.GetCartItems(customerId);

            List<OrderItem> items =
                new List<OrderItem>();

            foreach (DataRow row in table.Rows)
            {
                decimal unitPrice =
                    Convert.ToDecimal(row["UnitPrice"]);

                int quantity =
                    Convert.ToInt32(row["Quantity"]);

                decimal discountPercentage =
                    Convert.ToDecimal(row["DiscountPercentage"]);

                decimal taxPercentage =
                    Convert.ToDecimal(row["TaxPercentage"]);

                decimal discountAmount;
                decimal taxAmount;

                // Reuse OrderService to calculate discount, tax and final item total.
                decimal total =
                    orderService.CalculateItemTotal(
                        unitPrice,
                        quantity,
                        discountPercentage,
                        taxPercentage,
                        out discountAmount,
                        out taxAmount);

                OrderItem item =
                    new OrderItem
                    {
                        MedicineId = Convert.ToInt32(row["MedicineId"]),
                        MedicineName = row["MedicineName"].ToString(),
                        Quantity = quantity,
                        UnitPrice = unitPrice,
                        Discount = discountAmount,
                        Tax = taxAmount,
                        Total = total,
                        AvailableStock = Convert.ToInt32(row["AvailableStock"]),
                        PrescriptionRequired =
                            Convert.ToBoolean(row["PrescriptionRequired"])
                    };

                items.Add(item);
            }

            return items;
        }

        // Calculates cart summary totals shown before checkout.
        public void CalculateCartTotals(
            List<OrderItem> items,
            out decimal subTotal,
            out decimal discountTotal,
            out decimal taxTotal,
            out decimal grandTotal)
        {
            subTotal = 0;
            discountTotal = 0;
            taxTotal = 0;
            grandTotal = 0;

            foreach (OrderItem item in items)
            {
                subTotal += item.UnitPrice * item.Quantity;
                discountTotal += item.Discount;
                taxTotal += item.Tax;
                grandTotal += item.Total;
            }
        }
    }
}