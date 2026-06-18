namespace SmartMedERP.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool IsActive { get; set; }

        public string RoleName { get; set; }
    }
}