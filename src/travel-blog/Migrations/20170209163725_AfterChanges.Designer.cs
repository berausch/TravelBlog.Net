using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using travel_blog.Models;

namespace travelblog.Migrations
{
    [DbContext(typeof(TravelBlogContext))]
    [Migration("20170209163725_AfterChanges")]
    partial class AfterChanges
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

                    b.Property<int?>("BlogPeopleId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("LocationBlogId");

                    b.Property<string>("Title");

                    b.HasKey("BlogId");

                    b.HasIndex("BlogPeopleId");

                    b.HasIndex("LocationBlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("travel_blog.Models.BlogPeople", b =>
                {
                    b.Property<int>("BlogPeopleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<int>("LocationId");

                    b.HasKey("BlogPeopleId");

                    b.ToTable("BlogPeoples");
                });

            modelBuilder.Entity("travel_blog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int?>("LocationBlogId");

                    b.HasKey("LocationId");

                    b.HasIndex("LocationBlogId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("travel_blog.Models.LocationBlog", b =>
                {
                    b.Property<int>("LocationBlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<int>("LocationId");

                    b.HasKey("LocationBlogId");

                    b.ToTable("LocationBlogs");
                });

            modelBuilder.Entity("travel_blog.Models.People", b =>
                {
                    b.Property<int>("PeopleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BlogPeopleId");

                    b.Property<string>("Name");

                    b.HasKey("PeopleId");

                    b.HasIndex("BlogPeopleId");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("travel_blog.Models.Blog", b =>
                {
                    b.HasOne("travel_blog.Models.BlogPeople")
                        .WithMany("Blog")
                        .HasForeignKey("BlogPeopleId");

                    b.HasOne("travel_blog.Models.LocationBlog")
                        .WithMany("Blogs")
                        .HasForeignKey("LocationBlogId");
                });

            modelBuilder.Entity("travel_blog.Models.Location", b =>
                {
                    b.HasOne("travel_blog.Models.LocationBlog")
                        .WithMany("Locations")
                        .HasForeignKey("LocationBlogId");
                });

            modelBuilder.Entity("travel_blog.Models.People", b =>
                {
                    b.HasOne("travel_blog.Models.BlogPeople")
                        .WithMany("People")
                        .HasForeignKey("BlogPeopleId");
                });
        }
    }
}
