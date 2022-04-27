using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models.Entities
{
    public enum CustomerStatuses
    {
        Enabled,
        Disabled
    }
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(32)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(320)]
        public string Email { get; set; }
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
        [Required]
        public CustomerGroup CustomerGroup { get; set; }
        [Required]
        public CustomerStatuses Status { get; set; }
        public List<Order> Orders { get; set; }
    }
}
