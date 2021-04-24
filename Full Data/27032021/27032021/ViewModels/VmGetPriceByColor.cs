using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.ViewModels
{
    public class VmGetPriceByColor
    {
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public bool IsDiscount { get; set; }
    }
}
