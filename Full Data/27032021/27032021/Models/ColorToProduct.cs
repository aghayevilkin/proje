using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class ColorToProduct
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Column(TypeName = "money"), Required]
        public decimal Quantity { get; set; }
        [Column(TypeName = "money"), Required]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal DiscountPrice { get; set; }
        public DateTime DiscountDeadline { get; set; }

        [NotMapped]
        public bool IsDiscount { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }
}
