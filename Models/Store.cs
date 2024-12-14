using System;
using System.Collections.Generic;
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
        public double Latitude { get; set; } // Latitude of the store
        public double Longitude { get; set; } // Longitude of the store

        // Navigation property for products in the store
        public ICollection<StoreProduct> StoreProducts { get; set; } = new List<StoreProduct>();
    }

}