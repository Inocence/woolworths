using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class OrderCoupon
    {
        public int OrderId { get; set; } // Foreign key to Order
        public Order Order { get; set; } // Navigation property to Order

        public int CouponId { get; set; } // Foreign key to Coupon
        public Coupon Coupon { get; set; } // Navigation property to Coupon
    }

}