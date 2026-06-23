using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    public class OrderRepository
    {
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
                    WHERE IsDeleted = 0 AND IsActive = 1
                    ORDER BY MedicineName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public int CreateOrder(Order order)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO Orders
                    (CustomerId, Status, SubTotal, DiscountAmount, TaxAmount, DeliveryFee, GrandTotal)
                    VALUES
                    (@CustomerId, @Status, @SubTotal, @DiscountAmount, @TaxAmount, @DeliveryFee, @GrandTotal);

                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                cmd.Parameters.AddWithValue("@Status", order.Status);
                cmd.Parameters.AddWithValue("@SubTotal", order.SubTotal);
                cmd.Parameters.AddWithValue("@DiscountAmount", order.DiscountAmount);
                cmd.Parameters.AddWithValue("@TaxAmount", order.TaxAmount);
                cmd.Parameters.AddWithValue("@DeliveryFee", order.DeliveryFee);
                cmd.Parameters.AddWithValue("@GrandTotal", order.GrandTotal);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AddOrderItem(OrderItem item)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO OrderItems
                    (OrderId, MedicineId, Quantity, UnitPrice, Discount, Total)
                    VALUES
                    (@OrderId, @MedicineId, @Quantity, @UnitPrice, @Discount, @Total)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderId", item.OrderId);
                cmd.Parameters.AddWithValue("@MedicineId", item.MedicineId);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                cmd.Parameters.AddWithValue("@Discount", item.Discount);
                cmd.Parameters.AddWithValue("@Total", item.Total);

                cmd.ExecuteNonQuery();
            }
        }

        public void ReduceStock(int medicineId, int quantity)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Medicines
                    SET StockQuantity = StockQuantity - @Quantity
                    WHERE MedicineId = @MedicineId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MedicineId", medicineId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();
            }
        }
    }
}