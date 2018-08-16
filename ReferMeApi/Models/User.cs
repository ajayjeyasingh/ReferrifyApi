using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        public Password Password { get; set; }
        [Required]
        public int PasswordId { get; set; }
        [Required]
        public Email Email { get; set; }
        [Required]
        public int EmailId { get; set; }
        [Required]
        public Company Company { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public UserRole UserRole { get; set; }
        [Required]
        public int UserRoleId { get; set; }
        [Required]
        public UserStatus UserStatus { get; set; }
        [Required]
        public int UserStatusId { get; set; }




    }
}
