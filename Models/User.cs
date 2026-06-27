namespace SmartMedERP.Models
{
    /*
     * Represents a system user account.
     * This model is used for authentication, account status checking
     * and role-based authorization.
     */
    public class User
    {
        // Unique user account ID.
        public int UserId { get; set; }

        // Username used for login.
        public string Username { get; set; }

        // Hashed password stored securely in the database.
        public string PasswordHash { get; set; }

        // User email address.
        public string Email { get; set; }

        // User phone number.
        public string Phone { get; set; }

        // Shows whether the user account is active.
        public bool IsActive { get; set; }

        // Role assigned to the user, such as Admin, SuperAdmin or Customer.
        public string RoleName { get; set; }
    }
}