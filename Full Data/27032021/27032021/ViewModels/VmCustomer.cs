using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.ViewModels
{
    public class VmCustomer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(250), Required]
        public string Password { get; set; }

        [MaxLength(250)]
        public string ConfirmPassword { get; set; }
        public bool? isCart { get; set; }
        public int? isCommentPrdId { get; set; }
    }
}
