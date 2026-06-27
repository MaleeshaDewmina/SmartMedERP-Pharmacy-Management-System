namespace SmartMedERP.Models
{
    /*
     * Stores summary values displayed on the admin dashboard.
     * This model is filled by DashboardRepository and used by AdminDashboard.
     */
    public class DashboardStats
    {
        // Total number of active medicine records.
        public int TotalMedicines { get; set; }

        // Total number of registered customers.
        public int TotalCustomers { get; set; }

        // Total number of orders in the system.
        public int TotalOrders { get; set; }

        // Total revenue calculated from order grand totals.
        public decimal TotalRevenue { get; set; }
    }
}