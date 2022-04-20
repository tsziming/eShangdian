using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public enum OrderStatuses
    {
        Canceled,
        Processing,
        Processed,
        Pending,
        Complete,
        Denied,
        Expired,
        Failed,
    }
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public OrderStatuses OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
