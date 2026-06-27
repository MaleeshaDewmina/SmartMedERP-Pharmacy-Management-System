using System;
using System.Security.Cryptography;

namespace SmartMedERP.Utilities
{
    /*
     * Handles password hashing and verification for user authentication.
     * PBKDF2 with a random salt is used so passwords are not stored in plain text.
     */
    public static class PasswordHasher
    {
        // Creates a secure password hash in the format: Salt:Hash
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            // Generate a unique random salt for each password.
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // PBKDF2 applies repeated hashing to improve password security.
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return Convert.ToBase64String(salt) + ":" +
                       Convert.ToBase64String(hash);
            }
        }

        // Verifies an entered password against the stored Salt:Hash value.
        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrWhiteSpace(storedHash))
                return false;

            storedHash = storedHash
                .Trim()
                .Replace(" ", "")
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\t", "");

            string[] parts = storedHash.Split(':');

            if (parts.Length != 2)
                return false;

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedPassword = Convert.FromBase64String(parts[1]);

            // Recreate the hash using the original salt and compare it.
            using (var pbkdf2 = new Rfc2898DeriveBytes(password.Trim(), salt, 10000))
            {
                byte[] computedHash = pbkdf2.GetBytes(32);

                if (computedHash.Length != storedPassword.Length)
                    return false;

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedPassword[i])
                        return false;
                }

                return true;
            }
        }
    }
}