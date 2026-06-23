using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
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

        private void LoadMembershipLevels()
        {
            cmbMembershipLevel.Items.Clear();
            cmbMembershipLevel.Items.Add("Bronze");
            cmbMembershipLevel.Items.Add("Silver");
            cmbMembershipLevel.Items.Add("Gold");
            cmbMembershipLevel.Items.Add("Platinum");
            cmbMembershipLevel.SelectedIndex = 0;
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource =
                customerRepository.GetAllCustomers();
        }

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

            if (isNewCustomer && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                txtPassword.Focus();
                return false;
            }

            return true;
        }

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


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            dgvCustomers.DataSource =
                string.IsNullOrWhiteSpace(keyword)
                ? customerRepository.GetAllCustomers()
                : customerRepository.SearchCustomers(keyword);
        }

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
                    selectedIsActive ? "Block Customer" : "Activate Customer";

                txtUsername.Enabled = false;
                txtPassword.Clear();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateFields(true))
                return;

            try
            {
                Customer customer = GetCustomerFromForm();

                customerService.RegisterCustomer(
                    customer,
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim());

                MessageBox.Show("Customer saved successfully.");

                LoadCustomers();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Username or email already exists.");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBlock_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            customerService.ToggleStatus(
                selectedUserId,
                selectedIsActive);

            MessageBox.Show("Customer status updated.");

            LoadCustomers();
            ClearFields();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            if (!ValidateFields(false))
                return;

            Customer customer = GetCustomerFromForm();

            customerService.UpdateCustomer(customer);

            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                customerService.ResetPassword(
                    selectedUserId,
                    txtPassword.Text.Trim());
            }

            MessageBox.Show("Customer updated successfully.");

            LoadCustomers();
            ClearFields();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            LoadCustomers();
        }
    }
}