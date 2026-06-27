using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Displays and manages the customer's saved cart.
     * Customers can update quantities, remove items, clear the cart
     * and continue to checkout from this form.
     */
    public partial class CustomerCartForm : Form
    {
        private readonly CartService cartService =
            new CartService();

        private List<OrderItem> cartItems =
            new List<OrderItem>();

        private int currentCustomerId = 0;
        private int selectedMedicineId = 0;

        private decimal subTotal = 0;
        private decimal discountTotal = 0;
        private decimal taxTotal = 0;
        private decimal grandTotal = 0;

        public CustomerCartForm()
        {
            InitializeComponent();
            AttachGridEvents();
        }

        public CustomerCartForm(int customerId)
        {
            InitializeComponent();

            currentCustomerId = customerId;

            AttachGridEvents();
        }

        // Attaches grid events safely and prevents duplicate event execution.
        private void AttachGridEvents()
        {
            dgvCartItems.CellClick -= dgvCartItems_CellClick;
            dgvCartItems.CellClick += dgvCartItems_CellClick;

            dgvCartItems.SelectionChanged -= dgvCartItems_SelectionChanged;
            dgvCartItems.SelectionChanged += dgvCartItems_SelectionChanged;
        }

        private void CustomerCartForm_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Session expired. Please login again.");
                this.Close();
                return;
            }

            if (currentCustomerId == 0)
            {
                currentCustomerId =
                    cartService.GetCustomerIdByUserId(
                        SessionManager.CurrentUser.UserId);
            }

            if (currentCustomerId == 0)
            {
                MessageBox.Show("Customer profile not found.");
                this.Close();
                return;
            }

            SetupGrid();
            LoadCart();
        }

        // Prepares the cart item grid with customer-friendly columns.
        private void SetupGrid()
        {
            dgvCartItems.Columns.Clear();

            dgvCartItems.Columns.Add("MedicineId", "MedicineId");
            dgvCartItems.Columns.Add("MedicineName", "Medicine");
            dgvCartItems.Columns.Add("Quantity", "Qty");
            dgvCartItems.Columns.Add("UnitPrice", "Price");
            dgvCartItems.Columns.Add("Discount", "Discount");
            dgvCartItems.Columns.Add("Tax", "Tax");
            dgvCartItems.Columns.Add("Total", "Total");
            dgvCartItems.Columns.Add("AvailableStock", "Stock");

            dgvCartItems.Columns["MedicineId"].Visible = false;

            dgvCartItems.ReadOnly = true;
            dgvCartItems.AllowUserToAddRows = false;
            dgvCartItems.AllowUserToDeleteRows = false;
            dgvCartItems.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCartItems.MultiSelect = false;
            dgvCartItems.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItems.RowHeadersVisible = false;

            dgvCartItems.ColumnHeadersHeight = 35;
            dgvCartItems.RowTemplate.Height = 32;
        }

        // Loads saved cart items and calculates cart totals.
        private void LoadCart()
        {
            selectedMedicineId = 0;
            txtQuantity.Text = "1";

            cartItems =
                cartService.GetCartOrderItems(currentCustomerId);

            dgvCartItems.Rows.Clear();

            foreach (OrderItem item in cartItems)
            {
                dgvCartItems.Rows.Add(
                    item.MedicineId,
                    item.MedicineName,
                    item.Quantity,
                    item.UnitPrice.ToString("N2"),
                    item.Discount.ToString("N2"),
                    item.Tax.ToString("N2"),
                    item.Total.ToString("N2"),
                    item.AvailableStock);
            }

            cartService.CalculateCartTotals(
                cartItems,
                out subTotal,
                out discountTotal,
                out taxTotal,
                out grandTotal);

            lblSubTotal.Text =
                "Sub Total: Rs. " + subTotal.ToString("N2");

            lblDiscount.Text =
                "Discount: Rs. " + discountTotal.ToString("N2");

            lblTax.Text =
                "Tax: Rs. " + taxTotal.ToString("N2");

            lblGrandTotal.Text =
                "Grand Total: Rs. " + grandTotal.ToString("N2");

            // Select the first row automatically for easier quantity updates.
            if (dgvCartItems.Rows.Count > 0)
            {
                dgvCartItems.ClearSelection();

                dgvCartItems.Rows[0].Selected = true;
                dgvCartItems.CurrentCell =
                    dgvCartItems.Rows[0].Cells["MedicineName"];

                SelectCartItemFromRow(dgvCartItems.Rows[0]);
            }
        }

        private void dgvCartItems_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SelectCartItemFromRow(dgvCartItems.Rows[e.RowIndex]);
        }

        private void dgvCartItems_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvCartItems.CurrentRow == null)
                return;

            SelectCartItemFromRow(dgvCartItems.CurrentRow);
        }

        // Stores selected medicine ID and shows its quantity in the textbox.
        private void SelectCartItemFromRow(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow)
                return;

            if (!dgvCartItems.Columns.Contains("MedicineId"))
                return;

            object medicineIdValue =
                row.Cells["MedicineId"].Value;

            if (medicineIdValue == null ||
                medicineIdValue == DBNull.Value)
                return;

            selectedMedicineId =
                Convert.ToInt32(medicineIdValue);

            if (dgvCartItems.Columns.Contains("Quantity"))
            {
                object quantityValue =
                    row.Cells["Quantity"].Value;

                if (quantityValue != null &&
                    quantityValue != DBNull.Value)
                {
                    txtQuantity.Text =
                        quantityValue.ToString();
                }
            }
        }

        // Validates and updates the quantity of the selected cart item.
        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == 0)
            {
                if (dgvCartItems.CurrentRow != null)
                {
                    SelectCartItemFromRow(dgvCartItems.CurrentRow);
                }
            }

            if (selectedMedicineId == 0)
            {
                MessageBox.Show("Please select a cart item.");
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

            try
            {
                cartService.UpdateQuantity(
                    currentCustomerId,
                    selectedMedicineId,
                    quantity);

                MessageBox.Show("Cart quantity updated.");

                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update quantity failed: " + ex.Message);
            }
        }

        // Removes the selected medicine from the cart after confirmation.
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == 0)
            {
                if (dgvCartItems.CurrentRow != null)
                {
                    SelectCartItemFromRow(dgvCartItems.CurrentRow);
                }
            }

            if (selectedMedicineId == 0)
            {
                MessageBox.Show("Please select a cart item.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Remove selected item from cart?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                cartService.RemoveCartItem(
                    currentCustomerId,
                    selectedMedicineId);

                MessageBox.Show("Item removed from cart.");

                selectedMedicineId = 0;

                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Remove item failed: " + ex.Message);
            }
        }

        // Clears every item in the customer's saved cart.
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is already empty.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Clear all cart items?",
                    "Confirm Clear Cart",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                cartService.ClearCart(currentCustomerId);

                MessageBox.Show("Cart cleared.");

                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clear cart failed: " + ex.Message);
            }
        }

        // Opens checkout form with cart items and calculated totals.
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            LoadCart();

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            decimal deliveryFee = 0;

            CheckoutForm checkoutForm =
                new CheckoutForm(
                    currentCustomerId,
                    cartItems,
                    subTotal,
                    discountTotal,
                    taxTotal,
                    deliveryFee,
                    grandTotal);

            if (checkoutForm.ShowDialog() == DialogResult.OK)
            {
                /*
                 * Cart is cleared only after checkout succeeds.
                 * This prevents losing cart items if checkout fails.
                 */
                cartService.ClearCart(currentCustomerId);

                MessageBox.Show("Cart cleared after successful order.");

                LoadCart();

                this.DialogResult = DialogResult.OK;
            }
        }

        // Reloads latest cart data from the database.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}