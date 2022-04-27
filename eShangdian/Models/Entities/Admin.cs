using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace eShangdian.Models.Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        [DefaultValue("admin")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(256)]
        public string Password { get; set; }
        [Required]
        [StringLength(15)]
        public string Ip { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
    }
}
