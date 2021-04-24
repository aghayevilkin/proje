﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500),Required]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column(TypeName ="ntext")]
        public string Content { get; set; }
        public DateTime AddedDate { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public BlogCategory Category { get; set; }
        [NotMapped]
        public int[] TagIds { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public  User User { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
    }
}
