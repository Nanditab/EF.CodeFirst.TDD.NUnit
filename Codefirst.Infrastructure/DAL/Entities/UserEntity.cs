using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.Infrastructure.DAL.Entities
{
    public class UserEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(300)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(300)]
        public string LastName { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
