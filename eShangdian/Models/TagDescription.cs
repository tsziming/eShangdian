using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class TagDescription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Language Language { get; set; }
        [Required]
        public Tag Tag { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(64)]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(512)]
        public string Description { get; set; }
    }
}
