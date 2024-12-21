using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class WishlistItem
    {
        public int Id { get; set; } // Unique identifier for the wishlist item
        public int WishlistId { get; set; } // Foreign key to Wishlist
        public Wishlist Wishlist { get; set; } // Navigation property to Wishlist
        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product
    }

}