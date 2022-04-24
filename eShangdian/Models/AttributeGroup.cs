using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class AttributeGroup
    {
        [Key]
        public int Id { get; set; }
        public List<AttributeGroupDescription> Descriptions { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
