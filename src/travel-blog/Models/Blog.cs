using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace travel_blog.Models
{
    [Table("Blogs")]
    public class Blog
    {

        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public DateTime Date { get; set; }

    }
}
