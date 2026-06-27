using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartMedERP.Repositories;
using SmartMedERP.Models;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Main dashboard for admin users.
     * This form provides navigation to management modules,
     * displays dashboard statistics and shows low stock and expiry alerts.
     */
    public partial class AdminDashboard : Form
    {
        private readonly DashboardRepository dashboardRepository =
            new DashboardRepository();

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Display the logged-in user's name on the dashboard.
            if (SessionManager.CurrentUser != null)
            {
                lblLoggedUser.Text =
                    "Welcome, " + SessionManager.CurrentUser.Username;

                lblLoggedUsers.Text =
                    "Welcome, " + SessionManager.CurrentUser.Username;
            }

            /*
             * Admin user management and audit logs are restricted
             * to Super Admin users only.
             */
            if (SessionManager.CurrentUser != null &&
                SessionManager.CurrentUser.RoleName != "SuperAdmin")
            {
                btnAdminUsers.Visible = false;
                btnAuditLogs.Visible = false;
            }

            LoadDashboardStats();
            LoadDashboardAlerts();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Opens the order form.
        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm =
                new OrderForm();

            orderForm.Show();
        }

        private void lblRevenue_Click(object sender, EventArgs e)
        {

        }

        // Loads summary statistics for the admin dashboard.
        private void LoadDashboardStats()
        {
            DashboardStats stats =
                dashboardRepository.GetDashboardStats();

            lblMedicineCount.Text =
                stats.TotalMedicines.ToString();

            lblCustomerCount.Text =
                stats.TotalCustomers.ToString();

            lblOrderCount.Text =
                stats.TotalOrders.ToString();

            lblRevenue.Text =
                "Rs. " + stats.TotalRevenue.ToString("N2");
        }

        // Loads low stock and medicine expiry alerts.
        private void LoadDashboardAlerts()
        {
            DataTable lowStockTable =
                dashboardRepository.GetLowStockMedicines();

            DataTable expiryTable =
                dashboardRepository.GetExpiringMedicines();

            StringBuilder alerts =
                new StringBuilder();

            if (lowStockTable.Rows.Count == 0 &&
                expiryTable.Rows.Count == 0)
            {
                lblAlerts.Text = "No alerts yet.";
                return;
            }

            // Add low stock warning details.
            if (lowStockTable.Rows.Count > 0)
            {
                alerts.AppendLine("⚠ Low Stock Alerts");
                alerts.AppendLine();

                foreach (DataRow row in lowStockTable.Rows)
                {
                    alerts.AppendLine(
                        "• " +
                        row["MedicineName"].ToString() +
                        " | Stock: " +
                        row["StockQuantity"].ToString() +
                        " | Reorder Level: " +
                        row["ReorderLevel"].ToString());
                }

                alerts.AppendLine();
            }

            // Add medicine expiry warning details.
            if (expiryTable.Rows.Count > 0)
            {
                alerts.AppendLine("⚠ Expiry Alerts");
                alerts.AppendLine();

                foreach (DataRow row in expiryTable.Rows)
                {
                    DateTime expiryDate =
                        Convert.ToDateTime(row["ExpiryDate"]);

                    alerts.AppendLine(
                        "• " +
                        row["MedicineName"].ToString() +
                        " | Batch: " +
                        row["BatchNumber"].ToString() +
                        " | Expiry: " +
                        expiryDate.ToString("yyyy-MM-dd"));
                }
            }

            lblAlerts.Text =
                alerts.ToString();
        }

        // Opens category management.
        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm =
                new CategoryForm();

            categoryForm.Show();
        }

        // Opens supplier management.
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm =
                new SupplierForm();

            supplierForm.Show();
        }

        // Opens medicine inventory management.
        private void btnMedicines_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm =
                new MedicineForm();

            medicineForm.Show();
        }

        // Opens customer management.
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm =
                new CustomerForm();

            customerForm.Show();
        }

        // Opens reports module.
        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm =
                new ReportsForm();

            reportsForm.Show();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        // Opens admin order management.
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            AdminOrdersForm form =
                new AdminOrdersForm();

            form.Show();
        }

        // Logs out the current user and returns to the login form.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            AuditLogService auditLogService =
                new AuditLogService();

            auditLogService.Log(
                "Logout",
                "Authentication",
                "User logged out.");

            SessionManager.CurrentUser = null;

            LoginForm loginForm = null;

            // Reuse existing login form if it is already open.
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginForm)
                {
                    loginForm = (LoginForm)form;
                    break;
                }
            }

            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }

            loginForm.Show();
            loginForm.BringToFront();

            this.Close();
        }

        // Opens audit log viewer for Super Admin users.
        private void btnAuditLogs_Click(object sender, EventArgs e)
        {
            AuditLogForm form =
                new AuditLogForm();

            form.ShowDialog();
        }

        // Opens admin user management for Super Admin users only.
        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser == null ||
                SessionManager.CurrentUser.RoleName != "SuperAdmin")
            {
                MessageBox.Show("Access denied. Super Admin only.");
                return;
            }

            AdminUserManagementForm form =
                new AdminUserManagementForm();

            form.ShowDialog();
        }
    }
}