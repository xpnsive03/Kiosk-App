using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Core.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Order date is required.")]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Total amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than zero.")]
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "Staff ID is required.")]
        [ForeignKey("User")]
        [Display(Name = "Staff ID")]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Created date is required.")]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Order Items ID is required.")]
        [ForeignKey("OrderItem")]
        [Display(Name = "Order Items ID")]
        public int OrderItemsId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}
