using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class AttributeDescription
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
        public Attribute Attribute { get; set; }
    }
}
