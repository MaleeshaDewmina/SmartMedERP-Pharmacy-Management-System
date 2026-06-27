using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for customer medicine browsing.
     * This repository returns only active, available medicines for customer search.
     */
    public class CustomerMedicineRepository
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

        // Loads all active medicines that are currently in stock.
        public DataTable GetAvailableMedicines()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Category is joined to show customer-friendly medicine details.
                 * PrescriptionRequired is converted to Yes/No for better grid display.
                 */
                string query = @"
                    SELECT
                        M.MedicineId,
                        M.MedicineName,
                        M.GenericName,
                        M.BrandName,
                        ISNULL(C.CategoryName, 'Uncategorized') AS CategoryName,
                        M.SellingPrice,
                        M.DiscountPercentage,
                        M.TaxPercentage,
                        M.StockQuantity,
                        M.ExpiryDate,
                        CASE
                            WHEN M.PrescriptionRequired = 1 THEN 'Yes'
                            ELSE 'No'
                        END AS PrescriptionRequired
                    FROM Medicines M
                    LEFT JOIN Categories C
                        ON M.CategoryId = C.CategoryId
                    WHERE M.IsDeleted = 0
                    AND M.IsActive = 1
                    AND M.StockQuantity > 0
                    ORDER BY M.MedicineName";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Searches available medicines by name, generic name, brand, barcode or category.
        public DataTable SearchAvailableMedicines(string keyword)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT
                        M.MedicineId,
                        M.MedicineName,
                        M.GenericName,
                        M.BrandName,
                        ISNULL(C.CategoryName, 'Uncategorized') AS CategoryName,
                        M.SellingPrice,
                        M.DiscountPercentage,
                        M.TaxPercentage,
                        M.StockQuantity,
                        M.ExpiryDate,
                        CASE
                            WHEN M.PrescriptionRequired = 1 THEN 'Yes'
                            ELSE 'No'
                        END AS PrescriptionRequired
                    FROM Medicines M
                    LEFT JOIN Categories C
                        ON M.CategoryId = C.CategoryId
                    WHERE M.IsDeleted = 0
                    AND M.IsActive = 1
                    AND M.StockQuantity > 0
                    AND
                    (
                        M.MedicineName LIKE @Keyword
                        OR M.GenericName LIKE @Keyword
                        OR M.BrandName LIKE @Keyword
                        OR M.Barcode LIKE @Keyword
                        OR C.CategoryName LIKE @Keyword
                    )
                    ORDER BY M.MedicineName";

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