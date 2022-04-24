using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class ProductDescription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Language Language { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(1024)]
        public string Description { get; set; }
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string MetaTag { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1024)]
        public string MetaTagDescription { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1024)]
        public string MetaTagKeywords { get; set; }
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string Model { get; set; }
        [DataType(DataType.Text)]
        [StringLength(256)]
        public string Location { get; set; }
        [Required]
        [Range(0, double.PositiveInfinity)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        [DefaultValue(0)]
        public int Quantity { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAvailable { get; set; }
        [StringLength(256)]
        public string Seo { get; set; }
    }
}
