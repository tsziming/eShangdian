using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public enum CategoryStatuses
    {
        Plain,
        Featured,
        Home,
    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public List<CategoryDescription> Descriptions { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
        public CategoryStatuses Status { get; set; }
        
    }
}
