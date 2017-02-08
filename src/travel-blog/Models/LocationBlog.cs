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
        public int LocationBlogId { get; set; }
        public int LocationId { get; set; }
        public int BlogId { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
