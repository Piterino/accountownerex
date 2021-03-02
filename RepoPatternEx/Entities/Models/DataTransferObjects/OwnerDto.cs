using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.DataTransferObjects
{
    public class OwnerDto
    {
        [Display(Name = "Owner Id")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public IEnumerable<AccountDto> Accounts { get; set; }
    }
}
