using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiosk.Data.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [Display(Name = "Customer Name")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Contact number cannot be longer than 15 characters.")]
        [Display(Name = "Contact Number")]
        public string? ContactNumber { get; set; }

        [Required(ErrorMessage = "Created date is required.")]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Order ID is required.")]
        [ForeignKey("Order")]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        // Navigation property
        public Order Order { get; set; }
    }
}
