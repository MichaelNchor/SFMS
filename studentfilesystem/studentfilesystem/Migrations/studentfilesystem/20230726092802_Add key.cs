using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace studentfilesystem.Migrations.studentfilesystem
{
    public partial class Addkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "PassportImage",
                table: "Application");

            migrationBuilder.AddColumn<string>(
                name: "ProgrammeTag",
                table: "Programme",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentPath",
                table: "Document",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Department",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "Application",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "AcademicYear",
                table: "Application",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportPath",
                table: "Application",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportTitle",
                table: "Application",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammeChoice1",
                table: "Application",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammeChoice2",
                table: "Application",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgrammeChoice3",
                table: "Application",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Application",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgrammeTag",
                table: "Programme");

            migrationBuilder.DropColumn(
                name: "DocumentPath",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "AcademicYear",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "PassportPath",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "PassportTitle",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ProgrammeChoice1",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ProgrammeChoice2",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ProgrammeChoice3",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Application");

            migrationBuilder.AddColumn<byte[]>(
                name: "Document",
                table: "Document",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Department",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "Application",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<byte[]>(
                name: "PassportImage",
                table: "Application",
                nullable: true);
        }
    }
}
