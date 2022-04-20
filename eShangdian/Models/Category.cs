using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Category
    {
        public int Id { get; set; }
        public List<CategoryDescription> CategoryDescriptions { get; set; }
    }
}
