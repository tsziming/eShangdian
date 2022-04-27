using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class Attribute
    {
        [Key]
        public int Id { get; set; }
        public List<AttributeDescription> Descriptions { get; set; }
        public AttributeGroup Group { get; set; }
    }
}
