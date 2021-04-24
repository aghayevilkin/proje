using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Text { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Column(TypeName = "tinyint"), Required]
        public byte Rating { get; set; }
        public int? ReviewId { get; set; }
        [ForeignKey("ReviewId")]
        public Review ParentReview { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
