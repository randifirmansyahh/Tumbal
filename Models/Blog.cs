using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Judul")]
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
