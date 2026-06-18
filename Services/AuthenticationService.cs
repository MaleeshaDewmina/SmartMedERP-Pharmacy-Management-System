using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Utilities;

namespace SmartMedERP.Services
{
    public class AuthenticationService
    {
        private readonly UserRepository userRepository =
            new UserRepository();

        public User Login(string username, string password)
        {
            User user =
                userRepository.GetUserByUsername(username);

            if (user == null)
                return null;

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