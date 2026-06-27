using System;
using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for the customer cart.
     * Cart data is stored in the database so customers can return later
     * and continue checkout with saved items.
     */
    public class CartRepository
    {
        // Gets the CustomerId linked to the logged-in user account.
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

        // Loads all active cart items for a specific customer.
        public DataTable GetCartItems(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Joins CartItems with Medicines to show medicine details,
                 * pricing, stock and prescription requirement in the cart.
                 */
                string query = @"
                    SELECT
                        CI.CartItemId,
                        CI.CustomerId,
                        CI.MedicineId,
                        M.MedicineName,
                        CI.Quantity,
                        M.SellingPrice AS UnitPrice,
                        ISNULL(M.DiscountPercentage, 0) AS DiscountPercentage,
                        ISNULL(M.TaxPercentage, 0) AS TaxPercentage,
                        ISNULL(M.StockQuantity, 0) AS AvailableStock,
                        ISNULL(M.PrescriptionRequired, 0) AS PrescriptionRequired
                    FROM CartItems CI
                    INNER JOIN Medicines M
                        ON CI.MedicineId = M.MedicineId
                    WHERE CI.CustomerId = @CustomerId
                    AND ISNULL(M.IsDeleted, 0) = 0
                    AND ISNULL(M.IsActive, 1) = 1
                    ORDER BY CI.UpdatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Adds a new cart item or increases quantity if the item already exists.
        public void AddOrUpdateCartItem(
            int customerId,
            int medicineId,
            int quantity)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                int stock =
                    GetMedicineStock(medicineId, con);

                if (stock < 0)
                    throw new Exception("Medicine is not available.");

                int existingQuantity =
                    GetExistingCartQuantity(
                        customerId,
                        medicineId,
                        con);

                int newQuantity =
                    existingQuantity + quantity;

                // Prevents customers from adding more items than available stock.
                if (newQuantity > stock)
                {
                    throw new Exception(
                        "Cart quantity exceeds available stock. Available stock: " +
                        stock);
                }

                string query = @"
                    IF EXISTS
                    (
                        SELECT 1
                        FROM CartItems
                        WHERE CustomerId = @CustomerId
                        AND MedicineId = @MedicineId
                    )
                    BEGIN
                        UPDATE CartItems
                        SET
                            Quantity = Quantity + @Quantity,
                            UpdatedAt = GETDATE()
                        WHERE CustomerId = @CustomerId
                        AND MedicineId = @MedicineId
                    END
                    ELSE
                    BEGIN
                        INSERT INTO CartItems
                        (
                            CustomerId,
                            MedicineId,
                            Quantity,
                            CreatedAt,
                            UpdatedAt
                        )
                        VALUES
                        (
                            @CustomerId,
                            @MedicineId,
                            @Quantity,
                            GETDATE(),
                            GETDATE()
                        )
                    END";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@MedicineId", medicineId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates the quantity of a selected cart item.
        public void UpdateQuantity(
            int customerId,
            int medicineId,
            int quantity)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                // If quantity is zero or below, the item is removed from cart.
                if (quantity <= 0)
                {
                    RemoveCartItem(customerId, medicineId);
                    return;
                }

                int stock =
                    GetMedicineStock(medicineId, con);

                if (stock < 0)
                    throw new Exception("Medicine is not available.");

                // Prevents updating cart quantity above current stock level.
                if (quantity > stock)
                {
                    throw new Exception(
                        "Quantity exceeds available stock. Available stock: " +
                        stock);
                }

                string query = @"
                    UPDATE CartItems
                    SET
                        Quantity = @Quantity,
                        UpdatedAt = GETDATE()
                    WHERE CustomerId = @CustomerId
                    AND MedicineId = @MedicineId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@MedicineId", medicineId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();
            }
        }

        // Removes one medicine item from the customer's cart.
        public void RemoveCartItem(
            int customerId,
            int medicineId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    DELETE FROM CartItems
                    WHERE CustomerId = @CustomerId
                    AND MedicineId = @MedicineId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@MedicineId", medicineId);

                cmd.ExecuteNonQuery();
            }
        }

        // Removes all cart items for the customer.
        public void ClearCart(int customerId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    DELETE FROM CartItems
                    WHERE CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                cmd.ExecuteNonQuery();
            }
        }

        // Returns the total quantity of items in the customer's cart.
        public int GetCartCount(int customerId)
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

        // Gets current stock for an active medicine.
        private int GetMedicineStock(
            int medicineId,
            SqlConnection con)
        {
            string query = @"
                SELECT StockQuantity
                FROM Medicines
                WHERE MedicineId = @MedicineId
                AND ISNULL(IsDeleted, 0) = 0
                AND ISNULL(IsActive, 1) = 1";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@MedicineId", medicineId);

            object result = cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Gets the quantity already saved in the cart for the same medicine.
        private int GetExistingCartQuantity(
            int customerId,
            int medicineId,
            SqlConnection con)
        {
            string query = @"
                SELECT Quantity
                FROM CartItems
                WHERE CustomerId = @CustomerId
                AND MedicineId = @MedicineId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@CustomerId", customerId);
            cmd.Parameters.AddWithValue("@MedicineId", medicineId);

            object result = cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToInt32(result);
        }
    }
}