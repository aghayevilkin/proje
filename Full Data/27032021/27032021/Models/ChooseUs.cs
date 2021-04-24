using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class ChooseUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Icon { get; set; }

        [MaxLength(50), Required]
        public string Title { get; set; }

        [MaxLength(250), Required]
        public string Text { get; set; }
    }
}
