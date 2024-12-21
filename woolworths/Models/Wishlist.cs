using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Wishlist
    {
        public int Id { get; set; } // Unique identifier for the wishlist
        public int CustomerId { get; set; } // Foreign key to Customer
        public Customer Customer { get; set; } // Navigation property to Customer

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date when the wishlist was created

        // Navigation property for related products in the wishlist
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
    }

}