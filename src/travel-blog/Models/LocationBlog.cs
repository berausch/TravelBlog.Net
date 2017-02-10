using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace travel_blog.Models
{
    [Table("LocationBlogs")]
    public class LocationBlog
    {
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
