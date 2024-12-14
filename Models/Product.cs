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

    public class Product
    {
        public int Id { get; set; } // Primary Key

        // Basic Information
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } // Product name

        [MaxLength(1000)]
        public string Description { get; set; } // Product description

        [MaxLength(255)]
        public string Sku { get; set; } // SKU (Stock Keeping Unit)

        [Required]
        public decimal Price { get; set; } // Product price

        public decimal DiscountedPrice { get; set; } // Discounted price

        public int StockQuantity { get; set; } // Available stock

        public string ImageUrl { get; set; } // Product image URL

        // Category and Tags
        public int CategoryId { get; set; } // Foreign key for category
        public Category Category { get; set; } // Navigation property for category

        public ICollection<ProductTag> ProductTags { get; set; } // Many-to-many relationship with tags

        // Product Status
        public bool IsActive { get; set; } = true; // Whether the product is active
        public bool IsFeatured { get; set; } = false; // Whether the product is featured

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Creation timestamp
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Last update timestamp

        // Navigation Properties
        public ICollection<ProductReview> Reviews { get; set; } // Customer reviews
        public ICollection<ProductAttribute> Attributes { get; set; } // Custom attributes
        public ICollection<StoreProduct> StoreProducts { get; set; } = new List<StoreProduct>();
    }

}