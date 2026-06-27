using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Allows customers to search available medicines and add them to cart.
     * The cart is saved in the database so the customer can continue checkout later.
     */
    public partial class CustomerMedicineSearchForm : Form
    {
        private readonly CustomerMedicineRepository medicineRepository =
            new CustomerMedicineRepository();

        private readonly List<OrderItem> cartItems =
            new List<OrderItem>();

        private readonly CartService cartService =
            new CartService();

        private int currentCustomerId = 0;

        private decimal subTotal = 0;
        private decimal discountTotal = 0;
        private decimal taxTotal = 0;
        private decimal grandTotal = 0;

        public CustomerMedicineSearchForm()
        {
            InitializeComponent();

            btnPlaceOrder.Click -= btnPlaceOrder_Click;
            btnPlaceOrder.Click += btnPlaceOrder_Click;

            // Prevents grid formatting errors from interrupting the user.
            dgvMedicines.DataError -= dgvMedicines_DataError;
            dgvMedicines.DataError += dgvMedicines_DataError;
        }

        private void CustomerMedicineSearchForm_Load(object sender, EventArgs e)
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
                medicineRepository.GetCustomerIdByUserId(
                    SessionManager.CurrentUser.UserId);

            if (currentCustomerId == 0)
            {
                MessageBox.Show("Customer profile not found.");
                this.Hide();
                return;
            }

            LoadMedicines();
            SetupCartGrid();
            LoadSavedCartPreview();
        }

        // Loads all active medicines available for customer purchase.
        private void LoadMedicines()
        {
            dgvMedicines.DataSource =
                medicineRepository.GetAvailableMedicines();

            FormatMedicineGrid();
        }

        // Hides internal columns and shows only customer-friendly medicine details.
        private void FormatMedicineGrid()
        {
            if (dgvMedicines.Columns.Count == 0)
                return;

            foreach (DataGridViewColumn column in dgvMedicines.Columns)
            {
                column.Visible = false;
            }

            ShowMedicineColumn("MedicineName", "Medicine Name", 180);
            ShowMedicineColumn("GenericName", "Generic Name", 150);
            ShowMedicineColumn("BrandName", "Brand", 120);
            ShowMedicineColumn("CategoryName", "Category", 130);
            ShowMedicineColumn("SellingPrice", "Price", 90);
            ShowMedicineColumn("StockQuantity", "Available Stock", 110);
            ShowMedicineColumn("PrescriptionRequired", "Prescription", 100);
            ShowMedicineColumn("ExpiryDate", "Expiry Date", 120);

            if (dgvMedicines.Columns.Contains("SellingPrice"))
            {
                dgvMedicines.Columns["SellingPrice"].DefaultCellStyle.Format =
                    "N2";

                dgvMedicines.Columns["SellingPrice"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvMedicines.Columns.Contains("StockQuantity"))
            {
                dgvMedicines.Columns["StockQuantity"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMedicines.Columns.Contains("PrescriptionRequired"))
            {
                dgvMedicines.Columns["PrescriptionRequired"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMedicines.Columns.Contains("ExpiryDate"))
            {
                dgvMedicines.Columns["ExpiryDate"].DefaultCellStyle.Format =
                    "yyyy-MM-dd";

                dgvMedicines.Columns["ExpiryDate"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            dgvMedicines.ReadOnly = true;
            dgvMedicines.AllowUserToAddRows = false;
            dgvMedicines.AllowUserToDeleteRows = false;
            dgvMedicines.MultiSelect = false;
            dgvMedicines.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicines.RowHeadersVisible = false;
        }

        // Makes a selected medicine column visible and sets its display header.
        private void ShowMedicineColumn(
            string columnName,
            string headerText,
            int width)
        {
            if (dgvMedicines.Columns.Contains(columnName))
            {
                dgvMedicines.Columns[columnName].Visible = true;
                dgvMedicines.Columns[columnName].HeaderText = headerText;
                dgvMedicines.Columns[columnName].Width = width;
            }
        }

        private void dgvMedicines_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
        }

        // Prepares the small cart preview grid shown inside the search form.
        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("MedicineId", "MedicineId");
            dgvCart.Columns.Add("MedicineName", "Medicine");
            dgvCart.Columns.Add("Quantity", "Qty");
            dgvCart.Columns.Add("UnitPrice", "Price");
            dgvCart.Columns.Add("Discount", "Discount");
            dgvCart.Columns.Add("Tax", "Tax");
            dgvCart.Columns.Add("Total", "Total");

            dgvCart.Columns["MedicineId"].Visible = false;

            dgvCart.ReadOnly = true;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.MultiSelect = false;
            dgvCart.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCart.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.RowHeadersVisible = false;
        }

        // Displays saved cart items in the preview grid.
        private void LoadCartGrid()
        {
            dgvCart.Rows.Clear();

            foreach (OrderItem item in cartItems)
            {
                dgvCart.Rows.Add(
                    item.MedicineId,
                    item.MedicineName,
                    item.Quantity,
                    item.UnitPrice.ToString("N2"),
                    item.Discount.ToString("N2"),
                    item.Tax.ToString("N2"),
                    item.Total.ToString("N2"));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMedicines();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchMedicines();
        }

        // Searches medicines by keyword and refreshes the customer-friendly grid.
        private void SearchMedicines()
        {
            string keyword =
                txtSearch.Text.Trim();

            dgvMedicines.DataSource =
                string.IsNullOrWhiteSpace(keyword)
                ? medicineRepository.GetAvailableMedicines()
                : medicineRepository.SearchAvailableMedicines(keyword);

            FormatMedicineGrid();
        }

        // Validates quantity and adds the selected medicine to the saved cart.
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvMedicines.CurrentRow == null)
            {
                MessageBox.Show("Please select a medicine first.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                txtQuantity.Focus();
                return;
            }

            DataGridViewRow row =
                dgvMedicines.CurrentRow;

            int medicineId =
                Convert.ToInt32(row.Cells["MedicineId"].Value);

            try
            {
                cartService.AddToCart(
                    currentCustomerId,
                    medicineId,
                    quantity);

                MessageBox.Show("Medicine added to cart.");

                LoadSavedCartPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add to cart failed: " + ex.Message);
            }
        }

        // Calculates and displays cart preview totals.
        private void UpdateTotals()
        {
            subTotal = 0;
            discountTotal = 0;
            taxTotal = 0;

            foreach (OrderItem item in cartItems)
            {
                subTotal += item.UnitPrice * item.Quantity;
                discountTotal += item.Discount;
                taxTotal += item.Tax;
            }

            decimal deliveryFee = 0;

            if (!string.IsNullOrWhiteSpace(txtDeliveryFee.Text))
            {
                decimal.TryParse(
                    txtDeliveryFee.Text.Trim(),
                    out deliveryFee);
            }

            grandTotal =
                subTotal - discountTotal + taxTotal + deliveryFee;

            lblSubTotal.Text =
                "Rs. " + subTotal.ToString("N2");

            lblDiscount.Text =
                "Rs. " + discountTotal.ToString("N2");

            lblTax.Text =
                "Rs. " + taxTotal.ToString("N2");

            lblGrandTotal.Text =
                "Rs. " + grandTotal.ToString("N2");
        }

        private void txtDeliveryFee_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Opens the full cart form before checkout.
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            CustomerCartForm cartForm =
                new CustomerCartForm(currentCustomerId);

            if (cartForm.ShowDialog() == DialogResult.OK)
            {
                LoadSavedCartPreview();
                LoadMedicines();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        // Clears all saved cart items after customer confirmation.
        private void ClearCart()
        {
            DialogResult result =
                MessageBox.Show(
                    "Clear all saved cart items?",
                    "Confirm Clear Cart",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                cartService.ClearCart(currentCustomerId);

                cartItems.Clear();
                dgvCart.Rows.Clear();

                txtQuantity.Text = "1";
                txtDeliveryFee.Text = "0";

                UpdateTotals();

                MessageBox.Show("Cart cleared.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clear cart failed: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Loads saved cart items from the database into the preview grid.
        private void LoadSavedCartPreview()
        {
            cartItems.Clear();

            List<OrderItem> savedItems =
                cartService.GetCartOrderItems(currentCustomerId);

            cartItems.AddRange(savedItems);

            LoadCartGrid();
            UpdateTotals();
        }

        private void dgvMedicines_DataError(
            object sender,
            DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}