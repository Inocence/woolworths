using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Address
    {
        public int Id { get; set; } // Unique identifier for the address
        public int CustomerId { get; set; } // Foreign key to the customer
        public Customer Customer { get; set; } // Navigation property to Customer

        public string StreetAddress { get; set; } // Street address
        public string City { get; set; } // City
        public string State { get; set; } // State/Province
        public string PostalCode { get; set; } // Postal/ZIP code
        public string Country { get; set; } // Country
        public bool IsDefault { get; set; } // Is this the default address?

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When the address was created
    }
}