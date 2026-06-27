using System;
using System.Windows.Forms;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Displays the customer dashboard after login.
     * This form shows customer statistics, cart count, loyalty details
     * and provides navigation to shopping, orders, cart and profile.
     */
    public partial class CustomerDashboard : Form
    {
        private readonly CustomerDashboardRepository dashboardRepository =
            new CustomerDashboardRepository();

        private int currentCustomerId = 0;

        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        // Loads dashboard statistics for the currently logged-in customer.
        private void LoadDashboardData()
        {
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Session expired. Please login again.");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Close();
                return;
            }

            currentCustomerId =
                dashboardRepository.GetCustomerIdByUserId(
                    SessionManager.CurrentUser.UserId);

            if (currentCustomerId == 0)
            {
                MessageBox.Show("Customer profile not found.");
                return;
            }

            // Retrieve customer dashboard values from the repository layer.
            int medicineCount =
                dashboardRepository.GetAvailableMedicineCount();

            int orderCount =
                dashboardRepository.GetCustomerOrderCount(
                    currentCustomerId);

            int pendingCount =
                dashboardRepository.GetPendingOrderCount(
                    currentCustomerId);

            int cartCount =
                dashboardRepository.GetCartItemCount(
                    currentCustomerId);

            int loyaltyPoints =
                dashboardRepository.GetLoyaltyPoints(
                    currentCustomerId);

            string membershipLevel =
                dashboardRepository.GetMembershipLevel(
                    currentCustomerId);

            // Display customer-specific dashboard information.
            lblWelcome.Text =
                "Welcome " + SessionManager.CurrentUser.Username;

            lblMedicineCount.Text =
                medicineCount.ToString();

            lblOrderCount.Text =
                orderCount.ToString();

            lblPendingCount.Text =
                pendingCount.ToString();

            btnMyCart.Text =
                "My Cart (" + cartCount + ")";

            lblLoyaltyPoints.Text =
                "Loyalty Points: " + loyaltyPoints.ToString();

            lblMembershipLevel.Text =
                "Membership Level: " + membershipLevel;
        }

        // Opens the medicine search form for shopping.
        private void btnSearchMedicines_Click(object sender, EventArgs e)
        {
            CustomerMedicineSearchForm form =
                new CustomerMedicineSearchForm();

            form.ShowDialog();

            // Refresh dashboard after returning from shopping.
            LoadDashboardData();
        }

        // Opens the customer's order tracking form.
        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            MyOrdersForm form =
                new MyOrdersForm();

            form.ShowDialog();

            LoadDashboardData();
        }

        // Opens the customer profile form.
        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfileForm form =
                new CustomerProfileForm();

            form.ShowDialog();

            LoadDashboardData();
        }

        // Logs out the current customer and returns to the login form.
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

            // Clear current user session after logout.
            SessionManager.CurrentUser = null;

            LoginForm loginForm = null;

            // Reuse an existing LoginForm if it is already open.
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

        // Shortcut button that opens the medicine search form.
        private void btnStartShopping_Click(object sender, EventArgs e)
        {
            btnSearchMedicines_Click(sender, e);
        }

        // Opens the saved customer cart.
        private void btnMyCart_Click(object sender, EventArgs e)
        {
            CustomerCartForm form =
                new CustomerCartForm(currentCustomerId);

            form.ShowDialog();

            LoadDashboardData();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblFeatureBadgeSub_Click(object sender, EventArgs e)
        {

        }

        private void pnlFeature_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}