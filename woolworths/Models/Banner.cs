using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Banner
    {
        public int Id { get; set; } // Unique identifier for the banner
        public string ImageUrl { get; set; } // URL or path to the image
        public string Link { get; set; } // Link that the banner points to (e.g., a product page or a promotion)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When the banner was created
        public DateTime? ExpiryDate { get; set; } // When the banner will expire (if applicable)
        public bool IsActive { get; set; } // Whether the banner is active and visible on the site
    }

}