using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class PageDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Page Page { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
