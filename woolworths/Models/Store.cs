using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Store
    {
        public int Id { get; set; } // Unique identifier for the store
        public string Name { get; set; } // Store name (e.g., "Main Store", "Branch A")
        public string Address { get; set; } // Address of the store
        public string PhoneNumber { get; set; } // Store phone number
        public string Email { get; set; } // Store email address
        public bool IsActive { get; set; } // Whether the store is active
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date when the store was created

        // Geolocation data for calculating distances
        [Column(TypeName = "decimal(18,2)")]
        public decimal Latitude { get; set; } // Latitude of the store
        [Column(TypeName = "decimal(18,2)")]
        public decimal Longitude { get; set; } // Longitude of the store
        public ICollection<StoreProduct> StoreProducts = new List<StoreProduct>();
    }

}