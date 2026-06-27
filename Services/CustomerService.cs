using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Utilities;

namespace SmartMedERP.Services
{
    /*
     * Handles customer-related business logic.
     * This service manages customer registration, profile updates,
     * account status changes and password resets.
     */
    public class CustomerService
    {
        private readonly CustomerRepository customerRepository =
            new CustomerRepository();

        /*
         * Registers a new customer account.
         * Password is hashed before saving and the customer is assigned
         * the Customer role with default loyalty details.
         */
        public void RegisterCustomer(
            string fullName,
            string username,
            string email,
            string phone,
            string address,
            string password)
        {
            string passwordHash =
                PasswordHasher.HashPassword(password);

            int userId =
                customerRepository.AddUser(
                    username,
                    passwordHash,
                    email,
                    phone);

            // Assign the Customer role to the newly created user.
            customerRepository.AddCustomerRole(userId);

            Customer customer =
                new Customer
                {
                    UserId = userId,
                    FullName = fullName,
                    Address = address,
                    LoyaltyPoints = 0,
                    MembershipLevel = "Bronze"
                };

            customerRepository.AddCustomer(customer);
        }

        // Updates customer details through the repository layer.
        public void UpdateCustomer(Customer customer)
        {
            customerRepository.UpdateCustomer(customer);
        }

        // Changes customer account status between active and inactive.
        public void ToggleStatus(int userId, bool currentStatus)
        {
            bool newStatus = !currentStatus;

            customerRepository.ToggleCustomerStatus(
                userId,
                newStatus);
        }

        // Resets customer password after hashing the new password.
        public void ResetPassword(int userId, string newPassword)
        {
            string passwordHash =
                PasswordHasher.HashPassword(newPassword);

            customerRepository.UpdateCustomerPassword(
                userId,
                passwordHash);
        }
    }
}