using System;
using System.Security.Cryptography;

namespace SmartMedERP.Utilities
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Generate a random 16-byte salt
            byte[] salt = new byte[16];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Generate the hash using PBKDF2
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return Convert.ToBase64String(salt) + ":" +
                       Convert.ToBase64String(hash);
            }
        }

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