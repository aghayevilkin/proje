using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        public List<ColorToProduct> ColorToProducts { get; set; }
    }
}
