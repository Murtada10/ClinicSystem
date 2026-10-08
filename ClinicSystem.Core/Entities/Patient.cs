using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class Patient : Person
    {
        public DateTime DateOfBirth { get; set; }
        public string BloodType { get; set; } = string.Empty;

        // Note: We will add the List<Appointment> navigation property later
        // once the Appointment class is created!

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
