using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class AttributeGroup
    {
        public int Id { get; set; }
        public List<AttributeGroupDescription> AttributeGroupDescriptions { get; set; }
    }
}
