using System;

namespace SmartMedERP.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public int UserId { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int LoyaltyPoints { get; set; }

        public string MembershipLevel { get; set; }

        public bool IsActive { get; set; }
    }
}