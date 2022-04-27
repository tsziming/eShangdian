using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class ProductAttribute
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Attribute Attribute { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string Value { get; set; }
    }
}
