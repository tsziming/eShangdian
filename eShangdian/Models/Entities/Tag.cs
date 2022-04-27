using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public List<TagDescription> TagDescriptions { get; set; }
    }
}
