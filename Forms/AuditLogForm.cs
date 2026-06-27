using System;
using System.Data;
using System.Windows.Forms;
using SmartMedERP.Repositories;

namespace SmartMed.Forms
{
    /*
     * Displays system audit logs for administrators.
     * This form allows admins to view, search, refresh and clear audit log filters.
     */
    public partial class AuditLogForm : Form
    {
        private readonly AuditLogRepository auditLogRepository =
            new AuditLogRepository();

        public AuditLogForm()
        {
            InitializeComponent();
        }

        private void AuditLogForm_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        // Loads all audit logs or filtered logs based on the search keyword.
        private void LoadLogs()
        {
            DataTable table;

            string keyword =
                txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                table =
                    auditLogRepository.GetLogs();
            }
            else
            {
                table =
                    auditLogRepository.SearchLogs(keyword);
            }

            dgvAuditLogs.DataSource = table;

            FormatGrid();
        }

        // Formats the audit log grid for clear admin viewing.
        private void FormatGrid()
        {
            if (dgvAuditLogs.Columns.Count == 0)
                return;

            if (dgvAuditLogs.Columns.Contains("AuditLogId"))
            {
                dgvAuditLogs.Columns["AuditLogId"].Visible = false;
            }

            if (dgvAuditLogs.Columns.Contains("Username"))
            {
                dgvAuditLogs.Columns["Username"].HeaderText = "User";
            }

            if (dgvAuditLogs.Columns.Contains("RoleName"))
            {
                dgvAuditLogs.Columns["RoleName"].HeaderText = "Role";
            }

            if (dgvAuditLogs.Columns.Contains("ActionName"))
            {
                dgvAuditLogs.Columns["ActionName"].HeaderText = "Action";
            }

            if (dgvAuditLogs.Columns.Contains("ModuleName"))
            {
                dgvAuditLogs.Columns["ModuleName"].HeaderText = "Module";
            }

            if (dgvAuditLogs.Columns.Contains("Description"))
            {
                dgvAuditLogs.Columns["Description"].HeaderText = "Description";
            }

            if (dgvAuditLogs.Columns.Contains("MachineName"))
            {
                dgvAuditLogs.Columns["MachineName"].HeaderText = "Machine";
            }

            if (dgvAuditLogs.Columns.Contains("CreatedAt"))
            {
                dgvAuditLogs.Columns["CreatedAt"].HeaderText = "Date / Time";
            }

            dgvAuditLogs.ReadOnly = true;
            dgvAuditLogs.AllowUserToAddRows = false;
            dgvAuditLogs.AllowUserToDeleteRows = false;
            dgvAuditLogs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLogs.MultiSelect = false;
            dgvAuditLogs.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLogs.RowHeadersVisible = false;
        }

        // Searches logs while the admin types.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLogs();
        }

        // Reloads the latest audit log records.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        // Clears the search box and shows all audit logs again.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadLogs();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}