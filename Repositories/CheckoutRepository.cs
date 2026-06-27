using System;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations required during checkout.
     * This repository loads customer contact and delivery details
     * before an order is confirmed.
     */
    public class CheckoutRepository
    {
        // Retrieves customer phone, email and address for checkout delivery details.
        public Customer GetCustomerCheckoutDetails(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Joins Customers and Users because customer address is stored
                 * in Customers table while phone and email are stored in Users table.
                 */
                string query = @"
                    SELECT
                        C.CustomerId,
                        C.UserId,
                        C.FullName,
                        C.Address,
                        U.Phone,
                        U.Email
                    FROM Customers C
                    INNER JOIN Users U
                        ON C.UserId = U.UserId
                    WHERE C.CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized query is used to avoid SQL injection.
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Map checkout customer details into a Customer model object.
                    return new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FullName = reader["FullName"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                }

                return null;
            }
        }
    }
}