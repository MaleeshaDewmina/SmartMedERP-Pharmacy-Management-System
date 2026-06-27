using System;
using System.Data;
using System.Windows.Forms;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Displays the logged-in customer's order history.
     * Customers can filter orders by status, view tracking details
     * and open invoices for selected orders.
     */
    public partial class MyOrdersForm : Form
    {
        private readonly MyOrdersRepository myOrdersRepository =
            new MyOrdersRepository();

        private int currentCustomerId = 0;
        private int selectedOrderId = 0;

        public MyOrdersForm()
        {
            InitializeComponent();
        }

        private void MyOrdersForm_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Session expired. Please login again.");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
                return;
            }

            currentCustomerId =
                myOrdersRepository.GetCustomerIdByUserId(
                    SessionManager.CurrentUser.UserId);

            if (currentCustomerId == 0)
            {
                MessageBox.Show("Customer profile not found.");
                this.Hide();
                return;
            }

            LoadStatusFilter();
            LoadSummary();
            LoadOrders();
            ClearTrackingDetails();
        }

        // Loads order status options for filtering customer orders.
        private void LoadStatusFilter()
        {
            cmbStatusFilter.Items.Clear();

            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Processing");
            cmbStatusFilter.Items.Add("Delivered");
            cmbStatusFilter.Items.Add("Cancelled");

            cmbStatusFilter.SelectedIndex = 0;
        }

        // Loads order summary values shown at the top of the form.
        private void LoadSummary()
        {
            lblTotalOrders.Text =
                myOrdersRepository
                .GetTotalOrders(currentCustomerId)
                .ToString();

            lblPendingOrders.Text =
                myOrdersRepository
                .GetPendingOrders(currentCustomerId)
                .ToString();

            lblTotalSpent.Text =
                "Rs. " +
                myOrdersRepository
                .GetTotalSpent(currentCustomerId)
                .ToString("N2");
        }

        // Loads customer orders based on the selected status filter.
        private void LoadOrders()
        {
            if (currentCustomerId == 0)
                return;

            string selectedStatus =
                cmbStatusFilter.Text;

            DataTable table;

            if (selectedStatus == "All" ||
                string.IsNullOrWhiteSpace(selectedStatus))
            {
                table =
                    myOrdersRepository.GetOrders(currentCustomerId);
            }
            else
            {
                table =
                    myOrdersRepository.GetOrdersByStatus(
                        currentCustomerId,
                        selectedStatus);
            }

            dgvOrders.DataSource = table;

            FormatOrdersGrid();
        }

        // Formats the order history grid for customer-friendly display.
        private void FormatOrdersGrid()
        {
            if (dgvOrders.Columns.Count == 0)
                return;

            if (dgvOrders.Columns.Contains("OrderId"))
                dgvOrders.Columns["OrderId"].HeaderText = "Order ID";

            if (dgvOrders.Columns.Contains("OrderDate"))
                dgvOrders.Columns["OrderDate"].HeaderText = "Order Date";

            if (dgvOrders.Columns.Contains("SubTotal"))
                dgvOrders.Columns["SubTotal"].HeaderText = "Sub Total";

            if (dgvOrders.Columns.Contains("DiscountAmount"))
                dgvOrders.Columns["DiscountAmount"].HeaderText = "Discount";

            if (dgvOrders.Columns.Contains("TaxAmount"))
                dgvOrders.Columns["TaxAmount"].HeaderText = "Tax";

            if (dgvOrders.Columns.Contains("DeliveryFee"))
                dgvOrders.Columns["DeliveryFee"].HeaderText = "Delivery Fee";

            if (dgvOrders.Columns.Contains("GrandTotal"))
                dgvOrders.Columns["GrandTotal"].HeaderText = "Grand Total";

            // These values are shown in the tracking panel, so they are hidden from the grid.
            if (dgvOrders.Columns.Contains("DeliveryMethod"))
                dgvOrders.Columns["DeliveryMethod"].Visible = false;

            if (dgvOrders.Columns.Contains("PaymentMethod"))
                dgvOrders.Columns["PaymentMethod"].Visible = false;

            if (dgvOrders.Columns.Contains("PaymentStatus"))
                dgvOrders.Columns["PaymentStatus"].Visible = false;

            if (dgvOrders.Columns.Contains("PrescriptionRequired"))
                dgvOrders.Columns["PrescriptionRequired"].HeaderText = "Prescription";

            if (dgvOrders.Columns.Contains("PrescriptionStatus"))
                dgvOrders.Columns["PrescriptionStatus"].HeaderText = "Prescription Status";

            if (dgvOrders.Columns.Contains("AdminNote"))
                dgvOrders.Columns["AdminNote"].Visible = false;

            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.RowHeadersVisible = false;
        }

        // Clears selected order tracking information.
        private void ClearTrackingDetails()
        {
            lblSelectedOrder.Text =
                "Selected Order: None";

            lblDeliveryMethod.Text =
                "Delivery Method: -";

            lblPaymentMethod.Text =
                "Payment Method: -";

            lblPaymentStatus.Text =
                "Payment Status: -";

            lblPrescriptionStatus.Text =
                "Prescription Status: -";

            lblAdminNote.Text =
                "-";

            selectedOrderId = 0;
        }

        // Loads tracking information for the selected order row.
        private void LoadTrackingDetails(DataGridViewRow row)
        {
            string orderId =
                row.Cells["OrderId"].Value.ToString();

            selectedOrderId =
                Convert.ToInt32(orderId);

            lblSelectedOrder.Text =
                "Selected Order: #" + orderId;

            string deliveryMethod =
                GetCellValue(row, "DeliveryMethod");

            string paymentMethod =
                GetCellValue(row, "PaymentMethod");

            string paymentStatus =
                GetCellValue(row, "PaymentStatus");

            string prescriptionRequired =
                GetCellValue(row, "PrescriptionRequired");

            string prescriptionStatus =
                GetCellValue(row, "PrescriptionStatus");

            string adminNote =
                GetCellValue(row, "AdminNote");

            lblDeliveryMethod.Text =
                "Delivery Method: " +
                (string.IsNullOrWhiteSpace(deliveryMethod)
                    ? "-"
                    : deliveryMethod);

            lblPaymentMethod.Text =
                "Payment Method: " +
                (string.IsNullOrWhiteSpace(paymentMethod)
                    ? "-"
                    : paymentMethod);

            lblPaymentStatus.Text =
                "Payment Status: " +
                (string.IsNullOrWhiteSpace(paymentStatus)
                    ? "-"
                    : paymentStatus);

            string requiredText =
                prescriptionRequired == "True"
                ? "Required"
                : "Not Required";

            lblPrescriptionStatus.Text =
                "Prescription Status: " +
                requiredText +
                " / " +
                (string.IsNullOrWhiteSpace(prescriptionStatus)
                    ? "-"
                    : prescriptionStatus);

            lblAdminNote.Text =
                string.IsNullOrWhiteSpace(adminNote)
                ? "-"
                : adminNote;
        }

        // Safely reads a cell value from the orders grid.
        private string GetCellValue(
            DataGridViewRow row,
            string columnName)
        {
            if (!dgvOrders.Columns.Contains(columnName))
                return "";

            object value =
                row.Cells[columnName].Value;

            if (value == null || value == DBNull.Value)
                return "";

            return value.ToString();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
            ClearTrackingDetails();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSummary();
            LoadOrders();
            ClearTrackingDetails();
        }

        // Displays tracking details when the customer selects an order.
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvOrders.Rows[e.RowIndex];

            LoadTrackingDetails(row);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Opens the invoice form for the selected order.
        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            InvoiceForm invoiceForm =
                new InvoiceForm(selectedOrderId);

            invoiceForm.ShowDialog();
        }
    }
}