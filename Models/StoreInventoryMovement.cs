using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class StoreInventoryMovement
    {
        public int Id { get; set; } // Unique identifier for the inventory movement
        public int StoreId { get; set; } // Foreign key to Store
        public Store Store { get; set; } // Navigation property to Store

        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product

        public int QuantityChanged { get; set; } // Amount of change (+/-)
        public string Reason { get; set; } // Reason for the inventory change (e.g., "Sale", "Restock")
        public DateTime ChangeDate { get; set; } = DateTime.UtcNow; // When the change occurred
    }

}