using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Subscription
    {
        public int Id { get; set; } // Unique identifier for the subscription
        public int CustomerId { get; set; } // Foreign key to the customer
        public Customer Customer { get; set; } // Navigation property to Customer

        public string ProductName { get; set; } // Name of the subscribed product/service
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Subscription price
        public DateTime StartDate { get; set; } // Subscription start date
        public DateTime EndDate { get; set; } // Subscription end date
        public int Status { get; set; } // Subscription status (Active, Expired, Cancelled)
    }
}