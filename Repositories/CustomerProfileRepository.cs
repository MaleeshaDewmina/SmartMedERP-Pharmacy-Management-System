using System;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for customer profile management.
     * This repository loads customer profile details, updates profile data
     * and updates account passwords.
     */
    public class CustomerProfileRepository
    {
        // Loads customer profile, account details and loyalty information by UserId.
        public Customer GetCustomerProfileByUserId(int userId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Customers and Users are joined because personal details are
                 * stored across both tables. Loyalty details are stored in Customers.
                 */
                string query = @"
                    SELECT
                        C.CustomerId,
                        C.UserId,
                        C.FullName,
                        C.Address,
                        U.Username,
                        U.Email,
                        U.Phone,
                        ISNULL(C.LoyaltyPoints, 0) AS LoyaltyPoints,
                        ISNULL(C.MembershipLevel, 'Bronze') AS MembershipLevel
                    FROM Customers C
                    INNER JOIN Users U
                        ON C.UserId = U.UserId
                    WHERE C.UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized query prevents SQL injection.
                cmd.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Map database fields into a Customer model object.
                    return new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FullName = reader["FullName"].ToString(),
                        Address = reader["Address"].ToString(),
                        Username = reader["Username"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        LoyaltyPoints =
                            Convert.ToInt32(reader["LoyaltyPoints"]),
                        MembershipLevel =
                            reader["MembershipLevel"].ToString(),
                    };
                }

                return null;
            }
        }

        /*
         * Updates customer profile details in both Users and Customers tables.
         * A transaction is used so both updates succeed or fail together.
         */
        public void UpdateProfile(Customer customer)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string updateUserQuery = @"
                        UPDATE Users
                        SET
                            Email = @Email,
                            Phone = @Phone
                        WHERE UserId = @UserId";

                    SqlCommand userCmd =
                        new SqlCommand(
                            updateUserQuery,
                            con,
                            transaction);

                    userCmd.Parameters.AddWithValue("@UserId", customer.UserId);
                    userCmd.Parameters.AddWithValue("@Email", customer.Email);
                    userCmd.Parameters.AddWithValue("@Phone", customer.Phone);

                    userCmd.ExecuteNonQuery();

                    string updateCustomerQuery = @"
                        UPDATE Customers
                        SET
                            FullName = @FullName,
                            Address = @Address
                        WHERE CustomerId = @CustomerId";

                    SqlCommand customerCmd =
                        new SqlCommand(
                            updateCustomerQuery,
                            con,
                            transaction);

                    customerCmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    customerCmd.Parameters.AddWithValue("@FullName", customer.FullName);
                    customerCmd.Parameters.AddWithValue("@Address", customer.Address);

                    customerCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Updates the user's password hash after password validation is completed in the form.
        public void UpdatePassword(int userId, string passwordHash)
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
    }
}