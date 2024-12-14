using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class ProductAttribute
{
    public int Id { get; set; } // Unique identifier for the attribute
    public int ProductId { get; set; } // Foreign key for Product
    public Product Product { get; set; } // Navigation property for the associated product
    public string Key { get; set; } // The name of the attribute (e.g., "Color", "Size", "Material")
    public string Value { get; set; } // The value of the attribute (e.g., "Red", "Medium", "Cotton")

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Timestamp for when the attribute was created
}

}