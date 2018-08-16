using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [StringLength(255)]
        public string VerificationCode { get; set; }

    }
}
