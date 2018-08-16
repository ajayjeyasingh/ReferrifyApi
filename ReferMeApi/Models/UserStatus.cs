using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Models
{
    public class UserStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }

    public enum UserStatuses
    {
        Active = 1,
        Inactive = 2,
        AccountVerificationPending = 3
    }
}
