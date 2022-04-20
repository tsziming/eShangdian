using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public List<AttributeDescription> AttributeDescriptions { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
    }
}
