using System.ComponentModel.DataAnnotations;
namespace Kiosk.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot be longer than 100 characters.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        [StringLength(50, ErrorMessage = "Category cannot be longer than 50 characters.")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product image path is required.")]
        [StringLength(255, ErrorMessage = "Product image path cannot be longer than 255 characters.")]
        [Display(Name = "Product Image Path")]
        public string ProductImagePath { get; set; }
    }
}
