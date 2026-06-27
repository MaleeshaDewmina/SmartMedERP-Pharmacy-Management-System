using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for admin order management.
     * This repository loads customer orders, order items, updates order status,
     * payment status and prescription verification details.
     */
    public class AdminOrderRepository
    {
        // Loads orders using search keyword and selected order status.
        public DataTable GetOrders(string keyword, string status)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Orders are joined with Customers so admins can search
                 * by customer name or order ID.
                 */
                string query = @"
                    SELECT
                        O.OrderId,
                        C.FullName AS Customer,
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
                        O.PrescriptionFilePath,
                        O.AdminNote
                    FROM Orders O
                    INNER JOIN Customers C
                        ON O.CustomerId = C.CustomerId
                    WHERE
                    (
                        C.FullName LIKE @Keyword
                        OR CAST(O.OrderId AS NVARCHAR(20)) LIKE @Keyword
                    )
                    AND
                    (
                        @Status = 'All'
                        OR O.Status = @Status
                    )
                    ORDER BY O.OrderDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized values prevent SQL injection.
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("@Status", status);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Loads medicine items belonging to a selected order.
        public DataTable GetOrderItems(int orderId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * OrderItems are joined with Medicines to display medicine names
                 * with quantity, price, discount and total values.
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

        // Updates the current status of a selected order.
        public void UpdateOrderStatus(int orderId, string status)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Orders
                    SET Status = @Status
                    WHERE OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates the payment status of a selected order.
        public void UpdatePaymentStatus(int orderId, string paymentStatus)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Orders
                    SET PaymentStatus = @PaymentStatus
                    WHERE OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);

                cmd.ExecuteNonQuery();
            }
        }

        // Approves a prescription and stores admin verification details.
        public void ApprovePrescription(
            int orderId,
            string adminNote,
            int verifiedBy)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Orders
                    SET 
                        PrescriptionStatus = 'Approved',
                        AdminNote = @AdminNote,
                        VerifiedBy = @VerifiedBy,
                        VerifiedAt = GETDATE()
                    WHERE OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@AdminNote", adminNote);
                cmd.Parameters.AddWithValue("@VerifiedBy", verifiedBy);

                cmd.ExecuteNonQuery();
            }
        }

        /*
         * Rejects a prescription and cancels the order.
         * This prevents the customer order from continuing without
         * a valid prescription.
         */
        public void RejectPrescription(
            int orderId,
            string adminNote,
            int verifiedBy)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Orders
                    SET 
                        PrescriptionStatus = 'Rejected',
                        Status = 'Cancelled',
                        AdminNote = @AdminNote,
                        VerifiedBy = @VerifiedBy,
                        VerifiedAt = GETDATE()
                    WHERE OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@AdminNote", adminNote);
                cmd.Parameters.AddWithValue("@VerifiedBy", verifiedBy);

                cmd.ExecuteNonQuery();
            }
        }
    }
}