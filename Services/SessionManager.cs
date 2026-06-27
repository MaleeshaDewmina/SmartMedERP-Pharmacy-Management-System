using SmartMedERP.Models;

namespace SmartMedERP.Services
{
    /*
     * Stores the details of the currently logged-in user.
     * This allows forms to access the active user's ID, username and role.
     */
    public static class SessionManager
    {
        // Holds the active user session until the user logs out.
        public static UserSession CurrentUser { get; set; }
    }
}