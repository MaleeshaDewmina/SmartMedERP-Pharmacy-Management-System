using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for supplier management.
     * This repository supports supplier listing, searching,
     * adding, updating and deleting supplier records.
     */
    public class SupplierRepository
    {
        // Loads all suppliers from the database.
        public DataTable GetAllSuppliers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT * FROM Suppliers ORDER BY SupplierId DESC";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Searches suppliers by name, phone, email or address.
        public DataTable SearchSuppliers(string keyword)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT * FROM Suppliers
                    WHERE SupplierName LIKE @Keyword
                    OR Phone LIKE @Keyword
                    OR Email LIKE @Keyword
                    OR Address LIKE @Keyword
                    ORDER BY SupplierId DESC";

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

        // Adds a new supplier record.
        public void AddSupplier(Supplier supplier)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO Suppliers
                    (SupplierName, Phone, Email, Address)
                    VALUES
                    (@SupplierName, @Phone, @Email, @Address)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@Email", supplier.Email);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates an existing supplier record.
        public void UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Suppliers
                    SET SupplierName = @SupplierName,
                        Phone = @Phone,
                        Email = @Email,
                        Address = @Address
                    WHERE SupplierId = @SupplierId";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@Email", supplier.Email);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);

                cmd.ExecuteNonQuery();
            }
        }

        // Deletes a supplier by SupplierId.
        public void DeleteSupplier(int supplierId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query =
                    "DELETE FROM Suppliers WHERE SupplierId = @SupplierId";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SupplierId", supplierId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}