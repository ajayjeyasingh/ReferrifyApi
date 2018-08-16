using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }

    public enum UserRoles
    {
        Admin = 1,
        Member = 2
    }
}
