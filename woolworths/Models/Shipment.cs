using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Shipment
    {
        public int Id { get; set; } // Unique identifier for the shipment
        public int OrderId { get; set; } // Foreign key to the order being shipped
        public Order Order { get; set; } // Navigation property to Order

        public string ShippingProvider { get; set; } // Name of the shipping provider (e.g., FedEx, UPS)
        public string TrackingNumber { get; set; } // Tracking number for the shipment
        public DateTime ShippedDate { get; set; } // Date when the order was shipped
        public DateTime EstimatedArrival { get; set; } // Estimated delivery date
        public string ShippingStatus { get; set; } // Shipping status (e.g., "Shipped", "In Transit", "Delivered")
    }

}