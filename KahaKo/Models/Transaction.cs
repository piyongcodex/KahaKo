using System.ComponentModel.DataAnnotations;

namespace KahaKo.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int UserId { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public string PaymentMethod { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        // Navigation property
        public User User { get; set; }
        public List<TransactionItem> Items { get; set; }
    }
}
