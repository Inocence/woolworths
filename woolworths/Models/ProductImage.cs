using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class ProductImage
    {
        public int Id { get; set; } // Unique identifier for the product image
        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product
        public string ImageUrl { get; set; } // URL or path to the image
        public bool IsPrimary { get; set; } // Whether this image is the primary product image
    }

}