using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
