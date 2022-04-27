using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class CustomerGroupDescription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(512)]
        public string Description { get; set; }
        [Required]
        public CustomerGroup Group { get; set; }
        [Required]
        public Language Language { get; set; }
    }
}
