using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiosk.Data.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "Product ID is required.")]
        [ForeignKey("Product")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Delivery date and time are required.")]
        [Display(Name = "Delivery Date and Time")]
        public DateTime DeliveryDateAndTime { get; set; }

        [Required(ErrorMessage = "Supplier is required.")]
        [StringLength(100, ErrorMessage = "Supplier name cannot be longer than 100 characters.")]
        [Display(Name = "Supplier")]
        public string Supplier { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [StringLength(50, ErrorMessage = "Status cannot be longer than 50 characters.")]
        [Display(Name = "Status")]
        public string Status { get; set; }
        public Product Product { get; set; }
    }
}
