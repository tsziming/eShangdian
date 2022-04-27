using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        public List<ProductDescription> ProductDescription { get; set; }
        public List<Tag> Tags { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductAttribute> Attributes { get; set; } 
        public Discount Discount { get; set; }
        public List<Image> Images { get; set; }
    }
}
