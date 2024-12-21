using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class OrderItem
    {
        public int Id { get; set; } // Unique identifier for the order item
        public int OrderId { get; set; } // Foreign key to Order
        public Order Order { get; set; } // Navigation property to Order

        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product
        public int Quantity { get; set; } // Quantity of the product in the order
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Price of the product at the time of purchase
    }

}