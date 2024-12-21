using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } // Tag name
    public ICollection<ProductTag> ProductTags { get; set; } // Related products
}
}