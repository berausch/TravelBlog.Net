using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace travel_blog.Models
{
    [Table("BlogPeoples")]
    public class BlogPeople
    {
        public int BlogPeopleId { get; set; }
        public int LocationId { get; set; }
        public int BlogId { get; set; }

        public virtual ICollection<Blog> Blog { get; set; }
        public virtual ICollection<People> People { get; set; }

    }
}
