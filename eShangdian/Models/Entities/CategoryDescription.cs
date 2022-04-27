using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class CategoryDescription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Language Language { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(1024)]
        public string Description { get; set; }
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string MetaTitle{ get; set; }
        [DataType(DataType.Text)]
        [StringLength(512)]
        public string MetaDescription { get; set; }
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string MetaKeyword { get; set; }
    }
}
