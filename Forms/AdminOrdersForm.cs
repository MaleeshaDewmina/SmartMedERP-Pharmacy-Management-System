using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Allows administrators to manage customer orders.
     * Features include order status updates, payment status updates,
     * prescription verification and invoice viewing.
     */
    public partial class AdminOrdersForm : Form
    {
        private readonly AdminOrderRepository orderRepository =
            new AdminOrderRepository();

        private int selectedOrderId = 0;
        private bool selectedPrescriptionRequired = false;
        private string selectedPrescriptionFilePath = "";

        public AdminOrdersForm()
        {
            InitializeComponent();
        }

        private void AdminOrdersForm_Load(object sender, EventArgs e)
        {
            LoadStatusFilters();
            LoadOrders();
            ClearSelection();
        }

        // Loads order, update and payment status options into combo boxes.
        private void LoadStatusFilters()
        {
            cmbStatusFilter.Items.Clear();

            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Processing");
            cmbStatusFilter.Items.Add("Delivered");
            cmbStatusFilter.Items.Add("Cancelled");

            cmbStatusFilter.SelectedIndex = 0;

            cmbUpdateStatus.Items.Clear();

            cmbUpdateStatus.Items.Add("Pending");
            cmbUpdateStatus.Items.Add("Processing");
            cmbUpdateStatus.Items.Add("Delivered");
            cmbUpdateStatus.Items.Add("Cancelled");

            cmbUpdateStatus.SelectedIndex = 0;

            cmbPaymentStatus.Items.Clear();

            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Failed");
            cmbPaymentStatus.Items.Add("Refunded");

            cmbPaymentStatus.SelectedIndex = 0;
        }

        // Loads orders using the current search keyword and status filter.
        private void LoadOrders()
        {
            string keyword =
                txtSearch.Text.Trim();

            string status =
                cmbStatusFilter.Text;

            if (string.IsNullOrWhiteSpace(status))
                status = "All";

            DataTable table =
                orderRepository.GetOrders(keyword, status);

            dgvOrders.DataSource = table;

            FormatOrdersGrid();
        }

        // Formats the orders grid and hides internal data columns.
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

            if (dgvOrders.Columns.Contains("PrescriptionRequired"))
                dgvOrders.Columns["PrescriptionRequired"].HeaderText =
                    "Prescription Required";

            if (dgvOrders.Columns.Contains("PrescriptionStatus"))
                dgvOrders.Columns["PrescriptionStatus"].HeaderText =
                    "Prescription Status";

            if (dgvOrders.Columns.Contains("PrescriptionFilePath"))
                dgvOrders.Columns["PrescriptionFilePath"].Visible = false;

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

        // Loads medicine items belonging to the selected order.
        private void LoadOrderItems(int orderId)
        {
            dgvOrderItems.DataSource =
                orderRepository.GetOrderItems(orderId);

            FormatOrderItemsGrid();
        }

        // Formats the selected order item grid.
        private void FormatOrderItemsGrid()
        {
            if (dgvOrderItems.Columns.Count == 0)
                return;

            if (dgvOrderItems.Columns.Contains("MedicineName"))
                dgvOrderItems.Columns["MedicineName"].HeaderText = "Medicine";

            if (dgvOrderItems.Columns.Contains("UnitPrice"))
                dgvOrderItems.Columns["UnitPrice"].HeaderText = "Unit Price";

            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.RowHeadersVisible = false;
        }

        // Clears selected order details and disables action buttons.
        private void ClearSelection()
        {
            selectedOrderId = 0;
            selectedPrescriptionRequired = false;
            selectedPrescriptionFilePath = "";

            lblSelectedOrder.Text =
                "Selected Order: None";

            lblPrescriptionRequired.Text =
                "Prescription Required: No";

            lblPrescriptionStatus.Text =
                "Prescription Status: Not Required";

            txtSearch.Clear();

            dgvOrderItems.DataSource = null;

            btnViewPrescription.Enabled = false;
            btnApprovePrescription.Enabled = false;
            btnRejectPrescription.Enabled = false;

            if (cmbUpdateStatus.Items.Count > 0)
                cmbUpdateStatus.SelectedIndex = 0;

            if (cmbPaymentStatus.Items.Count > 0)
                cmbPaymentStatus.SelectedIndex = 0;

            btnUpdatePaymentStatus.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrders();
            ClearSelection();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
            ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
            ClearSelection();
        }

        // Loads selected order details into the admin controls.
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvOrders.Rows[e.RowIndex];

            selectedOrderId =
                Convert.ToInt32(row.Cells["OrderId"].Value);

            string currentStatus =
                row.Cells["Status"].Value.ToString();

            lblSelectedOrder.Text =
                "Selected Order: #" + selectedOrderId;

            cmbUpdateStatus.Text =
                currentStatus;

            string paymentStatus = "";

            if (row.Cells["PaymentStatus"].Value != DBNull.Value)
            {
                paymentStatus =
                    row.Cells["PaymentStatus"].Value.ToString();
            }

            if (string.IsNullOrWhiteSpace(paymentStatus))
            {
                cmbPaymentStatus.Text = "Pending";
            }
            else
            {
                cmbPaymentStatus.Text = paymentStatus;
            }

            btnUpdatePaymentStatus.Enabled = true;

            selectedPrescriptionRequired = false;

            if (row.Cells["PrescriptionRequired"].Value != DBNull.Value)
            {
                selectedPrescriptionRequired =
                    Convert.ToBoolean(row.Cells["PrescriptionRequired"].Value);
            }

            string prescriptionStatus =
                "Not Required";

            if (row.Cells["PrescriptionStatus"].Value != DBNull.Value)
            {
                prescriptionStatus =
                    row.Cells["PrescriptionStatus"].Value.ToString();
            }

            selectedPrescriptionFilePath = "";

            if (row.Cells["PrescriptionFilePath"].Value != DBNull.Value)
            {
                selectedPrescriptionFilePath =
                    row.Cells["PrescriptionFilePath"].Value.ToString();
            }

            string adminNote = "";

            if (row.Cells["AdminNote"].Value != DBNull.Value)
            {
                adminNote =
                    row.Cells["AdminNote"].Value.ToString();
            }

            txtSearch.Text =
                adminNote;

            lblPrescriptionRequired.Text =
                selectedPrescriptionRequired
                ? "Prescription Required: Yes"
                : "Prescription Required: No";

            lblPrescriptionStatus.Text =
                "Prescription Status: " + prescriptionStatus;

            btnViewPrescription.Enabled =
                selectedPrescriptionRequired &&
                !string.IsNullOrWhiteSpace(selectedPrescriptionFilePath);

            btnApprovePrescription.Enabled =
                selectedPrescriptionRequired;

            btnRejectPrescription.Enabled =
                selectedPrescriptionRequired;

            LoadOrderItems(selectedOrderId);
        }

        // Updates the selected order status after admin confirmation.
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbUpdateStatus.Text))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to update this order status?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                orderRepository.UpdateOrderStatus(
                    selectedOrderId,
                    cmbUpdateStatus.Text);

                AuditLogService auditLogService =
                    new AuditLogService();

                // Audit log records the admin action for traceability.
                auditLogService.Log(
                    "Update Order Status",
                    "Order Management",
                    "Updated order #" +
                    selectedOrderId +
                    " status to " +
                    cmbUpdateStatus.Text);

                MessageBox.Show("Order status updated successfully.");

                LoadOrders();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Status update failed: " + ex.Message);
            }
        }

        // Opens the uploaded prescription file using the default application.
        private void btnViewPrescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedPrescriptionFilePath))
            {
                MessageBox.Show("No prescription file available.");
                return;
            }

            if (!File.Exists(selectedPrescriptionFilePath))
            {
                MessageBox.Show("Prescription file not found.");
                return;
            }

            try
            {
                Process.Start(selectedPrescriptionFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open prescription file: " + ex.Message);
            }
        }

        // Approves the uploaded prescription and records the verifying admin.
        private void btnApprovePrescription_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (!selectedPrescriptionRequired)
            {
                MessageBox.Show("This order does not require prescription.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Approve this prescription?",
                    "Confirm Approval",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                int verifiedBy =
                    SessionManager.CurrentUser == null
                    ? 0
                    : SessionManager.CurrentUser.UserId;

                orderRepository.ApprovePrescription(
                    selectedOrderId,
                    txtSearch.Text.Trim(),
                    verifiedBy);

                AuditLogService auditLogService =
                    new AuditLogService();

                auditLogService.Log(
                    "Approve Prescription",
                    "Prescription Verification",
                    "Approved prescription for order #" +
                    selectedOrderId);

                MessageBox.Show("Prescription approved successfully.");

                LoadOrders();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Approval failed: " + ex.Message);
            }
        }

        // Rejects the prescription and cancels the order.
        private void btnRejectPrescription_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (!selectedPrescriptionRequired)
            {
                MessageBox.Show("This order does not require prescription.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter an admin note before rejecting.");
                txtSearch.Focus();
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Reject this prescription? This will cancel the order.",
                    "Confirm Rejection",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                int verifiedBy =
                    SessionManager.CurrentUser == null
                    ? 0
                    : SessionManager.CurrentUser.UserId;

                orderRepository.RejectPrescription(
                    selectedOrderId,
                    txtSearch.Text.Trim(),
                    verifiedBy);

                AuditLogService auditLogService =
                    new AuditLogService();

                auditLogService.Log(
                    "Reject Prescription",
                    "Prescription Verification",
                    "Rejected prescription for order #" +
                    selectedOrderId);

                MessageBox.Show("Prescription rejected and order cancelled.");

                LoadOrders();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rejection failed: " + ex.Message);
            }
        }

        // Opens the invoice for the selected order.
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

        private void pnlDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        // Updates the payment status of the selected order.
        private void btnUpdatePaymentStatus_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPaymentStatus.Text))
            {
                MessageBox.Show("Please select payment status.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to update payment status?",
                    "Confirm Payment Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                orderRepository.UpdatePaymentStatus(
                    selectedOrderId,
                    cmbPaymentStatus.Text);

                AuditLogService auditLogService =
                    new AuditLogService();

                // Store the payment update in the audit log.
                auditLogService.Log(
                    "Update Payment Status",
                    "Order Management",
                    "Updated payment status of order #" +
                    selectedOrderId +
                    " to " +
                    cmbPaymentStatus.Text);

                MessageBox.Show("Payment status updated successfully.");

                LoadOrders();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment status update failed: " + ex.Message);
            }
        }
    }
}