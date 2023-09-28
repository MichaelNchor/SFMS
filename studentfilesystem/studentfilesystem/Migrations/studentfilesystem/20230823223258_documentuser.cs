using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace studentfilesystem.Migrations.studentfilesystem
{
    public partial class documentuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "RefDepartment9",
                table: "Programme");

            migrationBuilder.AlterColumn<string>(
                name: "ProgrammeTag",
                table: "Programme",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProgrammeName",
                table: "Programme",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Programme",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Programme",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Programme",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ProgrammeId",
                table: "Programme",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Faculty",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Faculty",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Document",
                unicode: false,
                maxLength: 450,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Department",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Department",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Department",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "College",
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Programme_Department_DepartmentId_FacultyId_CollegeId",
                table: "Programme",
                columns: new[] { "DepartmentId", "FacultyId", "CollegeId" },
                principalTable: "Department",
                principalColumns: new[] { "DepartmentId", "FacultyId", "CollegeId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programme_Department_DepartmentId_FacultyId_CollegeId",
                table: "Programme");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Document");

            migrationBuilder.AlterColumn<string>(
                name: "ProgrammeTag",
                table: "Programme",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProgrammeName",
                table: "Programme",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CollegeId",
                table: "Programme",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "Programme",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentId",
                table: "Programme",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ProgrammeId",
                table: "Programme",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "CollegeId",
                table: "Faculty",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "Faculty",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "CollegeId",
                table: "Department",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "Department",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentId",
                table: "Department",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "CollegeId",
                table: "College",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "RefDepartment9",
                table: "Programme",
                columns: new[] { "DepartmentId", "FacultyId", "CollegeId" },
                principalTable: "Department",
                principalColumns: new[] { "DepartmentId", "FacultyId", "CollegeId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
