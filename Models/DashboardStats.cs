using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMedERP.Models
{
    public class DashboardStats
    {
        public int TotalMedicines { get; set; }

        public int TotalCustomers { get; set; }

        public int TotalOrders { get; set; }

        public decimal TotalRevenue { get; set; }
    }
}