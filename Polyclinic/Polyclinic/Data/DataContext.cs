using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Polyclinic.Entities;

namespace Polyclinic.Data
{
    public class DataContext : DbContext
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=PolyclinicDb;Trusted_Connection=True;";

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<PatientDoctor> PatientDoctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientDoctor>()
                .HasOne<Patient>()
                .WithMany()
                .HasForeignKey(pd => pd.PatientId);

            modelBuilder.Entity<PatientDoctor>()
                .HasOne<Doctor>()
                .WithMany()
                .HasForeignKey(pd => pd.DoctorId);

            modelBuilder.Entity<Visit>()
                .HasOne<Patient>()
                .WithMany()
                .HasForeignKey(v => v.PatientId);

            modelBuilder.Entity<Visit>()
                .HasOne<Doctor>()
                .WithMany()
                .HasForeignKey(v => v.DoctorId);

            modelBuilder.Entity<Visit>()
                .HasOne<Disease>()
                .WithMany()
                .HasForeignKey(v => v.DiseaseId);
        }
    }
}