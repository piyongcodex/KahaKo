using System.ComponentModel.DataAnnotations;

namespace KahaKo.Models
{
    public class TransactionItem
    {
        [Key]
        public int ItemId { get; set; }

        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        // Navigation properties
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }
    }
}
