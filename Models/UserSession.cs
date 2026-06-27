namespace SmartMedERP.Models
{
    /*
     * Stores the currently logged-in user's basic session details.
     * This model is used by SessionManager so forms can check
     * the active user's ID, username and role.
     */
    public class UserSession
    {
        // Logged-in user's ID.
        public int UserId { get; set; }

        // Logged-in user's username.
        public string Username { get; set; }

        // Logged-in user's role name.
        public string RoleName { get; set; }
    }
}