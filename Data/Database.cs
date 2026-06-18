using System.Data.SqlClient;

namespace SmartMedERP.Data
{
    public static class Database
    {
        private static readonly string ConnectionString =
            @"Server=DESKTOP-I9S2DH0\SQLEXPRESS;
              Database=SmartMedDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}