using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations related to orders.
     * This repository saves orders, order items and updates medicine stock.
     */
    public class OrderRepository
    {
        // Loads customers for order creation forms.
        public DataTable GetCustomers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT CustomerId, FullName
                    FROM Customers
                    ORDER BY FullName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Loads active medicines that can be selected for an order.
        public DataTable GetMedicines()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        MedicineId,
                        MedicineName,
                        SellingPrice,
                        DiscountPercentage,
                        TaxPercentage,
                        StockQuantity
                    FROM Medicines
                    WHERE ISNULL(IsDeleted, 0) = 0
                    AND ISNULL(IsActive, 1) = 1
                    ORDER BY MedicineName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Saves an order and reduces stock using a single database transaction.
        public void SaveOrderWithStockValidation(Order order)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * A transaction is used so the order, order items and stock update
                 * are saved together. If one step fails, all changes are rolled back.
                 */
                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    // Check stock before creating the order.
                    ValidateStockBeforeOrder(
                        order,
                        con,
                        transaction);

                    int orderId =
                        CreateOrder(
                            order,
                            con,
                            transaction);

                    foreach (OrderItem item in order.Items)
                    {
                        item.OrderId = orderId;

                        AddOrderItem(
                            item,
                            con,
                            transaction);

                        ReduceStockSafely(
                            item.MedicineId,
                            item.Quantity,
                            con,
                            transaction);
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Validates required quantity against available stock before saving.
        private void ValidateStockBeforeOrder(
            Order order,
            SqlConnection con,
            SqlTransaction transaction)
        {
            Dictionary<int, int> requiredStock =
                new Dictionary<int, int>();

            Dictionary<int, string> medicineNames =
                new Dictionary<int, string>();

            /*
             * Groups quantities by medicine ID. This prevents stock errors
             * if the same medicine appears more than once in the order.
             */
            foreach (OrderItem item in order.Items)
            {
                if (!requiredStock.ContainsKey(item.MedicineId))
                {
                    requiredStock[item.MedicineId] = 0;
                    medicineNames[item.MedicineId] = item.MedicineName;
                }

                requiredStock[item.MedicineId] += item.Quantity;
            }

            foreach (int medicineId in requiredStock.Keys)
            {
                int availableStock =
                    GetCurrentStockForUpdate(
                        medicineId,
                        con,
                        transaction);

                string medicineName =
                    medicineNames.ContainsKey(medicineId)
                    ? medicineNames[medicineId]
                    : "Medicine ID " + medicineId;

                if (availableStock < 0)
                {
                    throw new InvalidOperationException(
                        medicineName +
                        " is not available.");
                }

                if (availableStock < requiredStock[medicineId])
                {
                    throw new InvalidOperationException(
                        medicineName +
                        " does not have enough stock. Available stock: " +
                        availableStock +
                        ", requested quantity: " +
                        requiredStock[medicineId]);
                }
            }
        }

        // Locks the selected medicine row while checking stock.
        private int GetCurrentStockForUpdate(
            int medicineId,
            SqlConnection con,
            SqlTransaction transaction)
        {
            string query = @"
                SELECT StockQuantity
                FROM Medicines WITH (UPDLOCK, ROWLOCK)
                WHERE MedicineId = @MedicineId
                AND ISNULL(IsDeleted, 0) = 0
                AND ISNULL(IsActive, 1) = 1";

            SqlCommand cmd =
                new SqlCommand(
                    query,
                    con,
                    transaction);

            cmd.Parameters.AddWithValue("@MedicineId", medicineId);

            object result =
                cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Inserts the order header and returns the newly created OrderId.
        private int CreateOrder(
            Order order,
            SqlConnection con,
            SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO Orders
                (
                    CustomerId,
                    Status,
                    SubTotal,
                    DiscountAmount,
                    TaxAmount,
                    DeliveryFee,
                    GrandTotal,
                    DeliveryAddress,
                    DeliveryPhone,
                    DeliveryMethod,
                    DeliveryNote,
                    PaymentMethod,
                    PaymentStatus,
                    PrescriptionRequired,
                    PrescriptionFilePath,
                    PrescriptionStatus,
                    AdminNote
                )
                VALUES
                (
                    @CustomerId,
                    @Status,
                    @SubTotal,
                    @DiscountAmount,
                    @TaxAmount,
                    @DeliveryFee,
                    @GrandTotal,
                    @DeliveryAddress,
                    @DeliveryPhone,
                    @DeliveryMethod,
                    @DeliveryNote,
                    @PaymentMethod,
                    @PaymentStatus,
                    @PrescriptionRequired,
                    @PrescriptionFilePath,
                    @PrescriptionStatus,
                    @AdminNote
                );

                SELECT SCOPE_IDENTITY();";

            SqlCommand cmd =
                new SqlCommand(
                    query,
                    con,
                    transaction);

            cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            cmd.Parameters.AddWithValue("@Status", order.Status);
            cmd.Parameters.AddWithValue("@SubTotal", order.SubTotal);
            cmd.Parameters.AddWithValue("@DiscountAmount", order.DiscountAmount);
            cmd.Parameters.AddWithValue("@TaxAmount", order.TaxAmount);
            cmd.Parameters.AddWithValue("@DeliveryFee", order.DeliveryFee);
            cmd.Parameters.AddWithValue("@GrandTotal", order.GrandTotal);

            cmd.Parameters.AddWithValue(
                "@DeliveryAddress",
                string.IsNullOrWhiteSpace(order.DeliveryAddress)
                    ? (object)DBNull.Value
                    : order.DeliveryAddress);

            cmd.Parameters.AddWithValue(
                "@DeliveryPhone",
                string.IsNullOrWhiteSpace(order.DeliveryPhone)
                    ? (object)DBNull.Value
                    : order.DeliveryPhone);

            cmd.Parameters.AddWithValue(
                "@DeliveryMethod",
                string.IsNullOrWhiteSpace(order.DeliveryMethod)
                    ? (object)DBNull.Value
                    : order.DeliveryMethod);

            cmd.Parameters.AddWithValue(
                "@DeliveryNote",
                string.IsNullOrWhiteSpace(order.DeliveryNote)
                    ? (object)DBNull.Value
                    : order.DeliveryNote);

            cmd.Parameters.AddWithValue(
                "@PaymentMethod",
                string.IsNullOrWhiteSpace(order.PaymentMethod)
                    ? (object)DBNull.Value
                    : order.PaymentMethod);

            cmd.Parameters.AddWithValue(
                "@PaymentStatus",
                string.IsNullOrWhiteSpace(order.PaymentStatus)
                    ? "Pending"
                    : order.PaymentStatus);

            cmd.Parameters.AddWithValue(
                "@PrescriptionRequired",
                order.PrescriptionRequired);

            cmd.Parameters.AddWithValue(
                "@PrescriptionFilePath",
                string.IsNullOrWhiteSpace(order.PrescriptionFilePath)
                    ? (object)DBNull.Value
                    : order.PrescriptionFilePath);

            cmd.Parameters.AddWithValue(
                "@PrescriptionStatus",
                string.IsNullOrWhiteSpace(order.PrescriptionStatus)
                    ? "Not Required"
                    : order.PrescriptionStatus);

            cmd.Parameters.AddWithValue(
                "@AdminNote",
                string.IsNullOrWhiteSpace(order.AdminNote)
                    ? (object)DBNull.Value
                    : order.AdminNote);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Inserts each medicine line item for the order.
        private void AddOrderItem(
            OrderItem item,
            SqlConnection con,
            SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO OrderItems
                (
                    OrderId,
                    MedicineId,
                    Quantity,
                    UnitPrice,
                    Discount,
                    Total
                )
                VALUES
                (
                    @OrderId,
                    @MedicineId,
                    @Quantity,
                    @UnitPrice,
                    @Discount,
                    @Total
                )";

            SqlCommand cmd =
                new SqlCommand(
                    query,
                    con,
                    transaction);

            cmd.Parameters.AddWithValue("@OrderId", item.OrderId);
            cmd.Parameters.AddWithValue("@MedicineId", item.MedicineId);
            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
            cmd.Parameters.AddWithValue("@Discount", item.Discount);
            cmd.Parameters.AddWithValue("@Total", item.Total);

            cmd.ExecuteNonQuery();
        }

        // Reduces medicine stock only if enough stock is still available.
        private void ReduceStockSafely(
            int medicineId,
            int quantity,
            SqlConnection con,
            SqlTransaction transaction)
        {
            string query = @"
                UPDATE Medicines
                SET StockQuantity = StockQuantity - @Quantity
                WHERE MedicineId = @MedicineId
                AND StockQuantity >= @Quantity
                AND ISNULL(IsDeleted, 0) = 0
                AND ISNULL(IsActive, 1) = 1";

            SqlCommand cmd =
                new SqlCommand(
                    query,
                    con,
                    transaction);

            cmd.Parameters.AddWithValue("@MedicineId", medicineId);
            cmd.Parameters.AddWithValue("@Quantity", quantity);

            int rowsAffected =
                cmd.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                throw new InvalidOperationException(
                    "Stock update failed. The selected medicine may not have enough stock.");
            }
        }
    }
}