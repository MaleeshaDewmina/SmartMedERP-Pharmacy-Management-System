using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for audit logs.
     * Audit logs are used to track important user actions across the system.
     */
    public class AuditLogRepository
    {
        // Inserts a new audit log record into the database.
        public void AddLog(
            int? userId,
            string username,
            string roleName,
            string actionName,
            string moduleName,
            string description,
            string machineName)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO AuditLogs
                    (
                        UserId,
                        Username,
                        RoleName,
                        ActionName,
                        ModuleName,
                        Description,
                        MachineName,
                        CreatedAt
                    )
                    VALUES
                    (
                        @UserId,
                        @Username,
                        @RoleName,
                        @ActionName,
                        @ModuleName,
                        @Description,
                        @MachineName,
                        GETDATE()
                    )";

                SqlCommand cmd = new SqlCommand(query, con);

                // Nullable values are saved as database NULL when not available.
                cmd.Parameters.AddWithValue(
                    "@UserId",
                    userId.HasValue ? (object)userId.Value : DBNull.Value);

                cmd.Parameters.AddWithValue(
                    "@Username",
                    string.IsNullOrWhiteSpace(username)
                        ? (object)DBNull.Value
                        : username);

                cmd.Parameters.AddWithValue(
                    "@RoleName",
                    string.IsNullOrWhiteSpace(roleName)
                        ? (object)DBNull.Value
                        : roleName);

                cmd.Parameters.AddWithValue("@ActionName", actionName);
                cmd.Parameters.AddWithValue("@ModuleName", moduleName);

                cmd.Parameters.AddWithValue(
                    "@Description",
                    string.IsNullOrWhiteSpace(description)
                        ? (object)DBNull.Value
                        : description);

                cmd.Parameters.AddWithValue(
                    "@MachineName",
                    string.IsNullOrWhiteSpace(machineName)
                        ? (object)DBNull.Value
                        : machineName);

                cmd.ExecuteNonQuery();
            }
        }

        // Loads all audit logs in newest-first order.
        public DataTable GetLogs()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        AuditLogId,
                        Username,
                        RoleName,
                        ActionName,
                        ModuleName,
                        Description,
                        MachineName,
                        CreatedAt
                    FROM AuditLogs
                    ORDER BY CreatedAt DESC";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Searches audit logs by user, role, action, module or description.
        public DataTable SearchLogs(string keyword)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        AuditLogId,
                        Username,
                        RoleName,
                        ActionName,
                        ModuleName,
                        Description,
                        MachineName,
                        CreatedAt
                    FROM AuditLogs
                    WHERE
                        Username LIKE @Keyword
                        OR RoleName LIKE @Keyword
                        OR ActionName LIKE @Keyword
                        OR ModuleName LIKE @Keyword
                        OR Description LIKE @Keyword
                    ORDER BY CreatedAt DESC";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                // Parameterized search prevents SQL injection.
                cmd.Parameters.AddWithValue(
                    "@Keyword",
                    "%" + keyword + "%");

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }
    }
}