using System;
using System.Windows.Forms;
using SmartMedERP.Utilities;
using SmartMedERP.Repositories;
using SmartMedERP.Models;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser != null)
            {
                lblLoggedUser.Text =
                    "Welcome, " + SessionManager.CurrentUser.Username;
            }

            LoadDashboardStats();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void lblRevenue_Click(object sender, EventArgs e)
        {

        }

        private DashboardRepository dashboardRepository =
        new DashboardRepository();

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

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm =
            new CategoryForm();

            categoryForm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}