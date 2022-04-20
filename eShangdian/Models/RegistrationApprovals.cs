using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class RegistrationApprovals
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public bool Approved { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateResponsed { get; set; }
    }
}
