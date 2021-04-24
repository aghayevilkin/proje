using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }
}
