using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class ProductInventory
    {
        public int Id { get; set; } // Unique identifier for the inventory record
        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product
        public int QuantityChanged { get; set; } // The amount of stock added or subtracted
        public DateTime DateChanged { get; set; } // Date of the inventory change
        public string ChangeReason { get; set; } // Reason for the change (e.g., "Restock", "Sale")
    }

}