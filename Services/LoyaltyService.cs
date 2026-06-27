using System;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Services
{
    /*
     * Handles the customer loyalty programme.
     * Customers earn loyalty points after successful orders and their
     * membership level is updated based on total points.
     */
    public class LoyaltyService
    {
        // Calculates earned points using the rule: Rs. 100 = 1 point.
        public int CalculateEarnedPoints(decimal orderAmount)
        {
            if (orderAmount <= 0)
                return 0;

            int points =
                Convert.ToInt32(Math.Floor(orderAmount / 100));

            // A minimum of 1 point is awarded for every valid order.
            if (points <= 0)
                points = 1;

            return points;
        }

        // Returns the membership level based on total loyalty points.
        public string GetMembershipLevel(int totalPoints)
        {
            if (totalPoints >= 700)
                return "Platinum";

            if (totalPoints >= 300)
                return "Gold";

            if (totalPoints >= 100)
                return "Silver";

            return "Bronze";
        }

        // Adds earned loyalty points after an order and updates membership level.
        public int AddPointsForOrder(
            int customerId,
            decimal orderAmount)
        {
            int earnedPoints =
                CalculateEarnedPoints(orderAmount);

            if (earnedPoints <= 0)
                return 0;

            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * A transaction ensures loyalty points and membership level
                 * are updated together. If one update fails, changes are rolled back.
                 */
                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    string getQuery = @"
                        SELECT LoyaltyPoints
                        FROM Customers
                        WHERE CustomerId = @CustomerId";

                    SqlCommand getCmd =
                        new SqlCommand(
                            getQuery,
                            con,
                            transaction);

                    getCmd.Parameters.AddWithValue(
                        "@CustomerId",
                        customerId);

                    object result =
                        getCmd.ExecuteScalar();

                    if (result == null)
                        throw new Exception("Customer not found.");

                    int currentPoints =
                        Convert.ToInt32(result);

                    int newTotalPoints =
                        currentPoints + earnedPoints;

                    string newLevel =
                        GetMembershipLevel(newTotalPoints);

                    string updateQuery = @"
                        UPDATE Customers
                        SET
                            LoyaltyPoints = @LoyaltyPoints,
                            MembershipLevel = @MembershipLevel
                        WHERE CustomerId = @CustomerId";

                    SqlCommand updateCmd =
                        new SqlCommand(
                            updateQuery,
                            con,
                            transaction);

                    updateCmd.Parameters.AddWithValue(
                        "@LoyaltyPoints",
                        newTotalPoints);

                    updateCmd.Parameters.AddWithValue(
                        "@MembershipLevel",
                        newLevel);

                    updateCmd.Parameters.AddWithValue(
                        "@CustomerId",
                        customerId);

                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();

                    return earnedPoints;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}