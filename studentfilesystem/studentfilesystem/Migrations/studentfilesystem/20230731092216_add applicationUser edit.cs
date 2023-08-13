using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace studentfilesystem.Migrations.studentfilesystem
{
    public partial class addapplicationUseredit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ApplicationUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "ApplicationUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ApplicationUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ApplicationUser",
                nullable: true);
        }
    }
}
