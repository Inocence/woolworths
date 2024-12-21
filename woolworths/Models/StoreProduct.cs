using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class StoreProduct
    {
        public int Id {get; set;}
        public int StoreId { get; set; } // Foreign key to Store
        public Store Store { get; set; } // Navigation property to Store

        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Price of the product at this store (could differ by store)
        public int Inventory { get; set; } // Quantity of the product available at this store
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date of this record creation
        public DateTime? UpdatedAt { get; set; } // Last updated date

        // You can also include a flag to indicate if the product is in stock or not
        public bool IsInStock => Inventory > 0;
    }

}