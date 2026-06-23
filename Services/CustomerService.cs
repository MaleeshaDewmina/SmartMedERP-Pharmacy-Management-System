using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Utilities;

namespace SmartMedERP.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository customerRepository =
            new CustomerRepository();

        public void RegisterCustomer(
            Customer customer,
            string username,
            string password,
            string email,
            string phone)
        {
            string passwordHash =
                PasswordHasher.HashPassword(password);

            int userId =
                customerRepository.AddUser(
                    username,
                    passwordHash,
                    email,
                    phone);

            customerRepository.AddCustomerRole(userId);

            customer.UserId = userId;
            customer.Email = email;
            customer.Phone = phone;
            customer.Username = username;

            customerRepository.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            customerRepository.UpdateCustomer(customer);
        }

        public void ToggleStatus(int userId, bool currentStatus)
        {
            bool newStatus = !currentStatus;

            customerRepository.ToggleCustomerStatus(
                userId,
                newStatus);
        }

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