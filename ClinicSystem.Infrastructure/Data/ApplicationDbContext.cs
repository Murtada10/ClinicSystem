using ClinicSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options) { }
                
        // Entity Sets (Tables)
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<Invoice> Invoices => Set<Invoice>();
        public DbSet<MedicalRecord> MedicalRecords => Set<MedicalRecord>();
        public DbSet<Prescription> Prescriptions => Set<Prescription>();
        public DbSet<Medication> Medications => Set<Medication>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<ClinicRoom> ClinicRooms => Set<ClinicRoom>();
        public DbSet<DoctorShift> DoctorShifts => Set<DoctorShift>();
        public DbSet<PaymentTransaction> PaymentTransactions => Set<PaymentTransaction>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                // Local SQL Server instance connection string
                optionsBuilder.UseSqlServer("Server=localhost;Database=ClinicSystemDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Automatically scans and applies Fluent API configurations (#30–32)
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
