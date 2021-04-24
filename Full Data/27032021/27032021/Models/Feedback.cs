using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Fullname { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public string ImageFile { get; set; }
        [MaxLength(2000), Required]
        public string Text { get; set; }
    }
}
