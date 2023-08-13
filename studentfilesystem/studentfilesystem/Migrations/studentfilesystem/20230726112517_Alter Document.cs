using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace studentfilesystem.Migrations.studentfilesystem
{
    public partial class AlterDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "RefApplication15",
                table: "Document");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Document",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Application_ApplicationId",
                table: "Document",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Application_ApplicationId",
                table: "Document");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Document",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddForeignKey(
            //    name: "RefApplication15",
            //    table: "Document",
            //    column: "ApplicationId",
            //    principalTable: "Application",
            //    principalColumn: "ApplicationId",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
