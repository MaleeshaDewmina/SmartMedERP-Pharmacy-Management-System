using System.Data.SqlClient;
using SmartMedERP.Data;
using SmartMedERP.Models;

namespace SmartMedERP.Repositories
{
    /*
     * Handles database operations related to system users.
     * This repository is mainly used during login to retrieve user,
     * password hash and role information from the database.
     */
    public class UserRepository
    {
        // Retrieves a user account by username together with assigned role details.
        public User GetUserByUsername(string username)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();

                /*
                 * Joins Users, UserRoles and Roles tables to get both
                 * authentication data and authorization role information.
                 */
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

                // Parameterized query prevents SQL injection.
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Map database fields into a User model object.
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