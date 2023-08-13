using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace studentfilesystem.Migrations.studentfilesystem
{
    public partial class auto_incr_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Surname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OtherNames = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    SchoolEmail = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PrimaryMobileNo = table.Column<int>(nullable: true),
                    KNUSTMobileNo = table.Column<int>(nullable: true),
                    OtherPhoneNo = table.Column<int>(nullable: true),
                    OtherEmail = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Region = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Country = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ResidentialAddress1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ResidentialAddress2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ResidentialAddress3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ResidentialAddress4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PostalAddress1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PostalAddress2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PostalAddress3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PostalAddress4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Religion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Denomination = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PassportImage = table.Column<byte[]>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK3", x => x.ApplicationId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    CollegeId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CollegeName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK4", x => x.CollegeId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Document = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK8", x => x.DocumentId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "RefApplication15",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CollegeId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FacultyName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK6", x => new { x.FacultyId, x.CollegeId })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "RefCollege7",
                        column: x => x.CollegeId,
                        principalTable: "College",
                        principalColumn: "CollegeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FacultyId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CollegeId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    DepartmentName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK5", x => new { x.DepartmentId, x.FacultyId, x.CollegeId })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "RefFaculty8",
                        columns: x => new { x.FacultyId, x.CollegeId },
                        principalTable: "Faculty",
                        principalColumns: new[] { "FacultyId", "CollegeId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Programme",
                columns: table => new
                {
                    ProgrammeId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    DepartmentId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FacultyId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CollegeId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    ProgrammeName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK7", x => new { x.ProgrammeId, x.DepartmentId, x.FacultyId, x.CollegeId })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "RefDepartment9",
                        columns: x => new { x.DepartmentId, x.FacultyId, x.CollegeId },
                        principalTable: "Department",
                        principalColumns: new[] { "DepartmentId", "FacultyId", "CollegeId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_FacultyId_CollegeId",
                table: "Department",
                columns: new[] { "FacultyId", "CollegeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Document_ApplicationId",
                table: "Document",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_CollegeId",
                table: "Faculty",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Programme_DepartmentId_FacultyId_CollegeId",
                table: "Programme",
                columns: new[] { "DepartmentId", "FacultyId", "CollegeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Programme");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "College");
        }
    }
}
