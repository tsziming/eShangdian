using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class AttributeGroupDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
        public string Name { get; set; }
    }
}
