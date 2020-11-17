using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrowX.Models
{
    public partial class GrowXDBContext : DbContext
    {
        public GrowXDBContext()
        {
        }

        public GrowXDBContext(DbContextOptions<GrowXDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<EventType> EventType { get; set; }
        public virtual DbSet<Objectives> Objectives { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QL7L7IF\\SQLEXPRESS01;Database=GrowXDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.Property(e => e.IdC).HasColumnName("idC");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("idCompany");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("imagePath")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("locationAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_Client_Company");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdCmp);

                entity.Property(e => e.IdCmp).HasColumnName("idCmp");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.IdE);

                entity.Property(e => e.IdE).HasColumnName("idE");

                entity.Property(e => e.DateEvent)
                    .HasColumnName("dateEvent")
                    .HasColumnType("date");

                entity.Property(e => e.DatePub)
                    .HasColumnName("datePub")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("idCompany");

                entity.Property(e => e.IdEventType).HasColumnName("idEventType");

                entity.Property(e => e.ImageEvent)
                    .HasColumnName("imageEvent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Organizer)
                    .HasColumnName("organizer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_Events_Company");

                entity.HasOne(d => d.IdEventTypeNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdEventType)
                    .HasConstraintName("FK_Events_EventType");
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.HasKey(e => e.IdTypeEvent);

                entity.Property(e => e.IdTypeEvent).HasColumnName("idTypeEvent");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Objectives>(entity =>
            {
                entity.HasKey(e => e.IdObj);

                entity.Property(e => e.IdObj).HasColumnName("idObj");

                entity.Property(e => e.ColbComment)
                    .HasColumnName("colbComment")
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.IdColb)
                    .HasColumnName("idColb")
                    .HasMaxLength(450);

                entity.Property(e => e.IdMng)
                    .HasColumnName("idMng")
                    .HasMaxLength(450);

                entity.Property(e => e.MngrComment)
                    .HasColumnName("mngrComment")
                    .IsUnicode(false);

                entity.Property(e => e.ObjectiveName)
                    .HasColumnName("objectiveName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Progression).HasColumnName("progression");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.TimeEstimation).HasColumnName("timeEstimation");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Validation).HasColumnName("validation");

                entity.HasOne(d => d.IdColbNavigation)
                    .WithMany(p => p.ObjectivesIdColbNavigation)
                    .HasForeignKey(d => d.IdColb)
                    .HasConstraintName("FK_Objectives_User1");

                entity.HasOne(d => d.IdMngNavigation)
                    .WithMany(p => p.ObjectivesIdMngNavigation)
                    .HasForeignKey(d => d.IdMng)
                    .HasConstraintName("FK_Objectives_User");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.IdP);

                entity.Property(e => e.IdP).HasColumnName("idP");

                entity.Property(e => e.DateBegin)
                    .HasColumnName("dateBegin")
                    .HasColumnType("date");

                entity.Property(e => e.DateFinish)
                    .HasColumnName("dateFinish")
                    .HasColumnType("date");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdCompany).HasColumnName("idCompany");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("imagePath")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressPercent).HasColumnName("progressPercent");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeEstimated).HasColumnName("timeEstimated");

                entity.Property(e => e.TimeSpent).HasColumnName("timeSpent");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK_Project_Client");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_Project_Company");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser)
                    .HasColumnName("idUser")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdCompany).HasColumnName("id_Company");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("imagePath")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_User_Company");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_AspNetUsers");
            });
        }
    }
}
