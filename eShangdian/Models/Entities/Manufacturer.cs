using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string Seo { get; set; }
        public List<Product> Products { get; set; }
    }
}
