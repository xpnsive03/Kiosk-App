using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiosk.Data.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required(ErrorMessage = "Product ID is required.")]
        [ForeignKey("Product")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Total amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than zero.")]
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        // Navigation property
        public Product Product { get; set; }
    }
}
