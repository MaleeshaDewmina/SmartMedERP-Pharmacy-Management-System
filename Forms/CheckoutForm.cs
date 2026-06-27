using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Handles the customer checkout process.
     * This form validates delivery details, prescription uploads, payment method,
     * order placement, loyalty points and audit logging.
     */
    public partial class CheckoutForm : Form
    {
        private readonly CheckoutRepository checkoutRepository =
            new CheckoutRepository();

        private readonly OrderService orderService =
            new OrderService();

        private int currentCustomerId = 0;

        private List<OrderItem> cartItems =
            new List<OrderItem>();

        private decimal subTotal = 0;
        private decimal discountTotal = 0;
        private decimal taxTotal = 0;
        private decimal deliveryFee = 0;
        private decimal grandTotal = 0;

        private bool prescriptionRequired = false;
        private string selectedPrescriptionFilePath = "";

        public CheckoutForm()
        {
            InitializeComponent();
        }

        public CheckoutForm(
            int customerId,
            List<OrderItem> items,
            decimal subTotal,
            decimal discountTotal,
            decimal taxTotal,
            decimal deliveryFee,
            decimal grandTotal)
        {
            InitializeComponent();

            this.currentCustomerId = customerId;
            this.cartItems = items;
            this.subTotal = subTotal;
            this.discountTotal = discountTotal;
            this.taxTotal = taxTotal;
            this.deliveryFee = deliveryFee;
            this.grandTotal = grandTotal;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            SetupCheckoutGrid();
            LoadCheckoutItems();
            LoadTotals();
            LoadDefaultCustomerDetails();
            CheckPrescriptionRequirement();
        }

        // Loads delivery and payment options used during checkout.
        private void LoadComboBoxes()
        {
            cmbDeliveryMethod.Items.Clear();
            cmbDeliveryMethod.Items.Add("Delivery");
            cmbDeliveryMethod.Items.Add("Pickup");
            cmbDeliveryMethod.SelectedIndex = 0;

            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash on Delivery");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Online Payment");
            cmbPaymentMethod.SelectedIndex = 0;
        }

        // Prepares the checkout items grid.
        private void SetupCheckoutGrid()
        {
            dgvCheckoutItems.Columns.Clear();

            dgvCheckoutItems.Columns.Add("MedicineName", "Medicine");
            dgvCheckoutItems.Columns.Add("Quantity", "Qty");
            dgvCheckoutItems.Columns.Add("UnitPrice", "Price");
            dgvCheckoutItems.Columns.Add("Total", "Total");

            dgvCheckoutItems.ReadOnly = true;
            dgvCheckoutItems.AllowUserToAddRows = false;
            dgvCheckoutItems.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCheckoutItems.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckoutItems.RowHeadersVisible = false;
        }

        // Displays selected cart items before confirming the order.
        private void LoadCheckoutItems()
        {
            dgvCheckoutItems.Rows.Clear();

            foreach (OrderItem item in cartItems)
            {
                dgvCheckoutItems.Rows.Add(
                    item.MedicineName,
                    item.Quantity,
                    item.UnitPrice.ToString("N2"),
                    item.Total.ToString("N2"));
            }
        }

        // Displays order summary totals.
        private void LoadTotals()
        {
            lblSubTotal.Text =
                "Rs. " + subTotal.ToString("N2");

            lblDiscount.Text =
                "Rs. " + discountTotal.ToString("N2");

            lblTax.Text =
                "Rs. " + taxTotal.ToString("N2");

            lblDeliveryFee.Text =
                "Rs. " + deliveryFee.ToString("N2");

            lblGrandTotal.Text =
                "Rs. " + grandTotal.ToString("N2");
        }

        // Loads saved customer phone and address as default delivery details.
        private void LoadDefaultCustomerDetails()
        {
            Customer customer =
                checkoutRepository.GetCustomerCheckoutDetails(
                    currentCustomerId);

            if (customer == null)
            {
                MessageBox.Show("Customer details not found.");
                return;
            }

            txtDeliveryPhone.Text =
                customer.Phone;

            txtDeliveryAddress.Text =
                customer.Address;
        }

        // Checks whether any medicine in the order requires a prescription.
        private void CheckPrescriptionRequirement()
        {
            prescriptionRequired = false;

            foreach (OrderItem item in cartItems)
            {
                if (item.PrescriptionRequired)
                {
                    prescriptionRequired = true;
                    break;
                }
            }

            if (prescriptionRequired)
            {
                lblPrescriptionRequired.Text =
                    "Prescription Required: Yes";

                lblPrescriptionRequired.ForeColor =
                    System.Drawing.Color.FromArgb(220, 53, 69);

                btnBrowsePrescription.Enabled = true;
                txtPrescriptionFile.Enabled = true;
            }
            else
            {
                lblPrescriptionRequired.Text =
                    "Prescription Required: No";

                lblPrescriptionRequired.ForeColor =
                    System.Drawing.Color.FromArgb(40, 167, 69);

                btnBrowsePrescription.Enabled = false;
                txtPrescriptionFile.Text = "Not required";
            }
        }

        private void chkUseDefaultAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseDefaultAddress.Checked)
            {
                LoadDefaultCustomerDetails();
            }
            else
            {
                txtDeliveryPhone.Clear();
                txtDeliveryAddress.Clear();
            }
        }

        private void cmbDeliveryMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeliveryMethod.Text == "Pickup")
            {
                txtDeliveryAddress.Text = "Pickup from pharmacy";
                txtDeliveryAddress.ReadOnly = true;
            }
            else
            {
                txtDeliveryAddress.ReadOnly = false;

                if (chkUseDefaultAddress.Checked)
                    LoadDefaultCustomerDetails();
            }
        }

        // Allows the customer to select a prescription file when required.
        private void btnBrowsePrescription_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog =
                new OpenFileDialog();

            openFileDialog.Title = "Select Prescription File";
            openFileDialog.Filter =
                "Prescription Files|*.jpg;*.jpeg;*.png;*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPrescriptionFilePath =
                    openFileDialog.FileName;

                txtPrescriptionFile.Text =
                    Path.GetFileName(selectedPrescriptionFilePath);
            }
        }

        // Copies the uploaded prescription into the application Prescriptions folder.
        private string SavePrescriptionFile()
        {
            if (string.IsNullOrWhiteSpace(selectedPrescriptionFilePath))
                return "";

            string folderPath =
                Path.Combine(
                    Application.StartupPath,
                    "Prescriptions");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string extension =
                Path.GetExtension(selectedPrescriptionFilePath);

            string newFileName =
                "Prescription_" +
                DateTime.Now.ToString("yyyyMMddHHmmss") +
                extension;

            string destinationPath =
                Path.Combine(folderPath, newFileName);

            File.Copy(
                selectedPrescriptionFilePath,
                destinationPath,
                true);

            return destinationPath;
        }

        // Validates checkout data, saves the order and updates customer loyalty points.
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (cartItems == null || cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeliveryPhone.Text))
            {
                MessageBox.Show("Please enter delivery phone.");
                txtDeliveryPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeliveryAddress.Text))
            {
                MessageBox.Show("Please enter delivery address.");
                txtDeliveryAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbDeliveryMethod.Text))
            {
                MessageBox.Show("Please select delivery method.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Please select payment method.");
                return;
            }

            // Prescription upload is compulsory only when the cart contains prescription medicines.
            if (prescriptionRequired &&
                string.IsNullOrWhiteSpace(selectedPrescriptionFilePath))
            {
                MessageBox.Show("Prescription is required for this order.");
                return;
            }

            try
            {
                string savedPrescriptionPath =
                    SavePrescriptionFile();

                Order order =
                    new Order
                    {
                        CustomerId = currentCustomerId,
                        OrderDate = DateTime.Now,
                        Status = "Pending",
                        SubTotal = subTotal,
                        DiscountAmount = discountTotal,
                        TaxAmount = taxTotal,
                        DeliveryFee = deliveryFee,
                        GrandTotal = grandTotal,
                        DeliveryAddress = txtDeliveryAddress.Text.Trim(),
                        DeliveryPhone = txtDeliveryPhone.Text.Trim(),
                        DeliveryMethod = cmbDeliveryMethod.Text,
                        DeliveryNote = txtDeliveryNote.Text.Trim(),
                        PaymentMethod = cmbPaymentMethod.Text,
                        PaymentStatus = "Pending",
                        PrescriptionRequired = prescriptionRequired,
                        PrescriptionFilePath = savedPrescriptionPath,
                        PrescriptionStatus =
                            prescriptionRequired
                            ? "Pending Review"
                            : "Not Required",
                        AdminNote = "",
                        Items = cartItems
                    };

                // OrderService validates the order and saves it with stock validation.
                orderService.PlaceOrder(order);

                LoyaltyService loyaltyService =
                    new LoyaltyService();

                // Loyalty points are awarded after successful order placement.
                int earnedPoints =
                    loyaltyService.AddPointsForOrder(
                        currentCustomerId,
                        grandTotal);

                AuditLogService auditLogService =
                    new AuditLogService();

                // Audit log keeps a record of customer order activity.
                auditLogService.Log(
                    "Place Order",
                    "Customer Order",
                    "Customer placed a new order with total Rs. " +
                    grandTotal.ToString("N2"));

                MessageBox.Show(
                    "Order placed successfully.\n" +
                    "You earned " + earnedPoints + " loyalty points.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout failed: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlSummary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}