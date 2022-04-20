using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public enum CustomerStatuses
    {
        Enabled,
        Disabled
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public DateTime RegisterDate { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
        public CustomerStatuses CustomerStatus { get; set; }
    }
}
