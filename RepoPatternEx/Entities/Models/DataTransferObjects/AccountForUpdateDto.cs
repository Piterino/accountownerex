using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models
{
    public class AccountForUpdateDto
    {
        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }
        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }
    }
}