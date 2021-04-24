﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30), Required]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
