using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using travel_blog.Models;

namespace travelblog.Migrations
{
    [DbContext(typeof(TravelBlogContext))]
    [Migration("20170209222812_TryJoinSolution")]
    partial class TryJoinSolution
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("travel_blog.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("travel_blog.Models.BlogPeople", b =>
                {
                    b.Property<int>("PeopleId");

                    b.Property<int>("BlogId");

                    b.HasKey("PeopleId", "BlogId");

                    b.HasIndex("BlogId");

                    b.HasIndex("PeopleId");

                    b.ToTable("BlogPeoples");
                });

            modelBuilder.Entity("travel_blog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("LocationInfo");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("travel_blog.Models.LocationBlog", b =>
                {
                    b.Property<int>("LocationId");

                    b.Property<int>("BlogId");

                    b.HasKey("LocationId", "BlogId");

                    b.HasIndex("BlogId");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationBlogs");
                });

            modelBuilder.Entity("travel_blog.Models.People", b =>
                {
                    b.Property<int>("PeopleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<string>("Name");

                    b.HasKey("PeopleId");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("travel_blog.Models.BlogPeople", b =>
                {
                    b.HasOne("travel_blog.Models.Blog", "Blog")
                        .WithMany("BlogPeoples")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travel_blog.Models.People", "People")
                        .WithMany("BlogPeoples")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travel_blog.Models.LocationBlog", b =>
                {
                    b.HasOne("travel_blog.Models.Blog", "Blog")
                        .WithMany("LocationBlogs")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travel_blog.Models.Location", "Location")
                        .WithMany("LocationBlogs")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
