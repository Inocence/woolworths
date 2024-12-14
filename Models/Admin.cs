using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Admin
    {
        public string UserId { get; set; } // Foreign key to IdentityUser
        public AppUser User { get; set; } // Navigation property to IdentityUser

        public string Role { get; set; } // Role (e.g., "Admin", "Manager", "Support")
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When the admin account was created
    }

}