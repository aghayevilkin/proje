using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30), Required(ErrorMessage ="Ad boş olmamalıdır!")]
        public string Name { get; set; }
        public bool ForBlog { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
    }
}
