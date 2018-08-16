using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Models
{
    public class Password
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Salt { get; set; }
        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }
    }
}
