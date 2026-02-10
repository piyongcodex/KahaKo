using System.ComponentModel.DataAnnotations;

namespace KahaKo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Manager,
        Cashier
    }
}
