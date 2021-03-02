using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Owner")]
    public class Owner
    {
        [Column("ownerid")]
        public Guid OwnerId { get; set; }
        [Column("name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
        [Column("dateofbirth")]
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [Column("address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string Address { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}