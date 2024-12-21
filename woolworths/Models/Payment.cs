using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Payment
    {
        public int Id { get; set; } // Unique identifier for the payment
        public int OrderId { get; set; } // Foreign key to the order
        public Order Order { get; set; } // Navigation property to Order
        [Column(TypeName = "decimal(18,2)")]        
        public decimal Amount { get; set; } // Amount paid
        public string PaymentMethod { get; set; } // Payment method (e.g., Credit Card, PayPal)
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow; // Payment date
        public string PaymentStatus { get; set; } // Status of the payment (e.g., Pending, Completed)
    }
}