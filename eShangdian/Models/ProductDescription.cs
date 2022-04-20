using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class ProductDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MetaTag { get; set; }
        public string MetaTagDescription { get; set; }
        public string MetaTagKeywords { get; set; }
        public string Model { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
        public DateTime DateAvailable { get; set; }
        public string Seo { get; set; }
    }
}
