using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class ProductReview
    {
        public int Id { get; set; } // Unique identifier for the review
        public int ProductId { get; set; } // Foreign key to the product
        public Product Product { get; set; } // Navigation property to Product

        public string CustomerId { get; set; } // Foreign key to the customer
        public Customer Customer { get; set; } // Navigation property to Customer

        public int Rating { get; set; } // Rating (1-5)
        public string Comment { get; set; } // Review comment
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Review creation date
    }

}