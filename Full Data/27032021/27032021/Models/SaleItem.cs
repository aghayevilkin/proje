using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class SaleItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        [ForeignKey("ColorToProduct")]
        public int ColorToProductId { get; set; }
        public ColorToProduct ColorToProduct { get; set; }
        [Column(TypeName = "money"), Required]
        public decimal Quantity { get; set; }
        [Column(TypeName = "money"), Required]
        public decimal Price { get; set; }
    }
}
