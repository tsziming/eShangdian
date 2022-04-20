using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Event
    {
        public int Id { get; set; }
        public List<EventDescription> EventDescriptions { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
    }
}
