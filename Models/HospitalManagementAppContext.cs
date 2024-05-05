using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital_Management_Backend.Models
{
    public partial class HospitalManagementAppContext : DbContext
    {
        public HospitalManagementAppContext()
        {
        }

        public HospitalManagementAppContext(DbContextOptions<HospitalManagementAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("exams");

                entity.Property(e => e.ExamId).HasColumnName("exam_id");

                entity.Property(e => e.ExamDate)
                    .HasColumnType("date")
                    .HasColumnName("exam_date");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subject_name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK__students__A3DFF08D10C8B34B");

                entity.ToTable("students");

                entity.Property(e => e.SId).HasColumnName("S_Id");

                entity.Property(e => e.SAge).HasColumnName("S_Age");

                entity.Property(e => e.SFathername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("S_fathername");

                entity.Property(e => e.SGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("S_Gender")
                    .IsFixedLength();

                entity.Property(e => e.SName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("S_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
