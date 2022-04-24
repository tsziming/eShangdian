using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [StringLength(512)]
        public string Comment { get; set; }
        [Required]
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        [Required]
        [DefaultValue(OrderStatuses.Processing)]
        public OrderStatuses OrderStatus { get; set; }
    }
}
