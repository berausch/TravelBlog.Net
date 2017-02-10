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


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TravelBlog;integrated security=True");
        }

        public TravelBlogContext(DbContextOptions<TravelBlogContext> options) : base(options)
        {
   
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LocationBlog>()
                .HasKey(l => new { l.LocationId, l.BlogId });

            builder.Entity<LocationBlog>()
                .HasOne(lb => lb.Location)
                .WithMany(l => l.LocationBlogs)
                .HasForeignKey(lb => lb.LocationId);

            builder.Entity<LocationBlog>()
                .HasOne(lb => lb.Blog)
                .WithMany(b => b.LocationBlogs)
                .HasForeignKey(lb => lb.BlogId);

            builder.Entity<BlogPeople>()
                .HasKey(p=> new { p.PeopleId, p.BlogId });

            builder.Entity<BlogPeople>()
                .HasOne(bp => bp.People)
                .WithMany(p => p.BlogPeoples)
                .HasForeignKey(lb => lb.PeopleId);

            builder.Entity<BlogPeople>()
                .HasOne(lb => lb.Blog)
                .WithMany(b => b.BlogPeoples)
                .HasForeignKey(lb => lb.BlogId);

        }
    }
}
