using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for administrator user management.
     * This repository allows Super Admin users to view admins, add admins,
     * reset passwords and activate or deactivate admin accounts.
     */
    public class AdminUserRepository
    {
        // Loads all SuperAdmin and Admin user accounts.
        public DataTable GetAdminUsers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Users, UserRoles and Roles are joined to show each admin
                 * account together with its assigned role.
                 */
                string query = @"
                    SELECT
                        U.UserId,
                        U.Username,
                        U.Email,
                        U.Phone,
                        U.IsActive,
                        R.RoleName
                    FROM Users U
                    INNER JOIN UserRoles UR
                        ON U.UserId = UR.UserId
                    INNER JOIN Roles R
                        ON UR.RoleId = R.RoleId
                    WHERE R.RoleName IN ('SuperAdmin', 'Admin')
                    ORDER BY U.UserId DESC";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Checks whether a username already exists before creating a new admin.
        public bool UsernameExists(string username)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Users
                    WHERE Username = @Username";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        /*
         * Adds a new admin user and assigns a role.
         * A transaction is used so user creation and role assignment
         * are saved together.
         */
        public void AddAdminUser(
            string username,
            string passwordHash,
            string email,
            string phone,
            string roleName)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string userQuery = @"
                        INSERT INTO Users
                        (
                            Username,
                            PasswordHash,
                            Email,
                            Phone,
                            IsActive
                        )
                        VALUES
                        (
                            @Username,
                            @PasswordHash,
                            @Email,
                            @Phone,
                            1
                        );

                        SELECT SCOPE_IDENTITY();";

                    SqlCommand userCmd =
                        new SqlCommand(
                            userQuery,
                            con,
                            transaction);

                    userCmd.Parameters.AddWithValue("@Username", username);
                    userCmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    userCmd.Parameters.AddWithValue("@Email", email);
                    userCmd.Parameters.AddWithValue("@Phone", phone);

                    int userId =
                        Convert.ToInt32(userCmd.ExecuteScalar());

                    // Get the selected role ID before inserting into UserRoles.
                    string roleQuery = @"
                        SELECT RoleId
                        FROM Roles
                        WHERE RoleName = @RoleName";

                    SqlCommand roleCmd =
                        new SqlCommand(
                            roleQuery,
                            con,
                            transaction);

                    roleCmd.Parameters.AddWithValue("@RoleName", roleName);

                    object roleResult =
                        roleCmd.ExecuteScalar();

                    if (roleResult == null)
                        throw new Exception("Selected role not found.");

                    int roleId =
                        Convert.ToInt32(roleResult);

                    string userRoleQuery = @"
                        INSERT INTO UserRoles
                        (
                            UserId,
                            RoleId
                        )
                        VALUES
                        (
                            @UserId,
                            @RoleId
                        )";

                    SqlCommand userRoleCmd =
                        new SqlCommand(
                            userRoleQuery,
                            con,
                            transaction);

                    userRoleCmd.Parameters.AddWithValue("@UserId", userId);
                    userRoleCmd.Parameters.AddWithValue("@RoleId", roleId);

                    userRoleCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Resets an admin user's password using a newly generated password hash.
        public void ResetPassword(
            int userId,
            string passwordHash)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Users
                    SET PasswordHash = @PasswordHash
                    WHERE UserId = @UserId";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                cmd.ExecuteNonQuery();
            }
        }

        // Activates or deactivates an admin user account.
        public void ToggleUserStatus(
            int userId,
            bool isActive)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Users
                    SET IsActive = @IsActive
                    WHERE UserId = @UserId";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                cmd.ExecuteNonQuery();
            }
        }
    }
}