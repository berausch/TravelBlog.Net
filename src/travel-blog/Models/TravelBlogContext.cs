using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace travel_blog.Models
{
    public class TravelBlogContext : DbContext
    {
        public TravelBlogContext()
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<People> Peoples { get; set; }

        public DbSet<BlogPeople> BlogPeoples { get; set; }

        public DbSet<LocationBlog> LocationBlogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TravelBlog;integrated security=True");
        }

        public TravelBlogContext(DbContextOptions<TravelBlogContext> options) : base(options)
        {
   
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
