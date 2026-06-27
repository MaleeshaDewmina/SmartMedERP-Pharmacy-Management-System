using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for invoice generation.
     * This repository loads invoice header details and medicine line items
     * for viewing, printing and PDF export.
     */
    public class InvoiceRepository
    {
        // Loads main invoice details for a selected order.
        public DataTable GetInvoiceHeader(int orderId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Joins Orders, Customers and Users to get order details,
                 * customer name, email and phone number for the invoice.
                 */
                string query = @"
                    SELECT
                        O.OrderId,
                        O.OrderDate,
                        O.Status,
                        O.SubTotal,
                        O.DiscountAmount,
                        O.TaxAmount,
                        O.DeliveryFee,
                        O.GrandTotal,
                        O.DeliveryAddress,
                        O.DeliveryPhone,
                        O.DeliveryMethod,
                        O.PaymentMethod,
                        O.PaymentStatus,
                        O.PrescriptionRequired,
                        O.PrescriptionStatus,
                        O.AdminNote,
                        C.FullName AS CustomerName,
                        U.Email,
                        U.Phone AS CustomerPhone
                    FROM Orders O
                    INNER JOIN Customers C
                        ON O.CustomerId = C.CustomerId
                    INNER JOIN Users U
                        ON C.UserId = U.UserId
                    WHERE O.OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized query prevents SQL injection.
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Loads medicine line items for the selected invoice.
        public DataTable GetInvoiceItems(int orderId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Joins OrderItems with Medicines to show medicine names,
                 * quantities, prices, discounts and item totals.
                 */
                string query = @"
                    SELECT
                        M.MedicineName,
                        OI.Quantity,
                        OI.UnitPrice,
                        OI.Discount,
                        OI.Total
                    FROM OrderItems OI
                    INNER JOIN Medicines M
                        ON OI.MedicineId = M.MedicineId
                    WHERE OI.OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
    }
}