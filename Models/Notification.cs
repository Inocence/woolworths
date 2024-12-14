using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Notification
    {
        public int Id { get; set; } // Unique identifier for the notification
        public string CustomerId { get; set; } // Foreign key to Customer
        public Customer Customer { get; set; } // Navigation property to Customer

        public string Message { get; set; } // The notification message
        public bool IsRead { get; set; } // Whether the customer has read the notification
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When the notification was created
    }

}