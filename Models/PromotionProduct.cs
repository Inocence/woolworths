using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class PromotionProduct
    {
        public int PromotionId { get; set; } // Foreign key to Promotion
        public Promotion Promotion { get; set; } // Navigation property to Promotion

        public int ProductId { get; set; } // Foreign key to Product
        public Product Product { get; set; } // Navigation property to Product
    }

}