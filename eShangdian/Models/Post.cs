using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Post
    {
        public int Id { get; set; }
        public List<PostDescription> PostDescriptions { get; set; }
    }
}
