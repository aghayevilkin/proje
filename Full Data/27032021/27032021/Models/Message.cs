using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }

        [MaxLength(50),Required]
        public string Email { get; set; }

        [MaxLength(250), Required]
        public string Subject { get; set; }

        [MaxLength(3000), Required]
        public string Text { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
