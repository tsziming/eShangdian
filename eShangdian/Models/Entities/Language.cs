using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(7)]
        public string Code { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(512)]
        public string Locale { get; set; }
        public List<AttributeDescription> AttributeDescriptions { get; set; }
        public List<AttributeGroupDescription> AttributeGroupDescriptions { get; set; }
        public List<CategoryDescription> CategoryDescriptions { get; set; }
        public List<CustomerGroupDescription> CustomerGroupDescriptions { get; set; }
        public List<TagDescription> TagDescriptions { get; set; }
        public List<ProductDescription> ProductDescriptions { get; set; }
    }
}
