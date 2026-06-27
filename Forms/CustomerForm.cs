using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Handles admin-side customer management.
     * Admins can add customers, update customer details,
     * reset passwords, block or activate accounts and search customers.
     */
    public partial class CustomerForm : Form
    {
        private readonly CustomerRepository customerRepository =
            new CustomerRepository();

        private readonly CustomerService customerService =
            new CustomerService();

        private int selectedCustomerId = 0;
        private int selectedUserId = 0;
        private bool selectedIsActive = true;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadMembershipLevels();
            LoadCustomers();
        }

        // Loads loyalty membership levels into the combo box.
        private void LoadMembershipLevels()
        {
            cmbMembershipLevel.Items.Clear();

            cmbMembershipLevel.Items.Add("Bronze");
            cmbMembershipLevel.Items.Add("Silver");
            cmbMembershipLevel.Items.Add("Gold");
            cmbMembershipLevel.Items.Add("Platinum");

            cmbMembershipLevel.SelectedIndex = 0;
        }

        // Loads all customer records into the grid.
        private void LoadCustomers()
        {
            dgvCustomers.DataSource =
                customerRepository.GetAllCustomers();
        }

        // Clears all input fields and resets selected customer data.
        private void ClearFields()
        {
            selectedCustomerId = 0;
            selectedUserId = 0;
            selectedIsActive = true;

            txtFullName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtSearch.Clear();

            cmbMembershipLevel.SelectedIndex = 0;

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;

            btnBlock.Text = "Block / Activate";

            txtFullName.Focus();
        }

        // Validates customer input before saving or updating.
        private bool ValidateFields(bool isNewCustomer)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name.");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.");
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.");
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address.");
                txtAddress.Focus();
                return false;
            }

            // Password is required only when creating a new customer.
            if (isNewCustomer && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                txtPassword.Focus();
                return false;
            }

            if (isNewCustomer && txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        // Creates a Customer model object using form input values.
        private Customer GetCustomerFromForm()
        {
            return new Customer
            {
                CustomerId = selectedCustomerId,
                UserId = selectedUserId,
                FullName = txtFullName.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                MembershipLevel = cmbMembershipLevel.Text,
                LoyaltyPoints = 0,
                IsActive = selectedIsActive
            };
        }

        // Saves a new customer account.
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateFields(true))
                return;

            try
            {
                /*
                 * CustomerService handles registration logic,
                 * including password hashing and customer role assignment.
                 */
                customerService.RegisterCustomer(
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPassword.Text.Trim());

                MessageBox.Show("Customer saved successfully.");

                LoadCustomers();
                ClearFields();
            }
            catch (SqlException ex)
            {
                // Handles duplicate username or email database errors.
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Username or email already exists.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Updates the selected customer details.
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            if (!ValidateFields(false))
                return;

            try
            {
                Customer customer =
                    GetCustomerFromForm();

                customerService.UpdateCustomer(customer);

                /*
                 * Password reset is optional during update.
                 * If a new password is entered, it is validated and hashed.
                 */
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    if (txtPassword.Text.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters.");
                        txtPassword.Focus();
                        return;
                    }

                    customerService.ResetPassword(
                        selectedUserId,
                        txtPassword.Text.Trim());
                }

                MessageBox.Show("Customer updated successfully.");

                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        // Blocks or activates the selected customer account.
        private void btnBlock_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            try
            {
                customerService.ToggleStatus(
                    selectedUserId,
                    selectedIsActive);

                MessageBox.Show("Customer status updated.");

                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Status update failed: " + ex.Message);
            }
        }

        // Clears form fields and reloads customer data.
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            LoadCustomers();
        }

        // Searches customers while the admin types.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword =
                txtSearch.Text.Trim();

            dgvCustomers.DataSource =
                string.IsNullOrWhiteSpace(keyword)
                ? customerRepository.GetAllCustomers()
                : customerRepository.SearchCustomers(keyword);
        }

        // Loads selected customer data into the input fields.
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCustomers.Rows[e.RowIndex];

                selectedCustomerId =
                    Convert.ToInt32(row.Cells["CustomerId"].Value);

                selectedUserId =
                    Convert.ToInt32(row.Cells["UserId"].Value);

                txtFullName.Text =
                    row.Cells["FullName"].Value.ToString();

                txtUsername.Text =
                    row.Cells["Username"].Value.ToString();

                txtEmail.Text =
                    row.Cells["Email"].Value.ToString();

                txtPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value.ToString();

                cmbMembershipLevel.Text =
                    row.Cells["MembershipLevel"].Value.ToString();

                selectedIsActive =
                    Convert.ToBoolean(row.Cells["IsActive"].Value);

                btnBlock.Text =
                    selectedIsActive
                    ? "Block Customer"
                    : "Activate Customer";

                // Username should not be changed after account creation.
                txtUsername.Enabled = false;

                txtPassword.Clear();
                txtPassword.Enabled = true;
            }
        }
    }
}