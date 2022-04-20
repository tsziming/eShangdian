using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class EventDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Event Event { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
