using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(20), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(250), Required]
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public DateTime AddedDate { get; set; }
        public List<Product> Products { get; set; }
    }
}
