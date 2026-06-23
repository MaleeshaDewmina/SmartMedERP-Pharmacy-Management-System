using System;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    public class DashboardRepository
    {
        public DashboardStats GetDashboardStats()
        {
            DashboardStats stats = new DashboardStats();

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                stats.TotalMedicines =
                    Convert.ToInt32(new SqlCommand(
                        "SELECT COUNT(*) FROM Medicines WHERE IsDeleted = 0", con)
                        .ExecuteScalar());

                stats.TotalCustomers =
                    Convert.ToInt32(new SqlCommand(
                        "SELECT COUNT(*) FROM Customers", con)
                        .ExecuteScalar());

                stats.TotalOrders =
                    Convert.ToInt32(new SqlCommand(
                        "SELECT COUNT(*) FROM Orders", con)
                        .ExecuteScalar());

                object revenue =
                    new SqlCommand(
                        "SELECT ISNULL(SUM(GrandTotal), 0) FROM Orders", con)
                        .ExecuteScalar();

                stats.TotalRevenue =
                    Convert.ToDecimal(revenue);
            }

            return stats;
        }
    }
}