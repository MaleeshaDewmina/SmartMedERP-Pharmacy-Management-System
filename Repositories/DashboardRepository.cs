using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for the admin dashboard.
     * This repository provides summary statistics, low stock alerts
     * and medicine expiry alerts.
     */
    public class DashboardRepository
    {
        // Loads main dashboard summary statistics.
        public DashboardStats GetDashboardStats()
        {
            DashboardStats stats =
                new DashboardStats();

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                // Count all non-deleted medicines.
                stats.TotalMedicines =
                    Convert.ToInt32(new SqlCommand(
                        "SELECT COUNT(*) FROM Medicines WHERE IsDeleted = 0",
                        con).ExecuteScalar());

                // Count all registered customers.
                stats.TotalCustomers =
                    Convert.ToInt32(new SqlCommand(
                        "SELECT COUNT(*) FROM Customers",
                        con).ExecuteScalar());

                // Count all orders in the system.
                stats.TotalOrders =
                    Convert.ToInt32(new SqlCommand(
                        "SELECT COUNT(*) FROM Orders",
                        con).ExecuteScalar());

                // Calculate total revenue from all orders.
                object revenue =
                    new SqlCommand(
                        "SELECT ISNULL(SUM(GrandTotal), 0) FROM Orders",
                        con).ExecuteScalar();

                stats.TotalRevenue =
                    Convert.ToDecimal(revenue);
            }

            return stats;
        }

        // Loads medicines where stock quantity is below or equal to reorder level.
        public DataTable GetLowStockMedicines()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT TOP 5
                        MedicineName,
                        StockQuantity,
                        ReorderLevel
                    FROM Medicines
                    WHERE IsDeleted = 0
                    AND IsActive = 1
                    AND StockQuantity <= ReorderLevel
                    ORDER BY StockQuantity ASC";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Loads active medicines that will expire within the next 30 days.
        public DataTable GetExpiringMedicines()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT TOP 5
                        MedicineName,
                        BatchNumber,
                        ExpiryDate
                    FROM Medicines
                    WHERE IsDeleted = 0
                    AND IsActive = 1
                    AND ExpiryDate <= DATEADD(DAY, 30, GETDATE())
                    ORDER BY ExpiryDate ASC";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }
    }
}