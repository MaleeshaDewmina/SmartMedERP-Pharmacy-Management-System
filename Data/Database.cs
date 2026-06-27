using System.Data.SqlClient;

namespace SmartMedERP.Data
{
    /*
     * Provides a central database connection for the SmartMed ERP system.
     * Keeping the connection string in one place makes maintenance easier.
     */
    public static class Database
    {
        private static readonly string ConnectionString =
            @"Server=DESKTOP-I9S2DH0\SQLEXPRESS;
              Database=SmartMedDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        // Returns a new SQL connection object whenever a repository needs database access.
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}