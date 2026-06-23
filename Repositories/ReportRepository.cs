using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    public class ReportRepository
    {
        public DataTable GetSalesReport(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

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
                        O.GrandTotal
                    FROM Orders O
                    INNER JOIN Customers C ON O.CustomerId = C.CustomerId
                    WHERE CAST(O.OrderDate AS DATE) BETWEEN @FromDate AND @ToDate
                    ORDER BY O.OrderDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public ReportSummary GetSalesSummary(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        ISNULL(SUM(GrandTotal), 0) AS TotalSales,
                        COUNT(OrderId) AS TotalOrders,
                        ISNULL(SUM(GrandTotal), 0) AS TotalRevenue
                    FROM Orders
                    WHERE CAST(OrderDate AS DATE) BETWEEN @FromDate AND @ToDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new ReportSummary
                    {
                        TotalSales = Convert.ToDecimal(reader["TotalSales"]),
                        TotalOrders = Convert.ToInt32(reader["TotalOrders"]),
                        TotalRevenue = Convert.ToDecimal(reader["TotalRevenue"])
                    };
                }

                return new ReportSummary();
            }
        }

        public DataTable GetInventoryReport()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        M.MedicineId,
                        M.MedicineName,
                        C.CategoryName,
                        S.SupplierName,
                        M.StockQuantity,
                        M.ReorderLevel,
                        M.SellingPrice,
                        (M.StockQuantity * M.SellingPrice) AS InventoryValue,
                        M.ExpiryDate
                    FROM Medicines M
                    LEFT JOIN Categories C ON M.CategoryId = C.CategoryId
                    LEFT JOIN Suppliers S ON M.SupplierId = S.SupplierId
                    WHERE M.IsDeleted = 0
                    ORDER BY M.MedicineName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable GetLowStockReport()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        MedicineId,
                        MedicineName,
                        StockQuantity,
                        ReorderLevel,
                        ExpiryDate
                    FROM Medicines
                    WHERE IsDeleted = 0
                    AND StockQuantity <= ReorderLevel
                    ORDER BY StockQuantity ASC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable GetExpiryReport()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        MedicineId,
                        MedicineName,
                        BatchNumber,
                        StockQuantity,
                        ExpiryDate
                    FROM Medicines
                    WHERE IsDeleted = 0
                    AND ExpiryDate <= DATEADD(DAY, 30, GETDATE())
                    ORDER BY ExpiryDate ASC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
    }
}