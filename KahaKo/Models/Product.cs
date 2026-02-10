using System.ComponentModel.DataAnnotations;

namespace KahaKo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int Stock { get; set; } = 0;

        public string Barcode { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
