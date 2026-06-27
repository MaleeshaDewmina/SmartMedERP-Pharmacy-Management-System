using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for customer order history.
     * This repository loads customer orders, filters orders by status
     * and provides order summary values for the My Orders form.
     */
    public class MyOrdersRepository
    {
        // Gets the CustomerId linked with the logged-in user account.
        public int GetCustomerIdByUserId(int userId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT CustomerId
                    FROM Customers
                    WHERE UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", userId);

                object result = cmd.ExecuteScalar();

                if (result == null)
                    return 0;

                return Convert.ToInt32(result);
            }
        }

        // Loads all orders placed by a specific customer.
        public DataTable GetOrders(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Order details are loaded with delivery, payment,
                 * prescription and total amount information for tracking.
                 */
                string query = @"
                    SELECT
                        OrderId,
                        OrderDate,
                        Status,
                        DeliveryMethod,
                        PaymentMethod,
                        PaymentStatus,
                        PrescriptionRequired,
                        PrescriptionStatus,
                        AdminNote,
                        SubTotal,
                        DiscountAmount,
                        TaxAmount,
                        DeliveryFee,
                        GrandTotal
                    FROM Orders
                    WHERE CustomerId = @CustomerId
                    ORDER BY OrderDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Loads customer orders that match a selected order status.
        public DataTable GetOrdersByStatus(int customerId, string status)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        OrderId,
                        OrderDate,
                        Status,
                        DeliveryMethod,
                        PaymentMethod,
                        PaymentStatus,
                        PrescriptionRequired,
                        PrescriptionStatus,
                        AdminNote,
                        SubTotal,
                        DiscountAmount,
                        TaxAmount,
                        DeliveryFee,
                        GrandTotal
                    FROM Orders
                    WHERE CustomerId = @CustomerId
                    AND Status = @Status
                    ORDER BY OrderDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized values prevent SQL injection in the filter.
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@Status", status);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Returns the total number of orders placed by the customer.
        public int GetTotalOrders(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Orders
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Returns orders that are not yet completed.
        public int GetPendingOrders(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Orders
                    WHERE CustomerId = @CustomerId
                    AND Status IN ('Pending', 'Processing', 'Placed')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Returns the total amount spent by the customer.
        public decimal GetTotalSpent(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT ISNULL(SUM(GrandTotal), 0)
                    FROM Orders
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}