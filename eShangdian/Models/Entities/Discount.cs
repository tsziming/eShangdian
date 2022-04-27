using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        [Required]
        [Range(0,100)]
        public decimal Percentage { get; set; }
    }
}
