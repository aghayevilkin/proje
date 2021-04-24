using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Social
    {
        [Key]
        public int Id{ get; set; }

        [MaxLength(20), Required]
        public string Icon { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }

        [Required]
        public bool ForEmployee { get; set; }

        public List<SocialToEmployee> SocialToEmployees { get; set; }
    }
}
