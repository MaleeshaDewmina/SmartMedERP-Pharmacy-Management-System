using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for medicine categories.
     * This repository supports category listing, searching,
     * adding, updating and deleting.
     */
    public class CategoryRepository
    {
        // Loads all medicine categories from the database.
        public DataTable GetAllCategories()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        CategoryId,
                        CategoryName,
                        Description,
                        IsActive
                    FROM Categories
                    ORDER BY CategoryId DESC";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Searches categories by category name or description.
        public DataTable SearchCategories(string keyword)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        CategoryId,
                        CategoryName,
                        Description,
                        IsActive
                    FROM Categories
                    WHERE CategoryName LIKE @Keyword
                    OR Description LIKE @Keyword
                    ORDER BY CategoryId DESC";

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

        // Adds a new medicine category.
        public void AddCategory(Category category)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    INSERT INTO Categories
                    (CategoryName, Description, IsActive)
                    VALUES
                    (@CategoryName, @Description, @IsActive)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@CategoryName",
                    category.CategoryName);

                cmd.Parameters.AddWithValue(
                    "@Description",
                    category.Description);

                cmd.Parameters.AddWithValue(
                    "@IsActive",
                    category.IsActive);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates an existing medicine category.
        public void UpdateCategory(Category category)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Categories
                    SET 
                        CategoryName = @CategoryName,
                        Description = @Description,
                        IsActive = @IsActive
                    WHERE CategoryId = @CategoryId";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@CategoryId",
                    category.CategoryId);

                cmd.Parameters.AddWithValue(
                    "@CategoryName",
                    category.CategoryName);

                cmd.Parameters.AddWithValue(
                    "@Description",
                    category.Description);

                cmd.Parameters.AddWithValue(
                    "@IsActive",
                    category.IsActive);

                cmd.ExecuteNonQuery();
            }
        }

        // Deletes a category by CategoryId.
        public void DeleteCategory(int categoryId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    DELETE FROM Categories
                    WHERE CategoryId = @CategoryId";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@CategoryId",
                    categoryId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}