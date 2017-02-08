using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace travel_blog.Models
{
    [Table("Peoples")]
    public class People
    {
        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
    }
}
