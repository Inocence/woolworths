using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Customer
    {
        public string UserId { get; set; } // Foreign key to IdentityUser
        public AppUser User { get; set; } // Navigation property to IdentityUser

        public string FirstName { get; set; } // Customer's first name
        public string LastName { get; set; } // Customer's last name
        public string PhoneNumber { get; set; } // Customer's phone number
        public string Email { get; set; } // Customer's email address
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When the customer was created

        // Navigation property for related orders
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Navigation property for customer addresses
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }

}