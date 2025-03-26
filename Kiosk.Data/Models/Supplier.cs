using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiosk.Data.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [Display(Name = "Supplier Name")]
        public string Name { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Contact number cannot be longer than 15 characters.")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Created date is required.")]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Product ID is required.")]
        [ForeignKey("Product")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        // Navigation property
        public Product Product { get; set; }

        // Not mapped property to get the Product Name
        [NotMapped]
        [Display(Name = "Product Name")]
        public string ProductName => Product?.ProductName;
    }
}
