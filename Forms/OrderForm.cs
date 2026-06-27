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
     * Handles admin-side order creation.
     * Admin users can select a customer, add medicines to a cart,
     * calculate totals and place an order.
     */
    public partial class OrderForm : Form
    {
        private readonly OrderRepository orderRepository =
            new OrderRepository();

        private readonly OrderService orderService =
            new OrderService();

        private readonly List<OrderItem> cartItems =
            new List<OrderItem>();

        private decimal subTotal = 0;
        private decimal discountTotal = 0;
        private decimal taxTotal = 0;
        private decimal grandTotal = 0;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadMedicines();
            SetupCartGrid();
            UpdateTotals();
        }

        // Loads customers into the customer combo box.
        private void LoadCustomers()
        {
            cmbCustomer.DataSource =
                orderRepository.GetCustomers();

            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "CustomerId";
        }

        // Loads available medicines into the medicine combo box.
        private void LoadMedicines()
        {
            cmbMedicine.DataSource =
                orderRepository.GetMedicines();

            cmbMedicine.DisplayMember = "MedicineName";
            cmbMedicine.ValueMember = "MedicineId";
        }

        // Prepares the cart grid for displaying selected order items.
        private void SetupCartGrid()
        {
            dgvCart.AutoGenerateColumns = true;
            dgvCart.DataSource = null;
        }

        // Refreshes the cart grid after items are added or cleared.
        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cartItems;
        }

        // Calculates subtotal, discount, tax, delivery fee and grand total.
        private void UpdateTotals()
        {
            subTotal = 0;
            discountTotal = 0;
            taxTotal = 0;

            foreach (OrderItem item in cartItems)
            {
                decimal itemSubTotal =
                    item.UnitPrice * item.Quantity;

                subTotal += itemSubTotal;
                discountTotal += item.Discount;
                taxTotal += item.Tax;
            }

            decimal deliveryFee = 0;
            decimal.TryParse(txtDeliveryFee.Text.Trim(), out deliveryFee);

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

        // Adds the selected medicine to the order cart.
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbMedicine.SelectedValue == null)
            {
                MessageBox.Show("Please select a medicine.");
                return;
            }

            int quantity;

            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return;
            }

            DataRowView selectedMedicine =
                cmbMedicine.SelectedItem as DataRowView;

            int medicineId =
                Convert.ToInt32(selectedMedicine["MedicineId"]);

            string medicineName =
                selectedMedicine["MedicineName"].ToString();

            decimal unitPrice =
                Convert.ToDecimal(selectedMedicine["SellingPrice"]);

            decimal discountPercentage =
                Convert.ToDecimal(selectedMedicine["DiscountPercentage"]);

            decimal taxPercentage =
                Convert.ToDecimal(selectedMedicine["TaxPercentage"]);

            int availableStock =
                Convert.ToInt32(selectedMedicine["StockQuantity"]);

            // Prevents adding more quantity than available stock.
            if (quantity > availableStock)
            {
                MessageBox.Show(
                    "Not enough stock. Available stock: " + availableStock);

                return;
            }

            decimal discountAmount;
            decimal taxAmount;

            // OrderService handles business calculation for each order item.
            decimal total =
                orderService.CalculateItemTotal(
                    unitPrice,
                    quantity,
                    discountPercentage,
                    taxPercentage,
                    out discountAmount,
                    out taxAmount);

            OrderItem item =
                new OrderItem
                {
                    MedicineId = medicineId,
                    MedicineName = medicineName,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    Discount = discountAmount,
                    Tax = taxAmount,
                    Total = total,
                    AvailableStock = availableStock
                };

            cartItems.Add(item);

            RefreshCart();
            UpdateTotals();

            txtQuantity.Clear();
            txtQuantity.Focus();
        }

        // Creates the order object and saves it through the service layer.
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Please add at least one item.");
                return;
            }

            decimal deliveryFee = 0;
            decimal.TryParse(txtDeliveryFee.Text.Trim(), out deliveryFee);

            Order order =
                new Order
                {
                    CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue),
                    OrderDate = DateTime.Now,
                    Status = "Pending",
                    SubTotal = subTotal,
                    DiscountAmount = discountTotal,
                    TaxAmount = taxTotal,
                    DeliveryFee = deliveryFee,
                    GrandTotal = grandTotal,
                    Items = cartItems
                };

            orderService.PlaceOrder(order);

            MessageBox.Show("Order placed successfully.");

            ClearForm();
        }

        // Clears the order form.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Recalculates totals when delivery fee changes.
        private void txtDeliveryFee_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Resets cart, fields and reloads medicine stock values.
        private void ClearForm()
        {
            cartItems.Clear();

            RefreshCart();

            txtQuantity.Clear();
            txtDeliveryFee.Text = "0";

            if (cmbCustomer.Items.Count > 0)
                cmbCustomer.SelectedIndex = 0;

            if (cmbMedicine.Items.Count > 0)
                cmbMedicine.SelectedIndex = 0;

            UpdateTotals();
            LoadMedicines();
        }
    }
}