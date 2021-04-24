using _27032021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.ViewModels
{
    public class VmProduct
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Color> Colors { get; set; }
        public decimal? minPrice { get; set; }
        public decimal? maxPrice { get; set; }
        public int? catId { get; set; }
        public VmProduct Filter { get; set; }
    }
}
