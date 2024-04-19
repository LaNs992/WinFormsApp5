using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WinFormsApp5.models
{
    public partial class A_EKZAMENContext : DbContext
    {
        public A_EKZAMENContext()
        {
        }

        public A_EKZAMENContext(DbContextOptions<A_EKZAMENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Mark> Marks { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-URICGBM\\SQLEXPRESS;Database=A_EKZAMEN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.Property(e => e.TimeStart).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_Activity_Event");

                entity.HasOne(d => d.Moderator)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ModeratorId)
                    .HasConstraintName("FK_Activity_User");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CostOfArms).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.EnglishTitle).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasMaxLength(255);

                entity.Property(e => e.EventTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event");

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.Days).HasColumnType("datetime");

                entity.Property(e => e.Logo).HasMaxLength(255);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Event_City");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Event_Course");

                entity.HasOne(d => d.Winner)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.WinnerId)
                    .HasConstraintName("FK_Event_User");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.ToTable("Mark");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_Mark_Activity");

                entity.HasOne(d => d.Juri)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.JuriId)
                    .HasConstraintName("FK_Mark_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Patronymic).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.Surname).HasMaxLength(255);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_User_Country");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_User_Course");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_User_Gender");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
