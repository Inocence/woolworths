using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Promotion
    {
        public int Id { get; set; } // Unique identifier for the promotion
        public string Code { get; set; } // Promotion code (e.g., "BLACKFRIDAY")
        public string Name { get; set; } // Name of the promotion (e.g., "Black Friday Sale")
        public decimal DiscountPercentage { get; set; } // Discount percentage offered
        public DateTime StartDate { get; set; } // Start date of the promotion
        public DateTime EndDate { get; set; } // End date of the promotion
        public bool IsActive { get; set; } // Whether the promotion is currently active

        // Navigation property for products associated with the promotion
        public ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();
    }

}