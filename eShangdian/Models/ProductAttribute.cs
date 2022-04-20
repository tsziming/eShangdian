using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class ProductAttribute
    {
        public Attribute Attribute { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
    }
}
