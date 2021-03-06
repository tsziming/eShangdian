using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class AttributeGroupDescription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string Name { get; set; }
        [Required]
        public Language Language { get; set; }
        [Required]
        public AttributeGroup Group { get; set; }
    }
}
