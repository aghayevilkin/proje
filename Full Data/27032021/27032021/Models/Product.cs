using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public string MainImageFile { get; set; }
        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [ForeignKey("User")]
        public int AddedUserId { get; set; }
        public User User { get; set; }
        public DateTime AddedDate { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Feature> Features { get; set; }
        public List<Review> Reviews { get; set; }
        public List<ColorToProduct> ColorToProducts { get; set; }
    }
}
