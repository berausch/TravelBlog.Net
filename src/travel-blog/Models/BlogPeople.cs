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
        public int PeopleId { get; set; }
        public People People { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }


    }
}
