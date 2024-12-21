using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } // Product name
        public string Description { get; set; } // Product description
        public string Sku { get; set; } // SKU (Stock Keeping Unit)
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Product price
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountedPrice { get; set; } // Discounted price
        public int StockQuantity { get; set; } // Available stock
        public string ImageUrl { get; set; } // Product image URL
        // Category and Tags
        public int CategoryId { get; set; } // Foreign key for category
        public Category Category { get; set; } // Navigation property for category
        public ICollection<ProductTag> ProductTags { get; set; } // Many-to-many relationship with tags
        // Product Status
        public bool IsActive { get; set; } = true; // Whether the product is active
        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Creation timestamp
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Last update timestamp
        // Navigation Properties
        public ICollection<ProductReview> Reviews { get; set; } // Customer reviews
        public ICollection<ProductAttribute> Attributes { get; set; } // Custom attributes
        public ICollection<StoreProduct> StoreProducts { get; set; } = new List<StoreProduct>();
    }

}