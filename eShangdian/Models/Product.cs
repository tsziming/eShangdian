using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Product
    {
        public int Id { get; set; }
        public List<ProductDescription> ProductDescription { get; set; }
        public List<Tag> Tags { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; } 
    }
}
