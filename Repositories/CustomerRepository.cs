using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations related to customers.
     * This repository manages customer listing, searching, registration,
     * profile updates, account status changes and password updates.
     */
    public class CustomerRepository
    {
        // Loads all customers with linked user account details.
        public DataTable GetAllCustomers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Customers and Users are joined because customer profile
                 * data and login account data are stored in separate tables.
                 */
                string query = @"
                    SELECT
                        C.CustomerId,
                        C.UserId,
                        C.FullName,
                        U.Username,
                        U.Email,
                        U.Phone,
                        C.Address,
                        C.RegistrationDate,
                        C.LoyaltyPoints,
                        C.MembershipLevel,
                        U.IsActive
                    FROM Customers C
                    INNER JOIN Users U ON C.UserId = U.UserId
                    ORDER BY C.CustomerId DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Searches customers by name, username, email, phone, address or membership level.
        public DataTable SearchCustomers(string keyword)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        C.CustomerId,
                        C.UserId,
                        C.FullName,
                        U.Username,
                        U.Email,
                        U.Phone,
                        C.Address,
                        C.RegistrationDate,
                        C.LoyaltyPoints,
                        C.MembershipLevel,
                        U.IsActive
                    FROM Customers C
                    INNER JOIN Users U ON C.UserId = U.UserId
                    WHERE C.FullName LIKE @Keyword
                    OR U.Username LIKE @Keyword
                    OR U.Email LIKE @Keyword
                    OR U.Phone LIKE @Keyword
                    OR C.Address LIKE @Keyword
                    OR C.MembershipLevel LIKE @Keyword
                    ORDER BY C.CustomerId DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized search prevents SQL injection.
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Creates a new user account and returns the generated UserId.
        public int AddUser(
            string username,
            string passwordHash,
            string email,
            string phone)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO Users
                    (Username, PasswordHash, Email, Phone, IsActive)
                    VALUES
                    (@Username, @PasswordHash, @Email, @Phone, 1);

                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Creates the customer profile linked to the user account.
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO Customers
                    (UserId, FullName, Address, LoyaltyPoints, MembershipLevel)
                    VALUES
                    (@UserId, @FullName, @Address, @LoyaltyPoints, @MembershipLevel)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", customer.UserId);
                cmd.Parameters.AddWithValue("@FullName", customer.FullName);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@LoyaltyPoints", customer.LoyaltyPoints);
                cmd.Parameters.AddWithValue("@MembershipLevel", customer.MembershipLevel);

                cmd.ExecuteNonQuery();
            }
        }

        // Assigns the Customer role to the newly created user.
        public void AddCustomerRole(int userId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO UserRoles (UserId, RoleId)
                    SELECT @UserId, RoleId
                    FROM Roles
                    WHERE RoleName = 'Customer'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", userId);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates customer profile details across Users and Customers tables.
        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * User account details and customer profile details are updated
                 * together using one SQL command.
                 */
                string query = @"
                    UPDATE Users
                    SET Email = @Email,
                        Phone = @Phone
                    WHERE UserId = @UserId;

                    UPDATE Customers
                    SET FullName = @FullName,
                        Address = @Address,
                        MembershipLevel = @MembershipLevel
                    WHERE CustomerId = @CustomerId;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", customer.UserId);
                cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@FullName", customer.FullName);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@MembershipLevel", customer.MembershipLevel);

                cmd.ExecuteNonQuery();
            }
        }

        // Activates or deactivates a customer login account.
        public void ToggleCustomerStatus(int userId, bool isActive)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Users
                    SET IsActive = @IsActive
                    WHERE UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates the customer password hash in the Users table.
        public void UpdateCustomerPassword(int userId, string passwordHash)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Users
                    SET PasswordHash = @PasswordHash
                    WHERE UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                cmd.ExecuteNonQuery();
            }
        }
    }
}