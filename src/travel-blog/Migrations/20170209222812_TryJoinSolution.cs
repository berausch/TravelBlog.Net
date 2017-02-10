using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace travelblog.Migrations
{
    public partial class TryJoinSolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_BlogPeoples_BlogPeopleId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_BlogPeopleId",
                table: "Peoples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationBlogs",
                table: "LocationBlogs");

            migrationBuilder.DropIndex(
                name: "IX_Locations_LocationBlogId",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPeoples",
                table: "BlogPeoples");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogPeopleId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_LocationBlogId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogPeopleId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "LocationBlogId",
                table: "LocationBlogs");

            migrationBuilder.DropColumn(
                name: "LocationBlogId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "BlogPeopleId",
                table: "BlogPeoples");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "BlogPeoples");

            migrationBuilder.DropColumn(
                name: "BlogPeopleId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LocationBlogId",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "PeopleId",
                table: "BlogPeoples",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationBlogs",
                table: "LocationBlogs",
                columns: new[] { "LocationId", "BlogId" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationBlogs_BlogId",
                table: "LocationBlogs",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationBlogs_LocationId",
                table: "LocationBlogs",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPeoples",
                table: "BlogPeoples",
                columns: new[] { "PeopleId", "BlogId" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPeoples_BlogId",
                table: "BlogPeoples",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPeoples_PeopleId",
                table: "BlogPeoples",
                column: "PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPeoples_Blogs_BlogId",
                table: "BlogPeoples",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPeoples_Peoples_PeopleId",
                table: "BlogPeoples",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "PeopleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationBlogs_Blogs_BlogId",
                table: "LocationBlogs",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationBlogs_Locations_LocationId",
                table: "LocationBlogs",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPeoples_Blogs_BlogId",
                table: "BlogPeoples");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPeoples_Peoples_PeopleId",
                table: "BlogPeoples");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationBlogs_Blogs_BlogId",
                table: "LocationBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationBlogs_Locations_LocationId",
                table: "LocationBlogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationBlogs",
                table: "LocationBlogs");

            migrationBuilder.DropIndex(
                name: "IX_LocationBlogs_BlogId",
                table: "LocationBlogs");

            migrationBuilder.DropIndex(
                name: "IX_LocationBlogs_LocationId",
                table: "LocationBlogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPeoples",
                table: "BlogPeoples");

            migrationBuilder.DropIndex(
                name: "IX_BlogPeoples_BlogId",
                table: "BlogPeoples");

            migrationBuilder.DropIndex(
                name: "IX_BlogPeoples_PeopleId",
                table: "BlogPeoples");

            migrationBuilder.DropColumn(
                name: "PeopleId",
                table: "BlogPeoples");

            migrationBuilder.AddColumn<int>(
                name: "BlogPeopleId",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationBlogId",
                table: "LocationBlogs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "LocationBlogId",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogPeopleId",
                table: "BlogPeoples",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "BlogPeoples",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlogPeopleId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationBlogId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_BlogPeopleId",
                table: "Peoples",
                column: "BlogPeopleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationBlogs",
                table: "LocationBlogs",
                column: "LocationBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationBlogId",
                table: "Locations",
                column: "LocationBlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPeoples",
                table: "BlogPeoples",
                column: "BlogPeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogPeopleId",
                table: "Blogs",
                column: "BlogPeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_LocationBlogId",
                table: "Blogs",
                column: "LocationBlogId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_BlogPeoples_BlogPeopleId",
                table: "Peoples",
                column: "BlogPeopleId",
                principalTable: "BlogPeoples",
                principalColumn: "BlogPeopleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
