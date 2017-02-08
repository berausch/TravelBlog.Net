using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace travelblog.Migrations
{
    public partial class AdditionalTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPeoples",
                columns: table => new
                {
                    BlogPeopleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPeoples", x => x.BlogPeopleId);
                });

            migrationBuilder.CreateTable(
                name: "LocationBlogs",
                columns: table => new
                {
                    LocationBlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationBlogs", x => x.LocationBlogId);
                });

            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    PeopleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogPeopleId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.PeopleId);
                    table.ForeignKey(
                        name: "FK_Peoples_BlogPeoples_BlogPeopleId",
                        column: x => x.BlogPeopleId,
                        principalTable: "BlogPeoples",
                        principalColumn: "BlogPeopleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "LocationBlogId",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogPeopleId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationBlogId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationBlogId",
                table: "Locations",
                column: "LocationBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogPeopleId",
                table: "Blogs",
                column: "BlogPeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_LocationBlogId",
                table: "Blogs",
                column: "LocationBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_BlogPeopleId",
                table: "Peoples",
                column: "BlogPeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogPeoples_BlogPeopleId",
                table: "Blogs",
                column: "BlogPeopleId",
                principalTable: "BlogPeoples",
                principalColumn: "BlogPeopleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_LocationBlogs_LocationBlogId",
                table: "Blogs",
                column: "LocationBlogId",
                principalTable: "LocationBlogs",
                principalColumn: "LocationBlogId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_LocationBlogs_LocationBlogId",
                table: "Locations",
                column: "LocationBlogId",
                principalTable: "LocationBlogs",
                principalColumn: "LocationBlogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogPeoples_BlogPeopleId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_LocationBlogs_LocationBlogId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_LocationBlogs_LocationBlogId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_LocationBlogId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogPeopleId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_LocationBlogId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LocationBlogId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "BlogPeopleId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LocationBlogId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "LocationBlogs");

            migrationBuilder.DropTable(
                name: "Peoples");

            migrationBuilder.DropTable(
                name: "BlogPeoples");
        }
    }
}
