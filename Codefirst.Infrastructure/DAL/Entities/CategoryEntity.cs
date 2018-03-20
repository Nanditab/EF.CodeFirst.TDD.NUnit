using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace Codefirst.Infrastructure.DAL.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int ID { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        
        public bool IsActive { get; set; }
    }
}
