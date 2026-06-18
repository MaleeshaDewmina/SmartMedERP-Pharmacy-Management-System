using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    public class UserRepository
    {
        public User GetUserByUsername(string username)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT
                    U.UserId,
                    U.Username,
                    U.PasswordHash,
                    U.Email,
                    U.Phone,
                    U.IsActive,
                    R.RoleName
                FROM Users U
                INNER JOIN UserRoles UR
                    ON U.UserId = UR.UserId
                INNER JOIN Roles R
                    ON UR.RoleId = R.RoleId
                WHERE U.Username = @Username";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        UserId = (int)reader["UserId"],
                        Username = reader["Username"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        IsActive = (bool)reader["IsActive"],
                        RoleName = reader["RoleName"].ToString()
                    };
                }

                return null;
            }
        }
    }
}