using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class PostDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Post Post { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
