using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Category name
        public int Sort {get; set;}
        public bool IsActive {get; set;}
        public ICollection<Product>? Products { get; set; } // Related products
    }

}