using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class ReturnRefund
    {
        public int Id { get; set; } // Unique identifier for the return/refund
        public int OrderItemId { get; set; } // Foreign key to OrderItem
        public OrderItem OrderItem { get; set; } // Navigation property to OrderItem

        public string Reason { get; set; } // Reason for the return/refund (e.g., "Damaged", "Wrong item")
        public decimal AmountRefunded { get; set; } // The amount refunded for the item
        public DateTime RequestDate { get; set; } // Date when the return/refund was requested
        public DateTime? ProcessedDate { get; set; } // Date when the refund/return was processed
        public string Status { get; set; } // Return status (e.g., "Pending", "Approved", "Completed")
    }

}