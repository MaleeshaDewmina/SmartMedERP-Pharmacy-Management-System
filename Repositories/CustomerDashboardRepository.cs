using System;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations required for the customer dashboard.
     * This repository provides customer statistics such as medicine count,
     * order count, cart count and loyalty details.
     */
    public class CustomerDashboardRepository
    {
        // Gets the CustomerId linked with the logged-in user account.
        public int GetCustomerIdByUserId(int userId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT CustomerId
                    FROM Customers
                    WHERE UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", userId);

                object result = cmd.ExecuteScalar();

                if (result == null)
                    return 0;

                return Convert.ToInt32(result);
            }
        }

        // Returns the number of active medicines available in the system.
        public int GetAvailableMedicineCount()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Medicines
                    WHERE ISNULL(IsDeleted, 0) = 0
                    AND ISNULL(IsActive, 1) = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Returns the total number of orders placed by the customer.
        public int GetCustomerOrderCount(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Orders
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Returns customer orders that are still pending or being processed.
        public int GetPendingOrderCount(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Orders
                    WHERE CustomerId = @CustomerId
                    AND Status IN ('Pending', 'Processing', 'Placed')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Returns the total quantity of medicines in the customer's saved cart.
        public int GetCartItemCount(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT ISNULL(SUM(Quantity), 0)
                    FROM CartItems
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Returns loyalty points earned by the customer.
        public int GetLoyaltyPoints(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT ISNULL(LoyaltyPoints, 0)
                    FROM Customers
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                object result = cmd.ExecuteScalar();

                if (result == null)
                    return 0;

                return Convert.ToInt32(result);
            }
        }

        // Returns customer membership level such as Bronze, Silver, Gold or Platinum.
        public string GetMembershipLevel(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT ISNULL(MembershipLevel, 'Bronze')
                    FROM Customers
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                object result = cmd.ExecuteScalar();

                if (result == null)
                    return "Bronze";

                return result.ToString();
            }
        }
    }
}