using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class CategoryDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MetaTitle{ get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}
