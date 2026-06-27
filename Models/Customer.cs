using System;

namespace SmartMedERP.Models
{
    /*
     * Represents a customer in the SmartMed ERP system.
     * This model contains both customer profile details and linked
     * user account information.
     */
    public class Customer
    {
        // Unique customer profile ID.
        public int CustomerId { get; set; }

        // Linked user account ID from the Users table.
        public int UserId { get; set; }

        // Customer's full name.
        public string FullName { get; set; }

        // Login username from the user account.
        public string Username { get; set; }

        // Customer email address.
        public string Email { get; set; }

        // Customer phone number.
        public string Phone { get; set; }

        // Customer delivery or contact address.
        public string Address { get; set; }

        // Date and time the customer registered.
        public DateTime RegistrationDate { get; set; }

        // Total loyalty points earned by the customer.
        public int LoyaltyPoints { get; set; }

        // Customer membership level such as Bronze, Silver, Gold or Platinum.
        public string MembershipLevel { get; set; }

        // Shows whether the linked user account is active.
        public bool IsActive { get; set; }
    }
}