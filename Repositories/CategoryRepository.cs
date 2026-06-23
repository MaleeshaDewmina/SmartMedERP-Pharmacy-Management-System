using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    public class CategoryRepository
    {
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