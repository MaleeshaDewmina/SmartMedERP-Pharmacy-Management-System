using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SmartMedERP.Data;
using SmartMedERP.Models;
using SmartMedERP.Repositories;

namespace SmartMed.Forms
{
    public partial class MedicineForm : Form
    {
        private readonly MedicineRepository medicineRepository =
            new MedicineRepository();

        private int selectedMedicineId = 0;

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSuppliers();
            LoadMedicines();

            chkIsActive.Checked = true;
        }

        private void LoadCategories()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT CategoryId, CategoryName FROM Categories WHERE IsActive = 1",
                        con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbCategory.DataSource = table;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
        }

        private void LoadSuppliers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT SupplierId, SupplierName FROM Suppliers",
                        con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbSupplier.DataSource = table;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierId";
            }
        }

        private void LoadMedicines()
        {
            dgvMedicines.DataSource =
                medicineRepository.GetAllMedicines();
        }

        private void ClearFields()
        {
            selectedMedicineId = 0;

            txtMedicineName.Clear();
            txtGenericName.Clear();
            txtBrandName.Clear();
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtTaxPercentage.Clear();
            txtDiscountPercentage.Clear();
            txtStockQuantity.Clear();
            txtReorderLevel.Clear();
            txtBatchNumber.Clear();
            txtBarcode.Clear();
            txtQRCode.Clear();
            txtSearch.Clear();

            chkPrescriptionRequired.Checked = false;
            chkIsActive.Checked = true;

            dtpManufactureDate.Value = DateTime.Today;
            dtpExpiryDate.Value = DateTime.Today.AddYears(1);

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            if (cmbSupplier.Items.Count > 0)
                cmbSupplier.SelectedIndex = 0;

            txtMedicineName.Focus();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                MessageBox.Show("Please enter medicine name.");
                txtMedicineName.Focus();
                return false;
            }

            decimal costPrice;
            if (!decimal.TryParse(txtCostPrice.Text.Trim(), out costPrice) || costPrice < 0)
            {
                MessageBox.Show("Please enter valid cost price.");
                txtCostPrice.Focus();
                return false;
            }

            decimal sellingPrice;
            if (!decimal.TryParse(txtSellingPrice.Text.Trim(), out sellingPrice) || sellingPrice < 0)
            {
                MessageBox.Show("Please enter valid selling price.");
                txtSellingPrice.Focus();
                return false;
            }

            decimal tax;
            if (!decimal.TryParse(txtTaxPercentage.Text.Trim(), out tax) || tax < 0 || tax > 100)
            {
                MessageBox.Show("Please enter valid tax percentage between 0 and 100.");
                txtTaxPercentage.Focus();
                return false;
            }

            decimal discount;
            if (!decimal.TryParse(txtDiscountPercentage.Text.Trim(), out discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Please enter valid discount percentage between 0 and 100.");
                txtDiscountPercentage.Focus();
                return false;
            }

            int stock;
            if (!int.TryParse(txtStockQuantity.Text.Trim(), out stock) || stock < 0)
            {
                MessageBox.Show("Please enter valid stock quantity.");
                txtStockQuantity.Focus();
                return false;
            }

            int reorder;
            if (!int.TryParse(txtReorderLevel.Text.Trim(), out reorder) || reorder < 0)
            {
                MessageBox.Show("Please enter valid reorder level.");
                txtReorderLevel.Focus();
                return false;
            }

            if (dtpExpiryDate.Value.Date <= DateTime.Today)
            {
                MessageBox.Show("Expiry date must be a future date.");
                dtpExpiryDate.Focus();
                return false;
            }

            return true;
        }

        private Medicine GetMedicineFromForm()
        {
            return new Medicine
            {
                MedicineId = selectedMedicineId,
                MedicineName = txtMedicineName.Text.Trim(),
                GenericName = txtGenericName.Text.Trim(),
                BrandName = txtBrandName.Text.Trim(),
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue),
                CostPrice = Convert.ToDecimal(txtCostPrice.Text.Trim()),
                SellingPrice = Convert.ToDecimal(txtSellingPrice.Text.Trim()),
                TaxPercentage = Convert.ToDecimal(txtTaxPercentage.Text.Trim()),
                DiscountPercentage = Convert.ToDecimal(txtDiscountPercentage.Text.Trim()),
                StockQuantity = Convert.ToInt32(txtStockQuantity.Text.Trim()),
                ReorderLevel = Convert.ToInt32(txtReorderLevel.Text.Trim()),
                BatchNumber = txtBatchNumber.Text.Trim(),
                ManufactureDate = dtpManufactureDate.Value.Date,
                ExpiryDate = dtpExpiryDate.Value.Date,
                PrescriptionRequired = chkPrescriptionRequired.Checked,
                Barcode = txtBarcode.Text.Trim(),
                QRCode = txtQRCode.Text.Trim(),
                IsActive = chkIsActive.Checked
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Medicine medicine = GetMedicineFromForm();

            medicineRepository.AddMedicine(medicine);

            MessageBox.Show("Medicine saved successfully.");

            LoadMedicines();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == 0)
            {
                MessageBox.Show("Please select a medicine first.");
                return;
            }

            if (!ValidateFields())
                return;

            Medicine medicine = GetMedicineFromForm();

            medicineRepository.UpdateMedicine(medicine);

            MessageBox.Show("Medicine updated successfully.");

            LoadMedicines();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == 0)
            {
                MessageBox.Show("Please select a medicine first.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this medicine?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                medicineRepository.DeleteMedicine(selectedMedicineId);

                MessageBox.Show("Medicine deleted successfully.");

                LoadMedicines();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadMedicines();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            dgvMedicines.DataSource =
                string.IsNullOrWhiteSpace(keyword)
                ? medicineRepository.GetAllMedicines()
                : medicineRepository.SearchMedicines(keyword);
        }

        private void dgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvMedicines.Rows[e.RowIndex];

                selectedMedicineId =
                    Convert.ToInt32(row.Cells["MedicineId"].Value);

                txtMedicineName.Text = row.Cells["MedicineName"].Value.ToString();
                txtGenericName.Text = row.Cells["GenericName"].Value.ToString();
                txtBrandName.Text = row.Cells["BrandName"].Value.ToString();

                cmbCategory.SelectedValue =
                    Convert.ToInt32(row.Cells["CategoryId"].Value);

                cmbSupplier.SelectedValue =
                    Convert.ToInt32(row.Cells["SupplierId"].Value);

                txtCostPrice.Text = row.Cells["CostPrice"].Value.ToString();
                txtSellingPrice.Text = row.Cells["SellingPrice"].Value.ToString();
                txtTaxPercentage.Text = row.Cells["TaxPercentage"].Value.ToString();
                txtDiscountPercentage.Text = row.Cells["DiscountPercentage"].Value.ToString();
                txtStockQuantity.Text = row.Cells["StockQuantity"].Value.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();
                txtBatchNumber.Text = row.Cells["BatchNumber"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtQRCode.Text = row.Cells["QRCode"].Value.ToString();

                dtpManufactureDate.Value =
                    Convert.ToDateTime(row.Cells["ManufactureDate"].Value);

                dtpExpiryDate.Value =
                    Convert.ToDateTime(row.Cells["ExpiryDate"].Value);

                chkPrescriptionRequired.Checked =
                    Convert.ToBoolean(row.Cells["PrescriptionRequired"].Value);

                chkIsActive.Checked =
                    Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }
    }
}