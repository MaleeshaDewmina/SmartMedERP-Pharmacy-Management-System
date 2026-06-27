using System.Data;
using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations for medicine inventory.
     * This repository supports medicine listing, searching,
     * adding, updating and soft deleting.
     */
    public class MedicineRepository
    {
        // Loads all non-deleted medicines with category and supplier details.
        public DataTable GetAllMedicines()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Categories and Suppliers are joined to show readable names
                 * instead of only foreign key IDs.
                 */
                string query = @"
                    SELECT 
                        M.MedicineId,
                        M.MedicineName,
                        M.GenericName,
                        M.BrandName,
                        C.CategoryName,
                        S.SupplierName,
                        M.CostPrice,
                        M.SellingPrice,
                        M.TaxPercentage,
                        M.DiscountPercentage,
                        M.StockQuantity,
                        M.ReorderLevel,
                        M.BatchNumber,
                        M.ManufactureDate,
                        M.ExpiryDate,
                        M.PrescriptionRequired,
                        M.Barcode,
                        M.QRCode,
                        M.IsActive,
                        M.CategoryId,
                        M.SupplierId
                    FROM Medicines M
                    LEFT JOIN Categories C ON M.CategoryId = C.CategoryId
                    LEFT JOIN Suppliers S ON M.SupplierId = S.SupplierId
                    WHERE M.IsDeleted = 0
                    ORDER BY M.MedicineId DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Searches medicines by name, category, supplier or barcode.
        public DataTable SearchMedicines(string keyword)
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
                        C.CategoryName,
                        S.SupplierName,
                        M.CostPrice,
                        M.SellingPrice,
                        M.TaxPercentage,
                        M.DiscountPercentage,
                        M.StockQuantity,
                        M.ReorderLevel,
                        M.BatchNumber,
                        M.ManufactureDate,
                        M.ExpiryDate,
                        M.PrescriptionRequired,
                        M.Barcode,
                        M.QRCode,
                        M.IsActive,
                        M.CategoryId,
                        M.SupplierId
                    FROM Medicines M
                    LEFT JOIN Categories C ON M.CategoryId = C.CategoryId
                    LEFT JOIN Suppliers S ON M.SupplierId = S.SupplierId
                    WHERE M.IsDeleted = 0
                    AND (
                        M.MedicineName LIKE @Keyword
                        OR M.GenericName LIKE @Keyword
                        OR M.BrandName LIKE @Keyword
                        OR C.CategoryName LIKE @Keyword
                        OR S.SupplierName LIKE @Keyword
                        OR M.Barcode LIKE @Keyword
                    )
                    ORDER BY M.MedicineId DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                // Parameterized search prevents SQL injection.
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        // Adds a new medicine record to the inventory.
        public void AddMedicine(Medicine medicine)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * IsDeleted is set to 0 because this is a new active inventory record.
                 * Soft delete is used instead of permanently removing medicines.
                 */
                string query = @"
                    INSERT INTO Medicines
                    (
                        MedicineName,
                        GenericName,
                        BrandName,
                        CategoryId,
                        SupplierId,
                        CostPrice,
                        SellingPrice,
                        TaxPercentage,
                        DiscountPercentage,
                        StockQuantity,
                        ReorderLevel,
                        BatchNumber,
                        ManufactureDate,
                        ExpiryDate,
                        PrescriptionRequired,
                        Barcode,
                        QRCode,
                        IsActive,
                        IsDeleted
                    )
                    VALUES
                    (
                        @MedicineName,
                        @GenericName,
                        @BrandName,
                        @CategoryId,
                        @SupplierId,
                        @CostPrice,
                        @SellingPrice,
                        @TaxPercentage,
                        @DiscountPercentage,
                        @StockQuantity,
                        @ReorderLevel,
                        @BatchNumber,
                        @ManufactureDate,
                        @ExpiryDate,
                        @PrescriptionRequired,
                        @Barcode,
                        @QRCode,
                        @IsActive,
                        0
                    )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MedicineName", medicine.MedicineName);
                cmd.Parameters.AddWithValue("@GenericName", medicine.GenericName);
                cmd.Parameters.AddWithValue("@BrandName", medicine.BrandName);
                cmd.Parameters.AddWithValue("@CategoryId", medicine.CategoryId);
                cmd.Parameters.AddWithValue("@SupplierId", medicine.SupplierId);
                cmd.Parameters.AddWithValue("@CostPrice", medicine.CostPrice);
                cmd.Parameters.AddWithValue("@SellingPrice", medicine.SellingPrice);
                cmd.Parameters.AddWithValue("@TaxPercentage", medicine.TaxPercentage);
                cmd.Parameters.AddWithValue("@DiscountPercentage", medicine.DiscountPercentage);
                cmd.Parameters.AddWithValue("@StockQuantity", medicine.StockQuantity);
                cmd.Parameters.AddWithValue("@ReorderLevel", medicine.ReorderLevel);
                cmd.Parameters.AddWithValue("@BatchNumber", medicine.BatchNumber);
                cmd.Parameters.AddWithValue("@ManufactureDate", medicine.ManufactureDate);
                cmd.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);
                cmd.Parameters.AddWithValue("@PrescriptionRequired", medicine.PrescriptionRequired);
                cmd.Parameters.AddWithValue("@Barcode", medicine.Barcode);
                cmd.Parameters.AddWithValue("@QRCode", medicine.QRCode);
                cmd.Parameters.AddWithValue("@IsActive", medicine.IsActive);

                cmd.ExecuteNonQuery();
            }
        }

        // Updates an existing medicine record.
        public void UpdateMedicine(Medicine medicine)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Medicines
                    SET
                        MedicineName = @MedicineName,
                        GenericName = @GenericName,
                        BrandName = @BrandName,
                        CategoryId = @CategoryId,
                        SupplierId = @SupplierId,
                        CostPrice = @CostPrice,
                        SellingPrice = @SellingPrice,
                        TaxPercentage = @TaxPercentage,
                        DiscountPercentage = @DiscountPercentage,
                        StockQuantity = @StockQuantity,
                        ReorderLevel = @ReorderLevel,
                        BatchNumber = @BatchNumber,
                        ManufactureDate = @ManufactureDate,
                        ExpiryDate = @ExpiryDate,
                        PrescriptionRequired = @PrescriptionRequired,
                        Barcode = @Barcode,
                        QRCode = @QRCode,
                        IsActive = @IsActive
                    WHERE MedicineId = @MedicineId";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MedicineId", medicine.MedicineId);
                cmd.Parameters.AddWithValue("@MedicineName", medicine.MedicineName);
                cmd.Parameters.AddWithValue("@GenericName", medicine.GenericName);
                cmd.Parameters.AddWithValue("@BrandName", medicine.BrandName);
                cmd.Parameters.AddWithValue("@CategoryId", medicine.CategoryId);
                cmd.Parameters.AddWithValue("@SupplierId", medicine.SupplierId);
                cmd.Parameters.AddWithValue("@CostPrice", medicine.CostPrice);
                cmd.Parameters.AddWithValue("@SellingPrice", medicine.SellingPrice);
                cmd.Parameters.AddWithValue("@TaxPercentage", medicine.TaxPercentage);
                cmd.Parameters.AddWithValue("@DiscountPercentage", medicine.DiscountPercentage);
                cmd.Parameters.AddWithValue("@StockQuantity", medicine.StockQuantity);
                cmd.Parameters.AddWithValue("@ReorderLevel", medicine.ReorderLevel);
                cmd.Parameters.AddWithValue("@BatchNumber", medicine.BatchNumber);
                cmd.Parameters.AddWithValue("@ManufactureDate", medicine.ManufactureDate);
                cmd.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);
                cmd.Parameters.AddWithValue("@PrescriptionRequired", medicine.PrescriptionRequired);
                cmd.Parameters.AddWithValue("@Barcode", medicine.Barcode);
                cmd.Parameters.AddWithValue("@QRCode", medicine.QRCode);
                cmd.Parameters.AddWithValue("@IsActive", medicine.IsActive);

                cmd.ExecuteNonQuery();
            }
        }

        // Soft deletes a medicine by marking it as deleted.
        public void DeleteMedicine(int medicineId)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                    UPDATE Medicines
                    SET IsDeleted = 1
                    WHERE MedicineId = @MedicineId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MedicineId", medicineId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}