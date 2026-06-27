using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;

namespace SmartMed.Forms
{
    /*
     * Handles medicine category management.
     * Admin users can add, update, search and delete medicine categories.
     */
    public partial class CategoryForm : Form
    {
        private readonly CategoryRepository categoryRepository =
            new CategoryRepository();

        private int selectedCategoryId = 0;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        // Loads all categories into the grid.
        private void LoadCategories()
        {
            dgvCategories.DataSource =
                categoryRepository.GetAllCategories();
        }

        // Clears input fields and resets the form state.
        private void ClearFields()
        {
            selectedCategoryId = 0;
            txtCategoryName.Clear();
            txtDescription.Clear();
            txtSearch.Clear();
            chkIsActive.Checked = true;
            txtCategoryName.Focus();
        }

        // Validates required category input.
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter category name.");
                txtCategoryName.Focus();
                return false;
            }

            return true;
        }

        // Saves a new medicine category.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                Category category = new Category
                {
                    CategoryName = txtCategoryName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    IsActive = chkIsActive.Checked
                };

                categoryRepository.AddCategory(category);

                MessageBox.Show("Category saved successfully.");

                LoadCategories();
                ClearFields();
            }
            catch (SqlException ex)
            {
                // Handles duplicate category name errors.
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This category already exists.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        // Updates the selected category.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category first.");
                return;
            }

            if (!ValidateFields())
                return;

            Category category = new Category
            {
                CategoryId = selectedCategoryId,
                CategoryName = txtCategoryName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                IsActive = chkIsActive.Checked
            };

            categoryRepository.UpdateCategory(category);

            MessageBox.Show("Category updated successfully.");

            LoadCategories();
            ClearFields();
        }

        // Deletes the selected category after confirmation.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category first.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this category?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                categoryRepository.DeleteCategory(selectedCategoryId);

                MessageBox.Show("Category deleted successfully.");

                LoadCategories();
                ClearFields();
            }
        }

        // Clears form fields and reloads all categories.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadCategories();
        }

        // Searches categories while the admin types.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadCategories();
            }
            else
            {
                dgvCategories.DataSource =
                    categoryRepository.SearchCategories(keyword);
            }
        }

        // Loads selected category details into the form fields.
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCategories.Rows[e.RowIndex];

                selectedCategoryId =
                    Convert.ToInt32(row.Cells["CategoryId"].Value);

                txtCategoryName.Text =
                    row.Cells["CategoryName"].Value.ToString();

                txtDescription.Text =
                    row.Cells["Description"].Value.ToString();

                chkIsActive.Checked =
                    Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }
    }
}