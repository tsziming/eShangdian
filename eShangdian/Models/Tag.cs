using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public List<TagDescription> TagDescriptions { get; set; }
    }
}
