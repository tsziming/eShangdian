using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Page
    {
        public int Id { get; set; }
        public List<PageDescription> PageDescriptions { get; set; }
        public string Url { get; set; }
    }
}
