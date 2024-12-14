using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Coupon
    {
        public int Id { get; set; } // Unique identifier for the coupon
        public string Code { get; set; } // The coupon code (e.g., "SAVE20")
        public decimal DiscountAmount { get; set; } // Discount amount or percentage
        public bool IsActive { get; set; } // Whether the coupon is currently active
        public DateTime ExpirationDate { get; set; } // Expiration date for the coupon
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When the coupon was created

        // Navigation property for orders that use this coupon
        public ICollection<OrderCoupon> OrderCoupons { get; set; } = new List<OrderCoupon>();
    }
}