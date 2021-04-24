using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }

        [MaxLength(20), Required]
        public string Surname { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public string ImageFile { get; set; }
        public DateTime AddedDate { get; set; }

        public List<SocialToEmployee> SocialToEmployees { get; set; }
    }
}
