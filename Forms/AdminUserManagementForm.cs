using System;
using System.Windows.Forms;
using SmartMedERP.Repositories;
using SmartMedERP.Services;
using SmartMedERP.Utilities;

namespace SmartMed.Forms
{
    /*
     * Allows Super Admin users to manage administrator accounts.
     * Features include adding admins, resetting passwords,
     * activating or deactivating accounts and audit logging.
     */
    public partial class AdminUserManagementForm : Form
    {
        private readonly AdminUserRepository adminUserRepository =
            new AdminUserRepository();

        private int selectedUserId = 0;
        private bool selectedIsActive = false;

        public AdminUserManagementForm()
        {
            InitializeComponent();
        }

        private void AdminUserManagementForm_Load(object sender, EventArgs e)
        {
            // Only Super Admin users are allowed to access this form.
            if (SessionManager.CurrentUser == null ||
                SessionManager.CurrentUser.RoleName != "SuperAdmin")
            {
                MessageBox.Show("Access denied. Super Admin only.");
                this.Close();
                return;
            }

            LoadRoles();
            LoadAdminUsers();
        }

        // Loads available admin roles into the role combo box.
        private void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("SuperAdmin");
            cmbRole.SelectedIndex = 0;
        }

        // Loads all admin users into the grid.
        private void LoadAdminUsers()
        {
            dgvAdminUsers.DataSource =
                adminUserRepository.GetAdminUsers();

            FormatGrid();
            ClearInputs();
        }

        // Formats the admin users grid for clear viewing.
        private void FormatGrid()
        {
            if (dgvAdminUsers.Columns.Count == 0)
                return;

            if (dgvAdminUsers.Columns.Contains("UserId"))
                dgvAdminUsers.Columns["UserId"].Visible = false;

            if (dgvAdminUsers.Columns.Contains("RoleName"))
                dgvAdminUsers.Columns["RoleName"].HeaderText = "Role";

            if (dgvAdminUsers.Columns.Contains("IsActive"))
                dgvAdminUsers.Columns["IsActive"].HeaderText = "Active";

            dgvAdminUsers.ReadOnly = true;
            dgvAdminUsers.AllowUserToAddRows = false;
            dgvAdminUsers.AllowUserToDeleteRows = false;
            dgvAdminUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAdminUsers.MultiSelect = false;
            dgvAdminUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminUsers.RowHeadersVisible = false;
        }

        // Clears input fields and resets selected user details.
        private void ClearInputs()
        {
            selectedUserId = 0;
            selectedIsActive = false;

            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;
        }

        // Loads selected admin user details into the input fields.
        private void dgvAdminUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvAdminUsers.Rows[e.RowIndex];

            selectedUserId =
                Convert.ToInt32(row.Cells["UserId"].Value);

            txtUsername.Text =
                row.Cells["Username"].Value.ToString();

            txtEmail.Text =
                row.Cells["Email"].Value.ToString();

            txtPhone.Text =
                row.Cells["Phone"].Value.ToString();

            cmbRole.Text =
                row.Cells["RoleName"].Value.ToString();

            selectedIsActive =
                Convert.ToBoolean(row.Cells["IsActive"].Value);

            // Password is cleared because existing passwords are stored as hashes.
            txtPassword.Clear();
        }

        // Validates details and creates a new admin account.
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser.RoleName != "SuperAdmin")
            {
                MessageBox.Show("Only Super Admin can add admins.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone.");
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please select role.");
                return;
            }

            if (adminUserRepository.UsernameExists(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            try
            {
                // Password is hashed before saving to the database.
                string passwordHash =
                    PasswordHasher.HashPassword(
                        txtPassword.Text.Trim());

                adminUserRepository.AddAdminUser(
                    txtUsername.Text.Trim(),
                    passwordHash,
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    cmbRole.Text);

                AuditLogService auditLogService =
                    new AuditLogService();

                auditLogService.Log(
                    "Create Admin User",
                    "Admin Management",
                    "Created new " +
                    cmbRole.Text +
                    " account: " +
                    txtUsername.Text.Trim());

                MessageBox.Show("Admin user created successfully.");

                LoadAdminUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin user creation failed: " + ex.Message);
            }
        }

        // Resets the password of the selected admin user.
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter new password in password field.");
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Reset password for selected admin?",
                    "Confirm Reset",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string passwordHash =
                    PasswordHasher.HashPassword(
                        txtPassword.Text.Trim());

                adminUserRepository.ResetPassword(
                    selectedUserId,
                    passwordHash);

                AuditLogService auditLogService =
                    new AuditLogService();

                auditLogService.Log(
                    "Reset Admin Password",
                    "Admin Management",
                    "Reset password for admin user ID " +
                    selectedUserId);

                MessageBox.Show("Password reset successfully.");

                LoadAdminUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password reset failed: " + ex.Message);
            }
        }

        // Activates or deactivates the selected admin account.
        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            // Prevents the current Super Admin from disabling their own account.
            if (selectedUserId == SessionManager.CurrentUser.UserId)
            {
                MessageBox.Show("You cannot deactivate your own account.");
                return;
            }

            bool newStatus =
                !selectedIsActive;

            DialogResult result =
                MessageBox.Show(
                    newStatus
                    ? "Activate selected admin account?"
                    : "Deactivate selected admin account?",
                    "Confirm Status Change",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                adminUserRepository.ToggleUserStatus(
                    selectedUserId,
                    newStatus);

                AuditLogService auditLogService =
                    new AuditLogService();

                auditLogService.Log(
                    "Change Admin Status",
                    "Admin Management",
                    "Changed admin user ID " +
                    selectedUserId +
                    " active status to " +
                    newStatus);

                MessageBox.Show("Admin status updated successfully.");

                LoadAdminUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Status update failed: " + ex.Message);
            }
        }

        // Reloads latest admin user records.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdminUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}