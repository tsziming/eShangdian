using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class CustomerGroup
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool LimitAccess { get; set; }
        public List<CustomerGroupDescription> Descriptions { get; set; }
    }
}
