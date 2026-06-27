using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Utilities;

namespace SmartMedERP.Services
{
    /*
     * Handles user login validation.
     * This service separates authentication business logic from the UI layer.
     */
    public class AuthenticationService
    {
        private readonly UserRepository userRepository =
            new UserRepository();

        // Validates username and password, then returns the logged-in user.
        public User Login(string username, string password)
        {
            // Retrieve user details and role information from the database.
            User user =
                userRepository.GetUserByUsername(username);

            if (user == null)
                return null;

            // Prevent deactivated accounts from logging into the system.
            if (!user.IsActive)
                return null;

            // Verify the entered password against the stored hashed password.
            bool valid =
                PasswordHasher.VerifyPassword(
                    password,
                    user.PasswordHash);

            if (!valid)
                return null;

            return user;
        }
    }
}