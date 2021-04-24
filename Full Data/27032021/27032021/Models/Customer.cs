using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public string ImageFile { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        [MaxLength(15), Required, NotMapped]
        public string PasswordInput { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public bool HasAccount { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [MaxLength(250)]
        public string State { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [MaxLength(250)]
        public string Company { get; set; }
        public string Token { get; set; }
        public DateTime AddedDate { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
