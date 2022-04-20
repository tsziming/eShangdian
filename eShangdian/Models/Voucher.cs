using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public List<VoucherDescription> VoucherDescriptions { get; set; }
        public decimal Value { get; set; }
    }
}
