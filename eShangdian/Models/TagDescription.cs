using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class TagDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Tag Tag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
