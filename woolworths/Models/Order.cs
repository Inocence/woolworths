using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Order
    {
        public int Id { get; set; } // Unique identifier for the order
        public int CustomerId { get; set; } // Foreign key to the customer
        public Customer Customer { get; set; } // Navigation property to Customer

        public DateTime OrderDate { get; set; } = DateTime.UtcNow; // Date when the order was placed
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; } // Total order amount
        public int ShippingAddressId { get; set; } // Foreign key to shipping address
        public Address ShippingAddress { get; set; } // Navigation property to Address
        public string OrderStatus { get; set; } // Status of the order (e.g., Pending, Shipped, Delivered)

        // Navigation property for related order items
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

}