using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.ViewModels
{
    public class VmResetpassword
    {
       
        [MaxLength(30), Required]
        public string Password { get; set; }

        [MaxLength(30), Required]
        public string ConfirmPassword { get; set; }
    }
}
