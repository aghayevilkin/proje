using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.ViewModels
{
    public class VmCustomerNotRegistered
    {
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        public int CountryId { get; set; }
        [MaxLength(250)]
        public string State { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [MaxLength(250)]
        public string Company { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }

        [MaxLength(250)]
        public string ConfirmPassword { get; set; }
        public bool CreateAccount { get; set; }


        //Properties for Card info
        [MaxLength(250), Required]
        public string CardOwnerName { get; set; }

        [MaxLength(16), Required]
        public string CardNumber { get; set; }

        [MaxLength(3), Required]
        public string SecurityCode { get; set; }

        [MaxLength(5), Required]
        public string CardDate { get; set; }
    }
}
