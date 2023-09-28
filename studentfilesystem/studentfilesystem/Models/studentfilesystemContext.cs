using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace studentfilesystem.Models
{
    public partial class studentfilesystemContext : IdentityDbContext<IdentityUser>
    {
        public studentfilesystemContext()
        {
        }

        public studentfilesystemContext(DbContextOptions<studentfilesystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<UserApplication> UserApplication { get; set; }
        //public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        //public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        //public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Programme> Programme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=studentfilesystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK3")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ApplicationId).ValueGeneratedOnAdd();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KnustmobileNo).HasColumnName("KNUSTMobileNo");

                entity.Property(e => e.Status).HasColumnName("Status");

                entity.Property(e => e.OtherEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherNames)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddress3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddress4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeChoice1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeChoice2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeChoice3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            //modelBuilder.Entity<AspNetRoleClaims>(entity =>
            //{
            //    entity.Property(e => e.RoleId)
            //        .IsRequired()
            //        .HasMaxLength(450);

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspNetRoleClaims)
            //        .HasForeignKey(d => d.RoleId);
            //});

            //modelBuilder.Entity<AspNetRoles>(entity =>
            //{
            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Name).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedName).HasMaxLength(256);
            //});

            //modelBuilder.Entity<AspNetUserClaims>(entity =>
            //{
            //    entity.Property(e => e.UserId)
            //        .IsRequired()
            //        .HasMaxLength(450);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserClaims)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserLogins>(entity =>
            //{
            //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            //    entity.Property(e => e.UserId)
            //        .IsRequired()
            //        .HasMaxLength(450);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserLogins)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserRoles>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.RoleId });

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspNetUserRoles)
            //        .HasForeignKey(d => d.RoleId);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserRoles)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserTokens>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserTokens)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUsers>(entity =>
            //{
            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Email).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

            //    entity.Property(e => e.UserName).HasMaxLength(256);
            //});

            modelBuilder.Entity<College>(entity =>
            {
                entity.HasKey(e => e.CollegeId)
                    .HasName("PK4")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CollegeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CollegeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserApplication>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK9")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationId");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.FacultyId, e.CollegeId })
                    .HasName("PK5")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.DepartmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.FacultyId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollegeId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => new { d.FacultyId, d.CollegeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefFaculty8");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK8")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.DocumentId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");


                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                //entity.Property(e => e.UpdatedBy)
                //    .HasMaxLength(50)
                //    .IsUnicode(false);

                //entity.HasOne(d => d.Application)
                //    .WithMany(p => p.Document)
                //    .HasForeignKey(d => d.ApplicationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("RefApplication15");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => new { e.FacultyId, e.CollegeId })
                    .HasName("PK6")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.FacultyId).ValueGeneratedOnAdd();

                entity.Property(e => e.CollegeId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Faculty)
                    .HasForeignKey(d => d.CollegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefCollege7");
            });

            modelBuilder.Entity<Programme>(entity =>
            {
                entity.HasKey(e => new { e.ProgrammeId, e.DepartmentId, e.FacultyId, e.CollegeId })
                    .HasName("PK7")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ProgrammeId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollegeId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Department)
                //    .WithMany(p => p.Programme)
                //    .HasForeignKey(d => new { d.DepartmentId, d.FacultyId, d.CollegeId })
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("RefDepartment9");
            });
        }
    }
}
