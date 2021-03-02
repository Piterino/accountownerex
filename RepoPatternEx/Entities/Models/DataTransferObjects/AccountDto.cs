using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.DataTransferObjects
{
    public class AccountDto
    {
        [Display(Name = "Id")]
        public Guid AccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public string AccountType { get; set; }
    }
}
