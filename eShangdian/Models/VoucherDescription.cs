using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class VoucherDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Voucher Voucher { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
