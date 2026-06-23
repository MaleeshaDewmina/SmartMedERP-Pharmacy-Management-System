using System;
using System.Windows.Controls;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;

namespace SmartMed.Forms
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierRepository supplierRepository =
            new SupplierRepository();

        private int selectedSupplierId = 0;

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource =
                supplierRepository.GetAllSuppliers();
        }

        private void ClearFields()
        {
            selectedSupplierId = 0;
            txtSupplierName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSearch.Clear();
            txtSupplierName.Focus();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter supplier name.");
                txtSupplierName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Supplier supplier = new Supplier
            {
                SupplierName = txtSupplierName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            supplierRepository.AddSupplier(supplier);

            MessageBox.Show("Supplier saved successfully.");

            LoadSuppliers();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            if (!ValidateFields())
                return;

            Supplier supplier = new Supplier
            {
                SupplierId = selectedSupplierId,
                SupplierName = txtSupplierName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            supplierRepository.UpdateSupplier(supplier);

            MessageBox.Show("Supplier updated successfully.");

            LoadSuppliers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this supplier?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                supplierRepository.DeleteSupplier(selectedSupplierId);

                MessageBox.Show("Supplier deleted successfully.");

                LoadSuppliers();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadSuppliers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            dgvSuppliers.DataSource =
                string.IsNullOrWhiteSpace(keyword)
                ? supplierRepository.GetAllSuppliers()
                : supplierRepository.SearchSuppliers(keyword);
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSuppliers.Rows[e.RowIndex];

                selectedSupplierId =
                    Convert.ToInt32(row.Cells["SupplierId"].Value);

                txtSupplierName.Text =
                    row.Cells["SupplierName"].Value.ToString();

                txtPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                txtEmail.Text =
                    row.Cells["Email"].Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value.ToString();
            }
        }
    }
}