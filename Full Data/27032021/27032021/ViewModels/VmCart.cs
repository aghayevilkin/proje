using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.ViewModels
{
    public class VmCart
    {
        public int Id { get; set; }
        public string MainImage { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal MaxQuantity { get; set; }
    }
}
