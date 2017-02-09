using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelblog.Migrations
{
    public partial class BioLocationInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationInfo",
                table: "Locations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "LocationInfo",
                table: "Locations");
        }
    }
}
