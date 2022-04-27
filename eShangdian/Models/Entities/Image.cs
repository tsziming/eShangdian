using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShangdian.Models.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(64)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string FilePath { get; set; }
        public List<Product> Products { get; set; }
    }
}
